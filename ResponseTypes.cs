// Decompiled with JetBrains decompiler
// Type: DeviceManagement.ResponseTypes
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

namespace DeviceManagement
{
  public enum ResponseTypes
  {
    OK = 0,
    NoPermission = 1,
    NoSupport = 2,
    ValueInvalid = 3,
    AuthFail = 4,
    NoData = 5,
    UserFull = 6,
    NoResponse = 120,
    ForbidConnect = 127,
    SystemError = 128,
  }
}
