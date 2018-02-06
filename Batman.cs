// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Batman
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System.Net.Sockets;

namespace DeviceManagement
{
  public class Batman
  {
    public static int BUFFERSIZE = 256;
    public byte[] RevBuffer = new byte[Batman.BUFFERSIZE];
    public byte[] SendBuffer = new byte[Batman.BUFFERSIZE];
    public Socket WorkSocket;
    public bool IsClosed;
  }
}
