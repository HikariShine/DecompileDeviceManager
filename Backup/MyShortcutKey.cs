// Decompiled with JetBrains decompiler
// Type: DeviceManagement.MyShortcutKey
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.Windows.Forms;

namespace DeviceManagement
{
  public class MyShortcutKey
  {
    private bool isCtrl;
    private bool isAlt;
    private bool isShift;
    private Keys keyCode;

    public bool IsCtrl
    {
      get
      {
        return this.isCtrl;
      }
    }

    public bool IsAlt
    {
      get
      {
        return this.isAlt;
      }
    }

    public bool IsShift
    {
      get
      {
        return this.isShift;
      }
    }

    public Keys KeyCode
    {
      get
      {
        return this.keyCode;
      }
    }

    public MyShortcutKey(string keyString)
    {
      string[] strArray = keyString.Replace(" ", "").Split("+".ToCharArray());
      int num = 1;
      for (int index = 0; index < strArray.Length; ++index)
      {
        switch (strArray[index])
        {
          case "CTRL":
            this.isCtrl = true;
            ++num;
            break;
          case "ALT":
            this.isAlt = true;
            ++num;
            break;
          case "SHIFT":
            this.isShift = true;
            ++num;
            break;
          default:
            if (this.keyCode == Keys.ControlKey || this.keyCode == Keys.Menu || this.keyCode == Keys.ShiftKey)
              throw new Exception("Create Error!");
            this.keyCode = (Keys) Enum.Parse(typeof (Keys), strArray[index]);
            break;
        }
      }
      if (strArray.Length < num)
        throw new Exception("Create Error!");
    }

    public override string ToString()
    {
      string str = "";
      if (this.isCtrl)
        str += "CTRL + ";
      if (this.isAlt)
        str += "ALT + ";
      if (this.isShift)
        str += "SHIFT + ";
      return str + this.keyCode.ToString();
    }

    public override bool Equals(object obj)
    {
      if (!(obj is MyShortcutKey))
        return false;
      MyShortcutKey myShortcutKey = (MyShortcutKey) obj;
      return myShortcutKey.isAlt == this.isAlt && myShortcutKey.isCtrl == this.isCtrl && (myShortcutKey.isShift == this.isShift && myShortcutKey.keyCode == this.keyCode);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
