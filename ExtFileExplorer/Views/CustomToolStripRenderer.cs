using System.Drawing;
using System.Windows.Forms;

namespace ExtFileExplorer.Views;

internal sealed class CustomToolStripRenderer : ToolStripProfessionalRenderer
{
  private readonly Color color;
  private readonly SolidBrush brush;
  private readonly Pen pen;

  private readonly Color colorButtonBackground;
  private readonly SolidBrush brushButtonBackground;
  private readonly Pen penButtonBackground;

  public CustomToolStripRenderer() : base(new CustomToolStripColors())
  {
    RoundedEdges = false;

    color = Color.FromArgb(25, 25, 25);
    brush = new SolidBrush(color);
    pen = new Pen(color);

    colorButtonBackground = Color.FromArgb(35, 35, 35);
    brushButtonBackground = new SolidBrush(colorButtonBackground);
    penButtonBackground = new Pen(colorButtonBackground);
  }

  protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
  {
    //base.OnRenderToolStripBorder(e);
  }

  protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
  {
    if (e.Item.Selected)
    {
      Rectangle rectangle = new(Point.Empty, e.Item.Size);
      e.Graphics.FillRectangle(brushButtonBackground, rectangle);
      e.Graphics.DrawRectangle(penButtonBackground, 1, 0, rectangle.Width - 2, rectangle.Height - 1);
    }
    else
    {
      base.OnRenderButtonBackground(e);
    }
  }
}

internal sealed class CustomToolStripColors : ProfessionalColorTable
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

  public CustomToolStripColors()
  {
    UseSystemColors = false;
  }
}
