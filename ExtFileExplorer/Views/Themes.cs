using System;
using System.Drawing;

namespace ExtFileExplorer.Views;

internal static class Themes
{
  public static event EventHandler? OnThemeChanged;

  public static Theme Current
  {
    get => current;
    set
    {
      if (current == value)
        return;

      current = value;
      OnThemeChanged?.Invoke(null, EventArgs.Empty);
    }
  }

  public static Theme DarkMode = new()
  {
    ForeColor = Color.White,
    BackColor = Color.FromArgb(40, 40, 40),
    ControlBackColor = Color.FromArgb(25, 25, 25),
    BorderColor = Color.FromArgb(90, 90, 90),
  };

  private static Theme current;

  static Themes()
  {
    current = DarkMode; // Default
  }
}

internal sealed class Theme
{
  public Color ForeColor { get; set; }
  public Color BackColor { get; set; }
  public Color ControlBackColor { get; set; }
  public Color BorderColor { get; set; }
}