using System;
using System.Globalization;

namespace ExtFileExplorer;
public static class Parse
{
  public static string ToString(object? value, string defaultValue = "")
    => value switch
    {
      null => defaultValue,
      string parsedValue => parsedValue, //parsedValue.ToString(),
      _ => value.ToString() ?? defaultValue
    };
  public static string ToString(object? value, IFormatProvider? provider, string defaultValue = "")
    => value switch
    {
      null => defaultValue,
      string parsedValue => parsedValue, //parsedValue.ToString(provider),
      char parsedValue => parsedValue.ToString(provider),
      bool parsedValue => parsedValue.ToString(provider),
      sbyte parsedValue => parsedValue.ToString(provider),
      short parsedValue => parsedValue.ToString(provider),
      int parsedValue => parsedValue.ToString(provider),
      long parsedValue => parsedValue.ToString(provider),
      byte parsedValue => parsedValue.ToString(provider),
      ushort parsedValue => parsedValue.ToString(provider),
      uint parsedValue => parsedValue.ToString(provider),
      ulong parsedValue => parsedValue.ToString(provider),
      float parsedValue => parsedValue.ToString(provider),
      double parsedValue => parsedValue.ToString(provider),
      decimal parsedValue => parsedValue.ToString(provider),
      DateTime parsedValue => parsedValue.ToString(provider),
      TimeSpan parsedValue => parsedValue.ToString(null, provider),
      Enum parsedValue => parsedValue.ToString(), //parsedValue.ToString(provider), [deprecated]
      _ => value.ToString() ?? defaultValue
    };
  public static string? ToNullableString(object? value, string? defaultValue = default)
    => value switch
    {
      null => defaultValue,
      string parsedValue => parsedValue, //parsedValue.ToString(provider),
      _ => value.ToString() ?? defaultValue
    };
  public static string? ToNullableString(object? value, IFormatProvider? provider, string? defaultValue = default)
    => value switch
    {
      null => defaultValue,
      string parsedValue => parsedValue, //parsedValue.ToString(provider),
      char parsedValue => parsedValue.ToString(provider),
      bool parsedValue => parsedValue.ToString(provider),
      sbyte parsedValue => parsedValue.ToString(provider),
      short parsedValue => parsedValue.ToString(provider),
      int parsedValue => parsedValue.ToString(provider),
      long parsedValue => parsedValue.ToString(provider),
      byte parsedValue => parsedValue.ToString(provider),
      ushort parsedValue => parsedValue.ToString(provider),
      uint parsedValue => parsedValue.ToString(provider),
      ulong parsedValue => parsedValue.ToString(provider),
      float parsedValue => parsedValue.ToString(provider),
      double parsedValue => parsedValue.ToString(provider),
      decimal parsedValue => parsedValue.ToString(provider),
      DateTime parsedValue => parsedValue.ToString(provider),
      TimeSpan parsedValue => parsedValue.ToString(null, provider),
      Enum parsedValue => parsedValue.ToString(), //parsedValue.ToString(provider), [deprecated]
      _ => value.ToString() ?? defaultValue
    };

  public static string ToExactString(object? value, string? format, string defaultValue = "")
    => value switch
    {
      null => defaultValue,
      string parsedValue => parsedValue,
      char parsedValue => parsedValue.ToString(),
      bool parsedValue => parsedValue.ToString(),
      sbyte parsedValue => parsedValue.ToString(format),
      short parsedValue => parsedValue.ToString(format),
      int parsedValue => parsedValue.ToString(format),
      long parsedValue => parsedValue.ToString(format),
      byte parsedValue => parsedValue.ToString(format),
      ushort parsedValue => parsedValue.ToString(format),
      uint parsedValue => parsedValue.ToString(format),
      ulong parsedValue => parsedValue.ToString(format),
      float parsedValue => parsedValue.ToString(format),
      double parsedValue => parsedValue.ToString(format),
      decimal parsedValue => parsedValue.ToString(format),
      DateTime parsedValue => parsedValue.ToString(format),
      TimeSpan parsedValue => parsedValue.ToString(format),
      Enum parsedValue => parsedValue.ToString(format),
      _ => value.ToString() ?? defaultValue
    };
  public static string ToExactString(object? value, string? format, IFormatProvider? provider, string defaultValue = "")
    => value switch
    {
      null => defaultValue,
      string parsedValue => parsedValue, //parsedValue.ToString(provider),
      char parsedValue => parsedValue.ToString(provider),
      bool parsedValue => parsedValue.ToString(provider),
      sbyte parsedValue => parsedValue.ToString(format, provider),
      short parsedValue => parsedValue.ToString(format, provider),
      int parsedValue => parsedValue.ToString(format, provider),
      long parsedValue => parsedValue.ToString(format, provider),
      byte parsedValue => parsedValue.ToString(format, provider),
      ushort parsedValue => parsedValue.ToString(format, provider),
      uint parsedValue => parsedValue.ToString(format, provider),
      ulong parsedValue => parsedValue.ToString(format, provider),
      float parsedValue => parsedValue.ToString(format, provider),
      double parsedValue => parsedValue.ToString(format, provider),
      decimal parsedValue => parsedValue.ToString(format, provider),
      DateTime parsedValue => parsedValue.ToString(format, provider),
      TimeSpan parsedValue => parsedValue.ToString(format, provider),
      Enum parsedValue => parsedValue.ToString(format), //parsedValue.ToString(format, provider), [deprecated]
      _ => value.ToString() ?? defaultValue
    };
  public static string? ToNullableExactString(object? value, string? format, string? defaultValue = default)
    => value switch
    {
      null => defaultValue,
      string parsedValue => parsedValue,
      char parsedValue => parsedValue.ToString(),
      bool parsedValue => parsedValue.ToString(),
      sbyte parsedValue => parsedValue.ToString(format),
      short parsedValue => parsedValue.ToString(format),
      int parsedValue => parsedValue.ToString(format),
      long parsedValue => parsedValue.ToString(format),
      byte parsedValue => parsedValue.ToString(format),
      ushort parsedValue => parsedValue.ToString(format),
      uint parsedValue => parsedValue.ToString(format),
      ulong parsedValue => parsedValue.ToString(format),
      float parsedValue => parsedValue.ToString(format),
      double parsedValue => parsedValue.ToString(format),
      decimal parsedValue => parsedValue.ToString(format),
      DateTime parsedValue => parsedValue.ToString(format),
      TimeSpan parsedValue => parsedValue.ToString(format),
      Enum parsedValue => parsedValue.ToString(format),
      _ => value.ToString() ?? defaultValue
    };
  public static string? ToNullableExactString(object? value, string? format, IFormatProvider? provider, string? defaultValue = default)
    => value switch
    {
      null => defaultValue,
      string parsedValue => parsedValue, //parsedValue.ToString(provider),
      char parsedValue => parsedValue.ToString(provider),
      bool parsedValue => parsedValue.ToString(provider),
      sbyte parsedValue => parsedValue.ToString(format, provider),
      short parsedValue => parsedValue.ToString(format, provider),
      int parsedValue => parsedValue.ToString(format, provider),
      long parsedValue => parsedValue.ToString(format, provider),
      byte parsedValue => parsedValue.ToString(format, provider),
      ushort parsedValue => parsedValue.ToString(format, provider),
      uint parsedValue => parsedValue.ToString(format, provider),
      ulong parsedValue => parsedValue.ToString(format, provider),
      float parsedValue => parsedValue.ToString(format, provider),
      double parsedValue => parsedValue.ToString(format, provider),
      decimal parsedValue => parsedValue.ToString(format, provider),
      DateTime parsedValue => parsedValue.ToString(format, provider),
      TimeSpan parsedValue => parsedValue.ToString(format, provider),
      Enum parsedValue => parsedValue.ToString(format), //parsedValue.ToString(format, provider), [deprecated]
      _ => value.ToString() ?? defaultValue
    };

  public static char ToChar(object? value, char defaultValue = default)
    => value switch
    {
      null => defaultValue,
      char parsedValue => parsedValue,
      _ => char.TryParse(value.ToString(), out char parsedValue) ? parsedValue : defaultValue
    };
  public static char? ToNullableChar(object? value, char? defaultValue = default)
    => value switch
    {
      null => defaultValue,
      char parsedValue => parsedValue,
      _ => char.TryParse(value.ToString(), out char parsedValue) ? parsedValue : defaultValue
    };

  public static bool ToBoolean(object? value, bool defaultValue = default)
    => value switch
    {
      null => defaultValue,
      bool parsedValue => parsedValue,
      _ => bool.TryParse(value.ToString(), out bool parsedValue) ? parsedValue : defaultValue
    };
  public static bool? ToNullableBoolean(object? value, bool? defaultValue = default)
    => value switch
    {
      null => defaultValue,
      bool parsedValue => parsedValue,
      _ => bool.TryParse(value.ToString(), out bool parsedValue) ? parsedValue : defaultValue
    };

  public static sbyte ToSByte(object? value, sbyte defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToSByte(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static sbyte ToSByte(object? value, IFormatProvider? provider, sbyte defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      sbyte parsedValue => parsedValue,
      _ => sbyte.TryParse(value.ToString(), styles, provider, out sbyte parsedValue) ? parsedValue : defaultValue
    };
  public static sbyte? ToNullableSByte(object? value, sbyte? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToNullableSByte(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static sbyte? ToNullableSByte(object? value, IFormatProvider? provider, sbyte? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      sbyte parsedValue => parsedValue,
      _ => sbyte.TryParse(value.ToString(), styles, provider, out sbyte parsedValue) ? parsedValue : defaultValue
    };

  public static short ToInt16(object? value, short defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToInt16(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static short ToInt16(object? value, IFormatProvider? provider, short defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      short parsedValue => parsedValue,
      _ => short.TryParse(value.ToString(), styles, provider, out short parsedValue) ? parsedValue : defaultValue
    };
  public static short? ToNullableInt16(object? value, sbyte? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToNullableInt16(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static short? ToNullableInt16(object? value, IFormatProvider? provider, sbyte? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      short parsedValue => parsedValue,
      _ => short.TryParse(value.ToString(), styles, provider, out short parsedValue) ? parsedValue : defaultValue
    };

  public static int ToInt32(object? value, int defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToInt32(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static int ToInt32(object? value, IFormatProvider? provider, int defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      int parsedValue => parsedValue,
      _ => int.TryParse(value.ToString(), styles, provider, out int parsedValue) ? parsedValue : defaultValue
    };
  public static int? ToNullableInt32(object? value, int? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToNullableInt32(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static int? ToNullableInt32(object? value, IFormatProvider? provider, int? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      int parsedValue => parsedValue,
      _ => int.TryParse(value.ToString(), styles, provider, out int parsedValue) ? parsedValue : defaultValue
    };

  public static long ToInt64(object? value, long defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToInt64(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static long ToInt64(object? value, IFormatProvider? provider, long defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      long parsedValue => parsedValue,
      _ => long.TryParse(value.ToString(), styles, provider, out long parsedValue) ? parsedValue : defaultValue
    };
  public static long? ToNullableInt64(object? value, long? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToNullableInt64(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static long? ToNullableInt64(object? value, IFormatProvider? provider, long? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      long parsedValue => parsedValue,
      _ => long.TryParse(value.ToString(), styles, provider, out long parsedValue) ? parsedValue : defaultValue
    };

  public static byte ToByte(object? value, byte defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToByte(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static byte ToByte(object? value, IFormatProvider? provider, byte defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      byte parsedValue => parsedValue,
      _ => byte.TryParse(value.ToString(), styles, provider, out byte parsedValue) ? parsedValue : defaultValue
    };
  public static byte? ToNullableByte(object? value, byte? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToNullableByte(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static byte? ToNullableByte(object? value, IFormatProvider? provider, byte? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      byte parsedValue => parsedValue,
      _ => byte.TryParse(value.ToString(), styles, provider, out byte parsedValue) ? parsedValue : defaultValue
    };

  public static ushort ToUInt16(object? value, ushort defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToUInt16(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static ushort ToUInt16(object? value, IFormatProvider? provider, ushort defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      ushort parsedValue => parsedValue,
      _ => ushort.TryParse(value.ToString(), styles, provider, out ushort parsedValue) ? parsedValue : defaultValue
    };
  public static ushort? ToNullableUInt16(object? value, ushort? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToNullableUInt16(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static ushort? ToNullableUInt16(object? value, IFormatProvider? provider, ushort? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      ushort parsedValue => parsedValue,
      _ => ushort.TryParse(value.ToString(), styles, provider, out ushort parsedValue) ? parsedValue : defaultValue
    };

  public static uint ToUInt32(object? value, uint defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToUInt32(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static uint ToUInt32(object? value, IFormatProvider? provider, uint defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      uint parsedValue => parsedValue,
      _ => uint.TryParse(value.ToString(), styles, provider, out uint parsedValue) ? parsedValue : defaultValue
    };
  public static uint? ToNullableUInt32(object? value, uint? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToNullableUInt32(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static uint? ToNullableUInt32(object? value, IFormatProvider? provider, uint? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      uint parsedValue => parsedValue,
      _ => uint.TryParse(value.ToString(), styles, provider, out uint parsedValue) ? parsedValue : defaultValue
    };

  public static ulong ToUInt64(object? value, ulong defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToUInt64(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static ulong ToUInt64(object? value, IFormatProvider? provider, ulong defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      ulong parsedValue => parsedValue,
      _ => ulong.TryParse(value.ToString(), styles, provider, out ulong parsedValue) ? parsedValue : defaultValue
    };
  public static ulong? ToNullableUInt64(object? value, ulong? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => ToNullableUInt64(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static ulong? ToNullableUInt64(object? value, IFormatProvider? provider, ulong? defaultValue = default, NumberStyles styles = NumberStyles.Integer)
    => value switch
    {
      null => defaultValue,
      ulong parsedValue => parsedValue,
      _ => ulong.TryParse(value.ToString(), styles, provider, out ulong parsedValue) ? parsedValue : defaultValue
    };

  public static float ToSingle(object? value, float defaultValue = default, NumberStyles styles = NumberStyles.AllowThousands | NumberStyles.Float)
    => ToSingle(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static float ToSingle(object? value, IFormatProvider? provider, float defaultValue = default, NumberStyles styles = NumberStyles.AllowThousands | NumberStyles.Float)
    => value switch
    {
      null => defaultValue,
      float parsedValue => parsedValue,
      _ => float.TryParse(value.ToString(), styles, provider, out float parsedValue) ? parsedValue : defaultValue
    };
  public static float? ToNullableSingle(object? value, float? defaultValue = default, NumberStyles styles = NumberStyles.AllowThousands | NumberStyles.Float)
    => ToNullableSingle(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static float? ToNullableSingle(object? value, IFormatProvider? provider, float? defaultValue = default, NumberStyles styles = NumberStyles.AllowThousands | NumberStyles.Float)
    => value switch
    {
      null => defaultValue,
      float parsedValue => parsedValue,
      _ => float.TryParse(value.ToString(), styles, provider, out float parsedValue) ? parsedValue : defaultValue
    };

  public static double ToDouble(object? value, double defaultValue = default, NumberStyles styles = NumberStyles.AllowThousands | NumberStyles.Float)
    => ToDouble(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static double ToDouble(object? value, IFormatProvider? provider, double defaultValue = default, NumberStyles styles = NumberStyles.AllowThousands | NumberStyles.Float)
    => value switch
    {
      null => defaultValue,
      double parsedValue => parsedValue,
      _ => double.TryParse(value.ToString(), styles, provider, out double parsedValue) ? parsedValue : defaultValue
    };
  public static double? ToNullableDouble(object? value, double? defaultValue = default, NumberStyles styles = NumberStyles.AllowThousands | NumberStyles.Float)
    => ToNullableDouble(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static double? ToNullableDouble(object? value, IFormatProvider? provider, double? defaultValue = default, NumberStyles styles = NumberStyles.AllowThousands | NumberStyles.Float)
    => value switch
    {
      null => defaultValue,
      double parsedValue => parsedValue,
      _ => double.TryParse(value.ToString(), styles, provider, out double parsedValue) ? parsedValue : defaultValue
    };

  public static decimal ToDecimal(object? value, decimal defaultValue = default, NumberStyles styles = NumberStyles.Number)
    => ToDecimal(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static decimal ToDecimal(object? value, IFormatProvider? provider, decimal defaultValue = default, NumberStyles styles = NumberStyles.Number)
    => value switch
    {
      null => defaultValue,
      decimal parsedValue => parsedValue,
      _ => decimal.TryParse(value.ToString(), styles, provider, out decimal parsedValue) ? parsedValue : defaultValue
    };
  public static decimal? ToNullableDecimal(object? value, decimal? defaultValue = default, NumberStyles styles = NumberStyles.Number)
    => ToNullableDecimal(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static decimal? ToNullableDecimal(object? value, IFormatProvider? provider, decimal? defaultValue = default, NumberStyles styles = NumberStyles.Number)
    => value switch
    {
      null => defaultValue,
      decimal parsedValue => parsedValue,
      _ => decimal.TryParse(value.ToString(), styles, provider, out decimal parsedValue) ? parsedValue : defaultValue
    };

  public static DateTime ToDateTime(object? value, DateTime defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => ToDateTime(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static DateTime ToDateTime(object? value, IFormatProvider? provider, DateTime defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => value switch
    {
      null => defaultValue,
      DateTime parsedValue => parsedValue,
      _ => DateTime.TryParse(value.ToString(), provider, styles, out DateTime parsedValue) ? parsedValue : defaultValue
    };
  public static DateTime? ToNullableDateTime(object? value, DateTime? defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => ToNullableDateTime(value, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static DateTime? ToNullableDateTime(object? value, IFormatProvider? provider, DateTime? defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => value switch
    {
      null => defaultValue,
      DateTime parsedValue => parsedValue,
      _ => DateTime.TryParse(value.ToString(), provider, styles, out DateTime parsedValue) ? parsedValue : defaultValue
    };

  public static DateTime ToExactDateTime(object? value, string? format, DateTime defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => ToExactDateTime(value, format, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static DateTime ToExactDateTime(object? value, string? format, IFormatProvider? provider, DateTime defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => value switch
    {
      null => defaultValue,
      DateTime parsedValue => parsedValue,
      _ => DateTime.TryParseExact(value.ToString(), format, provider, styles, out DateTime parsedValue) ? parsedValue : defaultValue
    };
  public static DateTime? ToNullableExactDateTime(object? value, string? format, DateTime? defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => ToNullableExactDateTime(value, format, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static DateTime? ToNullableExactDateTime(object? value, string? format, IFormatProvider? provider, DateTime? defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => value switch
    {
      null => defaultValue,
      DateTime parsedValue => parsedValue,
      _ => DateTime.TryParseExact(value.ToString(), format, provider, styles, out DateTime parsedValue) ? parsedValue : defaultValue
    };

  public static DateTime ToExactDateTime(object? value, string?[]? formats, DateTime defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => ToExactDateTime(value, formats, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static DateTime ToExactDateTime(object? value, string?[]? formats, IFormatProvider? provider, DateTime defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => value switch
    {
      null => defaultValue,
      DateTime parsedValue => parsedValue,
      _ => DateTime.TryParseExact(value.ToString(), formats, provider, styles, out DateTime parsedValue) ? parsedValue : defaultValue
    };
  public static DateTime? ToNullableExactDateTime(object? value, string?[]? formats, DateTime? defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => ToNullableExactDateTime(value, formats, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static DateTime? ToNullableExactDateTime(object? value, string?[]? formats, IFormatProvider? provider, DateTime? defaultValue = default, DateTimeStyles styles = DateTimeStyles.None)
    => value switch
    {
      null => defaultValue,
      DateTime parsedValue => parsedValue,
      _ => DateTime.TryParseExact(value.ToString(), formats, provider, styles, out DateTime parsedValue) ? parsedValue : defaultValue
    };

  public static TimeSpan ToTimeSpan(object? value, TimeSpan defaultValue = default)
    => ToTimeSpan(value, NumberFormatInfo.CurrentInfo, defaultValue);
  public static TimeSpan ToTimeSpan(object? value, IFormatProvider? provider, TimeSpan defaultValue = default)
    => value switch
    {
      null => defaultValue,
      TimeSpan parsedValue => parsedValue,
      _ => TimeSpan.TryParse(value.ToString(), provider, out TimeSpan parsedValue) ? parsedValue : defaultValue
    };
  public static TimeSpan? ToNullableTimeSpan(object? value, TimeSpan? defaultValue = default)
    => ToNullableTimeSpan(value, NumberFormatInfo.CurrentInfo, defaultValue);
  public static TimeSpan? ToNullableTimeSpan(object? value, IFormatProvider? provider, TimeSpan? defaultValue = default)
    => value switch
    {
      null => defaultValue,
      TimeSpan parsedValue => parsedValue,
      _ => TimeSpan.TryParse(value.ToString(), provider, out TimeSpan parsedValue) ? parsedValue : defaultValue
    };

  public static TimeSpan ToExactTimeSpan(object? value, string? format, TimeSpan defaultValue = default, TimeSpanStyles styles = TimeSpanStyles.None)
    => ToExactTimeSpan(value, format, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static TimeSpan ToExactTimeSpan(object? value, string? format, IFormatProvider? provider, TimeSpan defaultValue = default, TimeSpanStyles styles = TimeSpanStyles.None)
    => value switch
    {
      null => defaultValue,
      TimeSpan parsedValue => parsedValue,
      _ => TimeSpan.TryParseExact(value.ToString(), format, provider, styles, out TimeSpan parsedValue) ? parsedValue : defaultValue
    };
  public static TimeSpan? ToNullableExactTimeSpan(object? value, string? format, TimeSpan? defaultValue = default, TimeSpanStyles styles = TimeSpanStyles.None)
    => ToNullableExactTimeSpan(value, format, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static TimeSpan? ToNullableExactTimeSpan(object? value, string? format, IFormatProvider? provider, TimeSpan? defaultValue = default, TimeSpanStyles styles = TimeSpanStyles.None)
    => value switch
    {
      null => defaultValue,
      TimeSpan parsedValue => parsedValue,
      _ => TimeSpan.TryParseExact(value.ToString(), format, provider, styles, out TimeSpan parsedValue) ? parsedValue : defaultValue
    };

  public static TimeSpan ToExactTimeSpan(object? value, string?[]? formats, TimeSpan defaultValue = default, TimeSpanStyles styles = TimeSpanStyles.None)
    => ToExactTimeSpan(value, formats, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static TimeSpan ToExactTimeSpan(object? value, string?[]? formats, IFormatProvider? provider, TimeSpan defaultValue = default, TimeSpanStyles styles = TimeSpanStyles.None)
    => value switch
    {
      null => defaultValue,
      TimeSpan parsedValue => parsedValue,
      _ => TimeSpan.TryParseExact(value.ToString(), formats, provider, styles, out TimeSpan parsedValue) ? parsedValue : defaultValue
    };
  public static TimeSpan? ToNullableExactTimeSpan(object? value, string?[]? formats, TimeSpan? defaultValue = default, TimeSpanStyles styles = TimeSpanStyles.None)
    => ToNullableExactTimeSpan(value, formats, NumberFormatInfo.CurrentInfo, defaultValue, styles);
  public static TimeSpan? ToNullableExactTimeSpan(object? value, string?[]? formats, IFormatProvider? provider, TimeSpan? defaultValue = default, TimeSpanStyles styles = TimeSpanStyles.None)
    => value switch
    {
      null => defaultValue,
      TimeSpan parsedValue => parsedValue,
      _ => TimeSpan.TryParseExact(value.ToString(), formats, provider, styles, out TimeSpan parsedValue) ? parsedValue : defaultValue
    };

  public static TEnum ToEnum<TEnum>(object? value, TEnum defaultValue = default, bool ignoreCase = false) where TEnum : struct
    => value switch
    {
      null => defaultValue,
      TEnum parsedValue => parsedValue,
      _ => Enum.TryParse(value.ToString(), ignoreCase, out TEnum parsedValue) ? parsedValue : defaultValue
    };
  public static TEnum? ToNullableEnum<TEnum>(object? value, TEnum? defaultValue = default, bool ignoreCase = false) where TEnum : struct
    => value switch
    {
      null => defaultValue,
      TEnum parsedValue => parsedValue,
      _ => Enum.TryParse(value.ToString(), ignoreCase, out TEnum parsedValue) ? parsedValue : defaultValue
    };
}