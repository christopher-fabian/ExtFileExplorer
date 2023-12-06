using ExtFileExplorer.Disks;
using ExtFileExplorer.Files;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtFileExplorer.ViewModels;

internal sealed class MainViewModel : ViewModelBase
{
  public string? WorkDirectory
  {
    get => workDirectory;
    set
    {
      if (workDirectory != value)
      {
        workDirectory = value;
        NotifyPropertyChanged();
      }
    }
  }
  public string? ActiveFileSystemName
  {
    get => activeFileSystemName;
    set
    {
      if (activeFileSystemName != value)
      {
        activeFileSystemName = value;
        NotifyPropertyChanged();
      }
    }
  }
  public string LogMessage => logMessageBuilder.ToString();
  public bool HasActiveFileSystem => !string.IsNullOrWhiteSpace(ActiveFileSystemName);
  public BindingList<FileData> FileData { get; set; } = new BindingList<FileData>();
  public BindingList<DiskData> DiskData { get; set; } = new BindingList<DiskData>();

  private readonly StringBuilder logMessageBuilder = new();
  private readonly IExtFileService fileService;
  private readonly IDiskService diskService;
  private string? activeFileSystemName;
  private string? workDirectory;

  public MainViewModel(IExtFileService fileService, IDiskService diskService)
  {
    this.fileService = fileService;
    this.diskService = diskService;
  }

  public void LoadDisks()
  {
    DiskData.Clear();

    foreach (DiskData disk in diskService.GetDisks())
      DiskData.Add(disk);
  }

  public ExtFileSystemInfo ConnectFileSystem(DiskData disk)
  {
    ExtFileSystemInfo fileSystemInfo = fileService.OpenFileSystem(disk.DiskNumber, disk.DiskName);

    disk.TotalSpace = fileSystemInfo.TotalSpace;
    disk.TotalFreeSpace = fileSystemInfo.FreeSpace;
    disk.DiskStatus = DiskStatus.Connected;

    return fileSystemInfo;
  }

  public void AppendLogMessage(Exception exception)
    => AppendLogMessage($"An error has occured! {exception.Message}");
  public void AppendLogMessage(string message)
  {
    logMessageBuilder.Insert(0, $"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
    NotifyPropertyChanged(nameof(LogMessage));
  }

  public void ClearLog()
  {
    logMessageBuilder.Clear();
    NotifyPropertyChanged(nameof(LogMessage));
  }

  public void QueueFileCopy(FileSource fileSource, string fullPath, string? fileTargetName = null, string? fileTargetPath = null)
  {
    FileData fileData;

    switch (fileSource)
    {
      case FileSource.Native:
        fileData = GetFileDataNative();
        break;
      case FileSource.External:
        fileData = GetFileDataExternal();
        break;
      default:
        throw new NotSupportedException();
    }

    FileData.Add(fileData);

    FileData GetFileDataNative()
    {
      FileInfo fileInfo = new FileInfo(fullPath);
      return new FileData(fileInfo.Name, fileInfo.DirectoryName!, fileTargetName ?? fileInfo.Name, fileTargetPath, Parse.ToUInt64(fileInfo.Length), fileSource, FileAction.Copy);
    }

    FileData GetFileDataExternal()
    {
      string fileName = Path.GetFileName(fullPath);
      string filePath = fullPath.Replace(fileName, string.Empty);
      ulong fileSize = fileService.GetFileSize(activeFileSystemName!, fullPath);
      return new FileData(fileName, filePath, fileName, fileTargetPath, fileSize, fileSource, FileAction.Copy);
    }
  }
  public void QueueFileDeleting(FileSource fileSource, string fullPath)
  {
    string fileName = Path.GetFileName(fullPath);
    string filePath = fullPath.Replace(fileName, string.Empty);
    ulong fileSize = fileService.GetFileSize(activeFileSystemName!, fullPath);
    FileData.Add(new FileData(fileName, filePath, null, null, fileSize, fileSource, FileAction.Delete));
  }
  public void QueueDirectoryDeleting(FileSource fileSource, string fullPath)
  {
    FileData.Add(new FileData(null, fullPath, null, null, null, fileSource, FileAction.Delete));
  }
  public void QueueFileRenaming(FileSource fileSource, string sourcePath, string destinationPath)
  {
    string fileName = Path.GetFileName(sourcePath);
    string filePath = sourcePath.Replace(fileName, string.Empty);
    string targetFileName = Path.GetFileName(destinationPath);
    string targetFilePath = destinationPath.Replace(targetFileName, string.Empty);
    ulong fileSize = fileService.GetFileSize(activeFileSystemName!, sourcePath);
    FileData.Add(new FileData(fileName, filePath, targetFileName, targetFilePath, fileSize, fileSource, FileAction.Rename));
  }
  public void QueueDirectoryRenaming(FileSource fileSource, string sourcePath, string destinationPath)
    => FileData.Add(new FileData(null, sourcePath, null, destinationPath, null, fileSource, FileAction.Rename));

  public void LoadFileSystem(string fileSystemName)
  {
    fileService.GetFileSystemInfo(fileSystemName);
  }

  public void RemoveFile(string fileName)
  {
    FileData? file = FileData.FirstOrDefault(fileData => fileData.FileName == fileName);
    if (file is not null)
      FileData.Remove(file);
  }
}
