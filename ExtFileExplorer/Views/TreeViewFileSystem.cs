using ExtFileExplorer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExtFileExplorer.Views;

internal sealed class TreeViewFileSystem : TreeView
{
  public Color DirectoryNodeColor => Themes.Current.ForeColor;

  [Category("Appearance"), Description("The text color of file nodes.")]
  public Color FileNodeColor { get; set; } = SystemColors.Highlight;

  [Category("Appearance"), Description("The text color of selected nodes.")]
  private Color SelectedNodeColor { get; set; } = Color.Yellow;

  [Category("Appearance"), Description("The Image of the opened directory.")]
  public Bitmap DirectoryOpenedImage { get; set; } = Resources.FolderOpened_16x;

  [Category("Appearance"), Description("The Image of the opened directory.")]
  public Bitmap DirectoryClosedImage { get; set; } = Resources.FolderClosed_16x;

  [Category("Appearance"), Description("The Image of a file.")]
  public Bitmap FileImage { get; set; } = Resources.Document_noHalo_16x;

  private readonly Brush selectedNodeBrush;
  private readonly Brush fileNodeBrush;
  private readonly Brush directoryNodeBrush;

  public string? SelectedPath => SelectedNode?.Name;
  public string? SelectedText => SelectedNode?.Text;

  public bool PathSelected => SelectedNode is not null;

  public TreeViewFileSystem()
  {
    this.EnableDoubleBuffering();

    directoryNodeBrush = new SolidBrush(DirectoryNodeColor);
    fileNodeBrush = new SolidBrush(FileNodeColor);
    selectedNodeBrush = new SolidBrush(SelectedNodeColor);

    BorderStyle = BorderStyle.None;
    SetStyle(ControlStyles.UserPaint, true);
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    base.OnPaint(e);

    this.DrawBorder(e.Graphics, Themes.Current.BorderColor);
  }

  protected override void OnDrawNode(DrawTreeNodeEventArgs e)
  {
    DrawCustomNode(e);
    base.OnDrawNode(e);
  }

  private void DrawCustomNode(DrawTreeNodeEventArgs e)
  {
    TreeNode node = e.Node!;
    Rectangle nodeBounds = node.Bounds;

    bool isDirectory = node.ForeColor == DirectoryNodeColor;

    Image nodeIcon;
    Point nodeIconPoint = new(nodeBounds.Location.X - 20, nodeBounds.Location.Y + 2);
    Brush nodeTextBrush = (e.State & TreeNodeStates.Focused) is not 0 ? selectedNodeBrush : default!;
    Font nodeTextFont = node.NodeFont ?? Font;
    Rectangle nodeTextBounds = nodeBounds;
    nodeTextBounds.Width += 40;

    if (isDirectory)
    {
      nodeIcon = node.IsExpanded || node.Nodes.Count is 0
        ? DirectoryOpenedImage
        : DirectoryClosedImage;
      nodeTextBrush ??= directoryNodeBrush;
    }
    else
    {
      nodeIcon = FileImage;
      nodeTextBrush ??= fileNodeBrush;
    }

    // Draw icon
    e.Graphics.DrawImage(nodeIcon, nodeIconPoint);

    // Draw text
    e.Graphics.DrawString(node.Text, nodeTextFont, nodeTextBrush, nodeTextBounds);
  }

  public bool SelectedNodeIsDirectory()
    => SelectedNode.ForeColor == DirectoryNodeColor;

  public void LoadDirectories(IEnumerable<string> directories)
  {
    if (!directories.Any())
      return;

    foreach (string directory in directories)
    {
      TreeNode node = GetOrAddNode(directory);
      node.ForeColor = DirectoryNodeColor;
    }
  }

  public void LoadFiles(IEnumerable<string> files)
  {
    if (!files.Any())
      return;

    foreach (string file in files)
    {
      TreeNode node = GetOrAddNode(file);
      node.ForeColor = FileNodeColor;
    }
  }

  public void RemoveFiles(IEnumerable<string> files)
  {
    if (!files.Any())
      return;

    foreach (string file in files)
      RemoveNode(file);
  }

  public TreeNode GetOrAddNode(string path)
  {
    TreeNode? node = null;
    TreeNode? parentNode = null;
    TreeNodeCollection parentNodes = Nodes;

    // Example:
    // /Emulation
    // /Emulation/Storage
    // /Emulation/Storage/retroarch
    string[] subDirectories = path.Split("/", StringSplitOptions.RemoveEmptyEntries);
    string targetName = subDirectories[^1];

    string targetDirectory = string.Empty;

    foreach (string subDiretory in subDirectories)
    {
      targetDirectory += $"/{subDiretory}";

      //TreeNode[] nodes = parentNodes.Find(targetDirectory, false);
      //if (nodes.Length is 1)
      //{
      //  parentNode = nodes[0];
      //  parentNodes = parentNode.Nodes;
      //}
      node = parentNodes.Cast<TreeNode>().FirstOrDefault(node => node.Name == targetDirectory);
      if (node is not null)
      {
        parentNode = node;
        parentNodes = node.Nodes;
      }
    }

    node = parentNode?.Text == targetName ? parentNode : null;
    if (node is null)
    {
      if (parentNode is null)
        node = Nodes.Add(targetDirectory, targetName);
      else
        node = parentNode.Nodes.Add(targetDirectory, targetName);
    }
    return node;
  }

  public void RemoveNode(string path)
  {
    TreeNode? node = null;
    TreeNode? parentNode = null;
    TreeNodeCollection parentNodes = Nodes;

    // Example:
    // /Emulation
    // /Emulation/Storage
    // /Emulation/Storage/retroarch
    string[] subDirectories = path.Split("/", StringSplitOptions.RemoveEmptyEntries);
    string targetName = subDirectories[^1];

    string targetDirectory = "/";

    foreach (string subDiretory in subDirectories)
    {
      targetDirectory += $"{subDiretory}/";

      //TreeNode[] nodes = parentNodes.Find(targetDirectory, false);
      //if (nodes.Length is 1)
      //{
      //  parentNode = nodes[0];
      //  parentNodes = parentNode.Nodes;
      //}
      node = parentNodes.Cast<TreeNode>().FirstOrDefault(node => node.Name == targetDirectory);
      if (node is not null)
      {
        parentNode = node;
        parentNodes = node.Nodes;
      }
    }

    node = parentNode?.Text == targetName ? parentNode : null;
    node?.Remove();
  }
}
