// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Channel
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System.Collections;
using System.ComponentModel;
using System.Net;

namespace DeviceManagement
{
  public class Channel
  {
    public static uint[] BaudRateArray = new uint[19]
    {
      110U,
      134U,
      150U,
      300U,
      600U,
      1200U,
      1800U,
      2400U,
      4800U,
      7200U,
      9600U,
      14400U,
      19200U,
      38400U,
      57600U,
      115200U,
      230400U,
      460800U,
      921600U
    };
    private Channel.enumNetProtocol m_netprotocol = Channel.enumNetProtocol.TCP;
    private Channel.enumAcceptionConnection m_acceptconn = Channel.enumAcceptionConnection.No;
    private string startcharacter = "";
    private string m_remotehost = "0.0.0.0";
    private IPAddress m_udpnetseg = IPAddress.Any;
    private UDPDevCollection m_udpdevcollection = new UDPDevCollection();
    private bool m_inputwithactiveconn = true;
    private bool m_inputwithpassconn = true;
    private bool m_inputattimeofdisconn = true;
    private bool m_outputwithactiveconn = true;
    private bool m_outputwithpassconn = true;
    private bool m_outputattimeofdisconn = true;
    private byte retrytimeout = (byte) 1;
    private BinaryOptions serialportoptions = BinaryOptions.Enable;
    private uint m_baudrate = 9600U;
    private Channel.DataBitsNum m_databits = Channel.DataBitsNum._8;
    private string m_fmatchbyte = "";
    private string m_lmatchbyte = "";
    public Device parent;
    public Hashtable Visibility;
    private byte channelID;
    private byte communctionID;
    public bool HostlistSetting;
    public bool SerialSetting;
    public bool ConnectionSetting;
    private Channel.enumTCPMode m_tcpmode;
    private Channel.enumActiveConnect m_activeconnect;
    private ushort m_localport;
    private ushort m_remoteport;
    private ushort m_DNSQueryPeriod;
    private Channel.enumConnectResponse m_connectresponse;
    private bool m_usehostlist;
    private bool m_DSRdrop;
    private bool m_checkeot;
    private bool m_harddisconn;
    private byte m_inactivitytime;
    private Channel.enumDatagramType m_datagramtype;
    private bool m_acceptincoming;
    private ushort m_udplocalport;
    private ushort m_udpremoteport;
    private ushort m_udpunilocalport;
    private byte retrycnt;
    private HostCollection hostcollection;
    private BinaryOptions enableBackupLink;
    private Channel.ProtocolType m_serialportprotocol;
    private Channel.FIFO_Depth m_fifo;
    private Channel.enuFlowControl m_flowcontrol;
    private Channel.enuParity m_parity;
    private Channel.StopBitsNum m_stopbits;
    private bool m_packcontrol;
    private Channel.IdleGapTimeNum m_idlegaptime;
    private bool m_match2byteseq;
    private bool m_sendframeonly;
    private Channel.enuSendTrailingByte m_sendtrailingbyte;

    public Channel.enumNetProtocol NetProtocol
    {
      get
      {
        return this.m_netprotocol;
      }
      set
      {
        this.m_netprotocol = value;
      }
    }

    public Channel.enumTCPMode TCPMode
    {
      get
      {
        return this.m_tcpmode;
      }
      set
      {
        this.m_tcpmode = value;
      }
    }

    public Channel.enumAcceptionConnection AcceptionIncoming
    {
      get
      {
        return this.m_acceptconn;
      }
      set
      {
        this.m_acceptconn = value;
      }
    }

    public Channel.enumActiveConnect ActiveConnect
    {
      get
      {
        return this.m_activeconnect;
      }
      set
      {
        this.m_activeconnect = value;
      }
    }

    public string StartCharacter
    {
      get
      {
        return this.startcharacter;
      }
      set
      {
        if (Program.CheckNumStr(value.Trim(), 2, 0, "x"))
        {
          this.startcharacter = value.Trim();
        }
        else
        {
          this.parent.AddMessage(Message.MustHex, "StartCharacter");
          this.parent.IsChecked = false;
        }
      }
    }

    public ushort LocalPort
    {
      get
      {
        return this.m_localport;
      }
      set
      {
        this.m_localport = value;
      }
    }

    public ushort RemotePort
    {
      get
      {
        return this.m_remoteport;
      }
      set
      {
        this.m_remoteport = value;
      }
    }

    public string RemoteHost
    {
      get
      {
        return this.m_remotehost;
      }
      set
      {
        if (this.canDNS())
          this.parent.IsChecked = this.parent.IsChecked && Program.CheckStr("RemoteHost", ref this.m_remotehost, value, this.parent);
        else if (value.Trim().Length == 0)
          this.m_remotehost = "0.0.0.0";
        else if (Program.CheckIpStr(value))
        {
          this.m_remotehost = value;
        }
        else
        {
          this.parent.AddMessage(Message.InvalidIP, "RemoteHost");
          this.parent.IsChecked = false;
        }
        this.parent.IsChecked = this.parent.IsChecked && Program.CheckStr("RemoteHost", ref this.m_remotehost, value, this.parent);
      }
    }

    public ushort DNSQueryPeriod
    {
      get
      {
        return this.m_DNSQueryPeriod;
      }
      set
      {
        this.m_DNSQueryPeriod = value;
      }
    }

    public Channel.enumConnectResponse ConnectResponse
    {
      get
      {
        return this.m_connectresponse;
      }
      set
      {
        this.m_connectresponse = value;
      }
    }

    public bool UseHostlist
    {
      get
      {
        return this.m_usehostlist;
      }
      set
      {
        this.m_usehostlist = value;
      }
    }

    public bool OnDSRDrop
    {
      get
      {
        return this.m_DSRdrop;
      }
      set
      {
        this.m_DSRdrop = value;
      }
    }

    public bool CheckEOT
    {
      get
      {
        return this.m_checkeot;
      }
      set
      {
        this.m_checkeot = value;
      }
    }

    public bool HardDisconnect
    {
      get
      {
        return this.m_harddisconn;
      }
      set
      {
        this.m_harddisconn = value;
      }
    }

    public byte InactivityTimeout
    {
      get
      {
        return this.m_inactivitytime;
      }
      set
      {
        this.m_inactivitytime = value;
      }
    }

    public Channel.enumDatagramType DatagramType
    {
      get
      {
        return this.m_datagramtype;
      }
      set
      {
        this.m_datagramtype = value;
      }
    }

    public bool AcceptIncoming
    {
      get
      {
        return this.m_acceptincoming;
      }
      set
      {
        this.m_acceptincoming = value;
      }
    }

    public ushort UDPLocalPort
    {
      get
      {
        return this.m_udplocalport;
      }
      set
      {
        this.m_udplocalport = value;
      }
    }

    public ushort UDPRemotePort
    {
      get
      {
        return this.m_udpremoteport;
      }
      set
      {
        this.m_udpremoteport = value;
      }
    }

    public IPAddress UDPNetSegment
    {
      get
      {
        return this.m_udpnetseg;
      }
      set
      {
        this.m_udpnetseg = value;
      }
    }

    public UDPDevCollection DeviceAddressTable
    {
      get
      {
        return this.m_udpdevcollection;
      }
    }

    public ushort UDPUniCastLocalPort
    {
      get
      {
        return this.m_udpunilocalport;
      }
      set
      {
        this.m_udpunilocalport = value;
      }
    }

    public bool InputWithActiveConnect
    {
      get
      {
        return this.m_inputwithactiveconn;
      }
      set
      {
        this.m_inputwithactiveconn = value;
      }
    }

    public bool InputWithPassiveConnect
    {
      get
      {
        return this.m_inputwithpassconn;
      }
      set
      {
        this.m_inputwithpassconn = value;
      }
    }

    public bool InputAtTimeofDisconnect
    {
      get
      {
        return this.m_inputattimeofdisconn;
      }
      set
      {
        this.m_inputattimeofdisconn = value;
      }
    }

    public bool OutputWithActiveConnect
    {
      get
      {
        return this.m_outputwithactiveconn;
      }
      set
      {
        this.m_outputwithactiveconn = value;
      }
    }

    public bool OutputWithPassiveConnect
    {
      get
      {
        return this.m_outputwithpassconn;
      }
      set
      {
        this.m_outputwithpassconn = value;
      }
    }

    public bool OutputAtTimeofDisconnect
    {
      get
      {
        return this.m_outputattimeofdisconn;
      }
      set
      {
        this.m_outputattimeofdisconn = value;
      }
    }

    public byte RetryCounter
    {
      get
      {
        return this.retrycnt;
      }
      set
      {
        this.retrycnt = value;
      }
    }

    public byte RetryTimeout
    {
      get
      {
        return this.retrytimeout;
      }
      set
      {
        this.retrytimeout = value;
      }
    }

    public HostCollection HostList
    {
      get
      {
        return this.hostcollection;
      }
    }

    public BinaryOptions EnableBackupLink
    {
      get
      {
        return this.enableBackupLink;
      }
      set
      {
        this.enableBackupLink = value;
      }
    }

    public BinaryOptions SerialPortOptions
    {
      get
      {
        return this.serialportoptions;
      }
      set
      {
        this.serialportoptions = value;
      }
    }

    public Channel.ProtocolType SerialPortProtocol
    {
      get
      {
        return this.m_serialportprotocol;
      }
      set
      {
        this.m_serialportprotocol = value;
      }
    }

    public Channel.FIFO_Depth FIFO
    {
      get
      {
        return this.m_fifo;
      }
      set
      {
        this.m_fifo = value;
      }
    }

    public Channel.enuFlowControl FlowControl
    {
      get
      {
        return this.m_flowcontrol;
      }
      set
      {
        this.m_flowcontrol = value;
      }
    }

    public uint BaudRate
    {
      get
      {
        return this.m_baudrate;
      }
      set
      {
        this.m_baudrate = value;
      }
    }

    public Channel.DataBitsNum DataBits
    {
      get
      {
        return this.m_databits;
      }
      set
      {
        this.m_databits = value;
      }
    }

    public Channel.enuParity Parity
    {
      get
      {
        return this.m_parity;
      }
      set
      {
        this.m_parity = value;
      }
    }

    public Channel.StopBitsNum StopBits
    {
      get
      {
        return this.m_stopbits;
      }
      set
      {
        this.m_stopbits = value;
      }
    }

    public bool EnablePacking
    {
      get
      {
        return this.m_packcontrol;
      }
      set
      {
        this.m_packcontrol = value;
      }
    }

    public Channel.IdleGapTimeNum IdleGapTime
    {
      get
      {
        return this.m_idlegaptime;
      }
      set
      {
        this.m_idlegaptime = value;
      }
    }

    public bool Match2ByteSequence
    {
      get
      {
        return this.m_match2byteseq;
      }
      set
      {
        this.m_match2byteseq = value;
      }
    }

    public string FirstMatchByte
    {
      get
      {
        return this.m_fmatchbyte;
      }
      set
      {
        if (Program.CheckNumStr(value.Trim(), 2, 0, "x"))
        {
          this.m_fmatchbyte = value.Trim();
        }
        else
        {
          this.parent.AddMessage(Message.MustHex, "FirstMatchByte");
          this.parent.IsChecked = false;
        }
      }
    }

    public string LastMatchByte
    {
      get
      {
        return this.m_lmatchbyte;
      }
      set
      {
        if (Program.CheckNumStr(value.Trim(), 2, 0, "x"))
        {
          this.m_lmatchbyte = value.Trim();
        }
        else
        {
          this.parent.AddMessage(Message.MustHex, "LastMatchByte");
          this.parent.IsChecked = false;
        }
      }
    }

    public bool SendFrameOnly
    {
      get
      {
        return this.m_sendframeonly;
      }
      set
      {
        this.m_sendframeonly = value;
      }
    }

    public Channel.enuSendTrailingByte SendTrailingBytes
    {
      get
      {
        return this.m_sendtrailingbyte;
      }
      set
      {
        this.m_sendtrailingbyte = value;
      }
    }

    public Channel(Device parent, byte channelID, byte communctionID)
    {
      this.communctionID = communctionID;
      this.parent = parent;
      this.channelID = channelID;
      this.hostcollection = new HostCollection(this.canDNS(), parent);
      PropertyDescriptorCollection properties = TypeDescriptor.GetProperties((object) this);
      this.Visibility = new Hashtable(properties.Count);
      for (int index = 0; index < properties.Count; ++index)
        this.Visibility.Add((object) properties[index].Name, (object) false);
    }

    public byte GetChannelNum()
    {
      return this.channelID;
    }

    public byte GetCommunctionID()
    {
      return this.communctionID;
    }

    public string getChannelName()
    {
      if ((int) this.channelID == 0)
        return "2";
      return this.channelID.ToString();
    }

    public static byte getChannelID(string channelName)
    {
      if (channelName == "2")
        return (byte) 0;
      return byte.Parse(channelName);
    }

    public byte GetComID()
    {
      if ((int) this.channelID == 0)
        return (byte) 2;
      return this.channelID;
    }

    internal bool ComIsUsed()
    {
      return this.parent.CanPPP && this.parent.PPP && (this.parent.PPPWorkMode != Device.PPPOEWorkModes.Disable && (int) this.GetComID() == (int) this.parent.PPPComID) || this.parent.CanGPRS && this.parent.GPRS && (this.parent.GPRSWorkMode != Device.PPPOEWorkModes.Disable && (int) this.GetComID() == (int) this.parent.GPRSComID);
    }

    public object Clone()
    {
      return this.MemberwiseClone();
    }

    internal bool canDNS()
    {
      if ((int) this.channelID == 0 && this.parent.Com0CanDNS || (int) this.channelID == 1 && this.parent.Com1CanDNS || ((int) this.channelID == 3 && this.parent.Com3CanDNS || (int) this.channelID == 4 && this.parent.Com4CanDNS) || ((int) this.channelID == 5 && this.parent.Com5CanDNS || (int) this.channelID == 6 && this.parent.Com6CanDNS || ((int) this.channelID == 7 && this.parent.Com7CanDNS || (int) this.channelID == 8 && this.parent.Com8CanDNS)) || ((int) this.channelID == 9 && this.parent.Com9CanDNS || (int) this.channelID == 10 && this.parent.Com10CanDNS || ((int) this.channelID == 11 && this.parent.Com11CanDNS || (int) this.channelID == 12 && this.parent.Com12CanDNS) || ((int) this.channelID == 13 && this.parent.Com13CanDNS || (int) this.channelID == 14 && this.parent.Com14CanDNS || ((int) this.channelID == 15 && this.parent.Com15CanDNS || (int) this.channelID == 16 && this.parent.Com16CanDNS))) || ((int) this.channelID == 17 && this.parent.Com17CanDNS || (int) this.channelID == 18 && this.parent.Com18CanDNS || ((int) this.channelID == 19 && this.parent.Com19CanDNS || (int) this.channelID == 20 && this.parent.Com20CanDNS) || ((int) this.channelID == 21 && this.parent.Com21CanDNS || (int) this.channelID == 22 && this.parent.Com22CanDNS || ((int) this.channelID == 23 && this.parent.Com23CanDNS || (int) this.channelID == 24 && this.parent.Com24CanDNS)) || ((int) this.channelID == 25 && this.parent.Com25CanDNS || (int) this.channelID == 26 && this.parent.Com26CanDNS || ((int) this.channelID == 27 && this.parent.Com27CanDNS || (int) this.channelID == 28 && this.parent.Com28CanDNS) || ((int) this.channelID == 29 && this.parent.Com29CanDNS || (int) this.channelID == 30 && this.parent.Com30CanDNS || (int) this.channelID == 31 && this.parent.Com31CanDNS))))
        return true;
      if ((int) this.channelID == 32)
        return this.parent.Com32CanDNS;
      return false;
    }

    internal bool canRS232()
    {
      if ((int) this.channelID == 0 && this.parent.Com0CanRS232 || (int) this.channelID == 1 && this.parent.Com1CanRS232 || ((int) this.channelID == 3 && this.parent.Com3CanRS232 || (int) this.channelID == 4 && this.parent.Com4CanRS232) || ((int) this.channelID == 5 && this.parent.Com5CanRS232 || (int) this.channelID == 6 && this.parent.Com6CanRS232 || ((int) this.channelID == 7 && this.parent.Com7CanRS232 || (int) this.channelID == 8 && this.parent.Com8CanRS232)) || ((int) this.channelID == 9 && this.parent.Com9CanRS232 || (int) this.channelID == 10 && this.parent.Com10CanRS232 || ((int) this.channelID == 11 && this.parent.Com11CanRS232 || (int) this.channelID == 12 && this.parent.Com12CanRS232) || ((int) this.channelID == 13 && this.parent.Com13CanRS232 || (int) this.channelID == 14 && this.parent.Com14CanRS232 || ((int) this.channelID == 15 && this.parent.Com15CanRS232 || (int) this.channelID == 16 && this.parent.Com16CanRS232))) || ((int) this.channelID == 17 && this.parent.Com17CanRS232 || (int) this.channelID == 18 && this.parent.Com18CanRS232 || ((int) this.channelID == 19 && this.parent.Com19CanRS232 || (int) this.channelID == 20 && this.parent.Com20CanRS232) || ((int) this.channelID == 21 && this.parent.Com21CanRS232 || (int) this.channelID == 22 && this.parent.Com22CanRS232 || ((int) this.channelID == 23 && this.parent.Com23CanRS232 || (int) this.channelID == 24 && this.parent.Com24CanRS232)) || ((int) this.channelID == 25 && this.parent.Com25CanRS232 || (int) this.channelID == 26 && this.parent.Com26CanRS232 || ((int) this.channelID == 27 && this.parent.Com27CanRS232 || (int) this.channelID == 28 && this.parent.Com28CanRS232) || ((int) this.channelID == 29 && this.parent.Com29CanRS232 || (int) this.channelID == 30 && this.parent.Com30CanRS232 || (int) this.channelID == 31 && this.parent.Com31CanRS232))))
        return true;
      if ((int) this.channelID == 32)
        return this.parent.Com32CanRS232;
      return false;
    }

    internal bool canRS422()
    {
      if ((int) this.channelID == 0 && this.parent.Com0CanRS422 || (int) this.channelID == 1 && this.parent.Com1CanRS422 || ((int) this.channelID == 3 && this.parent.Com3CanRS422 || (int) this.channelID == 4 && this.parent.Com4CanRS422) || ((int) this.channelID == 5 && this.parent.Com5CanRS422 || (int) this.channelID == 6 && this.parent.Com6CanRS422 || ((int) this.channelID == 7 && this.parent.Com7CanRS422 || (int) this.channelID == 8 && this.parent.Com8CanRS422)) || ((int) this.channelID == 9 && this.parent.Com9CanRS422 || (int) this.channelID == 10 && this.parent.Com10CanRS422 || ((int) this.channelID == 11 && this.parent.Com11CanRS422 || (int) this.channelID == 12 && this.parent.Com12CanRS422) || ((int) this.channelID == 13 && this.parent.Com13CanRS422 || (int) this.channelID == 14 && this.parent.Com14CanRS422 || ((int) this.channelID == 15 && this.parent.Com15CanRS422 || (int) this.channelID == 16 && this.parent.Com16CanRS422))) || ((int) this.channelID == 17 && this.parent.Com17CanRS422 || (int) this.channelID == 18 && this.parent.Com18CanRS422 || ((int) this.channelID == 19 && this.parent.Com19CanRS422 || (int) this.channelID == 20 && this.parent.Com20CanRS422) || ((int) this.channelID == 21 && this.parent.Com21CanRS422 || (int) this.channelID == 22 && this.parent.Com22CanRS422 || ((int) this.channelID == 23 && this.parent.Com23CanRS422 || (int) this.channelID == 24 && this.parent.Com24CanRS422)) || ((int) this.channelID == 25 && this.parent.Com25CanRS422 || (int) this.channelID == 26 && this.parent.Com26CanRS422 || ((int) this.channelID == 27 && this.parent.Com27CanRS422 || (int) this.channelID == 28 && this.parent.Com28CanRS422) || ((int) this.channelID == 29 && this.parent.Com29CanRS422 || (int) this.channelID == 30 && this.parent.Com30CanRS422 || (int) this.channelID == 31 && this.parent.Com31CanRS422))))
        return true;
      if ((int) this.channelID == 32)
        return this.parent.Com32CanRS422;
      return false;
    }

    internal bool canRS485()
    {
      if ((int) this.channelID == 0 && this.parent.Com0CanRS485 || (int) this.channelID == 1 && this.parent.Com1CanRS485 || ((int) this.channelID == 3 && this.parent.Com3CanRS485 || (int) this.channelID == 4 && this.parent.Com4CanRS485) || ((int) this.channelID == 5 && this.parent.Com5CanRS485 || (int) this.channelID == 6 && this.parent.Com6CanRS485 || ((int) this.channelID == 7 && this.parent.Com7CanRS485 || (int) this.channelID == 8 && this.parent.Com8CanRS485)) || ((int) this.channelID == 9 && this.parent.Com9CanRS485 || (int) this.channelID == 10 && this.parent.Com10CanRS485 || ((int) this.channelID == 11 && this.parent.Com11CanRS485 || (int) this.channelID == 12 && this.parent.Com12CanRS485) || ((int) this.channelID == 13 && this.parent.Com13CanRS485 || (int) this.channelID == 14 && this.parent.Com14CanRS485 || ((int) this.channelID == 15 && this.parent.Com15CanRS485 || (int) this.channelID == 16 && this.parent.Com16CanRS485))) || ((int) this.channelID == 17 && this.parent.Com17CanRS485 || (int) this.channelID == 18 && this.parent.Com18CanRS485 || ((int) this.channelID == 19 && this.parent.Com19CanRS485 || (int) this.channelID == 20 && this.parent.Com20CanRS485) || ((int) this.channelID == 21 && this.parent.Com21CanRS485 || (int) this.channelID == 22 && this.parent.Com22CanRS485 || ((int) this.channelID == 23 && this.parent.Com23CanRS485 || (int) this.channelID == 24 && this.parent.Com24CanRS485)) || ((int) this.channelID == 25 && this.parent.Com25CanRS485 || (int) this.channelID == 26 && this.parent.Com26CanRS485 || ((int) this.channelID == 27 && this.parent.Com27CanRS485 || (int) this.channelID == 28 && this.parent.Com28CanRS485) || ((int) this.channelID == 29 && this.parent.Com29CanRS485 || (int) this.channelID == 30 && this.parent.Com30CanRS485 || (int) this.channelID == 31 && this.parent.Com31CanRS485))))
        return true;
      if ((int) this.channelID == 32)
        return this.parent.Com32CanRS485;
      return false;
    }

    internal bool canModen()
    {
      if ((int) this.channelID == 0 && this.parent.Com0CanModem || (int) this.channelID == 1 && this.parent.Com1CanModem || ((int) this.channelID == 3 && this.parent.Com3CanModem || (int) this.channelID == 4 && this.parent.Com4CanModem) || ((int) this.channelID == 5 && this.parent.Com5CanModem || (int) this.channelID == 6 && this.parent.Com6CanModem || ((int) this.channelID == 7 && this.parent.Com7CanModem || (int) this.channelID == 8 && this.parent.Com8CanModem)) || ((int) this.channelID == 9 && this.parent.Com9CanModem || (int) this.channelID == 10 && this.parent.Com10CanModem || ((int) this.channelID == 11 && this.parent.Com11CanModem || (int) this.channelID == 12 && this.parent.Com12CanModem) || ((int) this.channelID == 13 && this.parent.Com13CanModem || (int) this.channelID == 14 && this.parent.Com14CanModem || ((int) this.channelID == 15 && this.parent.Com15CanModem || (int) this.channelID == 16 && this.parent.Com16CanModem))) || ((int) this.channelID == 17 && this.parent.Com17CanModem || (int) this.channelID == 18 && this.parent.Com18CanModem || ((int) this.channelID == 19 && this.parent.Com19CanModem || (int) this.channelID == 20 && this.parent.Com20CanModem) || ((int) this.channelID == 21 && this.parent.Com21CanModem || (int) this.channelID == 22 && this.parent.Com22CanModem || ((int) this.channelID == 23 && this.parent.Com23CanModem || (int) this.channelID == 24 && this.parent.Com24CanModem)) || ((int) this.channelID == 25 && this.parent.Com25CanModem || (int) this.channelID == 26 && this.parent.Com26CanModem || ((int) this.channelID == 27 && this.parent.Com27CanModem || (int) this.channelID == 28 && this.parent.Com28CanModem) || ((int) this.channelID == 29 && this.parent.Com29CanModem || (int) this.channelID == 30 && this.parent.Com30CanModem || (int) this.channelID == 31 && this.parent.Com31CanModem))))
        return true;
      if ((int) this.channelID == 32)
        return this.parent.Com32CanModem;
      return false;
    }

    public enum enumNetProtocol
    {
      UDP,
      TCP,
    }

    public enum enumTCPMode
    {
      Client,
      Server,
      Both,
    }

    public enum enumAcceptionConnection
    {
      Yes,
      No,
    }

    public enum enumActiveConnect
    {
      None,
      WithAnyCharacter,
      WithStartCharacter,
      AutoStart,
    }

    public enum enumConnectResponse
    {
      None,
      ACT,
    }

    public enum enumDatagramType
    {
      Uni_Cast,
      Multi_Cast,
    }

    public enum ProtocolType
    {
      RS232,
      RS422,
      RS485,
    }

    public enum FIFO_Depth
    {
      _14,
      _8,
      _4,
    }

    public enum enuFlowControl
    {
      None,
      Software,
      Hardware,
    }

    public enum DataBitsNum
    {
      _5,
      _6,
      _7,
      _8,
    }

    public enum enuParity
    {
      NONE,
      ODD,
      EVEN,
      MARK,
      SPACE,
    }

    public enum StopBitsNum
    {
      _1,
      _1_5,
      _2,
    }

    public enum IdleGapTimeNum
    {
      _12msec,
      _11msec,
      _10msec,
    }

    public enum enuSendTrailingByte
    {
      None,
      One,
      Two,
    }
  }
}
