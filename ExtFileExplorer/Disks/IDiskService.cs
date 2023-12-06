using System.Collections.Generic;

namespace ExtFileExplorer.Disks;

internal interface IDiskService
{
  IEnumerable<DiskData> GetDisks();
}