using System;

namespace ExtFileExplorer;

public static class StringFormatter
{
  public enum SizeUnit
  {
    Bytes,
    KB,
    MB,
    GB,
    TB,
    PB,
    EB,
    ZB,
    YB
  }

  public static string ToSizeUnit(ulong bytes, SizeUnit size, int decimalPoints = 0)
    => $"{(bytes / (double)Math.Pow(1024, (long)size)).ToString($"N{decimalPoints}")} {size}";
}
