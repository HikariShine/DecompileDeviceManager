// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Host
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System.Net;
using System.Text;

namespace DeviceManagement
{
  public class Host
  {
    private string ip;
    private ushort port;
    internal bool canDNS;
    internal Device dev;

    public string IpAddress
    {
      get
      {
        return this.ip;
      }
      set
      {
        if (this.canDNS)
        {
          if (value.Length > 30)
            this.dev.AddMessage(Message.TooLong);
          else
            this.ip = value;
        }
        else if (value.Trim().Length == 0)
          this.ip = "0.0.0.0";
        else if (Program.CheckIpStr(value))
          this.ip = value;
        else
          this.dev.AddMessage(Message.InvalidIP);
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

    public void SetIP(byte[] data)
    {
      if (this.canDNS || !this.dev.IsNewVersion)
        this.ip = Encoding.ASCII.GetString(data).Replace("\0", "");
      else
        this.ip = new IPAddress(data).ToString();
    }

    public byte[] GetIPData()
    {
      if (this.canDNS || !this.dev.IsNewVersion)
        return Encoding.ASCII.GetBytes(this.ip);
      int interIp = FrameClass.getInterIP(IPAddress.Parse(this.ip));
      return new byte[4]
      {
        (byte) (interIp >> 24),
        (byte) (interIp >> 16),
        (byte) (interIp >> 8),
        (byte) interIp
      };
    }
  }
}
