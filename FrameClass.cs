// Decompiled with JetBrains decompiler
// Type: DeviceManagement.FrameClass
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.Collections.Generic;
using System.Net;

namespace DeviceManagement
{
  public class FrameClass
  {
    private byte commandOrResponse = (byte) 1;
    private IPAddress ipAddr = IPAddress.None;
    private List<OptionClass> optionList = new List<OptionClass>();
    private byte[] frame;
    private byte controlType;
    private byte identifier;
    private ushort length;
    private ushort maxLength;
    private Batman workBatman;
    private CommunicationTypes commType;

    public Batman WorkBatman
    {
      get
      {
        return this.workBatman;
      }
    }

    public byte[] Frame
    {
      get
      {
        return this.frame;
      }
      set
      {
        this.frame = value;
      }
    }

    public byte CommandOrResponse
    {
      get
      {
        return this.commandOrResponse;
      }
    }

    public byte ControlType
    {
      get
      {
        return this.controlType;
      }
      set
      {
        this.controlType = value;
      }
    }

    public byte Identifier
    {
      get
      {
        return this.identifier;
      }
      set
      {
        this.identifier = value;
      }
    }

    public ushort Length
    {
      get
      {
        return this.length;
      }
    }

    public ushort MaxLength
    {
      get
      {
        return this.maxLength;
      }
    }

    public IPAddress IpAddr
    {
      get
      {
        return this.ipAddr;
      }
    }

    public IPAddress CommIP
    {
      get
      {
        switch (this.commType)
        {
          case CommunicationTypes.UDP:
            return this.ipAddr;
          case CommunicationTypes.Broadcast:
            return IPAddress.Broadcast;
          default:
            return (IPAddress) null;
        }
      }
    }

    public List<OptionClass> OptionList
    {
      get
      {
        return this.optionList;
      }
      set
      {
        this.optionList = value;
      }
    }

    public FrameClass(byte commandControlType, byte commandIdentifier, IPAddress commandIPAddr, CommunicationTypes commType)
    {
      this.controlType = commandControlType;
      this.identifier = commandIdentifier;
      this.ipAddr = commandIPAddr;
      this.commType = commType;
      switch (commType)
      {
        case CommunicationTypes.UDP:
          this.length = (ushort) 4;
          this.maxLength = (ushort) 4;
          break;
        case CommunicationTypes.Broadcast:
          this.length = (ushort) 8;
          this.maxLength = (ushort) 8;
          break;
      }
      this.optionList = DataListManger.ReadOptionQueueForCommand(this.ipAddr, commandControlType, ref this.length, ref this.maxLength);
      this.frame = new byte[(int) this.length];
      this.createCommand();
    }

    public FrameClass(byte[] response, IPAddress responseIPAddr, Batman workBatman)
    {
      this.frame = response;
      this.commandOrResponse = (byte) 0;
      this.ipAddr = responseIPAddr;
      this.workBatman = workBatman;
      this.readResponse(Program.mainForm.GetDeviceVersion(this.ipAddr, workBatman));
    }

    internal static int getInterIP(IPAddress ip)
    {
      return IPAddress.HostToNetworkOrder((int) ip.Address);
    }

    private void createCommand()
    {
      this.frame[1] = this.identifier;
      ushort num1 = (ushort) 4;
      switch (this.commType)
      {
        case CommunicationTypes.UDP:
          this.frame[0] = (byte) ((uint) this.commandOrResponse + (uint) this.controlType * 2U);
          break;
        case CommunicationTypes.Broadcast:
          int interIp = FrameClass.getInterIP(this.ipAddr);
          byte[] numArray1 = this.frame;
          int index1 = (int) num1;
          int num2 = 1;
          ushort num3 = (ushort) (index1 + num2);
          int num4 = (int) (byte) (interIp >> 24);
          numArray1[index1] = (byte) num4;
          byte[] numArray2 = this.frame;
          int index2 = (int) num3;
          int num5 = 1;
          ushort num6 = (ushort) (index2 + num5);
          int num7 = (int) (byte) (interIp >> 16);
          numArray2[index2] = (byte) num7;
          byte[] numArray3 = this.frame;
          int index3 = (int) num6;
          int num8 = 1;
          ushort num9 = (ushort) (index3 + num8);
          int num10 = (int) (byte) (interIp >> 8);
          numArray3[index3] = (byte) num10;
          byte[] numArray4 = this.frame;
          int index4 = (int) num9;
          int num11 = 1;
          num1 = (ushort) (index4 + num11);
          int num12 = (int) (byte) interIp;
          numArray4[index4] = (byte) num12;
          this.frame[0] = (byte) ((int) this.commandOrResponse + (int) this.controlType * 2 + 128);
          break;
        default:
          return;
      }
      if (this.optionList != null)
      {
        for (int index5 = 0; index5 < this.optionList.Count; ++index5)
        {
          if (this.optionList[index5].Option != null)
            Array.Copy((Array) this.optionList[index5].Option, 0, (Array) this.frame, (int) num1, (int) this.optionList[index5].Length);
          num1 += (ushort) this.optionList[index5].Length;
        }
      }
      this.frame[2] = (byte) Math.Floor((double) this.length / 256.0);
      this.frame[3] = (byte) ((uint) this.length % 256U);
      if (this.frame.Length != (int) this.length)
      {
        Program.ShowMessage("Command字节数组编码,装配有误，请调试代码！", true);
      }
      else
      {
        if ((int) this.maxLength <= (int) byte.MaxValue)
          return;
        Program.ShowMessage("Command字节数组编码,装配超长，请调试代码！", true);
      }
    }

    private void readResponse(bool isNewVersion)
    {
      this.controlType = (byte) (((int) this.frame[0] - (int) this.commandOrResponse) / 2);
      this.identifier = this.frame[1];
      this.length = BitConverter.ToUInt16(new byte[2]
      {
        this.frame[3],
        this.frame[2]
      }, 0);
      this.maxLength = (ushort) 4;
      int num1 = 4;
      while (num1 < this.frame.Length)
      {
        byte num2 = this.frame[num1 + 2];
        byte[] responseOption = new byte[(int) num2];
        for (int index = 0; index < (int) num2; ++index)
          responseOption[index] = this.frame[num1 + index];
        OptionClass optionClass = new OptionClass(responseOption, isNewVersion);
        this.optionList.Add(optionClass);
        this.maxLength = (ushort) ((uint) this.maxLength + (uint) optionClass.MaxLength);
        num1 += (int) num2;
      }
      if (this.frame.Length == (int) this.length)
        return;
      Program.ShowMessage("response字节数组编码有误，请申请重发！", true);
    }

    public void RefreshReadResponse(bool isNewVersion)
    {
      for (int index = 0; index < this.optionList.Count; ++index)
        this.optionList[index].RefreshOption(isNewVersion);
    }
  }
}
