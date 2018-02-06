// Decompiled with JetBrains decompiler
// Type: DeviceManagement.MyLable
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace DeviceManagement
{
  public class MyLable : Control
  {
    private static ResourceManager resources = new ResourceManager(typeof (MyLable));
    private IContainer components;
    private string propertyName;
    private Label propertyLabel;

    public string PropertyName
    {
      get
      {
        return this.propertyName;
      }
      set
      {
        this.propertyName = value;
      }
    }

    public Label PropertyLabel
    {
      get
      {
        return this.propertyLabel;
      }
      set
      {
        this.propertyLabel = value;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      string str;
      try
      {
        str = (string) MyLable.resources.GetObject(this.propertyName, Program.cultureInfo);
      }
      catch
      {
        str = this.Text;
      }
      SizeF sizeF = graphics.MeasureString(str, this.Font);
      int num1 = (int) sizeF.Width;
      if ((double) sizeF.Width > (double) num1)
        ++num1;
      int num2 = (int) sizeF.Height;
      if ((double) sizeF.Height > (double) num2)
        ++num2;
      this.Width = num1;
      this.Height = num2;
      graphics.DrawString(str, this.Font, Brushes.Black, 0.0f, 0.0f);
      base.OnPaint(e);
    }

    protected override void OnMouseHover(EventArgs e)
    {
      if (this.propertyLabel != null)
      {
        try
        {
          this.propertyLabel.Text = (string) MyLable.resources.GetObject(this.propertyName + "Description", Program.cultureInfo);
        }
        catch
        {
          this.propertyLabel.Text = this.Text;
        }
      }
      base.OnMouseHover(e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      if (this.propertyLabel != null)
        this.propertyLabel.Text = "";
      base.OnMouseLeave(e);
    }
  }
}
