// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Log
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.IO;

namespace DeviceManagement
{
  public class Log
  {
    public static bool WriteLog(string log)
    {
      return Log.write(log, "Log");
    }

    public static bool WriteError(string error)
    {
      return Log.write(error, "Error");
    }

    public static bool WriteException(Exception exception)
    {
      if (exception.InnerException != null)
        Log.write("InnerException: " + exception.InnerException.ToString(), "Error");
      if (exception.Message != null)
        Log.write("Message: " + exception.Message.ToString(), "Error");
      if (exception.Source != null)
        Log.write("Source: " + exception.Source.ToString(), "Error");
      if (exception.StackTrace != null)
        Log.write("StackTrace :" + exception.StackTrace.ToString(), "Error");
      if (exception.TargetSite != null)
        Log.write("TargetSite :" + exception.TargetSite.ToString(), "Error");
      Log.write("-------------------------------------------------------------------------", "Error");
      return true;
    }

    private static bool write(string text, string writeType)
    {
      StreamWriter streamWriter = (StreamWriter) null;
      try
      {
        string path1 = Program.PATH + "\\Log";
        if (!Directory.Exists(path1))
          Directory.CreateDirectory(path1);
        string path2 = path1 + "\\" + DateTime.Now.ToString("yyyyMMdd") + writeType + ".txt";
        streamWriter = !File.Exists(path2) ? File.CreateText(path2) : File.AppendText(path2);
        streamWriter.WriteLine(text);
        return true;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        return false;
      }
      finally
      {
        if (streamWriter != null)
          streamWriter.Close();
      }
    }
  }
}
