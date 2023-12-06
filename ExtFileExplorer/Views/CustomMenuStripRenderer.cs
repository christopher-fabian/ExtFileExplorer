using System.Drawing;
using System.Windows.Forms;

namespace ExtFileExplorer.Views;

internal sealed class CustomMenuStripRenderer : ToolStripProfessionalRenderer
{
  private readonly Color color;
  private readonly SolidBrush brush;
  private readonly Pen pen;

  public CustomMenuStripRenderer() : base(new CustomMenuStripColors())
  {
    color = Color.FromArgb(25, 25, 25);
    brush = new SolidBrush(color);
    pen = new Pen(color);

    RoundedEdges = false;
  }

  protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
  {
    if (e.Item.Selected)
    {
      Rectangle rectangle = new(Point.Empty, e.Item.Size);
      e.Graphics.FillRectangle(brush, rectangle);
      e.Graphics.DrawRectangle(pen, 1, 0, rectangle.Width - 2, rectangle.Height - 1);
    }
    else
    {
      base.OnRenderMenuItemBackground(e);
    }
  }
}

internal sealed class CustomMenuStripColors : ProfessionalColorTable
{
  public override Color MenuItemPressedGradientBegin => color;
  public override Color MenuItemPressedGradientMiddle => color;
  public override Color MenuItemPressedGradientEnd => color;
  public override Color MenuBorder => color;
  public override Color MenuItemBorder => color;
  public override Color ImageMarginGradientBegin => color;
  public override Color ImageMarginGradientMiddle => color;
  public override Color ImageMarginGradientEnd => color;
  public override Color ToolStripDropDownBackground => color;
  public override Color SeparatorLight => separatorLight;

  private readonly Color separatorLight = Color.FromArgb(5, 5, 5);
  private readonly Color color = Color.FromArgb(25, 25, 25);

  public CustomMenuStripColors()
  {
    UseSystemColors = false;
  }
}
