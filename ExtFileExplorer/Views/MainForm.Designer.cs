using System.Windows.Forms;

namespace ExtFileExplorer.Views
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.textBoxWorkDirectory = new System.Windows.Forms.TextBox();
      this.labelWorkDirectory = new System.Windows.Forms.Label();
      this.textBoxLog = new System.Windows.Forms.TextBox();
      this.button4 = new System.Windows.Forms.Button();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.dataGridViewDisks = new System.Windows.Forms.DataGridView();
      this.ColumnDiskStatus = new System.Windows.Forms.DataGridViewImageColumn();
      this.ColumnDiskNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnTotalFreeSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnTotalSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
      this.ColumnDeleteEvent = new System.Windows.Forms.DataGridViewImageColumn();
      this.columnAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnFileTargetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnFileTargetPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fileSystemTreeView = new ExtFileExplorer.Views.TreeViewFileSystem();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.labelCurrentDisk = new System.Windows.Forms.Label();
      this.buttonReload = new System.Windows.Forms.Button();
      this.buttonCopyFrom = new System.Windows.Forms.Button();
      this.buttonDisconnect = new System.Windows.Forms.Button();
      this.labelFileInfo = new System.Windows.Forms.Label();
      this.labelFileSize = new System.Windows.Forms.Label();
      this.buttonRename = new System.Windows.Forms.Button();
      this.toolStripLog = new System.Windows.Forms.ToolStrip();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonChooseFile = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonRemoveAll = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
      this.menuStrip.SuspendLayout();
      this.toolStripLog.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxWorkDirectory
      // 
      this.textBoxWorkDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxWorkDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.textBoxWorkDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxWorkDirectory.ForeColor = System.Drawing.Color.White;
      this.textBoxWorkDirectory.Location = new System.Drawing.Point(90, 541);
      this.textBoxWorkDirectory.Name = "textBoxWorkDirectory";
      this.textBoxWorkDirectory.Size = new System.Drawing.Size(610, 22);
      this.textBoxWorkDirectory.TabIndex = 3;
      // 
      // labelWorkDirectory
      // 
      this.labelWorkDirectory.AutoSize = true;
      this.labelWorkDirectory.ForeColor = System.Drawing.Color.White;
      this.labelWorkDirectory.Location = new System.Drawing.Point(0, 546);
      this.labelWorkDirectory.Name = "labelWorkDirectory";
      this.labelWorkDirectory.Size = new System.Drawing.Size(84, 13);
      this.labelWorkDirectory.TabIndex = 2;
      this.labelWorkDirectory.Text = "Work Directory";
      // 
      // textBoxLog
      // 
      this.textBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.textBoxLog.ForeColor = System.Drawing.Color.White;
      this.textBoxLog.Location = new System.Drawing.Point(0, 783);
      this.textBoxLog.Multiline = true;
      this.textBoxLog.Name = "textBoxLog";
      this.textBoxLog.ReadOnly = true;
      this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxLog.Size = new System.Drawing.Size(1284, 78);
      this.textBoxLog.TabIndex = 4;
      // 
      // button4
      // 
      this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.ForeColor = System.Drawing.Color.White;
      this.button4.Image = global::ExtFileExplorer.Properties.Resources.AddConnection_16x;
      this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button4.Location = new System.Drawing.Point(862, 221);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(150, 23);
      this.button4.TabIndex = 11;
      this.button4.Text = "Connect";
      this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.ButtonConnect_Click);
      // 
      // buttonDelete
      // 
      this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonDelete.ForeColor = System.Drawing.Color.White;
      this.buttonDelete.Image = global::ExtFileExplorer.Properties.Resources.RemoveDocument_16x;
      this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonDelete.Location = new System.Drawing.Point(706, 451);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(150, 23);
      this.buttonDelete.TabIndex = 16;
      this.buttonDelete.Text = "Delete";
      this.buttonDelete.UseVisualStyleBackColor = false;
      this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteFromFileSystem_Click);
      // 
      // dataGridViewDisks
      // 
      this.dataGridViewDisks.AllowUserToAddRows = false;
      this.dataGridViewDisks.AllowUserToDeleteRows = false;
      dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
      this.dataGridViewDisks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
      this.dataGridViewDisks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewDisks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.dataGridViewDisks.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataGridViewDisks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewDisks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
      this.dataGridViewDisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDisks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDiskStatus,
            this.ColumnDiskNumber,
            this.ColumnName,
            this.ColumnType,
            this.ColumnFormat,
            this.ColumnTotalFreeSpace,
            this.ColumnTotalSpace});
      dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewDisks.DefaultCellStyle = dataGridViewCellStyle23;
      this.dataGridViewDisks.EnableHeadersVisualStyles = false;
      this.dataGridViewDisks.Location = new System.Drawing.Point(699, 52);
      this.dataGridViewDisks.Name = "dataGridViewDisks";
      this.dataGridViewDisks.ReadOnly = true;
      this.dataGridViewDisks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewDisks.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
      dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
      this.dataGridViewDisks.RowsDefaultCellStyle = dataGridViewCellStyle25;
      this.dataGridViewDisks.RowTemplate.Height = 25;
      this.dataGridViewDisks.Size = new System.Drawing.Size(585, 150);
      this.dataGridViewDisks.TabIndex = 18;
      // 
      // ColumnDiskStatus
      // 
      this.ColumnDiskStatus.HeaderText = "";
      this.ColumnDiskStatus.Name = "ColumnDiskStatus";
      this.ColumnDiskStatus.ReadOnly = true;
      // 
      // ColumnDiskNumber
      // 
      this.ColumnDiskNumber.DataPropertyName = "DiskNumber";
      this.ColumnDiskNumber.HeaderText = "Volume";
      this.ColumnDiskNumber.Name = "ColumnDiskNumber";
      this.ColumnDiskNumber.ReadOnly = true;
      // 
      // ColumnName
      // 
      this.ColumnName.DataPropertyName = "Name";
      this.ColumnName.HeaderText = "Name";
      this.ColumnName.Name = "ColumnName";
      this.ColumnName.ReadOnly = true;
      // 
      // ColumnType
      // 
      this.ColumnType.DataPropertyName = "Type";
      this.ColumnType.HeaderText = "Type";
      this.ColumnType.Name = "ColumnType";
      this.ColumnType.ReadOnly = true;
      // 
      // ColumnFormat
      // 
      this.ColumnFormat.DataPropertyName = "Format";
      this.ColumnFormat.HeaderText = "Format";
      this.ColumnFormat.Name = "ColumnFormat";
      this.ColumnFormat.ReadOnly = true;
      // 
      // ColumnTotalFreeSpace
      // 
      this.ColumnTotalFreeSpace.DataPropertyName = "TotalFreeSpaceInGB";
      this.ColumnTotalFreeSpace.HeaderText = "Free Space";
      this.ColumnTotalFreeSpace.Name = "ColumnTotalFreeSpace";
      this.ColumnTotalFreeSpace.ReadOnly = true;
      // 
      // ColumnTotalSpace
      // 
      this.ColumnTotalSpace.DataPropertyName = "TotalSpaceInGB";
      this.ColumnTotalSpace.HeaderText = "Total Space";
      this.ColumnTotalSpace.Name = "ColumnTotalSpace";
      this.ColumnTotalSpace.ReadOnly = true;
      // 
      // dataGridViewFiles
      // 
      this.dataGridViewFiles.AllowUserToAddRows = false;
      this.dataGridViewFiles.AllowUserToDeleteRows = false;
      dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
      this.dataGridViewFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
      this.dataGridViewFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.dataGridViewFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
      this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDeleteEvent,
            this.columnAction,
            this.ColumnStatus,
            this.columnFile,
            this.columnFilePath,
            this.ColumnFileTargetName,
            this.ColumnFileTargetPath,
            this.ColumnFileSize});
      dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewFiles.DefaultCellStyle = dataGridViewCellStyle28;
      this.dataGridViewFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dataGridViewFiles.EnableHeadersVisualStyles = false;
      this.dataGridViewFiles.Location = new System.Drawing.Point(0, 608);
      this.dataGridViewFiles.Name = "dataGridViewFiles";
      this.dataGridViewFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
      dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
      this.dataGridViewFiles.RowsDefaultCellStyle = dataGridViewCellStyle30;
      this.dataGridViewFiles.RowTemplate.Height = 25;
      this.dataGridViewFiles.Size = new System.Drawing.Size(1284, 175);
      this.dataGridViewFiles.TabIndex = 19;
      this.dataGridViewFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFiles_CellClick);
      this.dataGridViewFiles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewFiles_CellFormatting);
      // 
      // ColumnDeleteEvent
      // 
      this.ColumnDeleteEvent.HeaderText = "";
      this.ColumnDeleteEvent.Image = global::ExtFileExplorer.Properties.Resources.RemoveEvent_16x;
      this.ColumnDeleteEvent.Name = "ColumnDeleteEvent";
      this.ColumnDeleteEvent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColumnDeleteEvent.ToolTipText = "Remove";
      // 
      // columnAction
      // 
      this.columnAction.DataPropertyName = "FileAction";
      this.columnAction.HeaderText = "Action";
      this.columnAction.Name = "columnAction";
      this.columnAction.ReadOnly = true;
      // 
      // ColumnStatus
      // 
      this.ColumnStatus.DataPropertyName = "TransferStatus";
      this.ColumnStatus.HeaderText = "Status";
      this.ColumnStatus.Name = "ColumnStatus";
      this.ColumnStatus.ReadOnly = true;
      // 
      // columnFile
      // 
      this.columnFile.DataPropertyName = "FileName";
      this.columnFile.HeaderText = "File";
      this.columnFile.Name = "columnFile";
      this.columnFile.ReadOnly = true;
      // 
      // columnFilePath
      // 
      this.columnFilePath.DataPropertyName = "FilePath";
      this.columnFilePath.HeaderText = "Path";
      this.columnFilePath.Name = "columnFilePath";
      this.columnFilePath.ReadOnly = true;
      // 
      // ColumnFileTargetName
      // 
      this.ColumnFileTargetName.DataPropertyName = "FileTargetName";
      this.ColumnFileTargetName.HeaderText = "Target Name";
      this.ColumnFileTargetName.Name = "ColumnFileTargetName";
      // 
      // ColumnFileTargetPath
      // 
      this.ColumnFileTargetPath.DataPropertyName = "FileTargetPath";
      this.ColumnFileTargetPath.HeaderText = "Target Path";
      this.ColumnFileTargetPath.Name = "ColumnFileTargetPath";
      // 
      // ColumnFileSize
      // 
      this.ColumnFileSize.DataPropertyName = "FileSizeInKB";
      this.ColumnFileSize.HeaderText = "Size";
      this.ColumnFileSize.Name = "ColumnFileSize";
      // 
      // fileSystemTreeView
      // 
      this.fileSystemTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fileSystemTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.fileSystemTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.fileSystemTreeView.DirectoryClosedImage = ((System.Drawing.Bitmap)(resources.GetObject("fileSystemTreeView.DirectoryClosedImage")));
      this.fileSystemTreeView.DirectoryOpenedImage = ((System.Drawing.Bitmap)(resources.GetObject("fileSystemTreeView.DirectoryOpenedImage")));
      this.fileSystemTreeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
      this.fileSystemTreeView.FileImage = ((System.Drawing.Bitmap)(resources.GetObject("fileSystemTreeView.FileImage")));
      this.fileSystemTreeView.FileNodeColor = System.Drawing.SystemColors.Highlight;
      this.fileSystemTreeView.ForeColor = System.Drawing.Color.White;
      this.fileSystemTreeView.FullRowSelect = true;
      this.fileSystemTreeView.Location = new System.Drawing.Point(0, 68);
      this.fileSystemTreeView.Name = "fileSystemTreeView";
      this.fileSystemTreeView.Size = new System.Drawing.Size(700, 450);
      this.fileSystemTreeView.TabIndex = 23;
      this.fileSystemTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.FileSystemTreeView_BeforeCollapse);
      this.fileSystemTreeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.FileSystemTreeView_AfterCollapse);
      this.fileSystemTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.FileSystemTreeView_BeforeExpand);
      this.fileSystemTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.FileSystemTreeView_AfterExpand);
      this.fileSystemTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
      // 
      // toolStrip
      // 
      this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(1284, 25);
      this.toolStrip.TabIndex = 24;
      // 
      // menuStrip
      // 
      this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.menuStrip.Size = new System.Drawing.Size(1284, 24);
      this.menuStrip.TabIndex = 25;
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
      this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // labelCurrentDisk
      // 
      this.labelCurrentDisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.labelCurrentDisk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.labelCurrentDisk.ForeColor = System.Drawing.SystemColors.Highlight;
      this.labelCurrentDisk.Location = new System.Drawing.Point(0, 54);
      this.labelCurrentDisk.Name = "labelCurrentDisk";
      this.labelCurrentDisk.Size = new System.Drawing.Size(25, 15);
      this.labelCurrentDisk.TabIndex = 26;
      // 
      // buttonReload
      // 
      this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonReload.ForeColor = System.Drawing.Color.White;
      this.buttonReload.Image = global::ExtFileExplorer.Properties.Resources.ListFolder_16x;
      this.buttonReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonReload.Location = new System.Drawing.Point(706, 221);
      this.buttonReload.Name = "buttonReload";
      this.buttonReload.Size = new System.Drawing.Size(150, 23);
      this.buttonReload.TabIndex = 27;
      this.buttonReload.Text = "Open File System";
      this.buttonReload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.buttonReload.UseVisualStyleBackColor = false;
      this.buttonReload.Click += new System.EventHandler(this.ButtonOpenFileSystem_Click);
      // 
      // buttonCopyFrom
      // 
      this.buttonCopyFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCopyFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.buttonCopyFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonCopyFrom.ForeColor = System.Drawing.Color.White;
      this.buttonCopyFrom.Image = global::ExtFileExplorer.Properties.Resources.Copy_16x;
      this.buttonCopyFrom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonCopyFrom.Location = new System.Drawing.Point(706, 480);
      this.buttonCopyFrom.Name = "buttonCopyFrom";
      this.buttonCopyFrom.Size = new System.Drawing.Size(150, 23);
      this.buttonCopyFrom.TabIndex = 28;
      this.buttonCopyFrom.Text = "Copy";
      this.buttonCopyFrom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.buttonCopyFrom.UseVisualStyleBackColor = false;
      this.buttonCopyFrom.Click += new System.EventHandler(this.ButtonCopyFromFileSystem_Click);
      // 
      // buttonDisconnect
      // 
      this.buttonDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonDisconnect.ForeColor = System.Drawing.Color.White;
      this.buttonDisconnect.Image = global::ExtFileExplorer.Properties.Resources.Disconnect_16x;
      this.buttonDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonDisconnect.Location = new System.Drawing.Point(1018, 221);
      this.buttonDisconnect.Name = "buttonDisconnect";
      this.buttonDisconnect.Size = new System.Drawing.Size(150, 23);
      this.buttonDisconnect.TabIndex = 29;
      this.buttonDisconnect.Text = "Disconnect";
      this.buttonDisconnect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.buttonDisconnect.UseVisualStyleBackColor = false;
      this.buttonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
      // 
      // labelFileInfo
      // 
      this.labelFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelFileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.labelFileInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.labelFileInfo.ForeColor = System.Drawing.Color.Yellow;
      this.labelFileInfo.Location = new System.Drawing.Point(0, 517);
      this.labelFileInfo.Name = "labelFileInfo";
      this.labelFileInfo.Size = new System.Drawing.Size(600, 15);
      this.labelFileInfo.TabIndex = 30;
      this.labelFileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelFileSize
      // 
      this.labelFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelFileSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.labelFileSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.labelFileSize.ForeColor = System.Drawing.Color.Yellow;
      this.labelFileSize.Location = new System.Drawing.Point(599, 517);
      this.labelFileSize.Name = "labelFileSize";
      this.labelFileSize.Size = new System.Drawing.Size(101, 15);
      this.labelFileSize.TabIndex = 31;
      this.labelFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // buttonRename
      // 
      this.buttonRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.buttonRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonRename.ForeColor = System.Drawing.Color.White;
      this.buttonRename.Image = global::ExtFileExplorer.Properties.Resources.Rename_16x;
      this.buttonRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonRename.Location = new System.Drawing.Point(706, 509);
      this.buttonRename.Name = "buttonRename";
      this.buttonRename.Size = new System.Drawing.Size(150, 23);
      this.buttonRename.TabIndex = 32;
      this.buttonRename.Text = "Rename";
      this.buttonRename.UseVisualStyleBackColor = false;
      this.buttonRename.Click += new System.EventHandler(this.ButtonRename_Click);
      // 
      // toolStripLog
      // 
      this.toolStripLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.toolStripLog.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.toolStripLog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.toolStripLog.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStripLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButtonChooseFile,
            this.toolStripButtonRemoveAll,
            this.toolStripButtonRemove});
      this.toolStripLog.Location = new System.Drawing.Point(0, 583);
      this.toolStripLog.Name = "toolStripLog";
      this.toolStripLog.Size = new System.Drawing.Size(1284, 25);
      this.toolStripLog.TabIndex = 33;
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.toolStripButton1.Image = global::ExtFileExplorer.Properties.Resources.Event_16x;
      this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(66, 22);
      this.toolStripButton1.Text = "Execute";
      this.toolStripButton1.Click += new System.EventHandler(this.ButtonExecute_Click);
      this.toolStripButton1.Paint += new System.Windows.Forms.PaintEventHandler(this.ToolStripButton_Paint);
      // 
      // toolStripButtonChooseFile
      // 
      this.toolStripButtonChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.toolStripButtonChooseFile.Image = global::ExtFileExplorer.Properties.Resources.AddDocument_16x;
      this.toolStripButtonChooseFile.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonChooseFile.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
      this.toolStripButtonChooseFile.Name = "toolStripButtonChooseFile";
      this.toolStripButtonChooseFile.Size = new System.Drawing.Size(74, 22);
      this.toolStripButtonChooseFile.Text = "Copy File";
      this.toolStripButtonChooseFile.Click += new System.EventHandler(this.ButtonCopyToFileSystem_Click);
      this.toolStripButtonChooseFile.Paint += new System.Windows.Forms.PaintEventHandler(this.ToolStripButton_Paint);
      // 
      // toolStripButtonRemoveAll
      // 
      this.toolStripButtonRemoveAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripButtonRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.toolStripButtonRemoveAll.Image = global::ExtFileExplorer.Properties.Resources.RemoveEvent_16x;
      this.toolStripButtonRemoveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.toolStripButtonRemoveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonRemoveAll.Margin = new System.Windows.Forms.Padding(10, 1, 5, 2);
      this.toolStripButtonRemoveAll.Name = "toolStripButtonRemoveAll";
      this.toolStripButtonRemoveAll.Size = new System.Drawing.Size(83, 22);
      this.toolStripButtonRemoveAll.Text = "Remove All";
      this.toolStripButtonRemoveAll.Click += new System.EventHandler(this.ButtonRemoveAll_Click);
      this.toolStripButtonRemoveAll.Paint += new System.Windows.Forms.PaintEventHandler(this.ToolStripButton_Paint);
      // 
      // toolStripButtonRemove
      // 
      this.toolStripButtonRemove.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripButtonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.toolStripButtonRemove.Image = global::ExtFileExplorer.Properties.Resources.RemoveEvent_16x;
      this.toolStripButtonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonRemove.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
      this.toolStripButtonRemove.Name = "toolStripButtonRemove";
      this.toolStripButtonRemove.Size = new System.Drawing.Size(67, 22);
      this.toolStripButtonRemove.Text = "Remove";
      this.toolStripButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
      this.toolStripButtonRemove.Paint += new System.Windows.Forms.PaintEventHandler(this.ToolStripButton_Paint);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.ClientSize = new System.Drawing.Size(1284, 861);
      this.Controls.Add(this.buttonRename);
      this.Controls.Add(this.labelFileSize);
      this.Controls.Add(this.labelFileInfo);
      this.Controls.Add(this.buttonDisconnect);
      this.Controls.Add(this.buttonCopyFrom);
      this.Controls.Add(this.buttonReload);
      this.Controls.Add(this.labelCurrentDisk);
      this.Controls.Add(this.toolStripLog);
      this.Controls.Add(this.dataGridViewFiles);
      this.Controls.Add(this.fileSystemTreeView);
      this.Controls.Add(this.dataGridViewDisks);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(this.menuStrip);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.textBoxLog);
      this.Controls.Add(this.textBoxWorkDirectory);
      this.Controls.Add(this.labelWorkDirectory);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ForeColor = System.Drawing.Color.White;
      this.Name = "MainForm";
      this.Text = "EXT File Explorer";
      this.Shown += new System.EventHandler(this.MainForm_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.toolStripLog.ResumeLayout(false);
      this.toolStripLog.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private TextBox textBoxWorkDirectory;
    private Label labelWorkDirectory;
    private TextBox textBoxLog;
    private Button button4;
    private Button buttonDelete;
    private DataGridView dataGridViewDisks;
    private DataGridView dataGridViewFiles;
    private TreeViewFileSystem fileSystemTreeView;
    private ToolStrip toolStrip;
    private MenuStrip menuStrip;
    private Label labelCurrentDisk;
    private Button buttonReload;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private DataGridViewImageColumn ColumnDiskStatus;
    private DataGridViewTextBoxColumn ColumnDiskNumber;
    private DataGridViewTextBoxColumn ColumnName;
    private DataGridViewTextBoxColumn ColumnType;
    private DataGridViewTextBoxColumn ColumnFormat;
    private DataGridViewTextBoxColumn ColumnTotalFreeSpace;
    private DataGridViewTextBoxColumn ColumnTotalSpace;
    private Button buttonCopyFrom;
    private Button buttonDisconnect;
    private Label labelFileInfo;
    private Label labelFileSize;
    private Button buttonRename;
    private ToolStrip toolStripLog;
    private ToolStripButton toolStripButton1;
    private ToolStripButton toolStripButtonChooseFile;
    private ToolStripButton toolStripButtonRemove;
    private ToolStripButton toolStripButtonRemoveAll;
    private DataGridViewImageColumn ColumnDeleteEvent;
    private DataGridViewTextBoxColumn columnAction;
    private DataGridViewTextBoxColumn ColumnStatus;
    private DataGridViewTextBoxColumn columnFile;
    private DataGridViewTextBoxColumn columnFilePath;
    private DataGridViewTextBoxColumn ColumnFileTargetName;
    private DataGridViewTextBoxColumn ColumnFileTargetPath;
    private DataGridViewTextBoxColumn ColumnFileSize;
  }
}