// Decompiled with JetBrains decompiler
// Type: DeviceManagement.OptionListClass
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System.Collections.Generic;
using System.Net;

namespace DeviceManagement
{
  public class OptionListClass
  {
    private List<OptionClass> optionList;
    private IPAddress ipAddr;
    private byte controlType;

    public List<OptionClass> OptionList
    {
      get
      {
        return this.optionList;
      }
      set
      {
        this.optionList = value;
      }
    }

    public IPAddress IpAddr
    {
      get
      {
        return this.ipAddr;
      }
      set
      {
        this.ipAddr = value;
      }
    }

    public byte ControlType
    {
      get
      {
        return this.controlType;
      }
      set
      {
        this.controlType = value;
      }
    }

    public OptionListClass(IPAddress ipAddr, byte controlType)
    {
      this.optionList = new List<OptionClass>();
      this.ipAddr = ipAddr;
      this.controlType = controlType;
    }
  }
}
