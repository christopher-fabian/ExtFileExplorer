using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtFileExplorer.Files;

internal static class ExtPath
{
  public static string Combine(params string[] paths)
  {
    ArgumentNullException.ThrowIfNull(paths);

    StringBuilder builder = new();

    foreach (string path in paths)
    {
      builder.Append(path);
    }

    return builder.ToString();
  }
}