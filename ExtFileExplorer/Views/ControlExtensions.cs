using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExtFileExplorer.Views;

internal static class ControlExtensions
{
  private const int TVM_SETEXTENDEDSTYLE = 0x1100 + 44;
  private const int TVM_GETEXTENDEDSTYLE = 0x1100 + 45;
  private const int TVS_EX_DOUBLEBUFFER = 0x0004;

  [DllImport("user32")]
  private static extern IntPtr SendMessage(nint hWnd, uint Msg, nuint wParam, nint lParam);

  public static void EnableDoubleBuffering(this Control control)
    => SendMessage(control.Handle, TVM_SETEXTENDEDSTYLE, TVS_EX_DOUBLEBUFFER, TVS_EX_DOUBLEBUFFER);

  public static void DrawBorder(this Control control, Graphics graphics, Color color, ButtonBorderStyle style = ButtonBorderStyle.Solid)
    => DrawBorder(control.Width, control.Height, graphics, color, style);
  public static void DrawBorder(this ToolStripItem toolStripItem, Graphics graphics, Color color, ButtonBorderStyle style = ButtonBorderStyle.Solid)
    => DrawBorder(toolStripItem.Width, toolStripItem.Height, graphics, color, style);
  private static void DrawBorder(int width, int height, Graphics graphics, Color color, ButtonBorderStyle style = ButtonBorderStyle.Solid)
  {
    ControlPaint.DrawBorder(graphics,
      new Rectangle(0, 0, width, height),
      color,
      style);
  }
}

