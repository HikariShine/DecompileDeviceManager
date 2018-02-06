// Decompiled with JetBrains decompiler
// Type: DeviceManagement.MyCheckBox
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.Resources;
using System.Windows.Forms;

namespace DeviceManagement
{
  public class MyCheckBox : CheckBox
  {
    private static ResourceManager resources = new ResourceManager(typeof (MyLable));
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

    public override string Text
    {
      get
      {
        try
        {
          return (string) MyCheckBox.resources.GetObject(this.propertyName, Program.cultureInfo);
        }
        catch
        {
          return base.Text;
        }
      }
    }

    protected override void OnMouseHover(EventArgs e)
    {
      if (this.propertyLabel != null)
      {
        try
        {
          this.propertyLabel.Text = (string) MyCheckBox.resources.GetObject(this.propertyName + "Description", Program.cultureInfo);
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
