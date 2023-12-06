using ExtFileExplorer.Models;
using System;
using System.IO;

namespace ExtFileExplorer.Disks;

internal sealed class DiskData : ModelBase
{
  public DiskStatus DiskStatus
  {
    get => diskStatus;
    set
    {
      if (diskStatus != value)
      {
        diskStatus = value;
        NotifyPropertyChanged();
      }
    }
  }
  public int DiskNumber
  {
    get => diskNumber;
    set
    {
      if (diskNumber != value)
      {
        diskNumber = value;
        NotifyPropertyChanged();
      }
    }
  }
  public string DiskName
  {
    get => diskName;
    set
    {
      if (diskName != value)
      {
        diskName = value;
        NotifyPropertyChanged();
      }
    }
  }
  public DriveType Type
  {
    get => type;
    set
    {
      if (type != value)
      {
        type = value;
        NotifyPropertyChanged();
      }
    }
  }
  public string? Format
  {
    get => format;
    set
    {
      if (format != value)
      {
        format = value;
        NotifyPropertyChanged();
      }
    }
  }
  public string? DiskLabel
  {
    get => diskLabel;
    set
    {
      if (diskLabel != value)
      {
        diskLabel = value;
        NotifyPropertyChanged();
      }
    }
  }
  public ulong? TotalSpace
  {
    get => totalSpace;
    set
    {
      if (totalSpace != value)
      {
        totalSpace = value;
        NotifyPropertyChanged();
      }
    }
  }
  public ulong? TotalFreeSpace
  {
    get => totalFreeSpace;
    set
    {
      if (totalFreeSpace != value)
      {
        totalFreeSpace = value;
        NotifyPropertyChanged();
      }
    }
  }

  public string Name => string.IsNullOrWhiteSpace(DiskLabel) ? DiskName : $"{DiskLabel} ({DiskName})";

  public string TotalSpaceInGB => TotalSpace.HasValue ? StringFormatter.ToSizeUnit(TotalSpace.Value < 1024 ? 1024 : TotalSpace.Value, StringFormatter.SizeUnit.GB, 2) : string.Empty;

  public string TotalFreeSpaceInGB => TotalFreeSpace.HasValue ? StringFormatter.ToSizeUnit(TotalFreeSpace.Value < 1024 ? 1024 : TotalFreeSpace.Value, StringFormatter.SizeUnit.GB, 2) : string.Empty;

  public bool IsExtFileSystem => string.IsNullOrWhiteSpace(Format) || Format.Contains("EXT", StringComparison.OrdinalIgnoreCase);

  private DiskStatus diskStatus;
  private int diskNumber;
  private string diskName;
  private DriveType type;
  private string? format;
  private string? diskLabel;
  private ulong? totalSpace;
  private ulong? totalFreeSpace;

  public DiskData(int diskNumber, string diskName, DriveType type, string? format = null, string? diskLabel = null, ulong? totalSpace = null, ulong? totalFreeSpace = null)
  {
    this.diskStatus = DiskStatus.Disconnected;
    this.diskNumber = diskNumber;
    this.diskName = diskName;
    this.type = type;
    this.format = format;
    this.diskLabel = diskLabel;
    this.totalSpace = totalSpace;
    this.totalFreeSpace = totalFreeSpace;
  }
}
