using ExtFileExplorer.Disks;
using ExtFileExplorer.Files;
using ExtFileExplorer.Properties;
using ExtFileExplorer.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExtFileExplorer.Views;

internal partial class MainForm : Form
{
  private readonly IExtFileService fileService;
  private readonly OpenFileDialog openFileDialog = new()
  {
    Filter = "All files (*.*)|*.*",
    RestoreDirectory = true
  };
  private readonly FolderBrowserDialog folderBrowserDialog = new()
  {
  };
  private readonly MainViewModel viewModel;

  public MainForm(MainViewModel viewModel, IExtFileService fileService)
  {
    InitializeComponent();
    this.viewModel = viewModel;
    this.fileService = fileService;

    InitializeControls();
    InitializeDataBinding();

    viewModel.LoadDisks();

    Themes.OnThemeChanged += OnThemeChanged;
  }

  private void OnThemeChanged(object? sender, EventArgs e)
  {
    LoadButtonAppearance();
  }

  private void LoadButtonAppearance()
  {
    // Change button border color
    foreach (Button button in Controls.Cast<Control>().Where(control => control is Button))
      button.FlatAppearance.BorderColor = Themes.Current.BorderColor;
  }

  private void InitializeControls()
  {
    menuStrip.Renderer = new CustomMenuStripRenderer();
    toolStrip.Renderer = new CustomToolStripRenderer();
    toolStripLog.Renderer = new CustomToolStripRenderer();

    dataGridViewDisks.AutoGenerateColumns = false;
    dataGridViewDisks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

    dataGridViewFiles.AutoGenerateColumns = false;
    dataGridViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

    LoadButtonAppearance();
  }

  private void InitializeDataBinding()
  {
    dataGridViewDisks.DataBindings.Add(nameof(DataGridView.DataSource), viewModel, nameof(viewModel.DiskData));
    dataGridViewFiles.DataBindings.Add(nameof(DataGridView.DataSource), viewModel, nameof(viewModel.FileData));
    labelCurrentDisk.DataBindings.Add(nameof(Label.Text), viewModel, nameof(viewModel.ActiveFileSystemName));
    textBoxLog.DataBindings.Add(nameof(TextBox.Text), viewModel, nameof(viewModel.LogMessage));

    textBoxWorkDirectory.DataBindings.Add(nameof(TextBox.Text), viewModel, nameof(viewModel.WorkDirectory));

    //buttonCopyFrom.DataBindings.Add(nameof(System.Windows.Forms.Button.Enabled), viewModel, nameof(viewModel.HasActiveFileSystem));
  }

  private void LoadDataGridViewDisks()
  {
    foreach (DataGridViewRow row in dataGridViewDisks.Rows)
    {
      int diskNumber = Parse.ToInt32(row.Cells["ColumnDiskNumber"].Value);
      DiskData disk = viewModel.DiskData.First(disk => disk.DiskNumber == diskNumber);

      DataGridViewImageCell cellDiskStatus = (DataGridViewImageCell)row.Cells["ColumnDiskStatus"];

      switch (disk.DiskStatus)
      {
        case DiskStatus.Connected:
          cellDiskStatus.Value = Resources.StatusRunning;
          break;
        case DiskStatus.Disconnected:
          cellDiskStatus.Value = Resources.StatusStopped;
          break;
      }
    }

    dataGridViewDisks.Refresh();
  }

  private void LoadFileSystem(string fileSystemName)
  {
    viewModel.AppendLogMessage($"Open file system: {fileSystemName} ...");
    textBoxLog.Refresh();

    viewModel.ActiveFileSystemName = fileSystemName;
    viewModel.WorkDirectory = "/";

    LoadFileSystemTreeView();

    viewModel.AppendLogMessage($"File system opened successfully!");
    textBoxLog.Refresh();
  }

  private void LoadFileSystemTreeView()
  {
    fileSystemTreeView.Nodes.Clear();

    // Load Directories
    LoadTreeViewDirectories();
    // Load Files
    LoadTreeViewFiles();
  }

  private void LoadTreeViewDirectories(IEnumerable<string>? paths = null)
  {
    if (paths is null || !paths.Any())
      paths = new[] { "/" };
    foreach (string path in paths)
    {
      IEnumerable<string> directories = fileService.GetDirectories(viewModel.ActiveFileSystemName!, path);
      fileSystemTreeView.LoadDirectories(directories);
    }
  }

  private void LoadTreeViewFiles(IEnumerable<string>? paths = null)
  {
    if (paths is null || !paths.Any())
      paths = new[] { "/" };

    foreach (string path in paths)
    {
      IEnumerable<string> files = fileService.GetFiles(viewModel.ActiveFileSystemName!, path);
      fileSystemTreeView.LoadFiles(files);
    }
  }

  private bool TryGetSelectedDisk([NotNullWhen(true)] out DiskData? disk)
  {
    if (dataGridViewDisks.SelectedCells.Count is 0)
    {
      disk = null;
      return false;
    }

    int rowIndex = dataGridViewDisks.SelectedCells[0].RowIndex;
    DataGridViewRow row = dataGridViewDisks.Rows[rowIndex];
    int diskNumber = Parse.ToInt32(row.Cells["ColumnDiskNumber"].Value);
    disk = viewModel.DiskData.First(disk => disk.DiskNumber == diskNumber);
    return true;
  }

  private void Execute()
  {
    ISet<string> refreshDirectories = new HashSet<string>();
    ISet<string> removedDirectories = new HashSet<string>();

    try
    {
      IEnumerable<FileData> files = viewModel.FileData.Where(file => file.TransferStatus is not TransferStatus.Success);
      IEnumerable<FileData> fileCopyActions = files.Where(file => file.FileAction is FileAction.Copy);
      IEnumerable<FileData> fileDeleteActions = files.Where(file => file.FileAction is FileAction.Delete);
      IEnumerable<FileData> fileRenameActions = files.Where(file => file.FileAction is FileAction.Rename);

      foreach (FileData fileData in fileDeleteActions)
      {
        try
        {
          viewModel.AppendLogMessage($"Deleting file '{fileData.FullPath}'");
          viewModel.AppendLogMessage($"Please wait...");
          textBoxLog.Refresh();

          fileData.TransferStatus = TransferStatus.Processing;
          dataGridViewFiles.Refresh();

          if (fileData.FileName is null)
            fileService.DeleteDirectory(viewModel.ActiveFileSystemName!, fileData.FullPath);
          else
            fileService.DeleteFile(viewModel.ActiveFileSystemName!, fileData.FullPath);

          fileData.TransferStatus = TransferStatus.Success;
          dataGridViewFiles.Refresh();

          removedDirectories.Add(fileData.FullPath);

          viewModel.AppendLogMessage($"Finished successfully!");
        }
        catch (Exception ex)
        {
          fileData.TransferStatus = TransferStatus.Error;
          dataGridViewFiles.Refresh();

          viewModel.AppendLogMessage(ex);
        }

        textBoxLog.Refresh();
      }

      foreach (FileData fileData in fileCopyActions)
      {
        try
        {
          string sourcePath = Path.Combine(fileData.FilePath, fileData.FileName!);
          string destinationPath = $"{fileData.FileTargetPath!}/{fileData.FileTargetName}";

          viewModel.AppendLogMessage($"Copy file from '{sourcePath}' to '{destinationPath}'");
          viewModel.AppendLogMessage($"Please wait...");
          textBoxLog.Refresh();

          fileData.TransferStatus = TransferStatus.Processing;
          dataGridViewFiles.Refresh();

          fileService.CopyFile(viewModel.ActiveFileSystemName!, sourcePath, destinationPath, fileData.FileSource);

          fileData.TransferStatus = TransferStatus.Success;
          dataGridViewFiles.Refresh();

          refreshDirectories.Add(fileData.FileTargetPath!);

          viewModel.AppendLogMessage($"Finished successfully!");
        }
        catch (Exception ex)
        {
          fileData.TransferStatus = TransferStatus.Error;
          dataGridViewFiles.Refresh();

          viewModel.AppendLogMessage(ex);
        }

        textBoxLog.Refresh();
      }

      foreach (FileData fileData in fileRenameActions)
      {
        try
        {
          string sourcePath = $"{fileData.FilePath!}{fileData.FileName}";
          string destinationPath = $"{fileData.FileTargetPath!}{fileData.FileTargetName}";

          viewModel.AppendLogMessage($"Rename file from '{sourcePath}' to '{destinationPath}'");
          viewModel.AppendLogMessage($"Please wait...");
          textBoxLog.Refresh();

          fileData.TransferStatus = TransferStatus.Processing;
          dataGridViewFiles.Refresh();

          fileService.RenameFile(viewModel.ActiveFileSystemName!, sourcePath, destinationPath, fileData.FileSource);

          fileData.TransferStatus = TransferStatus.Success;
          dataGridViewFiles.Refresh();

          refreshDirectories.Add(fileData.FileTargetPath!);

          viewModel.AppendLogMessage($"Finished successfully!");
        }
        catch (Exception ex)
        {
          fileData.TransferStatus = TransferStatus.Error;
          dataGridViewFiles.Refresh();

          viewModel.AppendLogMessage(ex);
        }

        textBoxLog.Refresh();
      }
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }

    textBoxLog.Refresh();

    try
    {
      SuspendLayout();

      LoadTreeViewFiles(refreshDirectories);

      fileSystemTreeView.RemoveFiles(removedDirectories);
    }
    finally
    {
      ResumeLayout();
    }
  }

  private void ButtonConnect_Click(object sender, EventArgs e)
  {
    try
    {
      if (!TryGetSelectedDisk(out DiskData? disk))
        throw new Exception("No file system selected");

      if (!disk.IsExtFileSystem)
        throw new InvalidOperationException("Invalid file system! Format has to be Ext2, Ext3 or Ext4");

      if (fileService.GetFileSystemInfo(disk.DiskNumber) is not null)
        throw new InvalidOperationException("File system is already connected!");

      viewModel.AppendLogMessage($"Connecting to file system '{disk.Name}' ...");
      textBoxLog.Refresh();

      viewModel.ConnectFileSystem(disk);

      viewModel.AppendLogMessage($"Connected to file system '{disk.DiskName}' successfully!");

      LoadFileSystem(disk.DiskName);
      LoadDataGridViewDisks();
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }

    textBoxLog.Refresh();
  }

  private void ButtonDisconnect_Click(object sender, EventArgs e)
  {
    try
    {
      if (!TryGetSelectedDisk(out DiskData? disk))
        throw new Exception("No file system selected");

      if (!disk.IsExtFileSystem)
        throw new InvalidOperationException("Invalid file system! Format has to be Ext2, Ext3 or Ext4");

      if (fileService.GetFileSystemInfo(disk.DiskNumber) is null)
        return;

      viewModel.AppendLogMessage($"Disconnecting from file system '{disk.Name}' ...");
      textBoxLog.Refresh();

      ExtFileSystemInfo fileSystemInfo = fileService.CloseFileSystem(disk.DiskNumber);

      disk.TotalSpace = null;
      disk.TotalFreeSpace = null;
      disk.DiskStatus = DiskStatus.Disconnected;

      viewModel.AppendLogMessage($"Disconnected from file system '{disk.DiskName}' successfully!");

      LoadDataGridViewDisks();
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }

    textBoxLog.Refresh();
  }

  private void ButtonOpenFileSystem_Click(object sender, EventArgs e)
  {
    try
    {
      if (!TryGetSelectedDisk(out DiskData? disk))
        throw new Exception("No Disk selected");

      if (!disk.IsExtFileSystem)
        throw new InvalidOperationException("Invalid file system! Format has to be Ext2, Ext3 or Ext4");

      LoadFileSystem(disk.DiskName);
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }

    textBoxLog.Refresh();
  }

  private void ButtonExecute_Click(object sender, EventArgs e)
  {
    try
    {
      Execute();
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }
  }

  private void ButtonCopyToFileSystem_Click(object sender, EventArgs e)
  {
    try
    {
      if (openFileDialog.ShowDialog() is not DialogResult.OK)
        return;

      string workDirectory = viewModel.WorkDirectory!;

      viewModel.QueueFileCopy(FileSource.Native, openFileDialog.FileName, fileTargetPath: workDirectory);

      if (dataGridViewFiles.Rows.Count is 1)
        dataGridViewFiles.Rows[0].Selected = true;

      dataGridViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }
  }

  private void ButtonCopyFromFileSystem_Click(object sender, EventArgs e)
  {
    try
    {
      if (!fileSystemTreeView.PathSelected)
        throw new InvalidOperationException("Select file or directory");

      if (folderBrowserDialog.ShowDialog() is not DialogResult.OK)
        return;

      string sourcePath = fileSystemTreeView.SelectedPath!;
      string fileName = Path.GetFileName(sourcePath)!;

      viewModel.QueueFileCopy(FileSource.External, sourcePath, fileTargetName: fileName, fileTargetPath: folderBrowserDialog.SelectedPath);

      dataGridViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }
  }

  private void ButtonDeleteFromFileSystem_Click(object sender, EventArgs e)
  {
    try
    {
      if (!fileSystemTreeView.PathSelected)
        throw new InvalidOperationException("Select file or directory");

      string sourcePath = fileSystemTreeView.SelectedPath!;

      if (fileSystemTreeView.SelectedNodeIsDirectory())
        viewModel.QueueDirectoryDeleting(FileSource.External, sourcePath);
      else
        viewModel.QueueFileDeleting(FileSource.External, sourcePath);

      dataGridViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }
  }

  private void ButtonRename_Click(object sender, EventArgs e)
  {
    try
    {
      if (!fileSystemTreeView.PathSelected)
        throw new InvalidOperationException("Select file or directory");

      string sourcePath = fileSystemTreeView.SelectedPath!;

      if (fileSystemTreeView.SelectedNodeIsDirectory())
        viewModel.QueueDirectoryRenaming(FileSource.External, sourcePath, sourcePath);
      else
        viewModel.QueueFileRenaming(FileSource.External, sourcePath, sourcePath);

      dataGridViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }
  }

  private void ButtonRemove_Click(object sender, EventArgs e)
  {
    try
    {
      if (dataGridViewFiles.SelectedRows.Count > 0)
      {
        // Remove selected rows
        int rows = dataGridViewFiles.SelectedRows.Count;
        for (int i = rows - 1; i >= 0; i--)
        {
          DataGridViewRow row = dataGridViewFiles.SelectedRows[i];
          dataGridViewFiles.Rows.Remove(row);
        }
      }

      if (dataGridViewFiles.SelectedCells.Count > 0)
      {
        // Remove selected rows
        int rows = dataGridViewFiles.SelectedCells.Count;
        for (int i = rows - 1; i >= 0; i--)
        {
          DataGridViewRow row = dataGridViewFiles.SelectedCells[i].OwningRow;
          dataGridViewFiles.Rows.Remove(row);
        }
      }
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }
  }

  private void ButtonRemoveAll_Click(object sender, EventArgs e)
  {
    try
    {
      if (dataGridViewFiles.Rows.Count is 0)
        return;

      // Remove all rows
      int rows = dataGridViewFiles.Rows.Count;
      for (int i = rows - 1; i >= 0; i--)
      {
        DataGridViewRow row = dataGridViewFiles.Rows[i];
        dataGridViewFiles.Rows.Remove(row);
      }
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }
  }

  private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
  {
    try
    {
      if (e.Node is null)
        return;

      if (fileSystemTreeView.SelectedNodeIsDirectory())
      {
        viewModel.WorkDirectory = e.Node.Name;

        labelFileInfo.Text = viewModel.WorkDirectory;
        labelFileSize.Text = string.Empty;
      }
      else
      {
        IEnumerable<string> directories = e.Node.Name.Split("/", StringSplitOptions.RemoveEmptyEntries).SkipLast(1);
        if (directories.Any())
          viewModel.WorkDirectory = $"/{string.Join("/", directories)}/";
        else
          viewModel.WorkDirectory = $"/";

        ExtFileInfo? fileInfo = fileService.GetFileInfo(viewModel.ActiveFileSystemName!, e.Node.Name.TrimEnd('/'))!;
        if (fileInfo is null)
        {
          labelFileInfo.Text = viewModel.WorkDirectory;
          labelFileSize.Text = string.Empty;
        }
        else
        {
          labelFileInfo.Text = fileInfo.FullName;
          labelFileSize.Text = fileInfo.FileSize < 1024
            ? StringFormatter.ToSizeUnit(fileInfo.FileSize, StringFormatter.SizeUnit.Bytes)
            : StringFormatter.ToSizeUnit(fileInfo.FileSize, StringFormatter.SizeUnit.KB);
        }
      }
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }
  }

  private void DataGridViewFiles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
  {
    foreach (DataGridViewRow row in dataGridViewFiles.Rows)
    {
      switch (Parse.ToEnum<TransferStatus>(row.Cells["ColumnStatus"].Value))
      {
        case TransferStatus.Pending:
          row.Cells["ColumnStatus"].Style.ForeColor = SystemColors.Highlight;
          break;
        case TransferStatus.Success:
          row.Cells["ColumnStatus"].Style.ForeColor = Color.Green;
          break;
        case TransferStatus.Error:
          row.Cells["ColumnStatus"].Style.ForeColor = Color.Red;
          break;
      }
    }
  }

  private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
  {
    Application.Exit();
  }

  private void MainForm_Shown(object sender, EventArgs e)
  {
    LoadDataGridViewDisks();
  }

  private void FileSystemTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
  {
    fileSystemTreeView.SuspendLayout();
  }
  private void FileSystemTreeView_AfterExpand(object sender, TreeViewEventArgs e)
  {
    fileSystemTreeView.Refresh();
    fileSystemTreeView.ResumeLayout();
  }

  private void FileSystemTreeView_AfterCollapse(object sender, TreeViewEventArgs e)
  {
    fileSystemTreeView.Refresh();
    fileSystemTreeView.ResumeLayout();
  }
  private void FileSystemTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
  {
    fileSystemTreeView.SuspendLayout();
  }

  private void DataGridViewFiles_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.ColumnIndex is not -1)
    {
      switch (dataGridViewFiles.Columns[e.ColumnIndex].Name)
      {
        // Remove
        case "ColumnDeleteEvent":
          DataGridViewRow row = dataGridViewFiles.Rows[e.RowIndex];
          dataGridViewFiles.Rows.Remove(row);
          break;
      }
    }
  }

  private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
  {
    try
    {
      using AboutView view = new AboutView();
      view.ShowDialog();
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }
  }

  private void ToolStripButtonClearAll_Click(object sender, EventArgs e)
  {
    try
    {
      viewModel.ClearLog();
      textBoxLog.Clear();
    }
    catch (Exception ex)
    {
      viewModel.AppendLogMessage(ex);
    }
  }

  private void ToolStripButton_Paint(object sender, PaintEventArgs e)
  {
    // Draw border
    ToolStripButton button = (ToolStripButton)sender;
    button.DrawBorder(e.Graphics, Themes.Current.BorderColor);
  }
}