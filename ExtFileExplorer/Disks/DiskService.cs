using ExtFileExplorer.Files;
using System.Collections.Generic;
using System.IO;

namespace ExtFileExplorer.Disks;

internal sealed class DiskService : IDiskService
{
  private const bool HideNoneExtDrives = false;
  private const string ExtDriveFormat = "EXT";

  private readonly IExtFileService fileService;

  public DiskService(IExtFileService fileService)
    => this.fileService = fileService;

  public IEnumerable<DiskData> GetDisks()
  {
    ICollection<DiskData> disks = new List<DiskData>();
    DriveInfo[] drives = DriveInfo.GetDrives();
    for (int i = 0; i < drives.Length; i++)
    {
      DriveInfo drive = drives[i];

      if (drive.IsReady && !HideNoneExtDrives) // Windows Drive
        disks.Add(new DiskData(i, drive.Name, drive.DriveType, drive.DriveFormat, drive.VolumeLabel, Parse.ToNullableUInt64(drive.TotalSize), Parse.ToNullableUInt64(drive.TotalFreeSpace)));
      else
      {
        if (fileService.IsExtDisk(i)) // Linux (Ext2/3/4) Drive
          disks.Add(new DiskData(i, drive.Name, drive.DriveType, ExtDriveFormat));
        else if (!HideNoneExtDrives)
          disks.Add(new DiskData(i, drive.Name, drive.DriveType));
      }
    }
    return disks;
  }
}