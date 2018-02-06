// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Device
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Net;
using System.Resources;

namespace DeviceManagement
{
  public class Device
  {
    public CommunicationTypes CommunicationType = CommunicationTypes.Broadcast;
    public string lastPanelType = "Basic Setting";
    private string interMsg = "";
    private bool isChecked = true;
    private ChannelCollection channelList = new ChannelCollection();
    private DateTime localTime = DateTime.Now;
    private string timeserver = "";
    private string timezone = "";
    private string m_terminalmame = string.Empty;
    private Device.IPManner ipcfgmannner = Device.IPManner.Automatically;
    private string dhcpname = string.Empty;
    private IPAddress ipaddress = IPAddress.Any;
    private IPAddress subnet = IPAddress.Any;
    private IPAddress defaultgateway = IPAddress.Any;
    private IPAddress prefdnssvr = IPAddress.Any;
    private IPAddress alterdnssvr = IPAddress.Any;
    private bool autoneg = true;
    private Device.NetSpeed speed = Device.NetSpeed._100Mbps;
    public Device.NetDuplex duplex = Device.NetDuplex.Full;
    private string mac = "00:00:00:00:00:00";
    private bool nt_ethernet = true;
    private bool nt_ppp = true;
    private bool nt_pppoe = true;
    private bool nt_GPRS = true;
    private byte arpcachtime = (byte) 60;
    private BinaryOptions monibtup = BinaryOptions.Enable;
    private Device.PerformanceMode cpuperformancemode = Device.PerformanceMode.Regular;
    private ushort httpport = (ushort) 80;
    private ushort mtusize = (ushort) 1024;
    private string m_smtpdomainname = string.Empty;
    private ushort m_smtport = (ushort) 25;
    private string m_emailaddress = string.Empty;
    private string m_emailusername = string.Empty;
    private string m_emailpwd = string.Empty;
    private string m_emailAddress1 = string.Empty;
    private string m_emailAddress2 = string.Empty;
    private string m_emailAddress3 = string.Empty;
    private string m_emailtrgsb = string.Empty;
    private Device.enumPriority m_priority = Device.enumPriority.Low;
    private string m_serialmatchdata1 = "";
    private string m_serialmatchdata2 = "";
    private string m_serialmatchdata3 = "";
    private string m_emailtrgmsg = string.Empty;
    private Device.enumPriority m_inputpriority = Device.enumPriority.Low;
    public const string DEFAULTOLDPASSWORD = "wrongPsw";
    public Hashtable Visibility;
    public Batman workBatman;
    public bool Can10M;
    public bool Can100M;
    public bool CanEmail;
    public bool CanPins;
    public bool Com0Enable;
    public bool Com0CanRS232;
    public bool Com0CanRS422;
    public bool Com0CanRS485;
    public bool Com0CanModem;
    public bool Com0CanDNS;
    public bool Com1Enable;
    public bool Com1CanRS232;
    public bool Com1CanRS422;
    public bool Com1CanRS485;
    public bool Com1CanModem;
    public bool Com1CanDNS;
    public bool Com0UseHimself;
    public bool CanPPPOE;
    public bool IsBig;
    public int BaudRateNum;
    public bool IsNewVersion;
    public bool CanPPP;
    public bool CanGPRS;
    public bool Com3Enable;
    public bool Com3CanModem;
    public bool Com3CanRS232;
    public bool Com3CanRS422;
    public bool Com3CanRS485;
    public bool Com3CanDNS;
    public bool Com4Enable;
    public bool Com4CanModem;
    public bool Com4CanRS232;
    public bool Com4CanRS422;
    public bool Com4CanRS485;
    public bool Com4CanDNS;
    public bool Com5Enable;
    public bool Com5CanModem;
    public bool Com5CanRS232;
    public bool Com5CanRS422;
    public bool Com5CanRS485;
    public bool Com5CanDNS;
    public bool Com6Enable;
    public bool Com6CanModem;
    public bool Com6CanRS232;
    public bool Com6CanRS422;
    public bool Com6CanRS485;
    public bool Com6CanDNS;
    public bool Com7Enable;
    public bool Com7CanModem;
    public bool Com7CanRS232;
    public bool Com7CanRS422;
    public bool Com7CanRS485;
    public bool Com7CanDNS;
    public bool Com8Enable;
    public bool Com8CanModem;
    public bool Com8CanRS232;
    public bool Com8CanRS422;
    public bool Com8CanRS485;
    public bool Com8CanDNS;
    public bool Com9Enable;
    public bool Com9CanModem;
    public bool Com9CanRS232;
    public bool Com9CanRS422;
    public bool Com9CanRS485;
    public bool Com9CanDNS;
    public bool Com10Enable;
    public bool Com10CanModem;
    public bool Com10CanRS232;
    public bool Com10CanRS422;
    public bool Com10CanRS485;
    public bool Com10CanDNS;
    public bool Com11Enable;
    public bool Com11CanModem;
    public bool Com11CanRS232;
    public bool Com11CanRS422;
    public bool Com11CanRS485;
    public bool Com11CanDNS;
    public bool Com12Enable;
    public bool Com12CanModem;
    public bool Com12CanRS232;
    public bool Com12CanRS422;
    public bool Com12CanRS485;
    public bool Com12CanDNS;
    public bool Com13Enable;
    public bool Com13CanModem;
    public bool Com13CanRS232;
    public bool Com13CanRS422;
    public bool Com13CanRS485;
    public bool Com13CanDNS;
    public bool Com14Enable;
    public bool Com14CanModem;
    public bool Com14CanRS232;
    public bool Com14CanRS422;
    public bool Com14CanRS485;
    public bool Com14CanDNS;
    public bool Com15Enable;
    public bool Com15CanModem;
    public bool Com15CanRS232;
    public bool Com15CanRS422;
    public bool Com15CanRS485;
    public bool Com15CanDNS;
    public bool Com16Enable;
    public bool Com16CanModem;
    public bool Com16CanRS232;
    public bool Com16CanRS422;
    public bool Com16CanRS485;
    public bool Com16CanDNS;
    public bool Com17Enable;
    public bool Com17CanModem;
    public bool Com17CanRS232;
    public bool Com17CanRS422;
    public bool Com17CanRS485;
    public bool Com17CanDNS;
    public bool Com18Enable;
    public bool Com18CanModem;
    public bool Com18CanRS232;
    public bool Com18CanRS422;
    public bool Com18CanRS485;
    public bool Com18CanDNS;
    public bool Com19Enable;
    public bool Com19CanModem;
    public bool Com19CanRS232;
    public bool Com19CanRS422;
    public bool Com19CanRS485;
    public bool Com19CanDNS;
    public bool Com20Enable;
    public bool Com20CanModem;
    public bool Com20CanRS232;
    public bool Com20CanRS422;
    public bool Com20CanRS485;
    public bool Com20CanDNS;
    public bool Com21Enable;
    public bool Com21CanModem;
    public bool Com21CanRS232;
    public bool Com21CanRS422;
    public bool Com21CanRS485;
    public bool Com21CanDNS;
    public bool Com22Enable;
    public bool Com22CanModem;
    public bool Com22CanRS232;
    public bool Com22CanRS422;
    public bool Com22CanRS485;
    public bool Com22CanDNS;
    public bool Com23Enable;
    public bool Com23CanModem;
    public bool Com23CanRS232;
    public bool Com23CanRS422;
    public bool Com23CanRS485;
    public bool Com23CanDNS;
    public bool Com24Enable;
    public bool Com24CanModem;
    public bool Com24CanRS232;
    public bool Com24CanRS422;
    public bool Com24CanRS485;
    public bool Com24CanDNS;
    public bool Com25Enable;
    public bool Com25CanModem;
    public bool Com25CanRS232;
    public bool Com25CanRS422;
    public bool Com25CanRS485;
    public bool Com25CanDNS;
    public bool Com26Enable;
    public bool Com26CanModem;
    public bool Com26CanRS232;
    public bool Com26CanRS422;
    public bool Com26CanRS485;
    public bool Com26CanDNS;
    public bool Com27Enable;
    public bool Com27CanModem;
    public bool Com27CanRS232;
    public bool Com27CanRS422;
    public bool Com27CanRS485;
    public bool Com27CanDNS;
    public bool Com28Enable;
    public bool Com28CanModem;
    public bool Com28CanRS232;
    public bool Com28CanRS422;
    public bool Com28CanRS485;
    public bool Com28CanDNS;
    public bool Com29Enable;
    public bool Com29CanModem;
    public bool Com29CanRS232;
    public bool Com29CanRS422;
    public bool Com29CanRS485;
    public bool Com29CanDNS;
    public bool Com30Enable;
    public bool Com30CanModem;
    public bool Com30CanRS232;
    public bool Com30CanRS422;
    public bool Com30CanRS485;
    public bool Com30CanDNS;
    public bool Com31Enable;
    public bool Com31CanModem;
    public bool Com31CanRS232;
    public bool Com31CanRS422;
    public bool Com31CanRS485;
    public bool Com31CanDNS;
    public bool Com32Enable;
    public bool Com32CanModem;
    public bool Com32CanRS232;
    public bool Com32CanRS422;
    public bool Com32CanRS485;
    public bool Com32CanDNS;
    public bool BasicSetting;
    public bool NetworkSetting;
    public bool ServerSetting;
    public bool EmailSetting;
    public bool TriggerSetting;
    public bool InputTriggerSetting;
    public bool PinsSetting;
    public bool PPPOESetting;
    public bool PPPSetting;
    public bool GPRSSetting;
    private string userName;
    private string userPsw;
    private bool isLogged;
    public byte LoginIndex;
    private string newUserPsw;
    private BinaryOptions webconsole;
    private BinaryOptions telnetconsole;
    private BinaryOptions bootp;
    private BinaryOptions dhcp;
    private BinaryOptions autoip;
    private Device.enumMailOption m_coldstart;
    private Device.enumMailOption m_warmstart;
    private Device.enumMailOption m_authfail;
    private Device.enumMailOption m_ipchanged;
    private Device.enumMailOption m_pwdchanged;
    private Device.enumMailOption m_DCDchanged;
    private Device.enumMailOption m_DSRchanged;
    private byte m_minnoteinter;
    private Device.enumPinType input1;
    private Device.enumPinType input2;
    private bool m_enableserialinput;
    private Device.SerialChannels m_serialchannel;
    private Device.enumSerialDataSize m_serialdatasize;
    private byte m_inputminnoteinter;
    private byte m_renoteinter;
    private Device.InputOutputTypes io1;
    private Device.InputOutputTypes io2;
    private Device.IOTypes io1Type;
    private Device.IOTypes io2Type;
    private Device.EleStates io1State;
    private Device.EleStates io2State;
    private string deviceName;
    private IPAddress ip;
    private string serialNO;
    private string firmware;
    private string upTime;
    private string m_PPPOEUserName;
    private string m_PPPOEPassword;
    private Device.PPPOEWorkModes m_PPPOEWorkMode;
    private byte m_PPPOEMaxRedialTimes;
    private byte m_PPPOERedialInterval;
    private ushort m_PPPOEIDLETime;
    private Device.PPPOE_Status m_PPPOEStatus;
    private string m_PPPOEIP;
    private string m_PPPOEGateway;
    private string m_PPPOEDNS1;
    private string m_PPPOEDNS2;
    private string m_PPPUserName;
    private string m_PPPPassword;
    private Device.PPPOEWorkModes m_PPPWorkMode;
    private byte m_PPPMaxRedialTimes;
    private byte m_PPPRedialInterval;
    private ushort m_PPPIDLETime;
    private byte m_PPPComID;
    private Device.PPPOE_Status m_PPPStatus;
    private string m_PPPIP;
    private string m_PPPGateway;
    private string m_PPPDNS1;
    private string m_PPPDNS2;
    private string m_ServiceCode;
    private string m_GPRSPPPUserName;
    private string m_GPRSPPPPassword;
    private string m_GPRSSINUIMPIN;
    private string m_GPRSAPN;
    private Device.PPPOEWorkModes m_GPRSWorkMode;
    private byte m_GPRSMaxRedialTimes;
    private byte m_GPRSRedialInterval;
    private ushort m_GPRSIDLETime;
    private byte m_GPRSComID;
    private Device.PPPOE_Status m_GPRSStatus;
    private string m_GPRSIP;
    private string m_GPRSGateway;
    private string m_GPRSDNS1;
    private string m_GPRSDNS2;

    public bool IsChecked
    {
      get
      {
        return this.isChecked;
      }
      set
      {
        this.isChecked = value;
      }
    }

    public ChannelCollection ChannelList
    {
      get
      {
        return this.channelList;
      }
      set
      {
        this.channelList = value;
      }
    }

    public string UserName
    {
      get
      {
        return this.userName;
      }
      set
      {
        this.userName = value;
      }
    }

    public string UserPsw
    {
      get
      {
        return this.userPsw;
      }
      set
      {
        this.userPsw = value;
      }
    }

    public bool IsLogged
    {
      get
      {
        return this.isLogged;
      }
      set
      {
        this.isLogged = value;
      }
    }

    public string NewUserPsw
    {
      get
      {
        return this.newUserPsw;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("NewUserPsw", ref this.newUserPsw, value, this);
      }
    }

    public DateTime LocalTime
    {
      get
      {
        return this.localTime;
      }
      set
      {
        this.localTime = value;
      }
    }

    public string TimeServer
    {
      get
      {
        return this.timeserver;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("TimeServer", ref this.timeserver, value, this);
      }
    }

    public BinaryOptions WebConsole
    {
      get
      {
        return this.webconsole;
      }
      set
      {
        this.webconsole = value;
      }
    }

    public BinaryOptions TelnetConsole
    {
      get
      {
        return this.telnetconsole;
      }
      set
      {
        this.telnetconsole = value;
      }
    }

    public string TimeZone
    {
      get
      {
        return this.timezone;
      }
      set
      {
        this.timezone = value;
        bool flag = false;
        foreach (string str in Program.arytimezone)
        {
          if (str.Equals(this.timezone.Trim()))
          {
            flag = true;
            break;
          }
        }
        if (flag)
          return;
        this.timezone = Program.arytimezone[0];
      }
    }

    public string TerminalName
    {
      get
      {
        return this.m_terminalmame;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("TerminalName", ref this.m_terminalmame, value, this);
      }
    }

    public Device.IPManner IPConfiguration
    {
      get
      {
        return this.ipcfgmannner;
      }
      set
      {
        this.ipcfgmannner = value;
      }
    }

    public BinaryOptions Bootp
    {
      get
      {
        return this.bootp;
      }
      set
      {
        this.bootp = value;
      }
    }

    public BinaryOptions DHCP
    {
      get
      {
        return this.dhcp;
      }
      set
      {
        this.dhcp = value;
      }
    }

    public BinaryOptions AutoIP
    {
      get
      {
        return this.autoip;
      }
      set
      {
        this.autoip = value;
      }
    }

    public string DHCPHostName
    {
      get
      {
        return this.dhcpname;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("DHCPHostName", ref this.dhcpname, value, this);
      }
    }

    public IPAddress IPAddress
    {
      get
      {
        return this.ipaddress;
      }
      set
      {
        this.ipaddress = value;
      }
    }

    public IPAddress Subnet
    {
      get
      {
        return this.subnet;
      }
      set
      {
        this.subnet = value;
      }
    }

    public IPAddress DefaultGateway
    {
      get
      {
        return this.defaultgateway;
      }
      set
      {
        this.defaultgateway = value;
      }
    }

    public IPAddress PreferredDNSServer
    {
      get
      {
        return this.prefdnssvr;
      }
      set
      {
        this.prefdnssvr = value;
      }
    }

    public IPAddress AlternateDNSServer
    {
      get
      {
        return this.alterdnssvr;
      }
      set
      {
        this.alterdnssvr = value;
      }
    }

    public bool AutoNegotiate
    {
      get
      {
        return this.autoneg;
      }
      set
      {
        this.autoneg = value;
      }
    }

    public Device.NetSpeed Speed
    {
      get
      {
        return this.speed;
      }
      set
      {
        this.speed = value;
      }
    }

    public Device.NetDuplex Duplex
    {
      get
      {
        return this.duplex;
      }
      set
      {
        this.duplex = value;
      }
    }

    public string MacAddress
    {
      get
      {
        return this.mac;
      }
      set
      {
        if (Program.CheckMacStr(value.Trim()))
        {
          this.mac = value.Trim();
        }
        else
        {
          this.AddMessage(Message.InvalidMAC, "Mac Address");
          this.isChecked = false;
        }
      }
    }

    public bool Ethernet
    {
      get
      {
        return this.nt_ethernet;
      }
      set
      {
        this.nt_ethernet = value;
      }
    }

    public bool PPP
    {
      get
      {
        return this.nt_ppp;
      }
      set
      {
        this.nt_ppp = value;
      }
    }

    public bool PPPoE
    {
      get
      {
        return this.nt_pppoe;
      }
      set
      {
        this.nt_pppoe = value;
      }
    }

    public bool GPRS
    {
      get
      {
        return this.nt_GPRS;
      }
      set
      {
        this.nt_GPRS = value;
      }
    }

    public byte ARPcacheTimeout
    {
      get
      {
        return this.arpcachtime;
      }
      set
      {
        if ((int) value >= 60)
        {
          this.arpcachtime = value;
        }
        else
        {
          this.AddMessage(string.Format(Message.RangeError, (object) 60, (object) (int) byte.MaxValue), "ARPcacheTimeout");
          this.isChecked = false;
        }
      }
    }

    public BinaryOptions MonitorModeBootup
    {
      get
      {
        return this.monibtup;
      }
      set
      {
        this.monibtup = value;
      }
    }

    public Device.PerformanceMode CPUPerformanceMode
    {
      get
      {
        return this.cpuperformancemode;
      }
      set
      {
        this.cpuperformancemode = value;
      }
    }

    public ushort HTTPServerPort
    {
      get
      {
        return this.httpport;
      }
      set
      {
        this.httpport = value;
      }
    }

    public ushort MTUSize
    {
      get
      {
        return this.mtusize;
      }
      set
      {
        if ((int) value >= 256 && (int) value <= 1024)
        {
          this.mtusize = value;
        }
        else
        {
          this.AddMessage(string.Format(Message.RangeError, (object) 256, (object) 1024), "MTUSize");
          this.isChecked = false;
        }
      }
    }

    public string SMTPDomainName
    {
      get
      {
        return this.m_smtpdomainname;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("SMTPDomainName", ref this.m_smtpdomainname, value, this);
      }
    }

    public ushort SMTPPort
    {
      get
      {
        return this.m_smtport;
      }
      set
      {
        this.m_smtport = value;
      }
    }

    public string EmailAddress
    {
      get
      {
        return this.m_emailaddress;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckEmailAddr("EmailAddress", ref this.m_emailaddress, value, this);
      }
    }

    public string EmailUsername
    {
      get
      {
        return this.m_emailusername;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("EmailUsername", ref this.m_emailusername, value, this);
      }
    }

    public string EmailPassword
    {
      get
      {
        return this.m_emailpwd;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("EmailPassword", ref this.m_emailpwd, value, this);
      }
    }

    public string EmailAddress1
    {
      get
      {
        return this.m_emailAddress1;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckEmailAddr("EmailAddress1", ref this.m_emailAddress1, value, this);
      }
    }

    public string EmailAddress2
    {
      get
      {
        return this.m_emailAddress2;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckEmailAddr("EmailAddress2", ref this.m_emailAddress2, value, this);
      }
    }

    public string EmailAddress3
    {
      get
      {
        return this.m_emailAddress3;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckEmailAddr("EmailAddress3", ref this.m_emailAddress3, value, this);
      }
    }

    public Device.enumMailOption ColdStart
    {
      get
      {
        return this.m_coldstart;
      }
      set
      {
        this.m_coldstart = value;
      }
    }

    public Device.enumMailOption WarmStart
    {
      get
      {
        return this.m_warmstart;
      }
      set
      {
        this.m_warmstart = value;
      }
    }

    public Device.enumMailOption AuthenticationFailure
    {
      get
      {
        return this.m_authfail;
      }
      set
      {
        this.m_authfail = value;
      }
    }

    public Device.enumMailOption IPAddressChanged
    {
      get
      {
        return this.m_ipchanged;
      }
      set
      {
        this.m_ipchanged = value;
      }
    }

    public Device.enumMailOption PasswordChanged
    {
      get
      {
        return this.m_pwdchanged;
      }
      set
      {
        this.m_pwdchanged = value;
      }
    }

    public Device.enumMailOption DCDChanged
    {
      get
      {
        return this.m_DCDchanged;
      }
      set
      {
        this.m_DCDchanged = value;
      }
    }

    public Device.enumMailOption DSRChanged
    {
      get
      {
        return this.m_DSRchanged;
      }
      set
      {
        this.m_DSRchanged = value;
      }
    }

    public string EmailTriggerSubject
    {
      get
      {
        return this.m_emailtrgsb;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("EmailTriggerSubject", ref this.m_emailtrgsb, value, this);
      }
    }

    public Device.enumPriority Priority
    {
      get
      {
        return this.m_priority;
      }
      set
      {
        this.m_priority = value;
      }
    }

    public byte MinNotificationInterval
    {
      get
      {
        return this.m_minnoteinter;
      }
      set
      {
        this.m_minnoteinter = value;
      }
    }

    public Device.enumPinType Input1
    {
      get
      {
        return this.input1;
      }
      set
      {
        this.input1 = value;
      }
    }

    public Device.enumPinType Input2
    {
      get
      {
        return this.input2;
      }
      set
      {
        this.input2 = value;
      }
    }

    public bool EnableSerialTriggerInput
    {
      get
      {
        return this.m_enableserialinput;
      }
      set
      {
        this.m_enableserialinput = value;
      }
    }

    public Device.SerialChannels SerialChannel
    {
      get
      {
        return this.m_serialchannel;
      }
      set
      {
        this.m_serialchannel = value;
      }
    }

    public Device.enumSerialDataSize SerialDataSize
    {
      get
      {
        return this.m_serialdatasize;
      }
      set
      {
        this.m_serialdatasize = value;
      }
    }

    public string SerialMatchData1
    {
      get
      {
        return this.m_serialmatchdata1;
      }
      set
      {
        if (Program.CheckNumStr(value.Trim(), 2, 0, "x"))
        {
          this.m_serialmatchdata1 = value.Trim();
        }
        else
        {
          this.AddMessage(Message.MustHex, "SerialMatchData1");
          this.isChecked = false;
        }
      }
    }

    public string SerialMatchData2
    {
      get
      {
        return this.m_serialmatchdata2;
      }
      set
      {
        if (Program.CheckNumStr(value.Trim(), 2, 0, "x"))
        {
          this.m_serialmatchdata2 = value.Trim();
        }
        else
        {
          this.AddMessage(Message.MustHex, "SerialMatchData2");
          this.isChecked = false;
        }
      }
    }

    public string SerialMatchData3
    {
      get
      {
        return this.m_serialmatchdata3;
      }
      set
      {
        if (Program.CheckNumStr(value.Trim(), 2, 0, "x"))
        {
          this.m_serialmatchdata3 = value.Trim();
        }
        else
        {
          this.AddMessage(Message.MustHex, "SerialMatchData3");
          this.isChecked = false;
        }
      }
    }

    public string EmailInputTriggerMessage
    {
      get
      {
        return this.m_emailtrgmsg;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("EmailInputTriggerMessage", ref this.m_emailtrgmsg, value, this);
      }
    }

    public Device.enumPriority InputPriority
    {
      get
      {
        return this.m_inputpriority;
      }
      set
      {
        this.m_inputpriority = value;
      }
    }

    public byte InputMinNotificationInterval
    {
      get
      {
        return this.m_inputminnoteinter;
      }
      set
      {
        this.m_inputminnoteinter = value;
      }
    }

    public byte RenotificationInterval
    {
      get
      {
        return this.m_renoteinter;
      }
      set
      {
        this.m_renoteinter = value;
      }
    }

    public Device.InputOutputTypes IO1
    {
      get
      {
        return this.io1;
      }
      set
      {
        this.io1 = value;
      }
    }

    public Device.InputOutputTypes IO2
    {
      get
      {
        return this.io2;
      }
      set
      {
        this.io2 = value;
      }
    }

    public Device.IOTypes IO1Type
    {
      get
      {
        return this.io1Type;
      }
      set
      {
        this.io1Type = value;
      }
    }

    public Device.IOTypes IO2Type
    {
      get
      {
        return this.io2Type;
      }
      set
      {
        this.io2Type = value;
      }
    }

    public Device.EleStates IO1State
    {
      get
      {
        return this.io1State;
      }
      set
      {
        this.io1State = value;
      }
    }

    public Device.EleStates IO2State
    {
      get
      {
        return this.io2State;
      }
      set
      {
        this.io2State = value;
      }
    }

    public string DeviceName
    {
      get
      {
        return this.deviceName;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("DeviceName", ref this.deviceName, value, this);
      }
    }

    public IPAddress IP
    {
      get
      {
        return this.ip;
      }
    }

    public string SerialNO
    {
      get
      {
        return this.serialNO;
      }
      set
      {
        this.serialNO = value;
      }
    }

    public string Firmware
    {
      get
      {
        return this.firmware;
      }
      set
      {
        this.firmware = value;
      }
    }

    public string UpTime
    {
      get
      {
        return this.upTime;
      }
      set
      {
        this.upTime = value;
      }
    }

    public string PPPOEUserName
    {
      get
      {
        return this.m_PPPOEUserName;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPOEUserName", ref this.m_PPPOEUserName, value, this);
      }
    }

    public string PPPOEPassword
    {
      get
      {
        return this.m_PPPOEPassword;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPOEPassword", ref this.m_PPPOEPassword, value, this);
      }
    }

    public Device.PPPOEWorkModes PPPOEWorkMode
    {
      get
      {
        return this.m_PPPOEWorkMode;
      }
      set
      {
        this.m_PPPOEWorkMode = value;
      }
    }

    public byte PPPOEMaxRedialTimes
    {
      get
      {
        return this.m_PPPOEMaxRedialTimes;
      }
      set
      {
        this.m_PPPOEMaxRedialTimes = value;
      }
    }

    public byte PPPOERedialInterval
    {
      get
      {
        return this.m_PPPOERedialInterval;
      }
      set
      {
        this.m_PPPOERedialInterval = value;
      }
    }

    public ushort PPPOEIDLETime
    {
      get
      {
        return this.m_PPPOEIDLETime;
      }
      set
      {
        this.m_PPPOEIDLETime = value;
      }
    }

    public Device.PPPOE_Status PPPOEStatus
    {
      get
      {
        return this.m_PPPOEStatus;
      }
      set
      {
        this.m_PPPOEStatus = value;
      }
    }

    public string PPPOEIP
    {
      get
      {
        return this.m_PPPOEIP;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPOEIP", ref this.m_PPPOEIP, value, this);
      }
    }

    public string PPPOEGateway
    {
      get
      {
        return this.m_PPPOEGateway;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPOEGateway", ref this.m_PPPOEGateway, value, this);
      }
    }

    public string PPPOEDNS1
    {
      get
      {
        return this.m_PPPOEDNS1;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPOEDNS1", ref this.m_PPPOEDNS1, value, this);
      }
    }

    public string PPPOEDNS2
    {
      get
      {
        return this.m_PPPOEDNS2;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPOEDNS2", ref this.m_PPPOEDNS2, value, this);
      }
    }

    public string PPPUserName
    {
      get
      {
        return this.m_PPPUserName;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPUserName", ref this.m_PPPUserName, value, this);
      }
    }

    public string PPPPassword
    {
      get
      {
        return this.m_PPPPassword;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPPassword", ref this.m_PPPPassword, value, this);
      }
    }

    public Device.PPPOEWorkModes PPPWorkMode
    {
      get
      {
        return this.m_PPPWorkMode;
      }
      set
      {
        this.m_PPPWorkMode = value;
      }
    }

    public byte PPPMaxRedialTimes
    {
      get
      {
        return this.m_PPPMaxRedialTimes;
      }
      set
      {
        this.m_PPPMaxRedialTimes = value;
      }
    }

    public byte PPPRedialInterval
    {
      get
      {
        return this.m_PPPRedialInterval;
      }
      set
      {
        this.m_PPPRedialInterval = value;
      }
    }

    public ushort PPPIDLETime
    {
      get
      {
        return this.m_PPPIDLETime;
      }
      set
      {
        this.m_PPPIDLETime = value;
      }
    }

    public byte PPPComID
    {
      get
      {
        return this.m_PPPComID;
      }
      set
      {
        bool flag = false;
        foreach (Channel channel in this.ChannelList)
        {
          if ((int) channel.GetComID() == (int) value)
          {
            flag = true;
            this.m_PPPComID = value;
          }
        }
        if (flag)
          return;
        this.m_PPPComID = this.ChannelList[0].GetComID();
      }
    }

    public Device.PPPOE_Status PPPStatus
    {
      get
      {
        return this.m_PPPStatus;
      }
      set
      {
        this.m_PPPStatus = value;
      }
    }

    public string PPPIP
    {
      get
      {
        return this.m_PPPIP;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPIP", ref this.m_PPPIP, value, this);
      }
    }

    public string PPPGateway
    {
      get
      {
        return this.m_PPPGateway;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPGateway", ref this.m_PPPGateway, value, this);
      }
    }

    public string PPPDNS1
    {
      get
      {
        return this.m_PPPDNS1;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPDNS1", ref this.m_PPPDNS1, value, this);
      }
    }

    public string PPPDNS2
    {
      get
      {
        return this.m_PPPDNS2;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("PPPDNS2", ref this.m_PPPDNS2, value, this);
      }
    }

    public string ServiceCode
    {
      get
      {
        return this.m_ServiceCode;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("ServiceCode", ref this.m_ServiceCode, value, this);
      }
    }

    public string GPRSPPPUserName
    {
      get
      {
        return this.m_GPRSPPPUserName;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("GPRSPPPUserName", ref this.m_GPRSPPPUserName, value, this);
      }
    }

    public string GPRSPPPPassword
    {
      get
      {
        return this.m_GPRSPPPPassword;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("GPRSPPPPassword", ref this.m_GPRSPPPPassword, value, this);
      }
    }

    public string GPRSSINUIMPIN
    {
      get
      {
        return this.m_GPRSSINUIMPIN;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("GPRSSINUIMPIN", ref this.m_GPRSSINUIMPIN, value, this);
      }
    }

    public string GPRSAPN
    {
      get
      {
        return this.m_GPRSAPN;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("GPRSAPN", ref this.m_GPRSAPN, value, this);
      }
    }

    public Device.PPPOEWorkModes GPRSWorkMode
    {
      get
      {
        return this.m_GPRSWorkMode;
      }
      set
      {
        this.m_GPRSWorkMode = value;
      }
    }

    public byte GPRSMaxRedialTimes
    {
      get
      {
        return this.m_GPRSMaxRedialTimes;
      }
      set
      {
        this.m_GPRSMaxRedialTimes = value;
      }
    }

    public byte GPRSRedialInterval
    {
      get
      {
        return this.m_GPRSRedialInterval;
      }
      set
      {
        this.m_GPRSRedialInterval = value;
      }
    }

    public ushort GPRSIDLETime
    {
      get
      {
        return this.m_GPRSIDLETime;
      }
      set
      {
        this.m_GPRSIDLETime = value;
      }
    }

    public byte GPRSComID
    {
      get
      {
        return this.m_GPRSComID;
      }
      set
      {
        bool flag = false;
        foreach (Channel channel in this.ChannelList)
        {
          if ((int) channel.GetComID() == (int) value)
          {
            flag = true;
            this.m_GPRSComID = value;
          }
        }
        if (flag)
          return;
        this.m_GPRSComID = this.ChannelList[0].GetComID();
      }
    }

    public Device.PPPOE_Status GPRSStatus
    {
      get
      {
        return this.m_GPRSStatus;
      }
      set
      {
        this.m_GPRSStatus = value;
      }
    }

    public string GPRSIP
    {
      get
      {
        return this.m_GPRSIP;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("GPRSIP", ref this.m_GPRSIP, value, this);
      }
    }

    public string GPRSGateway
    {
      get
      {
        return this.m_GPRSGateway;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("GPRSGateway", ref this.m_GPRSGateway, value, this);
      }
    }

    public string GPRSDNS1
    {
      get
      {
        return this.m_GPRSDNS1;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("GPRSDNS1", ref this.m_GPRSDNS1, value, this);
      }
    }

    public string GPRSDNS2
    {
      get
      {
        return this.m_GPRSDNS2;
      }
      set
      {
        this.isChecked = this.isChecked && Program.CheckStr("GPRSDNS2", ref this.m_GPRSDNS2, value, this);
      }
    }

    public Device(IPAddress ip, Batman workBatman)
    {
      this.ip = ip;
      this.workBatman = workBatman;
      PropertyDescriptorCollection properties = TypeDescriptor.GetProperties((object) this);
      this.Visibility = new Hashtable(properties.Count);
      for (int index = 0; index < properties.Count; ++index)
      {
        switch (properties[index].Name)
        {
          case "NewUserName":
          case "NewUserPsw":
            this.Visibility.Add((object) properties[index].Name, (object) true);
            break;
          default:
            this.Visibility.Add((object) properties[index].Name, (object) false);
            break;
        }
      }
      this.BasicSetting = false;
      this.NetworkSetting = false;
      this.ServerSetting = false;
      this.EmailSetting = false;
      this.TriggerSetting = false;
      this.InputTriggerSetting = false;
      this.PinsSetting = false;
      this.PPPOESetting = false;
      this.PPPSetting = false;
      this.GPRSSetting = false;
    }

    public void AddMessage(string message)
    {
      this.AddMessage(message, (string) null);
    }

    public void AddMessage(string message, string typeName)
    {
      if (message != null && message != "")
      {
        Device device1 = this;
        string str1 = device1.interMsg + "\n" + message;
        device1.interMsg = str1;
        if (typeName == null)
          return;
        Device device2 = this;
        string str2 = device2.interMsg + ":" + Device.getPropertyName(typeName);
        device2.interMsg = str2;
      }
      else
        this.interMsg = message;
    }

    private static string getPropertyName(string property)
    {
      try
      {
        return (string) new ResourceManager(typeof (MyLable)).GetObject(property, Program.cultureInfo);
      }
      catch (MissingManifestResourceException ex)
      {
        Log.WriteException((Exception) ex);
        return property;
      }
    }

    public void ClearMessage()
    {
      this.interMsg = "";
    }

    public string GetMessage()
    {
      return this.interMsg;
    }

    public void ResetSetting()
    {
      this.BasicSetting = false;
      this.NetworkSetting = false;
      this.ServerSetting = false;
      this.EmailSetting = false;
      this.TriggerSetting = false;
      this.InputTriggerSetting = false;
      this.PinsSetting = false;
      this.PPPOESetting = false;
      this.PPPSetting = false;
      this.GPRSSetting = false;
    }

    public enum IPManner
    {
      Manually,
      Automatically,
    }

    public enum NetSpeed
    {
      _10Mbps,
      _100Mbps,
    }

    public enum NetDuplex
    {
      Half,
      Full,
    }

    public enum PerformanceMode
    {
      High,
      Regular,
    }

    public enum enumMailOption
    {
      MailOff,
      MailOn,
    }

    public enum enumPriority
    {
      High = 1,
      Normal = 3,
      Low = 5,
    }

    public enum enumPinType
    {
      Low,
      High,
      None,
    }

    public enum SerialChannels
    {
      Channel2,
      Channel1,
    }

    public enum enumSerialDataSize
    {
      TwoBytes,
      ThreeBytes,
    }

    public enum InputOutputTypes
    {
      IO_Mode,
      Systerm_led_mode,
      Connection_Indicator_Mode,
      Flow_Control_Mode,
      RS485_Controllor,
      RS422_Controllor,
    }

    public enum IOTypes
    {
      Input,
      Output,
    }

    public enum EleStates
    {
      Low,
      Hight,
    }

    public enum PPPOEWorkModes
    {
      Disable,
      Auto_Dial,
      Dial_on_Demand,
      Adaptive,
    }

    public enum PPPOE_Status
    {
      Deactive,
      Dialing,
      Active,
      Disconnecting,
      Error,
    }
  }
}
