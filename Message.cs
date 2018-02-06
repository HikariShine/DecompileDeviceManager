// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Message
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System.Resources;

namespace DeviceManagement
{
  public class Message
  {
    private static ResourceManager resources = new ResourceManager(typeof (Message));

    public static string Communicating
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("Communicating", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Communicating apparatus...Please wait!";
        }
      }
    }

    public static string GetOK
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("GetOK", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Get Properties Successfully!";
        }
      }
    }

    public static string GetError
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("GetError", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Get Properties Error!";
        }
      }
    }

    public static string SetError
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("SetError", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Set Properties Error!";
        }
      }
    }

    public static string EmailAddrError
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("EmailAddrError", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Email Address Error!";
        }
      }
    }

    public static string SetOK
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("SetOK", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Upload Properties Successfully!";
        }
      }
    }

    public static string CommunicateFormText
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("CommunicateFormText", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Communicating!";
        }
      }
    }

    public static string TooLong
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("TooLong", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Too long,please retype!";
        }
      }
    }

    public static string TooShort
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("TooShort", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Too Short,please retype!";
        }
      }
    }

    public static string InvalidIP
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("InvalidIP", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Invalid ip address,please retype!";
        }
      }
    }

    public static string InvalidPort
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("InvalidPort", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Invalid port,please retype!";
        }
      }
    }

    public static string LogOut
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("LogOut", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Are you sure to login out?";
        }
      }
    }

    public static string InvalidMAC
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("InvalidMAC", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Invalid ip address,please retype!";
        }
      }
    }

    public static string RangeError
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("RangeError", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Please check the number between {0} and {1}!";
        }
      }
    }

    public static string MustHex
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("MustHex", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Please input hex number!";
        }
      }
    }

    public static string InvalidTime
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("InvalidTime", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Invalid time,please retype like \"Minute:Second\"!";
        }
      }
    }

    public static string PasswordError
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("PasswordError", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Password is wrong,please retype!";
        }
      }
    }

    public static string NotContain
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("NotContain", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Please check not contain \"{0}\"!";
        }
      }
    }

    public static string UpdateBPWD
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("UpdateBPWD", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Password is OK,please update to device!";
        }
      }
    }

    public static string PasswordIdentical
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("PasswordIdentical", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Password is not identically!";
        }
      }
    }

    public static string ApplicationClose
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("ApplicationClose", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Application need restart!";
        }
      }
    }

    public static string EnumArgument
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("EnumArgument", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Value not in this enum!";
        }
      }
    }

    public static string NoDevice
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("NoDevice", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Can not find the device in the network!";
        }
      }
    }

    public static string ClearDeviceList
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("ClearDeviceList", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Are you sure to clear device list?";
        }
      }
    }

    public static string RecoverProperty
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("RecoverProperty", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Are you sure to recover device property?";
        }
      }
    }

    public static string UploadProperty
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("UploadProperty", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Are you sure to upload device property?";
        }
      }
    }

    public static string RestartDevice
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("RestartDevice", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Are you sure to restart device?";
        }
      }
    }

    public static string OK
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("OK", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "OK!";
        }
      }
    }

    public static string NotLogin
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("NotLogin", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "You are not login!";
        }
      }
    }

    public static string NotCompatible
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("NotCompatible", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Software and device are not Compatible!";
        }
      }
    }

    public static string ParameterError
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("ParameterError", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Some parameter error!";
        }
      }
    }

    public static string CheckError
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("CheckError", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Username or password is wrong!";
        }
      }
    }

    public static string DeviceNotAnswer
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("DeviceNotAnswer", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Device is not answer,please retry later!";
        }
      }
    }

    public static string Nonsupport
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("Nonsupport", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Software is not nonsupport!";
        }
      }
    }

    public static string SystemError
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("SystemError", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Occur a error,please restart!";
        }
      }
    }

    public static string UserFull
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("UserFull", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "User Full!";
        }
      }
    }

    public static string IsExist
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("IsExist", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "The device exist in device list!";
        }
      }
    }

    public static string Refreshing
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("Refreshing", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Refreshing property of the device!";
        }
      }
    }

    public static string Updateing
    {
      get
      {
        try
        {
          return (string) Message.resources.GetObject("Updateing", Program.cultureInfo);
        }
        catch (MissingManifestResourceException ex)
        {
          return "Updating property of the device!";
        }
      }
    }
  }
}
