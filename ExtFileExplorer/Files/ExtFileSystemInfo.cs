namespace ExtFileExplorer.Files;

internal sealed record ExtFileSystemInfo(int DiskNumber, string DiskName, ulong TotalSpace, ulong FreeSpace);
