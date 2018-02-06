// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Program
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.Data;
using System.Globalization;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace DeviceManagement
{
  internal static class Program
  {
    internal static bool IsCloseReceive = false;
    internal static CultureInfo cultureInfo = Thread.CurrentThread.CurrentUICulture;
    internal static object syncRoot = new object();
    internal static string[] arytimezone = new string[3]
    {
      "(GMT)Greenwich Mean Time: Dublin, Edinburgh, Lisbon, London",
      "(GMT+08:00)Beijing, Chongqing, Hong Kong, Urumqi",
      "(GMT-05:00)Eastern Time (US & Canada)"
    };
    internal static MyShortcutKey[] DefaultMyShortcutKeys = new MyShortcutKey[8]
    {
      new MyShortcutKey("F5"),
      new MyShortcutKey("CTRL+F"),
      new MyShortcutKey("Enter"),
      new MyShortcutKey("CTRL+C"),
      new MyShortcutKey("ALT+Q"),
      new MyShortcutKey("CTRL+I"),
      new MyShortcutKey("CTRL+T"),
      new MyShortcutKey("CTRL+P")
    };
    internal const int FRAME_RESPONSE = 0;
    internal const int FRAME_COMMAND = 1;
    internal static MainForm mainForm;
    internal static string PATH;
    internal static MyShortcutKey[] MyShortcutKeys;

    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Program.PATH = Application.StartupPath;
      ProtocolData.ReadXML();
      Program.ReadMyShortcutKeys();
      Program.mainForm = new MainForm();
      Application.Run((Form) Program.mainForm);
    }

    private static void ReadMyShortcutKeys()
    {
      Program.MyShortcutKeys = new MyShortcutKey[Program.DefaultMyShortcutKeys.Length];
      StringBuilder retVal = new StringBuilder((int) byte.MaxValue);
      for (int index1 = 0; index1 < Program.DefaultMyShortcutKeys.Length; ++index1)
      {
        try
        {
          retVal.Remove(0, retVal.Length);
          Win32.GetPrivateProfileString("Keys", "K" + (object) (index1 + 1), "", retVal, (int) byte.MaxValue, Program.PATH + "\\Setting.ini");
          Program.MyShortcutKeys[index1] = new MyShortcutKey(retVal.ToString());
          for (int index2 = 0; index2 < index1; ++index2)
          {
            if (Program.MyShortcutKeys[index1].Equals((object) Program.MyShortcutKeys[index2]))
            {
              Program.MyShortcutKeys[index2] = (MyShortcutKey) null;
              Win32.WritePrivateProfileString("Keys", "K" + (object) (index2 + 1), "", Program.PATH + "\\Setting.ini");
              break;
            }
          }
        }
        catch (Exception ex)
        {
          Log.WriteException(ex);
          Program.MyShortcutKeys[index1] = Program.DefaultMyShortcutKeys[index1];
          Win32.WritePrivateProfileString("Keys", "K" + (object) (index1 + 1), Program.DefaultMyShortcutKeys[index1].ToString(), Program.PATH + "\\Setting.ini");
        }
      }
    }

    public static void ShowMessage(string message, bool isError)
    {
      if (isError)
      {
        int num = (int) MessageBox.Show(message);
      }
      else
        Program.mainForm.SetMessage(message);
    }

    public static bool CheckStr(string name, ref string oldValue, string newValue, Device device)
    {
      if (newValue.IndexOf('<') != -1 || newValue.IndexOf('>') != -1 || (newValue.IndexOf('/') != -1 || newValue.IndexOf('"') != -1) || newValue.IndexOf('\'') != -1)
      {
        device.AddMessage(Message.ParameterError, name);
        return false;
      }
      DataView dataView = ProtocolData.SelectFromDT("property='" + name + "'", device.IsNewVersion);
      if (dataView.Count == 0)
      {
        device.AddMessage(Message.ParameterError, name);
        return false;
      }
      if (Encoding.UTF8.GetByteCount(newValue.Trim()) > (int) (sbyte) dataView[0]["maxLength"])
      {
        device.AddMessage(Message.TooLong, name);
        return false;
      }
      if (Encoding.UTF8.GetByteCount(newValue.Trim()) < (int) (sbyte) dataView[0]["minLength"])
      {
        device.AddMessage(Message.TooShort, name);
        return false;
      }
      oldValue = newValue.Trim();
      return true;
    }

    public static bool CheckEmailAddr(string name, ref string oldValue, string newValue, Device device)
    {
      if (oldValue == "")
      {
        oldValue = newValue.Trim();
        return true;
      }
      if (Encoding.UTF8.GetByteCount(newValue.Trim()) <= 30)
      {
        if (Regex.IsMatch(newValue, "^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$"))
        {
          oldValue = newValue.Trim();
          return true;
        }
        device.AddMessage(Message.EmailAddrError, name);
        return false;
      }
      device.AddMessage(Message.TooLong, name);
      return false;
    }

    public static bool CheckIpStr(string ip)
    {
      try
      {
        if (ip.Split(".".ToCharArray()).Length == 4)
        {
          IPAddress address;
          return IPAddress.TryParse(ip, out address);
        }
        return false;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        return false;
      }
    }

    public static bool CheckMacStr(string mac)
    {
      try
      {
        string[] strArray = mac.Split(".".ToCharArray());
        if (strArray.Length != 6)
          return false;
        for (int index = 0; index < strArray.Length; ++index)
        {
          if (!Program.CheckNumStr(strArray[index], 2, 2, "x") || index == 0 && ((int) byte.Parse(strArray[index], NumberStyles.HexNumber) & 1) != 0)
            return false;
        }
        return true;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        return false;
      }
    }

    public static bool CheckTimeStr(string time)
    {
      try
      {
        string[] strArray = time.Split(":".ToCharArray());
        if (strArray.Length != 2)
          return false;
        int num1 = int.Parse(strArray[0]);
        int num2 = int.Parse(strArray[1]);
        if (num1 >= 0 && num1 < 4)
          return num2 <= 60 && num2 >= 0;
        return num1 == 4 && (num2 <= 15 && num2 >= 0);
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        return false;
      }
    }

    public static bool CheckNumStr(string NumStr, int MaxLength, int MinLength, string NumType)
    {
      try
      {
        if (NumStr.Length > MaxLength || NumStr.Length < MinLength)
          return false;
        if (NumStr.Length == 0 && MinLength == 0)
          return true;
        byte[] bytes = Encoding.ASCII.GetBytes(NumStr);
        for (int index = 0; index < bytes.Length; ++index)
        {
          if (NumType.Equals("d"))
          {
            if ((int) bytes[index] <= 47 || (int) bytes[index] >= 58)
              return false;
          }
          else if (NumType.Equals("x") && ((int) bytes[index] <= 47 || (int) bytes[index] >= 58) && (((int) bytes[index] <= 96 || (int) bytes[index] >= 103) && ((int) bytes[index] <= 64 || (int) bytes[index] >= 71)))
            return false;
        }
        return true;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        return false;
      }
    }

    public static bool CheckNumStr(string NumStr, int MaxLength, int MinLength, string NumType, int MaxValue, int MinValue)
    {
      try
      {
        if (NumStr.Length > MaxLength || NumStr.Length < MinLength)
          return false;
        if (NumStr.Length == 0 && MinLength == 0)
          return true;
        byte[] bytes = Encoding.ASCII.GetBytes(NumStr);
        for (int index = 0; index < bytes.Length; ++index)
        {
          if (NumType.Equals("d"))
          {
            if ((int) bytes[index] <= 47 || (int) bytes[index] >= 58)
              return false;
          }
          else if (NumType.Equals("x") && ((int) bytes[index] <= 47 || (int) bytes[index] >= 58) && (((int) bytes[index] <= 96 || (int) bytes[index] >= 103) && ((int) bytes[index] <= 64 || (int) bytes[index] >= 71)))
            return false;
        }
        int num;
        if (NumType.Equals("d"))
        {
          num = Convert.ToInt32(NumStr);
        }
        else
        {
          if (!NumType.Equals("x"))
            return false;
          num = Convert.ToInt32(NumStr, 16);
        }
        return num >= MinValue && num <= MaxValue;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        return false;
      }
    }
  }
}
