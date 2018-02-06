// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Controller
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;

namespace DeviceManagement
{
  public class Controller
  {
    public static byte currentCommandID = (byte) 0;
    private static object syncRoot = new object();
    private const int NETWORK_TYPE_ID = 469;
    private static Batman[] WorkBatman;

    public static void InitWorkBatman()
    {
      IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
      ArrayList arrayList = new ArrayList();
      for (int index = 0; index < hostEntry.AddressList.Length; ++index)
      {
        if (hostEntry.AddressList[index].AddressFamily == AddressFamily.InterNetwork)
          arrayList.Add((object) hostEntry.AddressList[index]);
      }
      Controller.WorkBatman = new Batman[arrayList.Count];
      for (int index = 0; index < arrayList.Count; ++index)
        CommunicationClass.InitUdpSocket(ref Controller.WorkBatman[index], (IPAddress) arrayList[index], true);
    }

    public static byte GetNewCommandID()
    {
      lock (Controller.syncRoot)
        Controller.currentCommandID = (byte) ((uint) ++Controller.currentCommandID % (uint) byte.MaxValue);
      return Controller.currentCommandID;
    }

    public static void Seachdevice(IPAddress deviceIP)
    {
      try
      {
        string message = "";
        OptionClass optionClass1 = new OptionClass("FirmwareID", (byte[]) null, false);
        OptionClass optionClass2 = new OptionClass("DeviceName", (byte[]) null, false);
        OptionClass optionClass3 = new OptionClass("MacAddress", (byte[]) null, false);
        OptionClass optionClass4 = new OptionClass("SerialNO", (byte[]) null, false);
        OptionClass optionClass5 = new OptionClass("Firmware", (byte[]) null, false);
        OptionClass optionClass6 = new OptionClass("UpTime", (byte[]) null, false);
        DataListManger.ClearOption(deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass1, deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass2, deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass3, deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass4, deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass5, deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass6, deviceIP, (byte) 0);
        FrameClass sendCommand1 = new FrameClass((byte) 0, byte.MaxValue, deviceIP, CommunicationTypes.UDP);
        DataListManger.ClearOption(deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass1, deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass2, deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass3, deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass4, deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass5, deviceIP, (byte) 0);
        DataListManger.AddOption(optionClass6, deviceIP, (byte) 0);
        FrameClass sendCommand2 = new FrameClass((byte) 0, byte.MaxValue, deviceIP, CommunicationTypes.Broadcast);
        DataListManger.ClearFrameClass(sendCommand1.Identifier);
        for (int index = 0; index < Controller.WorkBatman.Length; ++index)
        {
          CommunicationClass.SendUdp(sendCommand1, Controller.WorkBatman[index]);
          CommunicationClass.SendUdp(sendCommand2, Controller.WorkBatman[index]);
        }
        int millisecondsTimeout = 100;
        for (int index1 = 0; index1 < 80; ++index1)
        {
          Thread.Sleep(millisecondsTimeout);
          FrameClass revFrameClass = DataListManger.GetRevFrameClass(sendCommand1.Identifier, (IPAddress) null);
          for (ResponseTypes responseTypes = Controller.CheckResponseControlType(revFrameClass); responseTypes != ResponseTypes.NoData; responseTypes = Controller.CheckResponseControlType(revFrameClass))
          {
            Device deviceByIp = Program.mainForm.GetDeviceByIP(revFrameClass.IpAddr, revFrameClass.WorkBatman);
            Controller.ReadResponseToDevice(ref deviceByIp, revFrameClass, ref message);
            if (deviceByIp != null)
            {
              Program.mainForm.AddNewDevice(deviceByIp);
              Program.mainForm.RefreshDevice(deviceByIp);
            }
            if (deviceIP != IPAddress.Broadcast)
              return;
            revFrameClass = DataListManger.GetRevFrameClass(byte.MaxValue, (IPAddress) null);
          }
          if (index1 % 20 == 19)
          {
            for (int index2 = 0; index2 < Controller.WorkBatman.Length; ++index2)
            {
              CommunicationClass.SendUdp(sendCommand1, Controller.WorkBatman[index2]);
              CommunicationClass.SendUdp(sendCommand2, Controller.WorkBatman[index2]);
            }
          }
        }
        if (!(message != ""))
          return;
        Program.ShowMessage(message, true);
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        Program.mainForm.ClearDevice();
        Program.ShowMessage(ex.Message, true);
      }
      finally
      {
        DataListManger.ClearOption(deviceIP, (byte) 0);
        DataListManger.ClearFrameClass(byte.MaxValue);
      }
    }

    public static ResponseTypes CheckResponseControlType(FrameClass response)
    {
      return response == null ? ResponseTypes.NoData : (ResponseTypes) response.ControlType;
    }

    public static void GetChannels(Device device)
    {
      ChannelCollection channelList = device.ChannelList;
      bool flag1 = false;
      if (device.Com1Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 1)
          {
            flag1 = true;
            break;
          }
        }
        if (!flag1)
        {
          Channel channel = new Channel(device, (byte) 1, (byte) 1);
          channelList.Add(channel);
        }
      }
      bool flag2 = false;
      if (device.Com0Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 0)
          {
            flag2 = true;
            break;
          }
        }
        if (!flag2)
        {
          Channel channel = new Channel(device, (byte) 0, device.Com0UseHimself ? (byte) 0 : (byte) 1);
          channelList.Add(channel);
        }
      }
      bool flag3 = false;
      if (device.Com3Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 3)
          {
            flag3 = true;
            break;
          }
        }
        if (!flag3)
        {
          Channel channel = new Channel(device, (byte) 3, (byte) 3);
          channelList.Add(channel);
        }
      }
      bool flag4 = false;
      if (device.Com4Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 4)
          {
            flag4 = true;
            break;
          }
        }
        if (!flag4)
        {
          Channel channel = new Channel(device, (byte) 4, (byte) 4);
          channelList.Add(channel);
        }
      }
      bool flag5 = false;
      if (device.Com5Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 5)
          {
            flag5 = true;
            break;
          }
        }
        if (!flag5)
        {
          Channel channel = new Channel(device, (byte) 5, (byte) 5);
          channelList.Add(channel);
        }
      }
      bool flag6 = false;
      if (device.Com6Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 6)
          {
            flag6 = true;
            break;
          }
        }
        if (!flag6)
        {
          Channel channel = new Channel(device, (byte) 6, (byte) 6);
          channelList.Add(channel);
        }
      }
      bool flag7 = false;
      if (device.Com7Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 7)
          {
            flag7 = true;
            break;
          }
        }
        if (!flag7)
        {
          Channel channel = new Channel(device, (byte) 7, (byte) 7);
          channelList.Add(channel);
        }
      }
      bool flag8 = false;
      if (device.Com8Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 8)
          {
            flag8 = true;
            break;
          }
        }
        if (!flag8)
        {
          Channel channel = new Channel(device, (byte) 8, (byte) 8);
          channelList.Add(channel);
        }
      }
      bool flag9 = false;
      if (device.Com9Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 9)
          {
            flag9 = true;
            break;
          }
        }
        if (!flag9)
        {
          Channel channel = new Channel(device, (byte) 9, (byte) 9);
          channelList.Add(channel);
        }
      }
      bool flag10 = false;
      if (device.Com10Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 10)
          {
            flag10 = true;
            break;
          }
        }
        if (!flag10)
        {
          Channel channel = new Channel(device, (byte) 10, (byte) 10);
          channelList.Add(channel);
        }
      }
      bool flag11 = false;
      if (device.Com11Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 11)
          {
            flag11 = true;
            break;
          }
        }
        if (!flag11)
        {
          Channel channel = new Channel(device, (byte) 11, (byte) 11);
          channelList.Add(channel);
        }
      }
      bool flag12 = false;
      if (device.Com12Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 12)
          {
            flag12 = true;
            break;
          }
        }
        if (!flag12)
        {
          Channel channel = new Channel(device, (byte) 12, (byte) 12);
          channelList.Add(channel);
        }
      }
      bool flag13 = false;
      if (device.Com13Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 13)
          {
            flag13 = true;
            break;
          }
        }
        if (!flag13)
        {
          Channel channel = new Channel(device, (byte) 13, (byte) 13);
          channelList.Add(channel);
        }
      }
      bool flag14 = false;
      if (device.Com14Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 14)
          {
            flag14 = true;
            break;
          }
        }
        if (!flag14)
        {
          Channel channel = new Channel(device, (byte) 14, (byte) 14);
          channelList.Add(channel);
        }
      }
      bool flag15 = false;
      if (device.Com15Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 15)
          {
            flag15 = true;
            break;
          }
        }
        if (!flag15)
        {
          Channel channel = new Channel(device, (byte) 15, (byte) 15);
          channelList.Add(channel);
        }
      }
      bool flag16 = false;
      if (device.Com16Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 16)
          {
            flag16 = true;
            break;
          }
        }
        if (!flag16)
        {
          Channel channel = new Channel(device, (byte) 16, (byte) 16);
          channelList.Add(channel);
        }
      }
      bool flag17 = false;
      if (device.Com17Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 17)
          {
            flag17 = true;
            break;
          }
        }
        if (!flag17)
        {
          Channel channel = new Channel(device, (byte) 17, (byte) 17);
          channelList.Add(channel);
        }
      }
      bool flag18 = false;
      if (device.Com18Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 18)
          {
            flag18 = true;
            break;
          }
        }
        if (!flag18)
        {
          Channel channel = new Channel(device, (byte) 18, (byte) 18);
          channelList.Add(channel);
        }
      }
      bool flag19 = false;
      if (device.Com19Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 19)
          {
            flag19 = true;
            break;
          }
        }
        if (!flag19)
        {
          Channel channel = new Channel(device, (byte) 19, (byte) 19);
          channelList.Add(channel);
        }
      }
      bool flag20 = false;
      if (device.Com20Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 20)
          {
            flag20 = true;
            break;
          }
        }
        if (!flag20)
        {
          Channel channel = new Channel(device, (byte) 20, (byte) 20);
          channelList.Add(channel);
        }
      }
      bool flag21 = false;
      if (device.Com21Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 21)
          {
            flag21 = true;
            break;
          }
        }
        if (!flag21)
        {
          Channel channel = new Channel(device, (byte) 21, (byte) 21);
          channelList.Add(channel);
        }
      }
      bool flag22 = false;
      if (device.Com22Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 22)
          {
            flag22 = true;
            break;
          }
        }
        if (!flag22)
        {
          Channel channel = new Channel(device, (byte) 22, (byte) 22);
          channelList.Add(channel);
        }
      }
      bool flag23 = false;
      if (device.Com23Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 23)
          {
            flag23 = true;
            break;
          }
        }
        if (!flag23)
        {
          Channel channel = new Channel(device, (byte) 23, (byte) 23);
          channelList.Add(channel);
        }
      }
      bool flag24 = false;
      if (device.Com24Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 24)
          {
            flag24 = true;
            break;
          }
        }
        if (!flag24)
        {
          Channel channel = new Channel(device, (byte) 24, (byte) 24);
          channelList.Add(channel);
        }
      }
      bool flag25 = false;
      if (device.Com25Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 25)
          {
            flag25 = true;
            break;
          }
        }
        if (!flag25)
        {
          Channel channel = new Channel(device, (byte) 25, (byte) 25);
          channelList.Add(channel);
        }
      }
      bool flag26 = false;
      if (device.Com26Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 26)
          {
            flag26 = true;
            break;
          }
        }
        if (!flag26)
        {
          Channel channel = new Channel(device, (byte) 26, (byte) 26);
          channelList.Add(channel);
        }
      }
      bool flag27 = false;
      if (device.Com27Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 27)
          {
            flag27 = true;
            break;
          }
        }
        if (!flag27)
        {
          Channel channel = new Channel(device, (byte) 27, (byte) 27);
          channelList.Add(channel);
        }
      }
      bool flag28 = false;
      if (device.Com28Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 28)
          {
            flag28 = true;
            break;
          }
        }
        if (!flag28)
        {
          Channel channel = new Channel(device, (byte) 28, (byte) 28);
          channelList.Add(channel);
        }
      }
      bool flag29 = false;
      if (device.Com29Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 29)
          {
            flag29 = true;
            break;
          }
        }
        if (!flag29)
        {
          Channel channel = new Channel(device, (byte) 29, (byte) 29);
          channelList.Add(channel);
        }
      }
      bool flag30 = false;
      if (device.Com30Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 30)
          {
            flag30 = true;
            break;
          }
        }
        if (!flag30)
        {
          Channel channel = new Channel(device, (byte) 30, (byte) 30);
          channelList.Add(channel);
        }
      }
      bool flag31 = false;
      if (device.Com31Enable)
      {
        for (int index = 0; index < channelList.Count; ++index)
        {
          if ((int) channelList[index].GetChannelNum() == 31)
          {
            flag31 = true;
            break;
          }
        }
        if (!flag31)
        {
          Channel channel = new Channel(device, (byte) 31, (byte) 31);
          channelList.Add(channel);
        }
      }
      bool flag32 = false;
      if (!device.Com32Enable)
        return;
      for (int index = 0; index < channelList.Count; ++index)
      {
        if ((int) channelList[index].GetChannelNum() == 32)
        {
          flag32 = true;
          break;
        }
      }
      if (flag32)
        return;
      Channel channel1 = new Channel(device, (byte) 32, (byte) 32);
      channelList.Add(channel1);
    }

    private static Channel getChannelByCommunctionID(Device device, byte communction)
    {
      foreach (Channel channel in device.ChannelList)
      {
        if ((int) channel.GetCommunctionID() == (int) communction)
          return channel;
      }
      return (Channel) null;
    }

    public static Channel getChannelByChannelNum(Device device, byte channelNum)
    {
      foreach (Channel channel in device.ChannelList)
      {
        if ((int) channel.GetChannelNum() == (int) channelNum)
          return channel;
      }
      return (Channel) null;
    }

    private static bool ReadResponseToDevice(ref Device device, FrameClass response, ref string message)
    {
      try
      {
        if (response.OptionList != null)
        {
          foreach (OptionClass optionClass in response.OptionList)
          {
            try
            {
              if (optionClass.PropertyName == "FirmwareID")
              {
                if (device != null || (int) optionClass.Length <= 3)
                  return false;
                device = new Device(response.IpAddr, response.WorkBatman);
                if (((int) optionClass.Option[5] & 64) == 64)
                  response.RefreshReadResponse(true);
                device.Com0Enable = ((int) optionClass.Option[3] & 1) == 1;
                device.Com0CanRS232 = ((int) optionClass.Option[3] & 2) == 2;
                device.Com0CanRS422 = ((int) optionClass.Option[3] & 4) == 4;
                device.Com0CanRS485 = ((int) optionClass.Option[3] & 8) == 8;
                device.Com1Enable = ((int) optionClass.Option[3] & 16) == 16;
                device.Com1CanRS232 = ((int) optionClass.Option[3] & 32) == 32;
                device.Com1CanRS422 = ((int) optionClass.Option[3] & 64) == 64;
                device.Com1CanRS485 = ((int) optionClass.Option[3] & 128) == 128;
                device.Com0CanModem = ((int) optionClass.Option[4] & 1) == 1;
                device.Com1CanModem = ((int) optionClass.Option[4] & 2) == 2;
                device.Can10M = ((int) optionClass.Option[4] & 4) == 4;
                device.Can100M = ((int) optionClass.Option[4] & 8) == 8;
                device.CanEmail = ((int) optionClass.Option[4] & 16) == 16;
                device.CanPins = ((int) optionClass.Option[4] & 32) == 32;
                device.Com0UseHimself = ((int) optionClass.Option[4] & 64) != 64;
                device.IsBig = ((int) optionClass.Option[4] & 128) == 128;
                device.BaudRateNum = (int) optionClass.Option[5] & 3;
                device.Com0CanDNS = ((int) optionClass.Option[5] & 4) == 4;
                device.Com1CanDNS = ((int) optionClass.Option[5] & 8) == 8;
                device.CanPPPOE = ((int) optionClass.Option[5] & 16) == 16;
                device.CommunicationType = ((int) optionClass.Option[5] & 32) == 32 ? CommunicationTypes.Broadcast : CommunicationTypes.UDP;
                device.IsNewVersion = ((int) optionClass.Option[5] & 64) == 64;
                device.CanPPP = ((int) optionClass.Option[5] & 128) == 128;
                device.CanGPRS = ((int) optionClass.Option[6] & 1) == 1;
                if (device.IsNewVersion)
                {
                  int index1 = 7;
                  device.Com3Enable = ((int) optionClass.Option[index1] & 1) == 1;
                  device.Com3CanModem = ((int) optionClass.Option[index1] & 2) == 2;
                  device.Com3CanRS232 = ((int) optionClass.Option[index1] & 4) == 4;
                  device.Com3CanRS422 = ((int) optionClass.Option[index1] & 8) == 8;
                  device.Com3CanRS485 = ((int) optionClass.Option[index1] & 16) == 16;
                  device.Com3CanDNS = ((int) optionClass.Option[index1] & 32) == 32;
                  int index2 = index1 + 1;
                  device.Com4Enable = ((int) optionClass.Option[index2] & 1) == 1;
                  device.Com4CanModem = ((int) optionClass.Option[index2] & 2) == 2;
                  device.Com4CanRS232 = ((int) optionClass.Option[index2] & 4) == 4;
                  device.Com4CanRS422 = ((int) optionClass.Option[index2] & 8) == 8;
                  device.Com4CanRS485 = ((int) optionClass.Option[index2] & 16) == 16;
                  device.Com4CanDNS = ((int) optionClass.Option[index2] & 32) == 32;
                  int index3 = index2 + 1;
                  device.Com5Enable = ((int) optionClass.Option[index3] & 1) == 1;
                  device.Com5CanModem = ((int) optionClass.Option[index3] & 2) == 2;
                  device.Com5CanRS232 = ((int) optionClass.Option[index3] & 4) == 4;
                  device.Com5CanRS422 = ((int) optionClass.Option[index3] & 8) == 8;
                  device.Com5CanRS485 = ((int) optionClass.Option[index3] & 16) == 16;
                  device.Com5CanDNS = ((int) optionClass.Option[index3] & 32) == 32;
                  int index4 = index3 + 1;
                  device.Com6Enable = ((int) optionClass.Option[index4] & 1) == 1;
                  device.Com6CanModem = ((int) optionClass.Option[index4] & 2) == 2;
                  device.Com6CanRS232 = ((int) optionClass.Option[index4] & 4) == 4;
                  device.Com6CanRS422 = ((int) optionClass.Option[index4] & 8) == 8;
                  device.Com6CanRS485 = ((int) optionClass.Option[index4] & 16) == 16;
                  device.Com6CanDNS = ((int) optionClass.Option[index4] & 32) == 32;
                  int index5 = index4 + 1;
                  device.Com7Enable = ((int) optionClass.Option[index5] & 1) == 1;
                  device.Com7CanModem = ((int) optionClass.Option[index5] & 2) == 2;
                  device.Com7CanRS232 = ((int) optionClass.Option[index5] & 4) == 4;
                  device.Com7CanRS422 = ((int) optionClass.Option[index5] & 8) == 8;
                  device.Com7CanRS485 = ((int) optionClass.Option[index5] & 16) == 16;
                  device.Com7CanDNS = ((int) optionClass.Option[index5] & 32) == 32;
                  int index6 = index5 + 1;
                  device.Com8Enable = ((int) optionClass.Option[index6] & 1) == 1;
                  device.Com8CanModem = ((int) optionClass.Option[index6] & 2) == 2;
                  device.Com8CanRS232 = ((int) optionClass.Option[index6] & 4) == 4;
                  device.Com8CanRS422 = ((int) optionClass.Option[index6] & 8) == 8;
                  device.Com8CanRS485 = ((int) optionClass.Option[index6] & 16) == 16;
                  device.Com8CanDNS = ((int) optionClass.Option[index6] & 32) == 32;
                  int index7 = index6 + 1;
                  device.Com9Enable = ((int) optionClass.Option[index7] & 1) == 1;
                  device.Com9CanModem = ((int) optionClass.Option[index7] & 2) == 2;
                  device.Com9CanRS232 = ((int) optionClass.Option[index7] & 4) == 4;
                  device.Com9CanRS422 = ((int) optionClass.Option[index7] & 8) == 8;
                  device.Com9CanRS485 = ((int) optionClass.Option[index7] & 16) == 16;
                  device.Com9CanDNS = ((int) optionClass.Option[index7] & 32) == 32;
                  int index8 = index7 + 1;
                  device.Com10Enable = ((int) optionClass.Option[index8] & 1) == 1;
                  device.Com10CanModem = ((int) optionClass.Option[index8] & 2) == 2;
                  device.Com10CanRS232 = ((int) optionClass.Option[index8] & 4) == 4;
                  device.Com10CanRS422 = ((int) optionClass.Option[index8] & 8) == 8;
                  device.Com10CanRS485 = ((int) optionClass.Option[index8] & 16) == 16;
                  device.Com10CanDNS = ((int) optionClass.Option[index8] & 32) == 32;
                  int index9 = index8 + 1;
                  device.Com11Enable = ((int) optionClass.Option[index9] & 1) == 1;
                  device.Com11CanModem = ((int) optionClass.Option[index9] & 2) == 2;
                  device.Com11CanRS232 = ((int) optionClass.Option[index9] & 4) == 4;
                  device.Com11CanRS422 = ((int) optionClass.Option[index9] & 8) == 8;
                  device.Com11CanRS485 = ((int) optionClass.Option[index9] & 16) == 16;
                  device.Com11CanDNS = ((int) optionClass.Option[index9] & 32) == 32;
                  int index10 = index9 + 1;
                  device.Com12Enable = ((int) optionClass.Option[index10] & 1) == 1;
                  device.Com12CanModem = ((int) optionClass.Option[index10] & 2) == 2;
                  device.Com12CanRS232 = ((int) optionClass.Option[index10] & 4) == 4;
                  device.Com12CanRS422 = ((int) optionClass.Option[index10] & 8) == 8;
                  device.Com12CanRS485 = ((int) optionClass.Option[index10] & 16) == 16;
                  device.Com12CanDNS = ((int) optionClass.Option[index10] & 32) == 32;
                  int index11 = index10 + 1;
                  device.Com13Enable = ((int) optionClass.Option[index11] & 1) == 1;
                  device.Com13CanModem = ((int) optionClass.Option[index11] & 2) == 2;
                  device.Com13CanRS232 = ((int) optionClass.Option[index11] & 4) == 4;
                  device.Com13CanRS422 = ((int) optionClass.Option[index11] & 8) == 8;
                  device.Com13CanRS485 = ((int) optionClass.Option[index11] & 16) == 16;
                  device.Com13CanDNS = ((int) optionClass.Option[index11] & 32) == 32;
                  int index12 = index11 + 1;
                  device.Com14Enable = ((int) optionClass.Option[index12] & 1) == 1;
                  device.Com14CanModem = ((int) optionClass.Option[index12] & 2) == 2;
                  device.Com14CanRS232 = ((int) optionClass.Option[index12] & 4) == 4;
                  device.Com14CanRS422 = ((int) optionClass.Option[index12] & 8) == 8;
                  device.Com14CanRS485 = ((int) optionClass.Option[index12] & 16) == 16;
                  device.Com14CanDNS = ((int) optionClass.Option[index12] & 32) == 32;
                  int index13 = index12 + 1;
                  device.Com15Enable = ((int) optionClass.Option[index13] & 1) == 1;
                  device.Com15CanModem = ((int) optionClass.Option[index13] & 2) == 2;
                  device.Com15CanRS232 = ((int) optionClass.Option[index13] & 4) == 4;
                  device.Com15CanRS422 = ((int) optionClass.Option[index13] & 8) == 8;
                  device.Com15CanRS485 = ((int) optionClass.Option[index13] & 16) == 16;
                  device.Com15CanDNS = ((int) optionClass.Option[index13] & 32) == 32;
                  int index14 = index13 + 1;
                  device.Com16Enable = ((int) optionClass.Option[index14] & 1) == 1;
                  device.Com16CanModem = ((int) optionClass.Option[index14] & 2) == 2;
                  device.Com16CanRS232 = ((int) optionClass.Option[index14] & 4) == 4;
                  device.Com16CanRS422 = ((int) optionClass.Option[index14] & 8) == 8;
                  device.Com16CanRS485 = ((int) optionClass.Option[index14] & 16) == 16;
                  device.Com16CanDNS = ((int) optionClass.Option[index14] & 32) == 32;
                  int index15 = index14 + 1;
                  device.Com17Enable = ((int) optionClass.Option[index15] & 1) == 1;
                  device.Com17CanModem = ((int) optionClass.Option[index15] & 2) == 2;
                  device.Com17CanRS232 = ((int) optionClass.Option[index15] & 4) == 4;
                  device.Com17CanRS422 = ((int) optionClass.Option[index15] & 8) == 8;
                  device.Com17CanRS485 = ((int) optionClass.Option[index15] & 16) == 16;
                  device.Com17CanDNS = ((int) optionClass.Option[index15] & 32) == 32;
                  int index16 = index15 + 1;
                  device.Com18Enable = ((int) optionClass.Option[index16] & 1) == 1;
                  device.Com18CanModem = ((int) optionClass.Option[index16] & 2) == 2;
                  device.Com18CanRS232 = ((int) optionClass.Option[index16] & 4) == 4;
                  device.Com18CanRS422 = ((int) optionClass.Option[index16] & 8) == 8;
                  device.Com18CanRS485 = ((int) optionClass.Option[index16] & 16) == 16;
                  device.Com18CanDNS = ((int) optionClass.Option[index16] & 32) == 32;
                  int index17 = index16 + 1;
                  device.Com19Enable = ((int) optionClass.Option[index17] & 1) == 1;
                  device.Com19CanModem = ((int) optionClass.Option[index17] & 2) == 2;
                  device.Com19CanRS232 = ((int) optionClass.Option[index17] & 4) == 4;
                  device.Com19CanRS422 = ((int) optionClass.Option[index17] & 8) == 8;
                  device.Com19CanRS485 = ((int) optionClass.Option[index17] & 16) == 16;
                  device.Com19CanDNS = ((int) optionClass.Option[index17] & 32) == 32;
                  int index18 = index17 + 1;
                  device.Com20Enable = ((int) optionClass.Option[index18] & 1) == 1;
                  device.Com20CanModem = ((int) optionClass.Option[index18] & 2) == 2;
                  device.Com20CanRS232 = ((int) optionClass.Option[index18] & 4) == 4;
                  device.Com20CanRS422 = ((int) optionClass.Option[index18] & 8) == 8;
                  device.Com20CanRS485 = ((int) optionClass.Option[index18] & 16) == 16;
                  device.Com20CanDNS = ((int) optionClass.Option[index18] & 32) == 32;
                  int index19 = index18 + 1;
                  device.Com21Enable = ((int) optionClass.Option[index19] & 1) == 1;
                  device.Com21CanModem = ((int) optionClass.Option[index19] & 2) == 2;
                  device.Com21CanRS232 = ((int) optionClass.Option[index19] & 4) == 4;
                  device.Com21CanRS422 = ((int) optionClass.Option[index19] & 8) == 8;
                  device.Com21CanRS485 = ((int) optionClass.Option[index19] & 16) == 16;
                  device.Com21CanDNS = ((int) optionClass.Option[index19] & 32) == 32;
                  int index20 = index19 + 1;
                  device.Com22Enable = ((int) optionClass.Option[index20] & 1) == 1;
                  device.Com22CanModem = ((int) optionClass.Option[index20] & 2) == 2;
                  device.Com22CanRS232 = ((int) optionClass.Option[index20] & 4) == 4;
                  device.Com22CanRS422 = ((int) optionClass.Option[index20] & 8) == 8;
                  device.Com22CanRS485 = ((int) optionClass.Option[index20] & 16) == 16;
                  device.Com22CanDNS = ((int) optionClass.Option[index20] & 32) == 32;
                  int index21 = index20 + 1;
                  device.Com23Enable = ((int) optionClass.Option[index21] & 1) == 1;
                  device.Com23CanModem = ((int) optionClass.Option[index21] & 2) == 2;
                  device.Com23CanRS232 = ((int) optionClass.Option[index21] & 4) == 4;
                  device.Com23CanRS422 = ((int) optionClass.Option[index21] & 8) == 8;
                  device.Com23CanRS485 = ((int) optionClass.Option[index21] & 16) == 16;
                  device.Com23CanDNS = ((int) optionClass.Option[index21] & 32) == 32;
                  int index22 = index21 + 1;
                  device.Com24Enable = ((int) optionClass.Option[index22] & 1) == 1;
                  device.Com24CanModem = ((int) optionClass.Option[index22] & 2) == 2;
                  device.Com24CanRS232 = ((int) optionClass.Option[index22] & 4) == 4;
                  device.Com24CanRS422 = ((int) optionClass.Option[index22] & 8) == 8;
                  device.Com24CanRS485 = ((int) optionClass.Option[index22] & 16) == 16;
                  device.Com24CanDNS = ((int) optionClass.Option[index22] & 32) == 32;
                  int index23 = index22 + 1;
                  device.Com25Enable = ((int) optionClass.Option[index23] & 1) == 1;
                  device.Com25CanModem = ((int) optionClass.Option[index23] & 2) == 2;
                  device.Com25CanRS232 = ((int) optionClass.Option[index23] & 4) == 4;
                  device.Com25CanRS422 = ((int) optionClass.Option[index23] & 8) == 8;
                  device.Com25CanRS485 = ((int) optionClass.Option[index23] & 16) == 16;
                  device.Com25CanDNS = ((int) optionClass.Option[index23] & 32) == 32;
                  int index24 = index23 + 1;
                  device.Com26Enable = ((int) optionClass.Option[index24] & 1) == 1;
                  device.Com26CanModem = ((int) optionClass.Option[index24] & 2) == 2;
                  device.Com26CanRS232 = ((int) optionClass.Option[index24] & 4) == 4;
                  device.Com26CanRS422 = ((int) optionClass.Option[index24] & 8) == 8;
                  device.Com26CanRS485 = ((int) optionClass.Option[index24] & 16) == 16;
                  device.Com26CanDNS = ((int) optionClass.Option[index24] & 32) == 32;
                  int index25 = index24 + 1;
                  device.Com27Enable = ((int) optionClass.Option[index25] & 1) == 1;
                  device.Com27CanModem = ((int) optionClass.Option[index25] & 2) == 2;
                  device.Com27CanRS232 = ((int) optionClass.Option[index25] & 4) == 4;
                  device.Com27CanRS422 = ((int) optionClass.Option[index25] & 8) == 8;
                  device.Com27CanRS485 = ((int) optionClass.Option[index25] & 16) == 16;
                  device.Com27CanDNS = ((int) optionClass.Option[index25] & 32) == 32;
                  int index26 = index25 + 1;
                  device.Com28Enable = ((int) optionClass.Option[index26] & 1) == 1;
                  device.Com28CanModem = ((int) optionClass.Option[index26] & 2) == 2;
                  device.Com28CanRS232 = ((int) optionClass.Option[index26] & 4) == 4;
                  device.Com28CanRS422 = ((int) optionClass.Option[index26] & 8) == 8;
                  device.Com28CanRS485 = ((int) optionClass.Option[index26] & 16) == 16;
                  device.Com28CanDNS = ((int) optionClass.Option[index26] & 32) == 32;
                  int index27 = index26 + 1;
                  device.Com29Enable = ((int) optionClass.Option[index27] & 1) == 1;
                  device.Com29CanModem = ((int) optionClass.Option[index27] & 2) == 2;
                  device.Com29CanRS232 = ((int) optionClass.Option[index27] & 4) == 4;
                  device.Com29CanRS422 = ((int) optionClass.Option[index27] & 8) == 8;
                  device.Com29CanRS485 = ((int) optionClass.Option[index27] & 16) == 16;
                  device.Com29CanDNS = ((int) optionClass.Option[index27] & 32) == 32;
                  int index28 = index27 + 1;
                  device.Com30Enable = ((int) optionClass.Option[index28] & 1) == 1;
                  device.Com30CanModem = ((int) optionClass.Option[index28] & 2) == 2;
                  device.Com30CanRS232 = ((int) optionClass.Option[index28] & 4) == 4;
                  device.Com30CanRS422 = ((int) optionClass.Option[index28] & 8) == 8;
                  device.Com30CanRS485 = ((int) optionClass.Option[index28] & 16) == 16;
                  device.Com30CanDNS = ((int) optionClass.Option[index28] & 32) == 32;
                  int index29 = index28 + 1;
                  device.Com31Enable = ((int) optionClass.Option[index29] & 1) == 1;
                  device.Com31CanModem = ((int) optionClass.Option[index29] & 2) == 2;
                  device.Com31CanRS232 = ((int) optionClass.Option[index29] & 4) == 4;
                  device.Com31CanRS422 = ((int) optionClass.Option[index29] & 8) == 8;
                  device.Com31CanRS485 = ((int) optionClass.Option[index29] & 16) == 16;
                  device.Com31CanDNS = ((int) optionClass.Option[index29] & 32) == 32;
                  int index30 = index29 + 1;
                  device.Com32Enable = ((int) optionClass.Option[index30] & 1) == 1;
                  device.Com32CanModem = ((int) optionClass.Option[index30] & 2) == 2;
                  device.Com32CanRS232 = ((int) optionClass.Option[index30] & 4) == 4;
                  device.Com32CanRS422 = ((int) optionClass.Option[index30] & 8) == 8;
                  device.Com32CanRS485 = ((int) optionClass.Option[index30] & 16) == 16;
                  device.Com32CanDNS = ((int) optionClass.Option[index30] & 32) == 32;
                  int num = index30 + 1;
                }
              }
              else
              {
                if (device == null)
                {
                  // ISSUE: explicit reference operation
                  // ISSUE: variable of a reference type
                  string& local = @message;
                  // ISSUE: explicit reference operation
                  string str = ^local + optionClass.PropertyName.ToString() + " Error: " + Message.SystemError + "\r";
                  // ISSUE: explicit reference operation
                  ^local = str;
                  return false;
                }
                if ((int) optionClass.Length == 3)
                {
                  string[] strArray1;
                  if ((strArray1 = optionClass.PropertyName.Split("@".ToCharArray())).Length > 1)
                  {
                    byte communction = byte.Parse(strArray1[1]);
                    Channel channelByCommunctionId = Controller.getChannelByCommunctionID(device, communction);
                    if (channelByCommunctionId != null)
                    {
                      string[] strArray2 = strArray1[0].Split("_".ToCharArray());
                      channelByCommunctionId.Visibility[(object) strArray2[0]] = (object) false;
                    }
                  }
                  else
                  {
                    string[] strArray2 = optionClass.PropertyName.Split("_".ToCharArray());
                    device.Visibility[(object) strArray2[0]] = (object) false;
                  }
                }
                else
                {
                  string[] strArray1;
                  string name1;
                  object obj1;
                  Type type;
                  if ((strArray1 = optionClass.PropertyName.Split("@".ToCharArray())).Length > 1)
                  {
                    name1 = strArray1[0];
                    byte communction = byte.Parse(strArray1[1]);
                    Channel channelByCommunctionId = Controller.getChannelByCommunctionID(device, communction);
                    obj1 = (object) channelByCommunctionId;
                    type = channelByCommunctionId.GetType();
                    string[] strArray2 = strArray1[0].Split("_".ToCharArray());
                    channelByCommunctionId.Visibility[(object) strArray2[0]] = (object) true;
                  }
                  else
                  {
                    name1 = optionClass.PropertyName;
                    obj1 = (object) device;
                    type = device.GetType();
                    string[] strArray2 = optionClass.PropertyName.Split("_".ToCharArray());
                    device.Visibility[(object) strArray2[0]] = (object) true;
                  }
                  if (device.IsNewVersion)
                  {
                    switch (optionClass.DataType)
                    {
                      case "Byte":
                      case "UTF8":
                      case "NetworkType":
                        PropertyInfo property1 = type.GetProperty(name1);
                        if (property1.PropertyType.IsEnum)
                        {
                          byte num = optionClass.OptionData[0];
                          object obj2 = System.Enum.Parse(property1.PropertyType, num.ToString());
                          if (System.Enum.IsDefined(property1.PropertyType, obj2))
                          {
                            property1.SetValue(obj1, obj2, (object[]) null);
                            continue;
                          }
                          Program.ShowMessage(name1.ToString() + " Error: " + Message.EnumArgument, true);
                          continue;
                        }
                        if (property1.PropertyType == typeof (string))
                        {
                          byte num = byte.MaxValue;
                          for (byte index = (byte) 0; (int) index < optionClass.OptionData.Length; ++index)
                          {
                            if ((int) optionClass.OptionData[(int) index] == 0)
                              num = index;
                            else if ((int) index > (int) num)
                              optionClass.OptionData[(int) index] = (byte) 0;
                          }
                          string str = Encoding.UTF8.GetString(optionClass.OptionData).Trim().Replace("\0", "");
                          property1.SetValue(obj1, (object) str, (object[]) null);
                          continue;
                        }
                        if (property1.PropertyType == typeof (ushort))
                        {
                          ushort num = (ushort) (((uint) optionClass.OptionData[0] << 8) + (uint) optionClass.OptionData[1]);
                          property1.SetValue(obj1, (object) num, (object[]) null);
                          continue;
                        }
                        if (property1.PropertyType == typeof (uint))
                        {
                          uint num = (uint) (((int) optionClass.OptionData[0] << 24) + ((int) optionClass.OptionData[1] << 16) + ((int) optionClass.OptionData[2] << 8)) + (uint) optionClass.OptionData[3];
                          property1.SetValue(obj1, (object) num, (object[]) null);
                          continue;
                        }
                        if (property1.PropertyType == typeof (IPAddress))
                        {
                          IPAddress ipAddress = new IPAddress(optionClass.OptionData);
                          property1.SetValue(obj1, (object) ipAddress, (object[]) null);
                          continue;
                        }
                        if (property1.PropertyType == typeof (DateTime))
                        {
                          byte num = byte.MaxValue;
                          for (byte index = (byte) 0; (int) index < optionClass.OptionData.Length; ++index)
                          {
                            if ((int) optionClass.OptionData[(int) index] == 0)
                              num = index;
                            else if ((int) index > (int) num)
                              optionClass.OptionData[(int) index] = (byte) 0;
                          }
                          DateTime dateTime = DateTime.Parse(Encoding.UTF8.GetString(optionClass.OptionData).Trim().Replace("\0", ""));
                          property1.SetValue(obj1, (object) dateTime, (object[]) null);
                          continue;
                        }
                        byte num1 = optionClass.OptionData[0];
                        property1.SetValue(obj1, Convert.ChangeType((object) num1, property1.PropertyType), (object[]) null);
                        continue;
                      case "DNSHOST":
                        if (obj1 is Channel)
                        {
                          PropertyInfo property2 = type.GetProperty(name1);
                          if (((Channel) obj1).canDNS())
                          {
                            byte num2 = byte.MaxValue;
                            for (byte index = (byte) 0; (int) index < optionClass.OptionData.Length; ++index)
                            {
                              if ((int) optionClass.OptionData[(int) index] == 0)
                                num2 = index;
                              else if ((int) index > (int) num2)
                                optionClass.OptionData[(int) index] = (byte) 0;
                            }
                            string str = Encoding.UTF8.GetString(optionClass.OptionData).Trim().Replace("\0", "");
                            property2.SetValue(obj1, (object) str, (object[]) null);
                            continue;
                          }
                          string str1 = optionClass.OptionData[0].ToString() + "." + optionClass.OptionData[1].ToString() + "." + optionClass.OptionData[2].ToString() + "." + optionClass.OptionData[3].ToString();
                          property2.SetValue(obj1, (object) str1, (object[]) null);
                          continue;
                        }
                        continue;
                      case "MacAddress":
                        PropertyInfo property3 = type.GetProperty(name1);
                        string str2 = optionClass.OptionData[0].ToString("X2") + "." + optionClass.OptionData[1].ToString("X2") + "." + optionClass.OptionData[2].ToString("X2") + "." + optionClass.OptionData[3].ToString("X2") + "." + optionClass.OptionData[4].ToString("X2") + "." + optionClass.OptionData[5].ToString("X2");
                        property3.SetValue(obj1, (object) str2, (object[]) null);
                        continue;
                      case "TimeZone":
                        PropertyInfo property4 = type.GetProperty(name1);
                        byte num3 = optionClass.OptionData[0];
                        property4.SetValue(obj1, (object) Program.arytimezone[(int) num3], (object[]) null);
                        continue;
                      case "BaudRate":
                        PropertyInfo property5 = type.GetProperty(name1);
                        uint num4 = (uint) (((int) optionClass.OptionData[0] << 24) + ((int) optionClass.OptionData[1] << 16) + ((int) optionClass.OptionData[2] << 8)) + (uint) optionClass.OptionData[3];
                        property5.SetValue(obj1, (object) num4, (object[]) null);
                        continue;
                      case "HEX":
                        type.GetProperty(name1).SetValue(obj1, (object) optionClass.OptionData[0].ToString("X2"), (object[]) null);
                        continue;
                      case "Collection":
                        string[] strArray3 = name1.Split("_".ToCharArray());
                        PropertyInfo property6 = type.GetProperty(strArray3[0]);
                        switch (strArray3[1])
                        {
                          case "a":
                            HostCollection hostCollection1 = (HostCollection) property6.GetValue(obj1, (object[]) null);
                            int index1 = int.Parse(strArray3[2]) - 1;
                            for (int count = hostCollection1.Count; count <= index1; ++count)
                              hostCollection1.Add(new Host());
                            hostCollection1[index1].SetIP(optionClass.OptionData);
                            continue;
                          case "p":
                            object obj3 = property6.GetValue(obj1, (object[]) null);
                            ushort num5 = (ushort) (((uint) optionClass.OptionData[0] << 8) + (uint) optionClass.OptionData[1]);
                            if (obj3 is HostCollection)
                            {
                              int index2 = int.Parse(strArray3[2]) - 1;
                              for (int count = ((HostCollection) obj3).Count; count <= index2; ++count)
                                ((HostCollection) obj3).Add(new Host());
                              ((HostCollection) obj3)[index2].Port = num5;
                              continue;
                            }
                            if (obj3 is UDPDevCollection)
                            {
                              int index2 = int.Parse(strArray3[2]) - 1;
                              for (int count = ((UDPDevCollection) obj3).Count; count <= index2; ++count)
                                ((UDPDevCollection) obj3).Add(new NetSegment());
                              ((UDPDevCollection) obj3)[index2].Port = num5;
                              continue;
                            }
                            continue;
                          case "ba":
                            UDPDevCollection udpDevCollection1 = (UDPDevCollection) property6.GetValue(obj1, (object[]) null);
                            int index3 = int.Parse(strArray3[2]) - 1;
                            for (int count = udpDevCollection1.Count; count <= index3; ++count)
                              udpDevCollection1.Add(new NetSegment());
                            udpDevCollection1[index3].BeginIPAddress = new IPAddress(optionClass.OptionData);
                            continue;
                          case "ea":
                            UDPDevCollection udpDevCollection2 = (UDPDevCollection) property6.GetValue(obj1, (object[]) null);
                            int index4 = int.Parse(strArray3[2]) - 1;
                            for (int count = udpDevCollection2.Count; count <= index4; ++count)
                              udpDevCollection2.Add(new NetSegment());
                            udpDevCollection2[index4].EndIPAddress = new IPAddress(optionClass.OptionData);
                            continue;
                          default:
                            continue;
                        }
                      default:
                        continue;
                    }
                  }
                  else
                  {
                    switch (optionClass.DataType)
                    {
                      case "Byte":
                        PropertyInfo property7 = type.GetProperty(name1);
                        if (property7.PropertyType.IsEnum)
                        {
                          byte num2 = optionClass.OptionData[0];
                          if (name1 == "ActiveConnect")
                            --num2;
                          else if (name1 == "SerialPortProtocol")
                            num2 -= (byte) 49;
                          else if (name1 == "Priority" || name1 == "InputPriority")
                            num2 -= (byte) 48;
                          else if (name1 == "SerialChannel")
                            num2 = (byte) (1U - (uint) num2);
                          object obj2 = System.Enum.Parse(property7.PropertyType, num2.ToString());
                          if (System.Enum.IsDefined(property7.PropertyType, obj2))
                          {
                            property7.SetValue(obj1, obj2, (object[]) null);
                            continue;
                          }
                          Program.ShowMessage(name1.ToString() + " Error: " + Message.EnumArgument, true);
                          continue;
                        }
                        if (property7.PropertyType == typeof (ushort))
                        {
                          ushort num2 = !device.IsBig ? (ushort) (((uint) optionClass.OptionData[1] << 8) + (uint) optionClass.OptionData[0]) : (ushort) (((uint) optionClass.OptionData[0] << 8) + (uint) optionClass.OptionData[1]);
                          property7.SetValue(obj1, Convert.ChangeType((object) num2, property7.PropertyType), (object[]) null);
                          continue;
                        }
                        byte num6 = optionClass.OptionData[0];
                        property7.SetValue(obj1, Convert.ChangeType((object) num6, property7.PropertyType), (object[]) null);
                        continue;
                      case "ASCII":
                        PropertyInfo property8 = type.GetProperty(name1);
                        byte num7 = byte.MaxValue;
                        for (byte index2 = (byte) 0; (int) index2 < optionClass.OptionData.Length; ++index2)
                        {
                          if ((int) optionClass.OptionData[(int) index2] == 0)
                            num7 = index2;
                          else if ((int) index2 > (int) num7)
                            optionClass.OptionData[(int) index2] = (byte) 0;
                        }
                        if (property8.PropertyType.Name.Equals("IPAddress"))
                        {
                          string ipString = Encoding.ASCII.GetString(optionClass.OptionData).Trim().Replace("\0", "");
                          property8.SetValue(obj1, (object) IPAddress.Parse(ipString), (object[]) null);
                          continue;
                        }
                        string str3 = Encoding.ASCII.GetString(optionClass.OptionData).Trim().Replace("\0", "");
                        property8.SetValue(obj1, Convert.ChangeType((object) str3, property8.PropertyType), (object[]) null);
                        continue;
                      case "UTF8":
                        PropertyInfo property9 = type.GetProperty(name1);
                        byte num8 = byte.MaxValue;
                        for (byte index2 = (byte) 0; (int) index2 < optionClass.OptionData.Length; ++index2)
                        {
                          if ((int) optionClass.OptionData[(int) index2] == 0)
                            num8 = index2;
                          else if ((int) index2 > (int) num8)
                            optionClass.OptionData[(int) index2] = (byte) 0;
                        }
                        string ipString1 = Encoding.UTF8.GetString(optionClass.OptionData).Trim().Replace("\0", "");
                        if (property9.PropertyType == typeof (IPAddress))
                        {
                          property9.SetValue(obj1, Convert.ChangeType((object) IPAddress.Parse(ipString1), property9.PropertyType), (object[]) null);
                          continue;
                        }
                        property9.SetValue(obj1, Convert.ChangeType((object) ipString1, property9.PropertyType), (object[]) null);
                        continue;
                      case "Year":
                        string s1 = Encoding.ASCII.GetString(optionClass.OptionData);
                        if (s1.Replace("\0", "").Trim().Equals(""))
                          s1 = "1";
                        int year = int.Parse(s1);
                        string name2 = name1.Substring(0, name1.Length - 2);
                        PropertyInfo property10 = type.GetProperty(name2);
                        DateTime dateTime1 = (DateTime) property10.GetValue(obj1, (object[]) null);
                        dateTime1 = new DateTime(year, dateTime1.Month, dateTime1.Day, dateTime1.Hour, dateTime1.Minute, dateTime1.Second);
                        property10.SetValue(obj1, (object) dateTime1, (object[]) null);
                        continue;
                      case "Month":
                        string s2 = Encoding.ASCII.GetString(optionClass.OptionData);
                        if (s2.Replace("\0", "").Trim().Equals(""))
                          s2 = "1";
                        int month = int.Parse(s2);
                        string name3 = name1.Substring(0, name1.Length - 2);
                        PropertyInfo property11 = type.GetProperty(name3);
                        DateTime dateTime2 = (DateTime) property11.GetValue(obj1, (object[]) null);
                        dateTime2 = new DateTime(dateTime2.Year, month, dateTime2.Day, dateTime2.Hour, dateTime2.Minute, dateTime2.Second);
                        property11.SetValue(obj1, (object) dateTime2, (object[]) null);
                        continue;
                      case "Day":
                        string s3 = Encoding.ASCII.GetString(optionClass.OptionData);
                        if (s3.Replace("\0", "").Trim().Equals(""))
                          s3 = "1";
                        int day = int.Parse(s3);
                        string name4 = name1.Substring(0, name1.Length - 2);
                        PropertyInfo property12 = type.GetProperty(name4);
                        DateTime dateTime3 = (DateTime) property12.GetValue(obj1, (object[]) null);
                        dateTime3 = new DateTime(dateTime3.Year, dateTime3.Month, day, dateTime3.Hour, dateTime3.Minute, dateTime3.Second);
                        property12.SetValue(obj1, (object) dateTime3, (object[]) null);
                        continue;
                      case "Hour":
                        string s4 = Encoding.ASCII.GetString(optionClass.OptionData);
                        if (s4.Replace("\0", "").Trim().Equals(""))
                          s4 = "1";
                        int hour = int.Parse(s4);
                        string name5 = name1.Substring(0, name1.Length - 2);
                        PropertyInfo property13 = type.GetProperty(name5);
                        DateTime dateTime4 = (DateTime) property13.GetValue(obj1, (object[]) null);
                        dateTime4 = new DateTime(dateTime4.Year, dateTime4.Month, dateTime4.Day, hour, dateTime4.Minute, dateTime4.Second);
                        property13.SetValue(obj1, (object) dateTime4, (object[]) null);
                        continue;
                      case "Minute":
                        string s5 = Encoding.ASCII.GetString(optionClass.OptionData);
                        if (s5.Replace("\0", "").Trim().Equals(""))
                          s5 = "1";
                        int minute = int.Parse(s5);
                        string name6 = name1.Substring(0, name1.Length - 2);
                        PropertyInfo property14 = type.GetProperty(name6);
                        if (property14.PropertyType == typeof (DateTime))
                        {
                          DateTime dateTime5 = (DateTime) property14.GetValue(obj1, (object[]) null);
                          dateTime5 = new DateTime(dateTime5.Year, dateTime5.Month, dateTime5.Day, dateTime5.Hour, minute, dateTime5.Second);
                          property14.SetValue(obj1, (object) dateTime5, (object[]) null);
                          continue;
                        }
                        byte num9 = (byte) ((int) (byte) property14.GetValue(obj1, (object[]) null) % 60 + minute * 60);
                        property14.SetValue(obj1, (object) num9, (object[]) null);
                        continue;
                      case "Second":
                        string s6 = Encoding.ASCII.GetString(optionClass.OptionData);
                        if (s6.Replace("\0", "").Trim().Equals(""))
                          s6 = "1";
                        int second = int.Parse(s6);
                        string name7 = name1.Substring(0, name1.Length - 2);
                        PropertyInfo property15 = type.GetProperty(name7);
                        if (property15.PropertyType == typeof (DateTime))
                        {
                          DateTime dateTime5 = (DateTime) property15.GetValue(obj1, (object[]) null);
                          dateTime5 = new DateTime(dateTime5.Year, dateTime5.Month, dateTime5.Day, dateTime5.Hour, dateTime5.Minute, second);
                          property15.SetValue(obj1, (object) dateTime5, (object[]) null);
                          continue;
                        }
                        byte num10 = (byte) ((int) (byte) property15.GetValue(obj1, (object[]) null) / 60 * 60 + second);
                        property15.SetValue(obj1, (object) num10, (object[]) null);
                        continue;
                      case "TimeZone":
                        PropertyInfo property16 = type.GetProperty(name1);
                        byte num11 = optionClass.OptionData[0];
                        property16.SetValue(obj1, (object) Program.arytimezone[(int) num11], (object[]) null);
                        continue;
                      case "BaudRate":
                        PropertyInfo property17 = type.GetProperty(name1);
                        byte num12 = optionClass.OptionData[0];
                        if ((int) num12 < Channel.BaudRateArray.Length)
                        {
                          uint num2 = Channel.BaudRateArray[(int) num12];
                          property17.SetValue(obj1, (object) num2, (object[]) null);
                          continue;
                        }
                        continue;
                      case "Collection":
                        string[] strArray4 = name1.Split("_".ToCharArray());
                        PropertyInfo property18 = type.GetProperty(strArray4[0]);
                        IPAddress address;
                        switch (strArray4[1])
                        {
                          case "a":
                            HostCollection hostCollection2 = (HostCollection) property18.GetValue(obj1, (object[]) null);
                            int index5 = int.Parse(strArray4[2]) - 1;
                            for (int count = hostCollection2.Count; count <= index5; ++count)
                              hostCollection2.Add(new Host());
                            string str4 = Encoding.ASCII.GetString(optionClass.OptionData).Replace("\0", "");
                            hostCollection2[index5].IpAddress = str4;
                            continue;
                          case "p":
                            object obj4 = property18.GetValue(obj1, (object[]) null);
                            if (obj4 is HostCollection)
                            {
                              int index2 = int.Parse(strArray4[2]) - 1;
                              for (int count = ((HostCollection) obj4).Count; count <= index2; ++count)
                                ((HostCollection) obj4).Add(new Host());
                              ((HostCollection) obj4)[index2].Port = Convert.ToUInt16(Encoding.ASCII.GetString(optionClass.OptionData));
                              continue;
                            }
                            if (obj4 is UDPDevCollection)
                            {
                              int index2 = int.Parse(strArray4[2]) - 1;
                              for (int count = ((UDPDevCollection) obj4).Count; count <= index2; ++count)
                                ((UDPDevCollection) obj4).Add(new NetSegment());
                              ((UDPDevCollection) obj4)[index2].Port = Convert.ToUInt16(Encoding.ASCII.GetString(optionClass.OptionData));
                              continue;
                            }
                            continue;
                          case "ba":
                            UDPDevCollection udpDevCollection3 = (UDPDevCollection) property18.GetValue(obj1, (object[]) null);
                            int index6 = int.Parse(strArray4[2]) - 1;
                            for (int count = udpDevCollection3.Count; count <= index6; ++count)
                              udpDevCollection3.Add(new NetSegment());
                            udpDevCollection3[index6].BeginIPAddress = !IPAddress.TryParse(Encoding.ASCII.GetString(optionClass.OptionData).Replace("\0", ""), out address) ? IPAddress.Any : address;
                            continue;
                          case "ea":
                            UDPDevCollection udpDevCollection4 = (UDPDevCollection) property18.GetValue(obj1, (object[]) null);
                            int index7 = int.Parse(strArray4[2]) - 1;
                            for (int count = udpDevCollection4.Count; count <= index7; ++count)
                              udpDevCollection4.Add(new NetSegment());
                            udpDevCollection4[index7].EndIPAddress = !IPAddress.TryParse(Encoding.ASCII.GetString(optionClass.OptionData).Replace("\0", ""), out address) ? IPAddress.Any : address;
                            continue;
                          default:
                            continue;
                        }
                      default:
                        continue;
                    }
                  }
                }
              }
            }
            catch (Exception ex)
            {
              Log.WriteException(ex);
              // ISSUE: explicit reference operation
              // ISSUE: variable of a reference type
              string& local = @message;
              // ISSUE: explicit reference operation
              string str = ^local + optionClass.PropertyName.ToString() + " Error: " + ex.Message + "\r";
              // ISSUE: explicit reference operation
              ^local = str;
            }
          }
        }
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        string& local = @message;
        // ISSUE: explicit reference operation
        string str = ^local + ex.Message + "\r";
        // ISSUE: explicit reference operation
        ^local = str;
      }
      return true;
    }

    public static ResponseTypes AuthUser(Device currentDevice)
    {
      try
      {
        string s = currentDevice.UserName + " " + currentDevice.UserPsw;
        long length = (long) (4.0 / 3.0 * (double) s.Length);
        if (length % 4L != 0L)
          length += 4L - length % 4L;
        char[] outArray = new char[length];
        Convert.ToBase64CharArray(Encoding.ASCII.GetBytes(s), 0, s.Length, outArray, 0);
        byte num1 = (byte) (4UL + (ulong) length);
        ushort num2 = (ushort) 4;
        byte[] sendCommand;
        IPAddress ip;
        switch (currentDevice.CommunicationType)
        {
          case CommunicationTypes.UDP:
            sendCommand = new byte[(int) num1];
            sendCommand[0] = (byte) 5;
            ip = currentDevice.IP;
            break;
          case CommunicationTypes.Broadcast:
            num1 += (byte) 4;
            sendCommand = new byte[(int) num1];
            int interIp = FrameClass.getInterIP(currentDevice.IP);
            byte[] numArray1 = sendCommand;
            int index1 = (int) num2;
            int num3 = 1;
            ushort num4 = (ushort) (index1 + num3);
            int num5 = (int) (byte) (interIp >> 24);
            numArray1[index1] = (byte) num5;
            byte[] numArray2 = sendCommand;
            int index2 = (int) num4;
            int num6 = 1;
            ushort num7 = (ushort) (index2 + num6);
            int num8 = (int) (byte) (interIp >> 16);
            numArray2[index2] = (byte) num8;
            byte[] numArray3 = sendCommand;
            int index3 = (int) num7;
            int num9 = 1;
            ushort num10 = (ushort) (index3 + num9);
            int num11 = (int) (byte) (interIp >> 8);
            numArray3[index3] = (byte) num11;
            byte[] numArray4 = sendCommand;
            int index4 = (int) num10;
            int num12 = 1;
            num2 = (ushort) (index4 + num12);
            int num13 = (int) (byte) interIp;
            numArray4[index4] = (byte) num13;
            sendCommand[0] = (byte) 133;
            ip = IPAddress.Broadcast;
            break;
          default:
            return ResponseTypes.SystemError;
        }
        sendCommand[2] = (byte) ((uint) num1 >> 8);
        sendCommand[3] = num1;
        for (int index5 = 0; (long) index5 < length; ++index5)
          sendCommand[index5 + (int) num2] = Convert.ToByte(outArray[index5]);
        FrameClass response = CommunicationClass.SendAndReceive(sendCommand, currentDevice.IP, ip, Controller.GetNewCommandID(), currentDevice.workBatman);
        if (response == null || ((int) response.ControlType & 15) != 0)
          return Controller.CheckResponseControlType(response);
        currentDevice.LoginIndex = (byte) ((uint) response.ControlType >> 4);
        return ResponseTypes.OK;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        Program.ShowMessage(ex.Message, true);
        return ResponseTypes.SystemError;
      }
    }

    public static ResponseTypes RebootSystem(Device currentDevice, RebootTypes rebootType)
    {
      try
      {
        int num = (int) Controller.GetNewCommandID();
        if (currentDevice.IsNewVersion)
        {
          DataView dataView = ProtocolData.SelectFromDT("propertyName = 'PowerManage'", currentDevice.IsNewVersion);
          if (dataView.Count != 1)
            return ResponseTypes.SystemError;
          OptionClass optionClass = new OptionClass(dataView[0], (byte[]) null);
          optionClass.OptionData = new byte[1];
          optionClass.OptionData[0] = (byte) rebootType;
          optionClass.createOption();
          DataListManger.AddOption(optionClass, currentDevice.IP, (byte) 3);
          return Controller.CheckResponseControlType(CommunicationClass.SendAndReceive(new FrameClass((byte) 3, Controller.currentCommandID, currentDevice.IP, currentDevice.CommunicationType), currentDevice.workBatman));
        }
        CommunicationClass.SendUdp(new FrameClass((byte) 3, Controller.currentCommandID, currentDevice.IP, currentDevice.CommunicationType), currentDevice.workBatman);
        return ResponseTypes.OK;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        Program.ShowMessage(ex.Message, true);
        return ResponseTypes.SystemError;
      }
      finally
      {
        DataListManger.ClearOption(currentDevice.IP, (byte) 0);
      }
    }

    public static ResponseTypes Logout(Device currentDevice)
    {
      try
      {
        int num = (int) Controller.GetNewCommandID();
        return Controller.CheckResponseControlType(CommunicationClass.SendAndReceive(new FrameClass((byte) 4, Controller.currentCommandID, currentDevice.IP, currentDevice.CommunicationType), currentDevice.workBatman));
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        Program.ShowMessage(ex.Message, true);
        return ResponseTypes.SystemError;
      }
      finally
      {
        DataListManger.ClearOption(currentDevice.IP, (byte) 0);
      }
    }

    private static ResponseTypes GetParameters(DataView allRequest, Device currentDevice, ref string message)
    {
      try
      {
        IPAddress ip = currentDevice.IP;
        for (int index = 0; index < allRequest.Count; ++index)
        {
          if ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@1") || currentDevice.Com1CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@0") || currentDevice.Com0CanDNS) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@3") || currentDevice.Com3CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@4") || currentDevice.Com4CanDNS)) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@5") || currentDevice.Com5CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@6") || currentDevice.Com6CanDNS) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@7") || currentDevice.Com7CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@8") || currentDevice.Com8CanDNS))) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@9") || currentDevice.Com9CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@10") || currentDevice.Com10CanDNS) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@11") || currentDevice.Com11CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@12") || currentDevice.Com12CanDNS)) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@13") || currentDevice.Com13CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@14") || currentDevice.Com14CanDNS) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@15") || currentDevice.Com15CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@16") || currentDevice.Com16CanDNS)))) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@17") || currentDevice.Com17CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@18") || currentDevice.Com18CanDNS) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@19") || currentDevice.Com19CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@20") || currentDevice.Com20CanDNS)) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@21") || currentDevice.Com21CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@22") || currentDevice.Com22CanDNS) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@23") || currentDevice.Com23CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@24") || currentDevice.Com24CanDNS))) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@25") || currentDevice.Com25CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@26") || currentDevice.Com26CanDNS) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@27") || currentDevice.Com27CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@28") || currentDevice.Com28CanDNS)) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@29") || currentDevice.Com29CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@30") || currentDevice.Com30CanDNS) && ((!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@31") || currentDevice.Com31CanDNS) && (!(allRequest[index]["propertyName"].ToString() == "DNSQueryPeriod@32") || currentDevice.Com32CanDNS))))))
            DataListManger.AddOption(new OptionClass(allRequest[index], (byte[]) null), ip, (byte) 0);
        }
        ResponseTypes responseTypes1;
        ResponseTypes responseTypes2;
        ResponseTypes responseTypes3;
        while (true)
        {
          int num = (int) Controller.GetNewCommandID();
          FrameClass sendCommand = new FrameClass((byte) 0, Controller.currentCommandID, ip, currentDevice.CommunicationType);
          if (sendCommand.OptionList != null)
          {
            FrameClass response1 = CommunicationClass.SendAndReceive(sendCommand, currentDevice.workBatman);
            responseTypes1 = Controller.CheckResponseControlType(response1);
            switch (responseTypes1)
            {
              case ResponseTypes.OK:
                Controller.ReadResponseToDevice(ref currentDevice, response1, ref message);
                continue;
              case ResponseTypes.NoPermission:
                responseTypes2 = Controller.AuthUser(currentDevice);
                if (responseTypes2 == ResponseTypes.OK)
                {
                  FrameClass response2 = CommunicationClass.SendAndReceive(sendCommand, currentDevice.workBatman);
                  responseTypes3 = Controller.CheckResponseControlType(response2);
                  if (responseTypes3 == ResponseTypes.OK)
                  {
                    Controller.ReadResponseToDevice(ref currentDevice, response2, ref message);
                    continue;
                  }
                  goto label_11;
                }
                else
                  goto label_12;
              case ResponseTypes.NoData:
                goto label_13;
              default:
                continue;
            }
          }
          else
            goto label_14;
        }
label_11:
        currentDevice.IsLogged = false;
        return responseTypes3;
label_12:
        currentDevice.IsLogged = false;
        return responseTypes2;
label_13:
        currentDevice.IsLogged = false;
        return responseTypes1;
label_14:
        return ResponseTypes.OK;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        message += ex.Message;
        return ResponseTypes.SystemError;
      }
      finally
      {
        DataListManger.ClearOption(currentDevice.IP, (byte) 0);
      }
    }

    public static byte[] GetBytes(string text)
    {
      return Encoding.UTF8.GetBytes(text);
    }

    public static ResponseTypes GetParameters(Device currentDevice, PanelTypes panelType, ref string message, byte ChannelID, bool isDevice)
    {
      try
      {
        string rowFilter = "Group='" + panelType.ToString() + "'";
        if (!isDevice)
        {
          bool flag = false;
          for (int index = 0; index < currentDevice.ChannelList.Count; ++index)
          {
            if ((int) currentDevice.ChannelList[index].GetChannelNum() == (int) ChannelID)
            {
              rowFilter = string.Concat(new object[4]
              {
                (object) rowFilter,
                (object) " and propertyName like'%@",
                (object) currentDevice.ChannelList[index].GetCommunctionID(),
                (object) "'"
              });
              flag = true;
              break;
            }
          }
          if (!flag)
            rowFilter += " and propertyName like'%@-1'";
        }
        return Controller.GetParameters(ProtocolData.SelectFromDT(rowFilter, currentDevice.IsNewVersion), currentDevice, ref message);
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        Program.ShowMessage(ex.Message, true);
        return ResponseTypes.SystemError;
      }
    }

    private static ResponseTypes SetParameters(DataView allRequest, Device currentDevice, ref string message, byte index)
    {
      try
      {
        IPAddress ip = currentDevice.IP;
        for (int index1 = 0; index1 < allRequest.Count; ++index1)
        {
          OptionClass optionClass1 = new OptionClass(allRequest[index1], (byte[]) null);
          optionClass1.OptionType += (ushort) index;
          if ((int) optionClass1.MaxLength != 0)
          {
            string[] strArray1;
            string name1;
            object obj1;
            Type type;
            bool flag1;
            if ((strArray1 = optionClass1.PropertyName.Split("@".ToCharArray())).Length > 1)
            {
              name1 = strArray1[0];
              byte communction = byte.Parse(strArray1[1]);
              Channel channelByCommunctionId = Controller.getChannelByCommunctionID(currentDevice, communction);
              obj1 = (object) channelByCommunctionId;
              type = channelByCommunctionId.GetType();
              flag1 = (bool) channelByCommunctionId.Visibility[(object) strArray1[0].Split("_".ToCharArray())[0]];
            }
            else
            {
              name1 = optionClass1.PropertyName;
              obj1 = (object) currentDevice;
              type = currentDevice.GetType();
              flag1 = (bool) ((Device) obj1).Visibility[(object) strArray1[0].Split("_".ToCharArray())[0]];
            }
            int num1;
            if (flag1)
            {
              if (currentDevice.IsNewVersion)
              {
                switch (optionClass1.DataType)
                {
                  case "Byte":
                  case "UTF8":
                    PropertyInfo property1 = type.GetProperty(name1);
                    object obj2 = property1.GetValue(obj1, (object[]) null);
                    if (property1.PropertyType.IsEnum)
                    {
                      byte[] numArray = new byte[1]
                      {
                        Convert.ToByte(System.Enum.Format(property1.PropertyType, obj2, "d").Trim())
                      };
                      optionClass1.OptionData = numArray;
                    }
                    else if (property1.PropertyType == typeof (string))
                    {
                      optionClass1.OptionData = Controller.GetBytes(obj2.ToString().Trim());
                      optionClass1.createOption();
                      DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    }
                    else if (property1.PropertyType == typeof (ushort))
                    {
                      byte[] numArray = new byte[2]
                      {
                        (byte) ((uint) (ushort) obj2 / 256U),
                        (byte) ((uint) (ushort) obj2 % 256U)
                      };
                      optionClass1.OptionData = numArray;
                    }
                    else if (property1.PropertyType == typeof (uint))
                    {
                      byte[] numArray = new byte[4]
                      {
                        (byte) ((uint) obj2 >> 24),
                        (byte) ((uint) obj2 >> 16),
                        (byte) ((uint) obj2 >> 8),
                        (byte) (uint) obj2
                      };
                      optionClass1.OptionData = numArray;
                    }
                    else if (property1.PropertyType == typeof (IPAddress))
                    {
                      int interIp = FrameClass.getInterIP((IPAddress) obj2);
                      byte[] numArray = new byte[4]
                      {
                        (byte) (interIp >> 24),
                        (byte) (interIp >> 16),
                        (byte) (interIp >> 8),
                        (byte) interIp
                      };
                      optionClass1.OptionData = numArray;
                    }
                    else if (property1.PropertyType == typeof (DateTime))
                    {
                      optionClass1.OptionData = Controller.GetBytes(((DateTime) obj2).ToString("yyyy-MM-dd HH:mm:ss") + "\0");
                      optionClass1.createOption();
                      DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    }
                    else
                    {
                      byte[] numArray = new byte[1]
                      {
                        Convert.ToByte(obj2)
                      };
                      optionClass1.OptionData = numArray;
                    }
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "DNSHOST":
                    if (obj1 is Channel)
                    {
                      object obj3 = type.GetProperty(name1).GetValue(obj1, (object[]) null);
                      byte[] numArray;
                      if (((Channel) obj1).canDNS())
                      {
                        numArray = Controller.GetBytes((string) obj3);
                      }
                      else
                      {
                        int interIp = FrameClass.getInterIP(IPAddress.Parse((string) obj3));
                        numArray = new byte[4]
                        {
                          (byte) (interIp >> 24),
                          (byte) (interIp >> 16),
                          (byte) (interIp >> 8),
                          (byte) interIp
                        };
                      }
                      optionClass1.OptionData = numArray;
                      optionClass1.createOption();
                      DataListManger.AddOption(optionClass1, ip, (byte) 1);
                      continue;
                    }
                    continue;
                  case "MacAddress":
                    object obj4 = type.GetProperty(name1).GetValue(obj1, (object[]) null);
                    byte[] numArray1 = new byte[6];
                    string[] strArray2 = ((string) obj4).Split(".".ToCharArray());
                    for (int index2 = 0; index2 < numArray1.Length; ++index2)
                      numArray1[index2] = byte.Parse(strArray2[index2], NumberStyles.HexNumber);
                    optionClass1.OptionData = numArray1;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "TimeZone":
                    string str1 = type.GetProperty(name1).GetValue(obj1, (object[]) null).ToString().Trim();
                    byte[] numArray2 = new byte[1];
                    for (byte index2 = (byte) 0; (int) index2 < Program.arytimezone.Length; ++index2)
                    {
                      if (Program.arytimezone[(int) index2] == str1)
                      {
                        numArray2[0] = index2;
                        break;
                      }
                    }
                    optionClass1.OptionData = numArray2;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "BaudRate":
                    uint num2 = (uint) type.GetProperty(name1).GetValue(obj1, (object[]) null);
                    byte[] numArray3 = new byte[4]
                    {
                      (byte) (num2 >> 24),
                      (byte) (num2 >> 16),
                      (byte) (num2 >> 8),
                      (byte) num2
                    };
                    optionClass1.OptionData = numArray3;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "HEX":
                    byte[] numArray4 = new byte[1]
                    {
                      byte.Parse((string) type.GetProperty(name1).GetValue(obj1, (object[]) null), NumberStyles.HexNumber)
                    };
                    optionClass1.OptionData = numArray4;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "NetworkType":
                    bool flag2 = (bool) type.GetProperty(name1).GetValue(obj1, (object[]) null);
                    string str2 = "";
                    if (flag2)
                    {
                      switch (name1)
                      {
                        case "Ethernet":
                          str2 = "0";
                          break;
                        case "PPP":
                          str2 = "1";
                          break;
                        case "PPPoE":
                          str2 = "2";
                          break;
                        case "GPRS":
                          str2 = "3";
                          break;
                      }
                    }
                    DataListManger.AddOptionValue(469, str2, ip, (byte) 1);
                    continue;
                  case "Collection":
                    string[] strArray3 = name1.Split("_".ToCharArray());
                    PropertyInfo property2 = type.GetProperty(strArray3[0]);
                    switch (strArray3[1])
                    {
                      case "a":
                        HostCollection hostCollection1 = (HostCollection) property2.GetValue(obj1, (object[]) null);
                        if (hostCollection1.Count >= int.Parse(strArray3[2]))
                        {
                          optionClass1.OptionData = hostCollection1[int.Parse(strArray3[2]) - 1].GetIPData();
                          optionClass1.createOption();
                          DataListManger.AddOption(optionClass1, ip, (byte) 1);
                          continue;
                        }
                        continue;
                      case "p":
                        object obj5 = property2.GetValue(obj1, (object[]) null);
                        if (obj5 is HostCollection)
                        {
                          if (((HostCollection) obj5).Count >= int.Parse(strArray3[2]))
                          {
                            byte[] numArray5 = new byte[2]
                            {
                              (byte) ((uint) ((HostCollection) obj5)[int.Parse(strArray3[2]) - 1].Port / 256U),
                              (byte) ((uint) ((HostCollection) obj5)[int.Parse(strArray3[2]) - 1].Port % 256U)
                            };
                            optionClass1.OptionData = numArray5;
                            optionClass1.createOption();
                            DataListManger.AddOption(optionClass1, ip, (byte) 1);
                            continue;
                          }
                          continue;
                        }
                        if (obj5 is UDPDevCollection && ((UDPDevCollection) obj5).Count >= int.Parse(strArray3[2]))
                        {
                          byte[] numArray5 = new byte[2]
                          {
                            (byte) ((uint) ((UDPDevCollection) obj5)[int.Parse(strArray3[2]) - 1].Port / 256U),
                            (byte) ((uint) ((UDPDevCollection) obj5)[int.Parse(strArray3[2]) - 1].Port % 256U)
                          };
                          optionClass1.OptionData = numArray5;
                          optionClass1.createOption();
                          DataListManger.AddOption(optionClass1, ip, (byte) 1);
                          continue;
                        }
                        continue;
                      case "ba":
                        UDPDevCollection udpDevCollection1 = (UDPDevCollection) property2.GetValue(obj1, (object[]) null);
                        if (udpDevCollection1.Count >= int.Parse(strArray3[2]))
                        {
                          int interIp = FrameClass.getInterIP(udpDevCollection1[int.Parse(strArray3[2]) - 1].BeginIPAddress);
                          byte[] numArray5 = new byte[4]
                          {
                            (byte) (interIp >> 24),
                            (byte) (interIp >> 16),
                            (byte) (interIp >> 8),
                            (byte) interIp
                          };
                          optionClass1.OptionData = numArray5;
                          optionClass1.createOption();
                          DataListManger.AddOption(optionClass1, ip, (byte) 1);
                          continue;
                        }
                        continue;
                      case "ea":
                        UDPDevCollection udpDevCollection2 = (UDPDevCollection) property2.GetValue(obj1, (object[]) null);
                        if (udpDevCollection2.Count >= int.Parse(strArray3[2]))
                        {
                          int interIp = FrameClass.getInterIP(udpDevCollection2[int.Parse(strArray3[2]) - 1].EndIPAddress);
                          byte[] numArray5 = new byte[4]
                          {
                            (byte) (interIp >> 24),
                            (byte) (interIp >> 16),
                            (byte) (interIp >> 8),
                            (byte) interIp
                          };
                          optionClass1.OptionData = numArray5;
                          optionClass1.createOption();
                          DataListManger.AddOption(optionClass1, ip, (byte) 1);
                          continue;
                        }
                        continue;
                      default:
                        continue;
                    }
                  default:
                    continue;
                }
              }
              else
              {
                switch (optionClass1.DataType)
                {
                  case "Byte":
                    PropertyInfo property3 = type.GetProperty(name1);
                    object obj6 = property3.GetValue(obj1, (object[]) null);
                    if (property3.PropertyType.IsEnum)
                    {
                      byte[] numArray5 = new byte[1]
                      {
                        Convert.ToByte(System.Enum.Format(property3.PropertyType, obj6, "d").Trim())
                      };
                      if (name1 == "ActiveConnect")
                        ++numArray5[0];
                      else if (name1 == "SerialPortProtocol")
                        numArray5[0] += (byte) 49;
                      else if (name1 == "Priority" || name1 == "InputPriority")
                        numArray5[0] += (byte) 48;
                      else if (name1 == "SerialChannel")
                        numArray5[0] = (byte) (1U - (uint) numArray5[0]);
                      optionClass1.OptionData = numArray5;
                    }
                    else if (property3.PropertyType == typeof (ushort))
                    {
                      byte[] numArray5 = new byte[2];
                      if (currentDevice.IsBig)
                      {
                        numArray5[0] = (byte) ((uint) (ushort) obj6 / 256U);
                        numArray5[1] = (byte) ((uint) (ushort) obj6 % 256U);
                      }
                      else
                      {
                        numArray5[0] = (byte) ((uint) (ushort) obj6 % 256U);
                        numArray5[1] = (byte) ((uint) (ushort) obj6 / 256U);
                      }
                      optionClass1.OptionData = numArray5;
                    }
                    else
                    {
                      byte[] numArray5 = new byte[1]
                      {
                        Convert.ToByte(obj6)
                      };
                      optionClass1.OptionData = numArray5;
                    }
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "ASCII":
                    byte[] bytes1 = Encoding.ASCII.GetBytes(type.GetProperty(name1).GetValue(obj1, (object[]) null).ToString().Trim());
                    optionClass1.OptionData = bytes1;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "UTF8":
                    byte[] bytes2 = Encoding.UTF8.GetBytes(type.GetProperty(name1).GetValue(obj1, (object[]) null).ToString().Trim());
                    optionClass1.OptionData = bytes2;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "Year":
                    string name2 = name1.Substring(0, name1.Length - 2);
                    DateTime dateTime1 = (DateTime) type.GetProperty(name2).GetValue(obj1, (object[]) null);
                    OptionClass optionClass2 = optionClass1;
                    Encoding ascii1 = Encoding.ASCII;
                    num1 = dateTime1.Year;
                    string s1 = num1.ToString();
                    byte[] bytes3 = ascii1.GetBytes(s1);
                    optionClass2.OptionData = bytes3;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "Month":
                    string name3 = name1.Substring(0, name1.Length - 2);
                    DateTime dateTime2 = (DateTime) type.GetProperty(name3).GetValue(obj1, (object[]) null);
                    OptionClass optionClass3 = optionClass1;
                    Encoding ascii2 = Encoding.ASCII;
                    num1 = dateTime2.Month;
                    string s2 = num1.ToString();
                    byte[] bytes4 = ascii2.GetBytes(s2);
                    optionClass3.OptionData = bytes4;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "Day":
                    string name4 = name1.Substring(0, name1.Length - 2);
                    DateTime dateTime3 = (DateTime) type.GetProperty(name4).GetValue(obj1, (object[]) null);
                    OptionClass optionClass4 = optionClass1;
                    Encoding ascii3 = Encoding.ASCII;
                    num1 = dateTime3.Day;
                    string s3 = num1.ToString();
                    byte[] bytes5 = ascii3.GetBytes(s3);
                    optionClass4.OptionData = bytes5;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "Hour":
                    string name5 = name1.Substring(0, name1.Length - 2);
                    DateTime dateTime4 = (DateTime) type.GetProperty(name5).GetValue(obj1, (object[]) null);
                    OptionClass optionClass5 = optionClass1;
                    Encoding ascii4 = Encoding.ASCII;
                    num1 = dateTime4.Hour;
                    string s4 = num1.ToString();
                    byte[] bytes6 = ascii4.GetBytes(s4);
                    optionClass5.OptionData = bytes6;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "Minute":
                    string name6 = name1.Substring(0, name1.Length - 2);
                    PropertyInfo property4 = type.GetProperty(name6);
                    if (property4.PropertyType == typeof (DateTime))
                    {
                      DateTime dateTime5 = (DateTime) property4.GetValue(obj1, (object[]) null);
                      OptionClass optionClass6 = optionClass1;
                      Encoding ascii5 = Encoding.ASCII;
                      num1 = dateTime5.Minute;
                      string s5 = num1.ToString();
                      byte[] bytes7 = ascii5.GetBytes(s5);
                      optionClass6.OptionData = bytes7;
                    }
                    else
                    {
                      byte num3 = (byte) property4.GetValue(obj1, (object[]) null);
                      OptionClass optionClass6 = optionClass1;
                      Encoding ascii5 = Encoding.ASCII;
                      num1 = (int) num3 / 60;
                      string s5 = num1.ToString();
                      byte[] bytes7 = ascii5.GetBytes(s5);
                      optionClass6.OptionData = bytes7;
                    }
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "Second":
                    string name7 = name1.Substring(0, name1.Length - 2);
                    PropertyInfo property5 = type.GetProperty(name7);
                    if (property5.PropertyType == typeof (DateTime))
                    {
                      DateTime dateTime5 = (DateTime) property5.GetValue(obj1, (object[]) null);
                      OptionClass optionClass6 = optionClass1;
                      Encoding ascii5 = Encoding.ASCII;
                      num1 = dateTime5.Second;
                      string s5 = num1.ToString();
                      byte[] bytes7 = ascii5.GetBytes(s5);
                      optionClass6.OptionData = bytes7;
                    }
                    else
                    {
                      byte num3 = (byte) property5.GetValue(obj1, (object[]) null);
                      OptionClass optionClass6 = optionClass1;
                      Encoding ascii5 = Encoding.ASCII;
                      num1 = (int) num3 % 60;
                      string s5 = num1.ToString();
                      byte[] bytes7 = ascii5.GetBytes(s5);
                      optionClass6.OptionData = bytes7;
                    }
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "TimeZone":
                    string str3 = type.GetProperty(name1).GetValue(obj1, (object[]) null).ToString().Trim();
                    byte[] numArray6 = new byte[1];
                    for (byte index2 = (byte) 0; (int) index2 < Program.arytimezone.Length; ++index2)
                    {
                      if (Program.arytimezone[(int) index2] == str3)
                      {
                        numArray6[0] = index2;
                        break;
                      }
                    }
                    optionClass1.OptionData = numArray6;
                    optionClass1.createOption();
                    DataListManger.AddOption(optionClass1, ip, (byte) 1);
                    continue;
                  case "BaudRate":
                    uint num4 = (uint) type.GetProperty(name1).GetValue(obj1, (object[]) null);
                    bool flag3 = false;
                    byte num5;
                    for (num5 = (byte) 0; (int) num5 < Channel.BaudRateArray.Length; ++num5)
                    {
                      if (num4.Equals(Channel.BaudRateArray[(int) num5]))
                      {
                        flag3 = true;
                        break;
                      }
                    }
                    if (flag3)
                    {
                      byte[] numArray5 = new byte[1]
                      {
                        num5
                      };
                      optionClass1.OptionData = numArray5;
                      optionClass1.createOption();
                      DataListManger.AddOption(optionClass1, ip, (byte) 1);
                      continue;
                    }
                    continue;
                  case "Collection":
                    string[] strArray4 = name1.Split("_".ToCharArray());
                    PropertyInfo property6 = type.GetProperty(strArray4[0]);
                    switch (strArray4[1])
                    {
                      case "a":
                        HostCollection hostCollection2 = (HostCollection) property6.GetValue(obj1, (object[]) null);
                        if (hostCollection2.Count >= int.Parse(strArray4[2]))
                        {
                          optionClass1.OptionData = Encoding.ASCII.GetBytes(hostCollection2[int.Parse(strArray4[2]) - 1].IpAddress);
                          optionClass1.createOption();
                          DataListManger.AddOption(optionClass1, ip, (byte) 1);
                          continue;
                        }
                        continue;
                      case "p":
                        object obj7 = property6.GetValue(obj1, (object[]) null);
                        if (obj7 is HostCollection)
                        {
                          if (((HostCollection) obj7).Count >= int.Parse(strArray4[2]))
                          {
                            optionClass1.OptionData = Encoding.ASCII.GetBytes(((HostCollection) obj7)[int.Parse(strArray4[2]) - 1].Port.ToString());
                            optionClass1.createOption();
                            DataListManger.AddOption(optionClass1, ip, (byte) 1);
                            continue;
                          }
                          continue;
                        }
                        if (obj7 is UDPDevCollection && ((UDPDevCollection) obj7).Count >= int.Parse(strArray4[2]))
                        {
                          optionClass1.OptionData = Encoding.ASCII.GetBytes(((UDPDevCollection) obj7)[int.Parse(strArray4[2]) - 1].Port.ToString());
                          optionClass1.createOption();
                          DataListManger.AddOption(optionClass1, ip, (byte) 1);
                          continue;
                        }
                        continue;
                      case "ba":
                        UDPDevCollection udpDevCollection3 = (UDPDevCollection) property6.GetValue(obj1, (object[]) null);
                        if (udpDevCollection3.Count >= int.Parse(strArray4[2]))
                        {
                          optionClass1.OptionData = Encoding.ASCII.GetBytes(udpDevCollection3[int.Parse(strArray4[2]) - 1].BeginIPAddress.ToString());
                          optionClass1.createOption();
                          DataListManger.AddOption(optionClass1, ip, (byte) 1);
                          continue;
                        }
                        continue;
                      case "ea":
                        UDPDevCollection udpDevCollection4 = (UDPDevCollection) property6.GetValue(obj1, (object[]) null);
                        if (udpDevCollection4.Count >= int.Parse(strArray4[2]))
                        {
                          optionClass1.OptionData = Encoding.ASCII.GetBytes(udpDevCollection4[int.Parse(strArray4[2]) - 1].EndIPAddress.ToString());
                          optionClass1.createOption();
                          DataListManger.AddOption(optionClass1, ip, (byte) 1);
                          continue;
                        }
                        continue;
                      default:
                        continue;
                    }
                  default:
                    continue;
                }
              }
            }
          }
        }
        ResponseTypes responseTypes1;
        ResponseTypes responseTypes2;
        ResponseTypes responseTypes3;
        do
        {
          int num = (int) Controller.GetNewCommandID();
          FrameClass sendCommand = new FrameClass((byte) 1, Controller.currentCommandID, ip, currentDevice.CommunicationType);
          if (sendCommand.OptionList != null)
          {
            responseTypes1 = Controller.CheckResponseControlType(CommunicationClass.SendAndReceive(sendCommand, currentDevice.workBatman));
            switch (responseTypes1)
            {
              case ResponseTypes.NoPermission:
                responseTypes2 = Controller.AuthUser(currentDevice);
                if (responseTypes2 == ResponseTypes.OK)
                {
                  responseTypes3 = Controller.CheckResponseControlType(CommunicationClass.SendAndReceive(sendCommand, currentDevice.workBatman));
                  continue;
                }
                goto label_122;
              case ResponseTypes.NoData:
                goto label_123;
              default:
                continue;
            }
          }
          else
            goto label_124;
        }
        while (responseTypes3 == ResponseTypes.OK);
        currentDevice.IsLogged = false;
        return responseTypes3;
label_122:
        currentDevice.IsLogged = false;
        return responseTypes2;
label_123:
        currentDevice.IsLogged = false;
        return responseTypes1;
label_124:
        return ResponseTypes.OK;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        message += ex.Message;
        return ResponseTypes.SystemError;
      }
      finally
      {
        DataListManger.ClearOption(currentDevice.IP, (byte) 1);
      }
    }

    public static ResponseTypes SetParameters(Device currentDevice, PanelTypes panelType, ref string message, byte ChannelID, bool isDevice)
    {
      return Controller.SetParameters(currentDevice, panelType, ref message, ChannelID, (byte) 0, isDevice);
    }

    public static ResponseTypes SetParameters(Device currentDevice, PanelTypes panelType, ref string message, byte ChannelID, byte index, bool isDevice)
    {
      try
      {
        string rowFilter = "Group='" + panelType.ToString() + "'";
        if (!isDevice)
        {
          bool flag = false;
          for (int index1 = 0; index1 < currentDevice.ChannelList.Count; ++index1)
          {
            if ((int) currentDevice.ChannelList[index1].GetChannelNum() == (int) ChannelID)
            {
              rowFilter = string.Concat(new object[4]
              {
                (object) rowFilter,
                (object) " and propertyName like'%@",
                (object) currentDevice.ChannelList[index1].GetCommunctionID(),
                (object) "'"
              });
              flag = true;
              break;
            }
          }
          if (!flag)
            rowFilter += " and propertyName like'%@-1'";
        }
        return Controller.SetParameters(ProtocolData.SelectFromDT(rowFilter, currentDevice.IsNewVersion), currentDevice, ref message, index);
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        Program.ShowMessage(ex.Message, true);
        return ResponseTypes.SystemError;
      }
    }

    public static void OptionMassage(ResponseTypes responseType)
    {
      switch (responseType)
      {
        case ResponseTypes.NoPermission:
          Program.ShowMessage(Message.NotLogin, true);
          break;
        case ResponseTypes.NoSupport:
          Program.ShowMessage(Message.NotCompatible, true);
          break;
        case ResponseTypes.ValueInvalid:
          Program.ShowMessage(Message.ParameterError, true);
          break;
        case ResponseTypes.AuthFail:
          Program.ShowMessage(Message.CheckError, true);
          break;
        case ResponseTypes.NoData:
          Program.ShowMessage(Message.DeviceNotAnswer, true);
          break;
        case ResponseTypes.UserFull:
          Program.ShowMessage(Message.UserFull, true);
          break;
        case ResponseTypes.ForbidConnect:
          Program.ShowMessage(Message.Nonsupport, true);
          break;
        case ResponseTypes.SystemError:
          Program.ShowMessage(Message.SystemError, true);
          break;
      }
    }
  }
}
