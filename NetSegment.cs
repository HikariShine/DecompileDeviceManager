// Decompiled with JetBrains decompiler
// Type: DeviceManagement.NetSegment
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System.Net;

namespace DeviceManagement
{
  public class NetSegment
  {
    private IPAddress m_startip = IPAddress.Any;
    private IPAddress m_endip = IPAddress.Any;
    private ushort port;

    public IPAddress BeginIPAddress
    {
      get
      {
        return this.m_startip;
      }
      set
      {
        this.m_startip = value;
      }
    }

    public IPAddress EndIPAddress
    {
      get
      {
        return this.m_endip;
      }
      set
      {
        this.m_endip = value;
      }
    }

    public ushort Port
    {
      get
      {
        return this.port;
      }
      set
      {
        this.port = value;
      }
    }

    public override string ToString()
    {
      if (this.m_startip != null && (int) this.port > 0)
        return this.m_startip.ToString();
      return "NetSegment";
    }
  }
}
