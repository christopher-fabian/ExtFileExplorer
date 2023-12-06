using System.Collections.Generic;

namespace ExtFileExplorer.Files;

internal interface IExtFileService
{
  bool IsExtDisk(int diskIndex, int partitionIndex = 0);

  ExtFileSystemInfo? GetFileSystemInfo(int diskNumber);
  ExtFileSystemInfo? GetFileSystemInfo(string diskName);
  ExtFileSystemInfo OpenFileSystem(int diskNumber, string diskName);
  ExtFileSystemInfo CloseFileSystem(int diskNumber);
  ExtFileInfo? GetFileInfo(int diskNumber, string path);
  ExtFileInfo? GetFileInfo(string diskName, string path);
  bool FileExists(int diskNumber, string path);
  bool FileExists(string diskName, string path);
  void CopyFile(int diskNumber, string sourcePath, string destinationPath, FileSource fileSource);
  void CopyFile(string diskName, string sourcePath, string destinationPath, FileSource fileSource);
  void RenameFile(int diskNumber, string sourcePath, string destinationPath, FileSource fileSource);
  void RenameFile(string diskName, string sourcePath, string destinationPath, FileSource fileSource);
  void DeleteFile(int diskNumber, string path);
  void DeleteFile(string diskName, string path);
  IEnumerable<string> GetDirectories(int diskNumber, string path, string pattern = "*");
  IEnumerable<string> GetDirectories(string diskName, string path, string pattern = "*");
  void DeleteDirectory(int diskNumber, string path);
  void DeleteDirectory(string diskName, string path);
  IEnumerable<string> GetFiles(int diskNumber, string path, string pattern = "*");
  IEnumerable<string> GetFiles(string diskName, string path, string pattern = "*");
  ulong GetFileSize(int diskNumber, string path);
  ulong GetFileSize(string diskName, string path);
}