// Decompiled with JetBrains decompiler
// Type: DeviceManagement.DataListManger
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;

namespace DeviceManagement
{
  public class DataListManger
  {
    private static object syncRoot = new object();
    private static List<OptionListClass> SendOList = new List<OptionListClass>();
    private static List<FrameClass> RevOList = new List<FrameClass>();
    private const int MAXLENGTH = 255;

    public static void AddOption(OptionClass optionClass, IPAddress ipAddr, byte controlType)
    {
      for (int index = 0; index < DataListManger.SendOList.Count; ++index)
      {
        if (DataListManger.SendOList[index].IpAddr == ipAddr && (int) DataListManger.SendOList[index].ControlType == (int) controlType)
        {
          DataListManger.SendOList[index].OptionList.Add(optionClass);
          return;
        }
      }
      DataListManger.SendOList.Add(new OptionListClass(ipAddr, controlType)
      {
        OptionList = {
          optionClass
        }
      });
    }

    public static void AddOptionValue(int id, string value, IPAddress ipAddr, byte controlType)
    {
      OptionListClass optionListClass = (OptionListClass) null;
      OptionClass optionClass1 = (OptionClass) null;
      for (int index = 0; index < DataListManger.SendOList.Count; ++index)
      {
        if (DataListManger.SendOList[index].IpAddr == ipAddr && (int) DataListManger.SendOList[index].ControlType == (int) controlType)
        {
          optionListClass = DataListManger.SendOList[index];
          using (List<OptionClass>.Enumerator enumerator = DataListManger.SendOList[index].OptionList.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              OptionClass current = enumerator.Current;
              if ((int) current.OptionType == id)
              {
                optionClass1 = current;
                break;
              }
            }
            break;
          }
        }
      }
      if (optionListClass == null)
      {
        optionListClass = new OptionListClass(ipAddr, controlType);
        DataListManger.SendOList.Add(optionListClass);
      }
      if (optionClass1 == null)
      {
        DataView dataView = ProtocolData.SelectFromDT("code=" + (object) id, true);
        if (dataView.Count != 1)
          return;
        OptionClass optionClass2 = new OptionClass(dataView[0], Encoding.Default.GetBytes(value));
        optionListClass.OptionList.Add(optionClass2);
      }
      else
      {
        if (!(value != ""))
          return;
        string s = Encoding.Default.GetString(optionClass1.OptionData) + value;
        optionClass1.OptionData = Encoding.Default.GetBytes(s);
        optionClass1.createOption();
      }
    }

    public static void ClearOption(IPAddress ipAddr, byte controlType)
    {
      for (int index = 0; index < DataListManger.SendOList.Count; ++index)
      {
        if (DataListManger.SendOList[index].IpAddr == ipAddr && (int) DataListManger.SendOList[index].ControlType == (int) controlType)
        {
          DataListManger.SendOList.RemoveAt(index);
          break;
        }
      }
    }

    public static List<OptionClass> ReadOptionQueueForCommand(IPAddress ipAddr, byte commandControlType, ref ushort commandLength, ref ushort commandMaxLength)
    {
      ushort num1 = commandMaxLength;
      for (int index = 0; index < DataListManger.SendOList.Count; ++index)
      {
        if (DataListManger.SendOList[index].IpAddr == ipAddr && (int) DataListManger.SendOList[index].ControlType == (int) commandControlType)
        {
          List<OptionClass> list = new List<OptionClass>();
          int count;
          for (count = 0; count < DataListManger.SendOList[index].OptionList.Count; ++count)
          {
            ushort num2 = (ushort) ((int) commandMaxLength + (int) DataListManger.SendOList[index].OptionList[count].MaxLength + 3);
            if ((int) num2 <= (int) byte.MaxValue)
            {
              commandLength = (ushort) ((uint) commandLength + (uint) DataListManger.SendOList[index].OptionList[count].Length);
              commandMaxLength = num2;
              list.Add(DataListManger.SendOList[index].OptionList[count]);
            }
            else
              break;
          }
          DataListManger.SendOList[index].OptionList.RemoveRange(0, count);
          if (DataListManger.SendOList[index].OptionList.Count == 0)
            DataListManger.SendOList.RemoveAt(index);
          return list;
        }
      }
      return (List<OptionClass>) null;
    }

    public static void AddRevFrameClass(FrameClass fClass)
    {
      lock (DataListManger.syncRoot)
        DataListManger.RevOList.Add(fClass);
    }

    public static FrameClass GetRevFrameClass(byte identifier, IPAddress checkIP)
    {
      lock (DataListManger.syncRoot)
      {
        for (int local_0 = 0; local_0 < DataListManger.RevOList.Count; ++local_0)
        {
          if ((int) DataListManger.RevOList[local_0].Identifier == (int) identifier && (checkIP == null || DataListManger.RevOList[local_0].IpAddr.Equals((object) checkIP)))
          {
            FrameClass local_1 = DataListManger.RevOList[local_0];
            DataListManger.RevOList.RemoveAt(local_0);
            return local_1;
          }
        }
      }
      return (FrameClass) null;
    }

    public static void ClearFrameClass(byte identifier)
    {
      lock (DataListManger.syncRoot)
      {
        for (int local_0 = 0; local_0 < DataListManger.RevOList.Count; ++local_0)
        {
          if ((int) DataListManger.RevOList[local_0].Identifier == (int) identifier)
          {
            DataListManger.RevOList.RemoveAt(local_0);
            --local_0;
          }
        }
      }
    }
  }
}
