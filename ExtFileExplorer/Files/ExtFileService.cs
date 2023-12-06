using SharpExt4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtFileExplorer.Files;

internal sealed class ExtFileService : IExtFileService, IDisposable
{
  private readonly IDictionary<ExtFileSystemInfo, ExtFileSystem> fileSystems = new Dictionary<ExtFileSystemInfo, ExtFileSystem>();

  public bool IsExtDisk(int diskIndex, int partitionIndex = 0)
  {
    try
    {
      ExtDisk disk = ExtDisk.Open(diskIndex);
      disk.Dispose();
    }
    catch
    {
      return false;
    }
    return true;
  }

  public ExtFileSystemInfo? GetFileSystemInfo(int diskNumber)
    => fileSystems.Keys.FirstOrDefault(fileSystem => fileSystem.DiskNumber == diskNumber);
  public ExtFileSystemInfo? GetFileSystemInfo(string diskName)
    => fileSystems.Keys.FirstOrDefault(fileSystem => fileSystem.DiskName == diskName);

  public ExtFileSystemInfo OpenFileSystem(int diskNumber, string diskName)
  {
    // Open a Linux ext4 disk image
    ExtDisk disk = ExtDisk.Open(diskNumber);
    // Get the partition
    Partition partition = disk.Partitions[0];
    // Get the file system
    ExtFileSystem fileSystem = ExtFileSystem.Open(disk, partition);

    ulong totalSpace = partition.Size - partition.Offset;
    ulong usedSpace = GetUsedSpace();

    ExtFileSystemInfo fileSystemInfo = new(diskNumber, diskName, totalSpace, totalSpace - usedSpace);
    fileSystems.Add(fileSystemInfo, fileSystem);
    return fileSystemInfo;

    // WARNING: Extremly slow if file system has a lot of files.
    ulong GetUsedSpace()
    {
      ulong result = 0L;

      //try
      //{
      //  IEnumerable<string> files = fileSystem.GetFiles("/", "*", SearchOption.AllDirectories);
      //  foreach (string file in files)
      //  {
      //    try
      //    {
      //      result += fileSystem.GetFileLength(file);
      //    }
      //    catch { }
      //  }
      //}
      //catch { }

      return result;
    }
  }
  public ExtFileSystemInfo CloseFileSystem(int diskNumber)
  {
    KeyValuePair<ExtFileSystemInfo, ExtFileSystem> filesystem = fileSystems.First(fileSystem => fileSystem.Key.DiskNumber == diskNumber);
    filesystem.Value.Dispose();
    fileSystems.Remove(filesystem);
    return filesystem.Key;
  }

  public void CopyFile(int diskNumber, string sourcePath, string destinationPath, FileSource fileSource)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskNumber == diskNumber).Value;
    CopyFile(fileSystem, sourcePath, destinationPath, fileSource);
  }
  public void CopyFile(string diskName, string sourcePath, string destinationPath, FileSource fileSource)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskName == diskName).Value;
    CopyFile(fileSystem, sourcePath, destinationPath, fileSource);
  }
  private static void CopyFile(ExtFileSystem fileSystem, string sourcePath, string destinationPath, FileSource fileSource)
  {
    if (fileSystem is null)
      throw new Exception("No disk/file system connected!");

    switch (fileSource)
    {
      case FileSource.Native:
        CopyFileFrom(fileSystem, sourcePath, destinationPath);
        break;
      case FileSource.External:
        CopyFileTo(fileSystem, sourcePath, destinationPath);
        break;
    }
  }
  private static void CopyFileFrom(ExtFileSystem fileSystem, string sourcePath, string destinationPath)
  {
    byte[] buffer = File.ReadAllBytes(sourcePath);

    using ExtFileStream stream = fileSystem.OpenFile(destinationPath, FileMode.Create, FileAccess.Write);
    stream.Write(buffer, 0, buffer.Length);
  }
  private static void CopyFileTo(ExtFileSystem fileSystem, string sourcePath, string destinationPath)
  {
    using ExtFileStream stream = fileSystem.OpenFile(sourcePath, FileMode.Open, FileAccess.Read);
    byte[] buffer = new byte[stream.Length];
    stream.Read(buffer, 0, (int)stream.Length);

    File.WriteAllBytes(destinationPath, buffer);
  }

  public void RenameFile(int diskNumber, string sourcePath, string destinationPath, FileSource fileSource)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskNumber == diskNumber).Value;
    RenameFile(fileSystem, sourcePath, destinationPath, fileSource);
  }
  public void RenameFile(string diskName, string sourcePath, string destinationPath, FileSource fileSource)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskName == diskName).Value;
    RenameFile(fileSystem, sourcePath, destinationPath, fileSource);
  }
  private static void RenameFile(ExtFileSystem fileSystem, string sourcePath, string destinationPath, FileSource fileSource)
  {
    if (fileSystem is null)
      throw new Exception("No disk/file system connected!");

    fileSystem.RenameFile(sourcePath, destinationPath);
  }

  public void DeleteFile(int diskNumber, string path)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskNumber == diskNumber).Value;
    DeleteFile(fileSystem, path);
  }
  public void DeleteFile(string diskName, string path)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskName == diskName).Value;
    DeleteFile(fileSystem, path);
  }
  private static void DeleteFile(ExtFileSystem fileSystem, string path)
  {
    if (fileSystem is null)
      throw new Exception("No disk/file system connected!");

    fileSystem.DeleteFile(path);
  }

  public IEnumerable<string> GetDirectories(int diskNumber, string path, string pattern = "*")
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskNumber == diskNumber).Value;
    return GetDirectories(fileSystem, path, pattern);
  }
  public IEnumerable<string> GetDirectories(string diskName, string path, string pattern = "*")
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskName == diskName).Value;
    return GetDirectories(fileSystem, path, pattern);
  }
  private static IEnumerable<string> GetDirectories(ExtFileSystem fileSystem, string path, string pattern = "*")
  {
    if (fileSystem is null)
      throw new Exception("No disk/file system connected!");

    return fileSystem.GetDirectories(path, pattern, SearchOption.AllDirectories).OrderBy(value => value);
  }

  public void DeleteDirectory(int diskNumber, string path)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskNumber == diskNumber).Value;
    DeleteDirectory(fileSystem, path);
  }
  public void DeleteDirectory(string diskName, string path)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskName == diskName).Value;
    DeleteDirectory(fileSystem, path);
  }
  private static void DeleteDirectory(ExtFileSystem fileSystem, string path)
  {
    if (fileSystem is null)
      throw new Exception("No disk/file system connected!");

    fileSystem.DeleteDirectory(path);
  }

  public IEnumerable<string> GetFiles(int diskNumber, string path, string pattern = "*")
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskNumber == diskNumber).Value;
    return GetFiles(fileSystem, path, pattern);
  }
  public IEnumerable<string> GetFiles(string diskName, string path, string pattern = "*")
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskName == diskName).Value;
    return GetFiles(fileSystem, path, pattern);
  }
  private static IEnumerable<string> GetFiles(ExtFileSystem fileSystem, string path, string pattern = "*")
  {
    if (fileSystem is null)
      throw new Exception("No disk/file system connected!");

    return fileSystem.GetFiles(path, pattern, SearchOption.AllDirectories).OrderBy(filePath => filePath);
  }

  public ulong GetFileSize(int diskNumber, string path)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskNumber == diskNumber).Value;
    return GetFileSize(fileSystem, path);
  }
  public ulong GetFileSize(string diskName, string path)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskName == diskName).Value;
    return GetFileSize(fileSystem, path);
  }
  public static ulong GetFileSize(ExtFileSystem fileSystem, string path)
  {
    if (fileSystem is null)
      throw new Exception("No disk/file system connected!");

    return fileSystem.GetFileLength(path);
  }

  public ExtFileInfo? GetFileInfo(int diskNumber, string path)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskNumber == diskNumber).Value;
    return GetFileInfo(fileSystem, path);
  }
  public ExtFileInfo? GetFileInfo(string diskName, string path)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskName == diskName).Value;
    return GetFileInfo(fileSystem, path);
  }
  private static ExtFileInfo? GetFileInfo(ExtFileSystem fileSystem, string path)
  {
    if (fileSystem is null)
      throw new Exception("No disk/file system connected!");

    if (!fileSystem.FileExists(path))
      return null;

    return new(Path.GetFileName(path), path, fileSystem.GetFileLength(path));
  }

  public bool FileExists(int diskNumber, string path)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskNumber == diskNumber).Value;
    return FileExists(fileSystem, path);
  }
  public bool FileExists(string diskName, string path)
  {
    ExtFileSystem? fileSystem = fileSystems.FirstOrDefault(fileSystem => fileSystem.Key.DiskName == diskName).Value;
    return FileExists(fileSystem, path);
  }
  private static bool FileExists(ExtFileSystem fileSystem, string path)
  {
    if (fileSystem is null)
      throw new Exception("No disk/file system connected!");

    return fileSystem.FileExists(path);
  }

  public void Dispose()
  {
    foreach (ExtFileSystem fileSystem in fileSystems.Values)
      fileSystem.Dispose();
  }


}