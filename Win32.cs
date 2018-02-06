// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Win32
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System.Runtime.InteropServices;
using System.Text;

namespace DeviceManagement
{
  internal class Win32
  {
    [DllImport("kernel32")]
    internal static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

    [DllImport("kernel32")]
    internal static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
  }
}
