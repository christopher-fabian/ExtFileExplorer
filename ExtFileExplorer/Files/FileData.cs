using ExtFileExplorer.Models;
using System;
using System.IO;

namespace ExtFileExplorer.Files;

internal sealed class FileData : ModelBase
{
  public string? FileName
  {
    get => fileName;
    set
    {
      if (fileName != value)
      {
        fileName = value;
        NotifyPropertyChanged();
      }
    }
  }
  public string FilePath
  {
    get => filePath;
    set
    {
      if (filePath != value)
      {
        filePath = value;
        NotifyPropertyChanged();
      }
    }
  }
  public string FullPath
  {
    get
    {
      string fullPath;
      if (string.IsNullOrWhiteSpace(fileName))
        fullPath = filePath;
      else
      {
        if (fileSource is FileSource.Native)
          fullPath = Path.Combine(filePath, fileName);
        else
          fullPath = $"{filePath}{fileName}";
      }
      return fullPath;
    }
  }
  public string? FileTargetName
  {
    get => fileTargetName;
    set
    {
      if (fileTargetName != value)
      {
        fileTargetName = value;
        NotifyPropertyChanged();
      }
    }
  }
  public string? FileTargetPath
  {
    get => fileTargetPath;
    set
    {
      if (fileTargetPath != value)
      {
        fileTargetPath = value;
        NotifyPropertyChanged();
      }
    }
  }
  public ulong? FileSize
  {
    get => fileSize;
    set
    {
      if (fileSize != value)
      {
        fileSize = value;
        NotifyPropertyChanged();
      }
    }
  }
  public FileSource FileSource
  {
    get => fileSource;
    set
    {
      if (fileSource != value)
      {
        fileSource = value;
        NotifyPropertyChanged();
      }
    }
  }
  public FileAction FileAction
  {
    get => fileAction;
    set
    {
      if (fileAction != value)
      {
        fileAction = value;
        NotifyPropertyChanged();
      }
    }
  }
  public TransferStatus TransferStatus
  {
    get => transferStatus;
    set
    {
      if (transferStatus != value)
      {
        transferStatus = value;
        NotifyPropertyChanged();
      }
    }
  }

  public string FileSizeInKB => FileSize.HasValue ? StringFormatter.ToSizeUnit(FileSize.Value < 1024 ? 1024 : FileSize.Value, StringFormatter.SizeUnit.KB) : string.Empty;

  private string? fileName;
  private string filePath;
  private string? fileTargetName;
  private string? fileTargetPath;
  private ulong? fileSize;
  private FileSource fileSource;
  private FileAction fileAction;
  private TransferStatus transferStatus;

  public FileData(string? fileName, string filePath, string? fileTargetName, string? fileTargetPath,
    ulong? fileSize, FileSource fileSource, FileAction fileAction, TransferStatus transferStatus = TransferStatus.Pending)
  {
    this.fileName = fileName;
    this.filePath = filePath;
    this.fileTargetName = fileTargetName;
    this.fileTargetPath = fileTargetPath;
    this.fileSize = fileSize;
    this.fileSource = fileSource;
    this.fileAction = fileAction;
    this.transferStatus = transferStatus;
  }
}