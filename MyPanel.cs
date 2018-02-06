// Decompiled with JetBrains decompiler
// Type: DeviceManagement.MyPanel
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace DeviceManagement
{
  public class MyPanel : UserControl
  {
    private bool isAllDisVisibility = true;
    private PanelTypes panelType;
    private byte channelNum;
    private RebootTypes rebootType;
    private bool canNotChange;
    private Device device;
    private IContainer components;
    private Panel basicPanel;
    private CheckBox telnetCB;
    private CheckBox webCB;
    private MyLable myLable7;
    private MyLable myLable6;
    private MyLable myLable5;
    private MyLable myLable4;
    private MyLable myLable3;
    private MyLable myLable2;
    private MyLable myLable1;
    private TextBox terminalTB;
    private TextBox timeServerTB;
    private DateTimePicker localTimeTB;
    private ComboBox timeZoneCB;
    private TextBox nameTB;
    private Label propertyL;
    private Panel networkPanel;
    private MyLable myLable14;
    private RadioButton userCfRB;
    private RadioButton autoCfRB;
    private Panel panel2;
    private Panel panel1;
    private CheckBox bootpCB;
    private MyLable myLable8;
    private CheckBox autoIPCB;
    private MyLable myLable11;
    private CheckBox dhcpCB;
    private MyLable myLable9;
    private TextBox dhcpNameTB;
    private MyLable myLable12;
    private MyLable myLable13;
    private MyLable myLable18;
    private MyLable myLable17;
    private MyLable myLable16;
    private MyLable myLable15;
    private Panel panel3;
    private MyLable myLable20;
    private MyLable myLable19;
    private TextBox ipTB;
    private ComboBox speedCB;
    private TextBox macTB;
    private MyLable myLable21;
    private ComboBox duplexCB;
    private TextBox gatewayTB;
    private TextBox subnetTB;
    private TextBox altDNSTB;
    private TextBox pDNSTB;
    private Panel serverPanel;
    private MyLable myLable22;
    private MyLable myLable26;
    private MyLable myLable25;
    private MyLable myLable24;
    private MyLable myLable23;
    private NumericUpDown arpNUD;
    private TextBox mtuTB;
    private NumericUpDown httpPortNUD;
    private CheckBox monitorCB;
    private ComboBox cpuCB;
    private Panel emailPanel;
    private MyLable myLable27;
    private MyLable myLable28;
    private MyLable myLable29;
    private MyLable myLable30;
    private MyLable myLable31;
    private TextBox emailUserTB;
    private TextBox emailTB;
    private NumericUpDown smtpPNUD;
    private TextBox smtpDTB;
    private TextBox emailPwdTB;
    private TextBox email3TB;
    private TextBox emial2TB;
    private TextBox email1TB;
    private MyLable myLable34;
    private MyLable myLable33;
    private MyLable myLable32;
    private Panel triggerPanel;
    private MyLable myLable41;
    private MyLable myLable40;
    private MyLable myLable39;
    private MyLable myLable38;
    private MyLable myLable37;
    private MyLable myLable36;
    private MyLable myLable35;
    private ComboBox coldCB;
    private ComboBox pwdChangeCB;
    private ComboBox ipChangeCB;
    private ComboBox loginFailCB;
    private ComboBox dsrCB;
    private ComboBox dcdCB;
    private ComboBox warmCB;
    private MyLable myLable42;
    private MyLable myLable44;
    private MyLable myLable43;
    private TextBox triggerMTB;
    private ComboBox priorityCB;
    private NumericUpDown minNotifyNUD;
    private Panel inputTriggerPanel;
    private NumericUpDown inputMNINUD;
    private ComboBox inputPriorityCB;
    private MyLable myLable45;
    private MyLable myLable46;
    private TextBox messageTB;
    private MyLable myLable47;
    private ComboBox input2CB;
    private ComboBox input1CB;
    private MyLable myLable48;
    private MyLable myLable49;
    private MyLable myLable53;
    private MyLable myLable54;
    private MyLable myLable50;
    private CheckBox enableSerialCB;
    private Panel panel5;
    private ComboBox dataSizeCB;
    private ComboBox channelsCB;
    private TextBox char3TB;
    private TextBox char2TB;
    private TextBox char1TB;
    private Label label12;
    private Label label11;
    private Label label10;
    private NumericUpDown reNotifyNUD;
    private MyLable myLable51;
    private Panel histlistPanel;
    private Label channelNameL;
    private MyLable myLable55;
    private MyLable myLable52;
    private NumericUpDown retryTNUD;
    private NumericUpDown retryCNUD;
    private TableLayoutPanel tableLayoutPanel1;
    private Label label20;
    private Label label19;
    private Label label18;
    private Label label17;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label21;
    private Label label22;
    private Label label23;
    private Label label24;
    private Label label25;
    private Label label26;
    private Label label27;
    private Label label28;
    private Label label29;
    private Label label30;
    private Label label31;
    private TextBox hostPort12TB;
    private TextBox hostIP12TB;
    private TextBox hostPort11TB;
    private TextBox hostIP11TB;
    private TextBox hostPort10TB;
    private TextBox hostIP10TB;
    private TextBox hostPort9TB;
    private TextBox hostIP9TB;
    private TextBox hostPort8TB;
    private TextBox hostIP8TB;
    private TextBox hostPort7TB;
    private TextBox hostIP7TB;
    private TextBox hostPort6TB;
    private TextBox hostIP6TB;
    private TextBox hostPort5TB;
    private TextBox hostIP5TB;
    private TextBox hostPort4TB;
    private TextBox hostIP4TB;
    private TextBox hostPort3TB;
    private TextBox hostIP3TB;
    private TextBox hostPort2TB;
    private TextBox hostIP2TB;
    private TextBox hostPort1TB;
    private TextBox hostIP1TB;
    private Panel passwordPanel;
    private GroupBox groupBox1;
    private TextBox oldPwdTB;
    private TextBox retypePwdTB;
    private TextBox newPwdTB;
    private TextBox userNameTB;
    private Label label46;
    private Label label45;
    private Label label44;
    private Label label43;
    private Panel pinsPanel;
    private ComboBox io1CB;
    private MyLable myLable96;
    private MyLable myLable97;
    private ComboBox io2CB;
    private ComboBox io2TypeCB;
    private ComboBox io1TypeCB;
    private ComboBox io2EleCB;
    private ComboBox io1EleCB;
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private Panel pppoePanel;
    private MyLable myLable98;
    private MyLable myLable106;
    private MyLable myLable105;
    private MyLable myLable104;
    private MyLable myLable103;
    private MyLable myLable102;
    private MyLable myLable101;
    private MyLable myLable100;
    private MyLable myLable99;
    private MyLable myLable108;
    private MyLable myLable107;
    private ComboBox pppoeWorkModeCB;
    private TextBox pppoePwdTB;
    private TextBox pppoeUserNameTB;
    private NumericUpDown pppoeMaxRTNUD;
    private NumericUpDown ppoeIDLENUD;
    private NumericUpDown pppoeRINUD;
    private TextBox pppoeStatusTB;
    private TextBox pppoeDNS2TB;
    private TextBox pppoeDNS1TB;
    private TextBox pppoeGatewayTB;
    private TextBox pppoeIPTB;
    private ComboBox backupLinkCB;
    private MyLable myLable109;
    private Panel connectionPanel;
    private Panel panel8;
    private NumericUpDown inactivityNUD;
    private GroupBox groupBox5;
    private MyLable myLable70;
    private MyLable myLable74;
    private CheckBox oatdCB;
    private MyLable myLable75;
    private CheckBox owacCB;
    private CheckBox owpcCB;
    private ComboBox workasCB;
    private GroupBox groupBox4;
    private MyLable myLable72;
    private MyLable myLable73;
    private MyLable myLable69;
    private CheckBox iwacCB;
    private CheckBox iwpcCB;
    private CheckBox iatdCB;
    private NumericUpDown dnsQueryPeriodNUD;
    private MyLable myLable56;
    private CheckBox hardDisconnectCB;
    private CheckBox checkEOTCB;
    private CheckBox onDSRDropCB;
    private ComboBox connectResponseCB;
    private TextBox tcpRomteHostTB;
    private CheckBox useHostlistCB;
    private NumericUpDown tcpRemotePortNUD;
    private NumericUpDown tcpLocalPortNUD;
    private TextBox startCharTB;
    private Label label42;
    private ComboBox tcpActiveCB;
    private MyLable myLable95;
    private MyLable myLable94;
    private MyLable myLable93;
    private MyLable myLable92;
    private MyLable myLable91;
    private MyLable myLable90;
    private MyLable myLable89;
    private MyLable myLable88;
    private MyLable myLable87;
    private MyLable myLable86;
    private MyLable myLable85;
    private MyLable myLable84;
    private NumericUpDown udpUCLPNUD;
    private TableLayoutPanel tableLayoutPanel2;
    private TextBox eAddr3TB;
    private TextBox bAddr3TB;
    private TextBox eAddr2TB;
    private TextBox bAddr2TB;
    private TextBox eAddr1TB;
    private TextBox bAddr1TB;
    private TextBox eAddr0TB;
    private TextBox bAddr0TB;
    private Label label38;
    private Label label37;
    private Label label36;
    private Label label35;
    private Label label32;
    private Label label39;
    private Label label40;
    private Label label41;
    private NumericUpDown udpPort0TB;
    private NumericUpDown udpPort1TB;
    private NumericUpDown udpPort2TB;
    private NumericUpDown udpPort3TB;
    private Panel panel7;
    private TextBox udpSegmentTB;
    private NumericUpDown udpRemotePortNUD;
    private NumericUpDown udpLocalPortNUD;
    private MyLable myLable79;
    private MyLable myLable80;
    private MyLable myLable81;
    private CheckBox udpAcceptCB;
    private ComboBox datagramCB;
    private MyLable myLable83;
    private MyLable myLable82;
    private MyLable myLable78;
    private MyLable myLable77;
    private ComboBox netProtocolCB;
    private MyLable myLable76;
    private Label channelNameL2;
    private Panel serialPanel;
    private Panel panel4;
    private ComboBox protocolCB;
    private Panel panel6;
    private TextBox lastTB;
    private TextBox firstCharTB;
    private Label label34;
    private Label label33;
    private ComboBox sendBytesCB;
    private CheckBox match2CB;
    private CheckBox sendFrameCB;
    private ComboBox idleCB;
    private MyLable myLable66;
    private MyLable myLable67;
    private MyLable myLable68;
    private MyLable myLable71;
    private CheckBox enablePackCB;
    private ComboBox stopbitCB;
    private ComboBox parityCB;
    private ComboBox databitCB;
    private ComboBox baudrateCB;
    private ComboBox flowCB;
    private ComboBox fifoCB;
    private MyLable myLable65;
    private MyLable myLable64;
    private MyLable myLable63;
    private MyLable myLable62;
    private MyLable myLable61;
    private MyLable myLable60;
    private MyLable myLable59;
    private MyLable myLable58;
    private CheckBox serialOptionCB;
    private MyLable myLable57;
    private Label channelNameL1;
    private Panel powerPanel;
    private RadioButton radioButton4;
    private RadioButton radioButton3;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private MyCheckBox ethernetCB;
    private MyCheckBox autoNegoCB;
    private MyCheckBox GPRSCB;
    private MyCheckBox pppoeCB;
    private MyCheckBox pppCB;
    private Panel pppPanel;
    private TextBox pppDNS2TB;
    private TextBox pppDNS1TB;
    private TextBox pppGatewayTB;
    private TextBox pppIPTB;
    private TextBox pppStatusTB;
    private NumericUpDown pppIDLENUD;
    private NumericUpDown pppRINUD;
    private NumericUpDown pppMaxRTNUD;
    private ComboBox pppWorkModeCB;
    private TextBox pppPwdTB;
    private TextBox pppUserNameTB;
    private MyLable myLable10;
    private MyLable myLable110;
    private MyLable myLable111;
    private MyLable myLable112;
    private MyLable myLable113;
    private MyLable myLable114;
    private MyLable myLable115;
    private MyLable myLable116;
    private MyLable myLable117;
    private MyLable myLable118;
    private MyLable myLable119;
    private ComboBox pppComCB;
    private MyLable myLable120;
    private Panel panel9;
    private Panel gprsPanel;
    private TextBox gprsUserTB;
    private TextBox supinTB;
    private TextBox gprsPwdTB;
    private TextBox serviceCodeTB;
    private MyLable myLable124;
    private MyLable myLable123;
    private MyLable myLable122;
    private MyLable myLable121;
    private MyLable myLable125;
    private TextBox gprsAPNTB;
    private MyLable myLable126;
    private ComboBox gprsComCB;
    private NumericUpDown gprsIDLENUD;
    private NumericUpDown gprsRINUD;
    private NumericUpDown gprsMaxRTNUD;
    private ComboBox gprsWorkModeCB;
    private MyLable myLable127;
    private MyLable myLable128;
    private MyLable myLable129;
    private MyLable myLable130;
    private TextBox gprsDNS2TB;
    private TextBox gprsDNS1TB;
    private TextBox gprsGatewayTB;
    private TextBox gprsIPTB;
    private TextBox gprsStatusTB;
    private MyLable myLable131;
    private MyLable myLable132;
    private MyLable myLable133;
    private MyLable myLable134;
    private MyLable myLable135;

    public RebootTypes RebootType
    {
      get
      {
        return this.rebootType;
      }
    }

    public Device SelectDevice
    {
      get
      {
        return this.device;
      }
    }

    public MyPanel()
    {
      this.InitializeComponent();
      this.timeZoneCB.Items.Clear();
      this.timeZoneCB.Items.AddRange((object[]) Program.arytimezone);
    }

    public void SetSelectDevice(Device device, PanelTypes panelType, byte channelID)
    {
      this.device = device;
      this.initPanel(panelType, channelID);
    }

    public bool initPanel(PanelTypes panelType)
    {
      return this.initPanel(panelType, (byte) 0);
    }

    public bool initPanel(PanelTypes panelType, byte channelNum)
    {
      try
      {
        this.panelType = panelType;
        this.channelNum = channelNum;
        switch (panelType)
        {
          case PanelTypes.BasicSetting:
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.basicPanel.Visible = true;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            if (!this.device.BasicSetting)
            {
              if (!this.getValue())
                return false;
              this.device.BasicSetting = true;
              break;
            }
            break;
          case PanelTypes.NetworkSetting:
            this.basicPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.networkPanel.Visible = true;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            if (!this.device.NetworkSetting)
            {
              if (!this.getValue())
                return false;
              this.device.NetworkSetting = true;
              break;
            }
            break;
          case PanelTypes.ServerSetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.serverPanel.Visible = true;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            if (!this.device.ServerSetting)
            {
              if (!this.getValue())
                return false;
              this.device.ServerSetting = true;
              break;
            }
            break;
          case PanelTypes.EmailSetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.emailPanel.Visible = true;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            if (!this.device.EmailSetting)
            {
              if (!this.getValue())
                return false;
              this.device.EmailSetting = true;
              break;
            }
            break;
          case PanelTypes.TriggerSetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.triggerPanel.Visible = true;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            if (!this.device.TriggerSetting)
            {
              if (!this.getValue())
                return false;
              this.device.TriggerSetting = true;
              break;
            }
            break;
          case PanelTypes.InputTriggerSetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.inputTriggerPanel.Visible = true;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            if (!this.device.InputTriggerSetting)
            {
              if (!this.getValue())
                return false;
              this.device.InputTriggerSetting = true;
              break;
            }
            break;
          case PanelTypes.HostlistSetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.histlistPanel.Visible = true;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            Channel channelByChannelNum1 = Controller.getChannelByChannelNum(this.device, channelNum);
            if (!channelByChannelNum1.HostlistSetting)
            {
              if (!this.getValue())
                return false;
              channelByChannelNum1.HostlistSetting = true;
              break;
            }
            break;
          case PanelTypes.SerialSetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.serialPanel.Visible = true;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            Channel channelByChannelNum2 = Controller.getChannelByChannelNum(this.device, channelNum);
            if (!channelByChannelNum2.SerialSetting)
            {
              if (!this.getValue())
                return false;
              channelByChannelNum2.SerialSetting = true;
              break;
            }
            break;
          case PanelTypes.ConnectionSetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.connectionPanel.Visible = true;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            Channel channelByChannelNum3 = Controller.getChannelByChannelNum(this.device, channelNum);
            if (!channelByChannelNum3.ConnectionSetting)
            {
              if (!this.getValue())
                return false;
              channelByChannelNum3.ConnectionSetting = true;
              break;
            }
            break;
          case PanelTypes.ChangePassword:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.passwordPanel.Visible = true;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            break;
          case PanelTypes.PinsSetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.pinsPanel.Visible = true;
            this.passwordPanel.Visible = false;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            if (!this.device.PinsSetting)
            {
              if (!this.getValue())
                return false;
              this.device.PinsSetting = true;
              break;
            }
            break;
          case PanelTypes.PPPOESetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pppoePanel.Visible = true;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            if (!this.device.PPPOESetting)
            {
              if (!this.getValue())
                return false;
              this.device.PPPOESetting = true;
              break;
            }
            break;
          case PanelTypes.PPPSetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = true;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            if (!this.device.PPPSetting)
            {
              if (!this.getValue())
                return false;
              this.device.PPPSetting = true;
              break;
            }
            break;
          case PanelTypes.GPRSSetting:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = true;
            if (!this.device.GPRSSetting)
            {
              if (!this.getValue())
                return false;
              this.device.GPRSSetting = true;
              break;
            }
            break;
          case PanelTypes.PowerManage:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = true;
            this.gprsPanel.Visible = false;
            break;
          default:
            this.basicPanel.Visible = false;
            this.networkPanel.Visible = false;
            this.serverPanel.Visible = false;
            this.emailPanel.Visible = false;
            this.triggerPanel.Visible = false;
            this.inputTriggerPanel.Visible = false;
            this.histlistPanel.Visible = false;
            this.serialPanel.Visible = false;
            this.connectionPanel.Visible = false;
            this.passwordPanel.Visible = false;
            this.pinsPanel.Visible = false;
            this.pppoePanel.Visible = false;
            this.pppPanel.Visible = false;
            this.powerPanel.Visible = false;
            this.gprsPanel.Visible = false;
            return false;
        }
        this.initValue();
        return true;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        return false;
      }
    }

    public bool getValue()
    {
      this.device.ClearMessage();
      this.device.IsChecked = true;
      bool isDevice;
      switch (this.panelType)
      {
        case PanelTypes.HostlistSetting:
        case PanelTypes.SerialSetting:
        case PanelTypes.ConnectionSetting:
          isDevice = false;
          break;
        default:
          isDevice = true;
          break;
      }
      string message = "";
      ResponseTypes parameters = Controller.GetParameters(this.device, this.panelType, ref message, this.channelNum, isDevice);
      if (parameters == ResponseTypes.OK)
      {
        if (!this.device.IsChecked)
          Program.ShowMessage(Message.GetError + ":" + this.device.GetMessage(), true);
        else
          Program.ShowMessage(Message.GetOK, false);
      }
      else
        Controller.OptionMassage(parameters);
      return parameters == ResponseTypes.OK;
    }

    private void setVisibility(string name, Control c1, Control c2)
    {
      this.setVisibility(true, name, c1, c2);
    }

    private void setVisibility(bool isDevice, string name, Control c1, Control c2)
    {
      this.setVisibility(isDevice, name, c1, c2, (Control) null);
    }

    private void setVisibility(bool isDevice, string name, Control c1, Control c2, Control c3)
    {
      if ((bool) (!isDevice ? Controller.getChannelByChannelNum(this.device, this.channelNum).Visibility : this.device.Visibility)[(object) name])
      {
        this.isAllDisVisibility = false;
        c1.Visible = true;
        if (c2 != null)
          c2.Visible = true;
        if (c3 == null)
          return;
        c3.Visible = true;
      }
      else
      {
        c1.Visible = false;
        if (c2 != null)
          c2.Visible = false;
        if (c3 == null)
          return;
        c3.Visible = false;
      }
    }

    public void initValue()
    {
      try
      {
        this.isAllDisVisibility = true;
        switch (this.panelType)
        {
          case PanelTypes.BasicSetting:
            this.setVisibility("DeviceName", (Control) this.myLable1, (Control) this.nameTB);
            this.nameTB.Text = this.device.DeviceName;
            this.setVisibility("TimeZone", (Control) this.myLable2, (Control) this.timeZoneCB);
            this.timeZoneCB.Text = this.device.TimeZone;
            this.setVisibility("LocalTime", (Control) this.myLable3, (Control) this.localTimeTB);
            this.localTimeTB.Value = this.device.LocalTime;
            this.setVisibility("TimeServer", (Control) this.myLable4, (Control) this.timeServerTB);
            this.timeServerTB.Text = this.device.TimeServer;
            this.setVisibility("WebConsole", (Control) this.myLable5, (Control) this.webCB);
            this.webCB.Checked = this.device.WebConsole == BinaryOptions.Enable;
            this.setVisibility("TelnetConsole", (Control) this.myLable6, (Control) this.telnetCB);
            this.telnetCB.Checked = this.device.TelnetConsole == BinaryOptions.Enable;
            this.setVisibility("TerminalName", (Control) this.myLable7, (Control) this.terminalTB);
            this.terminalTB.Text = this.device.TerminalName;
            break;
          case PanelTypes.NetworkSetting:
            this.setVisibility("IPConfiguration", (Control) this.autoCfRB, (Control) this.userCfRB);
            this.autoCfRB.Checked = this.device.IPConfiguration == Device.IPManner.Automatically;
            this.userCfRB.Checked = this.device.IPConfiguration == Device.IPManner.Manually;
            this.setVisibility("Bootp", (Control) this.myLable8, (Control) this.bootpCB);
            this.bootpCB.Checked = this.device.Bootp == BinaryOptions.Enable;
            this.setVisibility("DHCP", (Control) this.myLable9, (Control) this.dhcpCB);
            this.dhcpCB.Checked = this.device.DHCP == BinaryOptions.Enable;
            this.setVisibility("AutoIP", (Control) this.myLable11, (Control) this.autoIPCB);
            this.autoIPCB.Checked = this.device.AutoIP == BinaryOptions.Enable;
            this.setVisibility("DHCPHostName", (Control) this.myLable12, (Control) this.dhcpNameTB);
            this.dhcpNameTB.Text = this.device.DHCPHostName;
            this.setVisibility("IPAddress", (Control) this.myLable13, (Control) this.ipTB);
            this.ipTB.Text = this.device.IPAddress.ToString();
            this.setVisibility("Subnet", (Control) this.myLable15, (Control) this.subnetTB);
            this.subnetTB.Text = this.device.Subnet.ToString();
            this.setVisibility("DefaultGateway", (Control) this.myLable16, (Control) this.gatewayTB);
            this.gatewayTB.Text = this.device.DefaultGateway.ToString();
            this.setVisibility("PreferredDNSServer", (Control) this.myLable17, (Control) this.pDNSTB);
            this.pDNSTB.Text = this.device.PreferredDNSServer.ToString();
            this.setVisibility("AlternateDNSServer", (Control) this.myLable18, (Control) this.altDNSTB);
            this.altDNSTB.Text = this.device.AlternateDNSServer.ToString();
            this.setVisibility("AutoNegotiate", (Control) this.autoNegoCB, (Control) null);
            this.autoNegoCB.Checked = this.device.AutoNegotiate;
            this.setVisibility("Speed", (Control) this.myLable19, (Control) this.speedCB);
            this.speedCB.Items.Clear();
            if (this.device.Can10M)
              this.speedCB.Items.Add((object) "10M");
            if (this.device.Can100M)
              this.speedCB.Items.Add((object) "100M");
            if (this.device.Speed == Device.NetSpeed._10Mbps)
            {
              for (int index = 0; index < this.speedCB.Items.Count; ++index)
              {
                if (this.speedCB.Items[index].ToString() == "10M")
                {
                  this.speedCB.SelectedIndex = index;
                  break;
                }
              }
            }
            else
            {
              for (int index = 0; index < this.speedCB.Items.Count; ++index)
              {
                if (this.speedCB.Items[index].ToString() == "100M")
                {
                  this.speedCB.SelectedIndex = index;
                  break;
                }
              }
            }
            this.speedCB.SelectedIndex = (int) this.device.Speed;
            this.setVisibility("Duplex", (Control) this.myLable20, (Control) this.duplexCB);
            this.duplexCB.SelectedIndex = (int) this.device.Duplex;
            this.setVisibility("MacAddress", (Control) this.myLable21, (Control) this.macTB);
            this.macTB.Text = this.device.MacAddress;
            this.setVisibility("Ethernet", (Control) this.ethernetCB, (Control) null);
            this.ethernetCB.Checked = this.device.Ethernet;
            this.setVisibility("PPP", (Control) this.pppCB, (Control) null);
            this.pppCB.Checked = this.device.PPP;
            this.setVisibility("PPPoE", (Control) this.pppoeCB, (Control) null);
            this.pppoeCB.Checked = this.device.PPPoE;
            this.setVisibility("GPRS", (Control) this.GPRSCB, (Control) null);
            this.GPRSCB.Checked = this.device.GPRS;
            this.autoCfRB_CheckedChanged((object) null, (EventArgs) null);
            break;
          case PanelTypes.ServerSetting:
            this.setVisibility("ARPcacheTimeout", (Control) this.myLable22, (Control) this.arpNUD);
            this.arpNUD.Value = (Decimal) this.device.ARPcacheTimeout;
            this.arpNUD.Text = this.arpNUD.Value.ToString();
            this.setVisibility("MonitorModeBootup", (Control) this.myLable23, (Control) this.monitorCB);
            this.monitorCB.Checked = this.device.MonitorModeBootup == BinaryOptions.Enable;
            this.setVisibility("CPUPerformanceMode", (Control) this.myLable24, (Control) this.cpuCB);
            this.cpuCB.SelectedIndex = (int) this.device.CPUPerformanceMode;
            this.setVisibility("HTTPServerPort", (Control) this.myLable25, (Control) this.httpPortNUD);
            this.httpPortNUD.Value = (Decimal) this.device.HTTPServerPort;
            this.httpPortNUD.Text = this.httpPortNUD.Value.ToString();
            this.setVisibility("MTUSize", (Control) this.myLable26, (Control) this.mtuTB);
            this.mtuTB.Text = this.device.MTUSize.ToString();
            break;
          case PanelTypes.EmailSetting:
            this.setVisibility("SMTPDomainName", (Control) this.myLable31, (Control) this.smtpDTB);
            this.smtpDTB.Text = this.device.SMTPDomainName;
            this.setVisibility("SMTPPort", (Control) this.myLable30, (Control) this.smtpPNUD);
            this.smtpPNUD.Value = (Decimal) this.device.SMTPPort;
            this.smtpPNUD.Text = this.smtpPNUD.Value.ToString();
            this.setVisibility("EmailAddress", (Control) this.myLable29, (Control) this.emailTB);
            this.emailTB.Text = this.device.EmailAddress;
            this.setVisibility("EmailUsername", (Control) this.myLable27, (Control) this.emailUserTB);
            this.emailUserTB.Text = this.device.EmailUsername;
            this.setVisibility("EmailPassword", (Control) this.myLable28, (Control) this.emailPwdTB);
            this.emailPwdTB.Text = this.device.EmailPassword;
            this.setVisibility("EmailAddress1", (Control) this.myLable32, (Control) this.email1TB);
            this.email1TB.Text = this.device.EmailAddress1;
            this.setVisibility("EmailAddress2", (Control) this.myLable33, (Control) this.emial2TB);
            this.emial2TB.Text = this.device.EmailAddress2;
            this.setVisibility("EmailAddress3", (Control) this.myLable34, (Control) this.email3TB);
            this.email3TB.Text = this.device.EmailAddress3;
            break;
          case PanelTypes.TriggerSetting:
            this.setVisibility("ColdStart", (Control) this.myLable35, (Control) this.coldCB);
            this.coldCB.SelectedIndex = (int) this.device.ColdStart;
            this.setVisibility("WarmStart", (Control) this.myLable36, (Control) this.warmCB);
            this.warmCB.SelectedIndex = (int) this.device.WarmStart;
            this.setVisibility("DCDChanged", (Control) this.myLable37, (Control) this.dcdCB);
            this.dcdCB.SelectedIndex = (int) this.device.DCDChanged;
            this.setVisibility("DSRChanged", (Control) this.myLable38, (Control) this.dsrCB);
            this.dsrCB.SelectedIndex = (int) this.device.DSRChanged;
            this.setVisibility("AuthenticationFailure", (Control) this.myLable39, (Control) this.loginFailCB);
            this.loginFailCB.SelectedIndex = (int) this.device.AuthenticationFailure;
            this.setVisibility("IPAddressChanged", (Control) this.myLable40, (Control) this.ipChangeCB);
            this.ipChangeCB.SelectedIndex = (int) this.device.IPAddressChanged;
            this.setVisibility("PasswordChanged", (Control) this.myLable41, (Control) this.pwdChangeCB);
            this.pwdChangeCB.SelectedIndex = (int) this.device.PasswordChanged;
            this.setVisibility("EmailTriggerSubject", (Control) this.myLable42, (Control) this.triggerMTB);
            this.triggerMTB.Text = this.device.EmailTriggerSubject;
            this.setVisibility("Priority", (Control) this.myLable43, (Control) this.priorityCB);
            switch (this.device.Priority)
            {
              case Device.enumPriority.High:
                this.priorityCB.SelectedIndex = 2;
                break;
              case Device.enumPriority.Normal:
                this.priorityCB.SelectedIndex = 1;
                break;
              case Device.enumPriority.Low:
                this.priorityCB.SelectedIndex = 0;
                break;
            }
            this.setVisibility("MinNotificationInterval", (Control) this.myLable44, (Control) this.minNotifyNUD);
            this.minNotifyNUD.Value = (Decimal) this.device.MinNotificationInterval;
            this.minNotifyNUD.Text = this.minNotifyNUD.Value.ToString();
            break;
          case PanelTypes.InputTriggerSetting:
            this.setVisibility("Input1", (Control) this.myLable54, (Control) this.input1CB);
            this.input1CB.SelectedIndex = (int) this.device.Input1;
            this.setVisibility("Input2", (Control) this.myLable53, (Control) this.input2CB);
            this.input2CB.SelectedIndex = (int) this.device.Input2;
            this.setVisibility("EnableSerialTriggerInput", (Control) this.myLable50, (Control) this.enableSerialCB);
            this.enableSerialCB.Checked = this.device.EnableSerialTriggerInput;
            this.setVisibility("SerialChannel", (Control) this.myLable49, (Control) this.channelsCB);
            this.channelsCB.SelectedIndex = (int) this.device.SerialChannel;
            this.setVisibility("SerialDataSize", (Control) this.myLable48, (Control) this.dataSizeCB);
            this.dataSizeCB.SelectedIndex = (int) this.device.SerialDataSize;
            this.setVisibility("SerialMatchData1", (Control) this.label10, (Control) this.char1TB);
            this.char1TB.Text = this.device.SerialMatchData1;
            this.setVisibility("SerialMatchData2", (Control) this.label11, (Control) this.char2TB);
            this.char2TB.Text = this.device.SerialMatchData2;
            this.setVisibility("SerialMatchData3", (Control) this.label12, (Control) this.char3TB);
            this.char3TB.Text = this.device.SerialMatchData3;
            this.setVisibility("EmailInputTriggerMessage", (Control) this.myLable47, (Control) this.messageTB);
            this.messageTB.Text = this.device.EmailInputTriggerMessage;
            this.setVisibility("InputPriority", (Control) this.myLable46, (Control) this.inputPriorityCB);
            switch (this.device.InputPriority)
            {
              case Device.enumPriority.High:
                this.inputPriorityCB.SelectedIndex = 2;
                break;
              case Device.enumPriority.Normal:
                this.inputPriorityCB.SelectedIndex = 1;
                break;
              case Device.enumPriority.Low:
                this.inputPriorityCB.SelectedIndex = 0;
                break;
            }
            this.setVisibility("InputMinNotificationInterval", (Control) this.myLable45, (Control) this.inputMNINUD);
            this.inputMNINUD.Value = (Decimal) this.device.InputMinNotificationInterval;
            this.inputMNINUD.Text = this.inputMNINUD.Value.ToString();
            this.setVisibility("RenotificationInterval", (Control) this.myLable51, (Control) this.reNotifyNUD);
            this.reNotifyNUD.Value = (Decimal) this.device.RenotificationInterval;
            this.reNotifyNUD.Text = this.reNotifyNUD.Value.ToString();
            this.enableSerialCB_CheckedChanged((object) null, (EventArgs) null);
            break;
          case PanelTypes.HostlistSetting:
            Channel channelByChannelNum1 = Controller.getChannelByChannelNum(this.device, this.channelNum);
            if (this.device.CanGPRS || this.device.CanPPP)
            {
              if (!this.device.NetworkSetting)
              {
                this.panelType = PanelTypes.NetworkSetting;
                this.getValue();
                this.panelType = PanelTypes.HostlistSetting;
              }
              if (this.device.CanPPP && !this.device.PPPSetting)
              {
                this.panelType = PanelTypes.PPPSetting;
                this.getValue();
                this.panelType = PanelTypes.HostlistSetting;
              }
              if (this.device.CanGPRS && !this.device.GPRSSetting)
              {
                this.panelType = PanelTypes.GPRSSetting;
                this.getValue();
                this.panelType = PanelTypes.HostlistSetting;
              }
              this.histlistPanel.Enabled = !channelByChannelNum1.ComIsUsed();
            }
            else
              this.histlistPanel.Enabled = true;
            this.channelNameL.Text = "Channel " + channelByChannelNum1.getChannelName();
            this.setVisibility(false, "RetryCounter", (Control) this.myLable52, (Control) this.retryCNUD);
            this.retryCNUD.Value = (Decimal) channelByChannelNum1.RetryCounter;
            this.retryCNUD.Text = this.retryCNUD.Value.ToString();
            this.setVisibility(false, "RetryTimeout", (Control) this.myLable55, (Control) this.retryTNUD);
            this.retryTNUD.Value = (Decimal) channelByChannelNum1.RetryTimeout;
            this.retryTNUD.Text = this.retryTNUD.Value.ToString();
            this.setVisibility(false, "EnableBackupLink", (Control) this.myLable109, (Control) this.backupLinkCB);
            this.backupLinkCB.SelectedIndex = (int) channelByChannelNum1.EnableBackupLink;
            this.setVisibility(false, "HostList", (Control) this.tableLayoutPanel1, (Control) this.tableLayoutPanel1);
            for (int index = 0; index < 12; ++index)
            {
              bool flag = false;
              foreach (Control control in (ArrangedElementCollection) this.tableLayoutPanel1.Controls)
              {
                if (control is TextBox)
                {
                  if (control.Name == "hostIP" + (object) (index + 1) + "TB")
                  {
                    control.Text = index >= channelByChannelNum1.HostList.Count ? "" : channelByChannelNum1.HostList[index].IpAddress.ToString();
                    if (!flag)
                      flag = true;
                    else
                      break;
                  }
                  else if (control.Name == "hostPort" + (object) (index + 1) + "TB")
                  {
                    control.Text = index >= channelByChannelNum1.HostList.Count ? "" : channelByChannelNum1.HostList[index].Port.ToString();
                    if (!flag)
                      flag = true;
                    else
                      break;
                  }
                }
              }
            }
            break;
          case PanelTypes.SerialSetting:
            Channel channelByChannelNum2 = Controller.getChannelByChannelNum(this.device, this.channelNum);
            if (this.device.CanGPRS || this.device.CanPPP)
            {
              if (!this.device.NetworkSetting)
              {
                this.panelType = PanelTypes.NetworkSetting;
                this.getValue();
                this.panelType = PanelTypes.SerialSetting;
              }
              if (this.device.CanPPP && !this.device.PPPSetting)
              {
                this.panelType = PanelTypes.PPPSetting;
                this.getValue();
                this.panelType = PanelTypes.SerialSetting;
              }
              if (this.device.CanGPRS && !this.device.GPRSSetting)
              {
                this.panelType = PanelTypes.GPRSSetting;
                this.getValue();
                this.panelType = PanelTypes.SerialSetting;
              }
              this.panel9.Enabled = !channelByChannelNum2.ComIsUsed();
            }
            else
              this.panel9.Enabled = true;
            this.channelNameL1.Text = "Channel " + channelByChannelNum2.getChannelName();
            this.setVisibility(false, "SerialPortOptions", (Control) this.myLable57, (Control) this.serialOptionCB);
            this.serialOptionCB.Checked = channelByChannelNum2.SerialPortOptions == BinaryOptions.Enable;
            this.protocolCB.Items.Clear();
            if (channelByChannelNum2.canRS232())
              this.protocolCB.Items.Add((object) "RS232");
            if (channelByChannelNum2.canRS422())
              this.protocolCB.Items.Add((object) "RS422");
            if (channelByChannelNum2.canRS485())
              this.protocolCB.Items.Add((object) "RS485");
            this.setVisibility(false, "SerialPortProtocol", (Control) this.myLable58, (Control) this.protocolCB);
            for (int index = 0; index < this.protocolCB.Items.Count; ++index)
            {
              if (this.protocolCB.Items[index].ToString() == channelByChannelNum2.SerialPortProtocol.ToString())
              {
                this.protocolCB.SelectedIndex = index;
                break;
              }
            }
            this.setVisibility(false, "FIFO", (Control) this.myLable59, (Control) this.fifoCB);
            this.fifoCB.SelectedIndex = (int) channelByChannelNum2.FIFO;
            this.setVisibility(false, "DataBits", (Control) this.myLable62, (Control) this.databitCB);
            this.databitCB.SelectedIndex = (int) channelByChannelNum2.DataBits;
            this.baudrateCB.Items.Clear();
            switch (this.device.BaudRateNum)
            {
              case 0:
                this.baudrateCB.Items.AddRange((object[]) new string[16]
                {
                  "110",
                  "134",
                  "150",
                  "300",
                  "600",
                  "1200",
                  "1800",
                  "2400",
                  "4800",
                  "7200",
                  "9600",
                  "14400",
                  "19200",
                  "38400",
                  "57600",
                  "115200"
                });
                break;
              case 1:
                this.baudrateCB.Items.AddRange((object[]) new string[18]
                {
                  "110",
                  "134",
                  "150",
                  "300",
                  "600",
                  "1200",
                  "1800",
                  "2400",
                  "4800",
                  "7200",
                  "9600",
                  "14400",
                  "19200",
                  "38400",
                  "57600",
                  "115200",
                  "230400",
                  "460800"
                });
                break;
              case 2:
                this.baudrateCB.Items.AddRange((object[]) new string[19]
                {
                  "110",
                  "134",
                  "150",
                  "300",
                  "600",
                  "1200",
                  "1800",
                  "2400",
                  "4800",
                  "7200",
                  "9600",
                  "14400",
                  "19200",
                  "38400",
                  "57600",
                  "115200",
                  "230400",
                  "460800",
                  "921600"
                });
                break;
              case 3:
                this.baudrateCB.Items.AddRange((object[]) new string[14]
                {
                  "110",
                  "134",
                  "150",
                  "300",
                  "600",
                  "1200",
                  "1800",
                  "2400",
                  "4800",
                  "7200",
                  "9600",
                  "14400",
                  "19200",
                  "38400"
                });
                break;
              default:
                this.baudrateCB.Items.AddRange((object[]) new string[19]
                {
                  "110",
                  "134",
                  "150",
                  "300",
                  "600",
                  "1200",
                  "1800",
                  "2400",
                  "4800",
                  "7200",
                  "9600",
                  "14400",
                  "19200",
                  "38400",
                  "57600",
                  "115200",
                  "230400",
                  "460800",
                  "921600"
                });
                break;
            }
            this.baudrateCB.DropDownStyle = !this.device.IsNewVersion ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown;
            this.setVisibility(false, "BaudRate", (Control) this.myLable61, (Control) this.baudrateCB);
            this.baudrateCB.Text = channelByChannelNum2.BaudRate.ToString();
            this.setVisibility(false, "FlowControl", (Control) this.myLable60, (Control) this.flowCB);
            for (int index = 0; index < this.flowCB.Items.Count; ++index)
            {
              if (this.flowCB.Items[index].ToString() == channelByChannelNum2.FlowControl.ToString())
              {
                this.flowCB.SelectedIndex = index;
                break;
              }
            }
            this.setVisibility(false, "Parity", (Control) this.myLable63, (Control) this.parityCB);
            this.parityCB.SelectedIndex = (int) channelByChannelNum2.Parity;
            this.setVisibility(false, "StopBits", (Control) this.myLable64, (Control) this.stopbitCB);
            this.stopbitCB.SelectedIndex = (int) channelByChannelNum2.StopBits;
            this.setVisibility(false, "EnablePacking", (Control) this.myLable65, (Control) this.enablePackCB);
            this.enablePackCB.Checked = channelByChannelNum2.EnablePacking;
            this.setVisibility(false, "IdleGapTime", (Control) this.myLable66, (Control) this.idleCB);
            this.idleCB.SelectedIndex = (int) channelByChannelNum2.IdleGapTime;
            this.setVisibility(false, "Match2ByteSequence", (Control) this.myLable67, (Control) this.match2CB);
            this.match2CB.Checked = channelByChannelNum2.Match2ByteSequence;
            this.setVisibility(false, "FirstMatchByte", (Control) this.label33, (Control) this.firstCharTB);
            this.firstCharTB.Text = channelByChannelNum2.FirstMatchByte;
            this.setVisibility(false, "LastMatchByte", (Control) this.label34, (Control) this.lastTB);
            this.lastTB.Text = channelByChannelNum2.LastMatchByte;
            this.setVisibility(false, "SendFrameOnly", (Control) this.myLable68, (Control) this.sendFrameCB);
            this.sendFrameCB.Checked = channelByChannelNum2.SendFrameOnly;
            this.setVisibility(false, "SendTrailingBytes", (Control) this.myLable71, (Control) this.sendBytesCB);
            this.sendBytesCB.SelectedIndex = (int) channelByChannelNum2.SendTrailingBytes;
            this.enablePackCB_CheckedChanged((object) null, (EventArgs) null);
            this.serialOptionCB_CheckedChanged((object) null, (EventArgs) null);
            break;
          case PanelTypes.ConnectionSetting:
            Channel channelByChannelNum3 = Controller.getChannelByChannelNum(this.device, this.channelNum);
            if (this.device.CanGPRS || this.device.CanPPP)
            {
              if (!this.device.NetworkSetting)
              {
                this.panelType = PanelTypes.NetworkSetting;
                this.getValue();
                this.panelType = PanelTypes.ConnectionSetting;
              }
              if (this.device.CanPPP && !this.device.PPPSetting)
              {
                this.panelType = PanelTypes.PPPSetting;
                this.getValue();
                this.panelType = PanelTypes.ConnectionSetting;
              }
              if (this.device.CanGPRS && !this.device.GPRSSetting)
              {
                this.panelType = PanelTypes.GPRSSetting;
                this.getValue();
                this.panelType = PanelTypes.ConnectionSetting;
              }
              this.connectionPanel.Enabled = !channelByChannelNum3.ComIsUsed();
            }
            else
              this.connectionPanel.Enabled = true;
            this.channelNameL2.Text = "Channel " + channelByChannelNum3.getChannelName();
            this.setVisibility(false, "NetProtocol", (Control) this.myLable76, (Control) this.netProtocolCB);
            this.netProtocolCB.SelectedIndex = (int) channelByChannelNum3.NetProtocol;
            this.setVisibility(false, "DatagramType", (Control) this.myLable77, (Control) this.datagramCB);
            this.datagramCB.SelectedIndex = (int) channelByChannelNum3.DatagramType;
            this.setVisibility(false, "AcceptIncoming", (Control) this.myLable78, (Control) this.udpAcceptCB);
            this.udpAcceptCB.Checked = !this.device.IsNewVersion ? !channelByChannelNum3.AcceptIncoming : channelByChannelNum3.AcceptIncoming;
            this.setVisibility(false, "UDPLocalPort", (Control) this.myLable79, (Control) this.udpLocalPortNUD);
            this.udpLocalPortNUD.Value = (Decimal) channelByChannelNum3.UDPLocalPort;
            this.udpLocalPortNUD.Text = this.udpLocalPortNUD.Value.ToString();
            this.setVisibility(false, "UDPRemotePort", (Control) this.myLable80, (Control) this.udpRemotePortNUD);
            this.udpRemotePortNUD.Value = (Decimal) channelByChannelNum3.UDPRemotePort;
            this.udpRemotePortNUD.Text = this.udpRemotePortNUD.Value.ToString();
            this.setVisibility(false, "UDPNetSegment", (Control) this.myLable81, (Control) this.udpSegmentTB);
            this.udpSegmentTB.Text = channelByChannelNum3.UDPNetSegment.ToString();
            this.setVisibility(false, "UDPUniCastLocalPort", (Control) this.myLable82, (Control) this.udpUCLPNUD);
            this.udpUCLPNUD.Value = (Decimal) channelByChannelNum3.UDPUniCastLocalPort;
            this.udpUCLPNUD.Text = this.udpUCLPNUD.Value.ToString();
            this.setVisibility(false, "DeviceAddressTable", (Control) this.myLable83, (Control) this.tableLayoutPanel2);
            for (int index = 0; index < 4; ++index)
            {
              byte num = (byte) 0;
              foreach (Control control in (ArrangedElementCollection) this.tableLayoutPanel2.Controls)
              {
                if (control is TextBox)
                {
                  if (control.Name == "bAddr" + (object) index + "TB")
                  {
                    control.Text = index >= channelByChannelNum3.DeviceAddressTable.Count ? "" : channelByChannelNum3.DeviceAddressTable[index].BeginIPAddress.ToString();
                    if ((int) num != 2)
                      ++num;
                    else
                      break;
                  }
                  else if (control.Name == "eAddr" + (object) index + "TB")
                  {
                    control.Text = index >= channelByChannelNum3.DeviceAddressTable.Count ? "" : channelByChannelNum3.DeviceAddressTable[index].EndIPAddress.ToString();
                    if ((int) num != 2)
                      ++num;
                    else
                      break;
                  }
                }
                else if (control is NumericUpDown && control.Name == "udpPort" + (object) index + "TB")
                {
                  control.Text = index >= channelByChannelNum3.DeviceAddressTable.Count ? "" : channelByChannelNum3.DeviceAddressTable[index].Port.ToString();
                  if ((int) num != 2)
                    ++num;
                  else
                    break;
                }
              }
            }
            if (this.device.IsNewVersion)
            {
              this.workasCB.Items.Clear();
              this.workasCB.Items.Add((object) "Client");
              this.workasCB.Items.Add((object) "Server");
              this.workasCB.Items.Add((object) "Both");
              this.setVisibility(false, "TCPMode", (Control) this.myLable84, (Control) this.workasCB);
              this.workasCB.SelectedIndex = (int) channelByChannelNum3.TCPMode;
            }
            else
            {
              this.workasCB.Items.Clear();
              this.workasCB.Items.Add((object) "Server");
              this.workasCB.Items.Add((object) "Client");
              this.setVisibility(false, "AcceptionIncoming", (Control) this.myLable84, (Control) this.workasCB);
              this.workasCB.SelectedIndex = (int) channelByChannelNum3.AcceptionIncoming;
            }
            this.setVisibility(false, "ActiveConnect", (Control) this.myLable85, (Control) this.tcpActiveCB);
            this.tcpActiveCB.SelectedIndex = (int) channelByChannelNum3.ActiveConnect;
            this.setVisibility(false, "StartCharacter", (Control) this.myLable86, (Control) this.label42, (Control) this.startCharTB);
            this.startCharTB.Text = channelByChannelNum3.StartCharacter;
            this.setVisibility(false, "LocalPort", (Control) this.myLable87, (Control) this.tcpLocalPortNUD);
            this.tcpLocalPortNUD.Value = (Decimal) channelByChannelNum3.LocalPort;
            this.tcpLocalPortNUD.Text = this.tcpLocalPortNUD.Value.ToString();
            this.setVisibility(false, "RemotePort", (Control) this.myLable88, (Control) this.tcpRemotePortNUD);
            this.tcpRemotePortNUD.Value = (Decimal) channelByChannelNum3.RemotePort;
            this.tcpRemotePortNUD.Text = this.tcpRemotePortNUD.Value.ToString();
            this.setVisibility(false, "DNSQueryPeriod", (Control) this.myLable56, (Control) this.dnsQueryPeriodNUD);
            this.dnsQueryPeriodNUD.Value = (Decimal) channelByChannelNum3.DNSQueryPeriod;
            this.dnsQueryPeriodNUD.Text = this.dnsQueryPeriodNUD.Value.ToString();
            this.setVisibility(false, "RemoteHost", (Control) this.myLable89, (Control) this.tcpRomteHostTB);
            this.tcpRomteHostTB.Text = channelByChannelNum3.RemoteHost.ToString();
            this.setVisibility(false, "UseHostlist", (Control) this.myLable91, (Control) this.useHostlistCB);
            this.useHostlistCB.Checked = channelByChannelNum3.UseHostlist;
            this.setVisibility(false, "ConnectResponse", (Control) this.myLable90, (Control) this.connectResponseCB);
            this.connectResponseCB.SelectedIndex = (int) channelByChannelNum3.ConnectResponse;
            if (!channelByChannelNum3.canModen())
              channelByChannelNum3.Visibility[(object) "OnDSRDrop"] = (object) false;
            this.setVisibility(false, "OnDSRDrop", (Control) this.myLable92, (Control) this.onDSRDropCB);
            this.onDSRDropCB.Checked = channelByChannelNum3.OnDSRDrop;
            this.setVisibility(false, "HardDisconnect", (Control) this.myLable93, (Control) this.hardDisconnectCB);
            this.hardDisconnectCB.Checked = channelByChannelNum3.HardDisconnect;
            this.setVisibility(false, "CheckEOT", (Control) this.myLable94, (Control) this.checkEOTCB);
            this.checkEOTCB.Checked = channelByChannelNum3.CheckEOT;
            this.setVisibility(false, "InactivityTimeout", (Control) this.myLable95, (Control) this.inactivityNUD);
            this.inactivityNUD.Value = (Decimal) channelByChannelNum3.InactivityTimeout;
            this.inactivityNUD.Text = channelByChannelNum3.InactivityTimeout.ToString();
            this.setVisibility(false, "InputWithActiveConnect", (Control) this.myLable72, (Control) this.iwacCB);
            this.iwacCB.Checked = channelByChannelNum3.InputWithActiveConnect;
            this.setVisibility(false, "InputWithPassiveConnect", (Control) this.myLable73, (Control) this.iwpcCB);
            this.iwpcCB.Checked = channelByChannelNum3.InputWithPassiveConnect;
            this.setVisibility(false, "InputAtTimeofDisconnect", (Control) this.myLable69, (Control) this.iatdCB);
            this.iatdCB.Checked = channelByChannelNum3.InputAtTimeofDisconnect;
            this.setVisibility(false, "OutputWithActiveConnect", (Control) this.myLable70, (Control) this.owacCB);
            this.owacCB.Checked = channelByChannelNum3.OutputWithActiveConnect;
            this.setVisibility(false, "OutputWithPassiveConnect", (Control) this.myLable74, (Control) this.owpcCB);
            this.owpcCB.Checked = channelByChannelNum3.OutputWithPassiveConnect;
            this.setVisibility(false, "OutputAtTimeofDisconnect", (Control) this.myLable75, (Control) this.oatdCB);
            this.oatdCB.Checked = channelByChannelNum3.OutputAtTimeofDisconnect;
            break;
          case PanelTypes.ChangePassword:
            this.userNameTB.Text = this.device.UserName;
            this.newPwdTB.Text = "";
            this.retypePwdTB.Text = "";
            this.oldPwdTB.Text = "";
            this.isAllDisVisibility = false;
            break;
          case PanelTypes.PinsSetting:
            Channel channelByChannelNum4 = Controller.getChannelByChannelNum(this.device, (byte) 1);
            if (!channelByChannelNum4.SerialSetting)
            {
              byte num = this.channelNum;
              this.channelNum = (byte) 1;
              this.panelType = PanelTypes.SerialSetting;
              this.getValue();
              this.channelNum = num;
              this.panelType = PanelTypes.PinsSetting;
            }
            this.initPinsIOType(channelByChannelNum4.SerialPortProtocol, channelByChannelNum4.FlowControl, this.device.IO1, this.device.IO2);
            this.setVisibility("IO1", (Control) this.myLable96, (Control) this.io1CB);
            this.setVisibility("IO2", (Control) this.myLable97, (Control) this.io2CB);
            this.io1TypeCB.SelectedIndex = (int) this.device.IO1Type;
            this.io2TypeCB.SelectedIndex = (int) this.device.IO2Type;
            this.io1EleCB.SelectedIndex = (int) this.device.IO1State;
            this.io2EleCB.SelectedIndex = (int) this.device.IO2State;
            break;
          case PanelTypes.PPPOESetting:
            this.setVisibility("PPPOEUserName", (Control) this.myLable98, (Control) this.pppoeUserNameTB);
            this.pppoeUserNameTB.Text = this.device.PPPOEUserName;
            this.setVisibility("PPPOEPassword", (Control) this.myLable99, (Control) this.pppoePwdTB);
            this.pppoePwdTB.Text = this.device.PPPOEPassword;
            this.setVisibility("PPPOEWorkMode", (Control) this.myLable100, (Control) this.pppoeWorkModeCB);
            this.pppoeWorkModeCB.SelectedIndex = (int) this.device.PPPOEWorkMode;
            this.setVisibility("PPPOEMaxRedialTimes", (Control) this.myLable101, (Control) this.pppoeMaxRTNUD);
            this.pppoeMaxRTNUD.Value = (Decimal) this.device.PPPOEMaxRedialTimes;
            this.pppoeMaxRTNUD.Text = this.pppoeMaxRTNUD.Value.ToString();
            this.setVisibility("PPPOERedialInterval", (Control) this.myLable102, (Control) this.pppoeRINUD);
            this.pppoeRINUD.Value = (Decimal) this.device.PPPOERedialInterval;
            this.pppoeRINUD.Text = this.pppoeRINUD.Value.ToString();
            this.setVisibility("PPPOEIDLETime", (Control) this.myLable103, (Control) this.ppoeIDLENUD);
            this.ppoeIDLENUD.Value = (Decimal) this.device.PPPOEIDLETime;
            this.ppoeIDLENUD.Text = this.ppoeIDLENUD.Value.ToString();
            this.setVisibility("PPPOEStatus", (Control) this.myLable104, (Control) this.pppoeStatusTB);
            this.pppoeStatusTB.Text = this.device.PPPOEStatus.ToString();
            this.setVisibility("PPPOEIP", (Control) this.myLable105, (Control) this.pppoeIPTB);
            this.pppoeIPTB.Text = this.device.PPPOEIP;
            this.setVisibility("PPPOEGateway", (Control) this.myLable106, (Control) this.pppoeGatewayTB);
            this.pppoeGatewayTB.Text = this.device.PPPOEGateway;
            this.setVisibility("PPPOEDNS1", (Control) this.myLable107, (Control) this.pppoeDNS1TB);
            this.pppoeDNS1TB.Text = this.device.PPPOEDNS1;
            this.setVisibility("PPPOEDNS2", (Control) this.myLable108, (Control) this.pppoeDNS2TB);
            this.pppoeDNS2TB.Text = this.device.PPPOEDNS2;
            break;
          case PanelTypes.PPPSetting:
            this.setVisibility("PPPUserName", (Control) this.myLable119, (Control) this.pppUserNameTB);
            this.pppUserNameTB.Text = this.device.PPPUserName;
            this.setVisibility("PPPPassword", (Control) this.myLable118, (Control) this.pppPwdTB);
            this.pppPwdTB.Text = this.device.PPPPassword;
            this.setVisibility("PPPWorkMode", (Control) this.myLable117, (Control) this.pppWorkModeCB);
            this.pppWorkModeCB.SelectedIndex = (int) this.device.PPPWorkMode;
            this.setVisibility("PPPMaxRedialTimes", (Control) this.myLable116, (Control) this.pppMaxRTNUD);
            this.pppMaxRTNUD.Value = (Decimal) this.device.PPPMaxRedialTimes;
            this.pppMaxRTNUD.Text = this.pppMaxRTNUD.Value.ToString();
            this.setVisibility("PPPRedialInterval", (Control) this.myLable115, (Control) this.pppRINUD);
            this.pppRINUD.Value = (Decimal) this.device.PPPRedialInterval;
            this.pppRINUD.Text = this.pppRINUD.Value.ToString();
            this.setVisibility("PPPIDLETime", (Control) this.myLable114, (Control) this.pppIDLENUD);
            this.pppIDLENUD.Value = (Decimal) this.device.PPPIDLETime;
            this.pppIDLENUD.Text = this.pppIDLENUD.Value.ToString();
            this.pppComCB.Items.Clear();
            if (this.device.CanPPP)
            {
              foreach (Channel channel in this.device.ChannelList)
                this.pppComCB.Items.Add((object) ("COM" + (object) channel.GetComID()));
            }
            this.setVisibility("PPPComID", (Control) this.myLable120, (Control) this.pppComCB);
            for (int index = 0; index < this.pppComCB.Items.Count; ++index)
            {
              if (this.pppComCB.Items[index].ToString() == "COM" + this.device.PPPComID.ToString())
              {
                this.pppComCB.SelectedIndex = index;
                break;
              }
            }
            this.setVisibility("PPPStatus", (Control) this.myLable113, (Control) this.pppStatusTB);
            this.pppStatusTB.Text = this.device.PPPStatus.ToString();
            this.setVisibility("PPPIP", (Control) this.myLable112, (Control) this.pppIPTB);
            this.pppIPTB.Text = this.device.PPPIP;
            this.setVisibility("PPPGateway", (Control) this.myLable111, (Control) this.pppGatewayTB);
            this.pppGatewayTB.Text = this.device.PPPGateway;
            this.setVisibility("PPPDNS1", (Control) this.myLable110, (Control) this.pppDNS1TB);
            this.pppDNS1TB.Text = this.device.PPPDNS1;
            this.setVisibility("PPPDNS2", (Control) this.myLable10, (Control) this.pppDNS2TB);
            this.pppDNS2TB.Text = this.device.PPPDNS2;
            break;
          case PanelTypes.GPRSSetting:
            this.setVisibility("ServiceCode", (Control) this.myLable121, (Control) this.serviceCodeTB);
            this.serviceCodeTB.Text = this.device.ServiceCode;
            this.setVisibility("GPRSPPPUserName", (Control) this.myLable122, (Control) this.gprsUserTB);
            this.gprsUserTB.Text = this.device.GPRSPPPUserName;
            this.setVisibility("GPRSPPPPassword", (Control) this.myLable123, (Control) this.gprsPwdTB);
            this.gprsPwdTB.Text = this.device.GPRSPPPPassword;
            this.setVisibility("GPRSSINUIMPIN", (Control) this.myLable124, (Control) this.supinTB);
            this.supinTB.Text = this.device.GPRSSINUIMPIN;
            this.setVisibility("GPRSAPN", (Control) this.myLable125, (Control) this.gprsAPNTB);
            this.gprsAPNTB.Text = this.device.GPRSAPN;
            this.setVisibility("GPRSWorkMode", (Control) this.myLable130, (Control) this.gprsWorkModeCB);
            this.gprsWorkModeCB.SelectedIndex = (int) this.device.GPRSWorkMode;
            this.setVisibility("GPRSMaxRedialTimes", (Control) this.myLable129, (Control) this.gprsMaxRTNUD);
            this.gprsMaxRTNUD.Value = (Decimal) this.device.GPRSMaxRedialTimes;
            this.gprsMaxRTNUD.Text = this.gprsMaxRTNUD.Value.ToString();
            this.setVisibility("GPRSRedialInterval", (Control) this.myLable128, (Control) this.gprsRINUD);
            this.gprsRINUD.Value = (Decimal) this.device.GPRSRedialInterval;
            this.gprsRINUD.Text = this.gprsRINUD.Value.ToString();
            this.setVisibility("GPRSIDLETime", (Control) this.myLable127, (Control) this.gprsIDLENUD);
            this.gprsIDLENUD.Value = (Decimal) this.device.GPRSIDLETime;
            this.gprsIDLENUD.Text = this.gprsIDLENUD.Value.ToString();
            this.gprsComCB.Items.Clear();
            if (this.device.CanGPRS)
            {
              foreach (Channel channel in this.device.ChannelList)
                this.gprsComCB.Items.Add((object) ("COM" + (object) channel.GetComID()));
            }
            this.setVisibility("GPRSComID", (Control) this.myLable126, (Control) this.gprsComCB);
            for (int index = 0; index < this.gprsComCB.Items.Count; ++index)
            {
              if (this.gprsComCB.Items[index].ToString() == "COM" + this.device.GPRSComID.ToString())
              {
                this.gprsComCB.SelectedIndex = index;
                break;
              }
            }
            this.setVisibility("GPRSStatus", (Control) this.myLable135, (Control) this.gprsStatusTB);
            this.gprsStatusTB.Text = this.device.GPRSStatus.ToString();
            this.setVisibility("GPRSIP", (Control) this.myLable134, (Control) this.gprsIPTB);
            this.gprsIPTB.Text = this.device.GPRSIP;
            this.setVisibility("GPRSGateway", (Control) this.myLable133, (Control) this.gprsGatewayTB);
            this.gprsGatewayTB.Text = this.device.GPRSGateway;
            this.setVisibility("GPRSDNS1", (Control) this.myLable132, (Control) this.gprsDNS1TB);
            this.gprsDNS1TB.Text = this.device.GPRSDNS1;
            this.setVisibility("GPRSDNS2", (Control) this.myLable131, (Control) this.gprsDNS2TB);
            this.gprsDNS2TB.Text = this.device.GPRSDNS2;
            break;
          case PanelTypes.PowerManage:
            this.isAllDisVisibility = false;
            this.radioButton1.Visible = this.device.IsNewVersion;
            this.radioButton2.Visible = this.device.IsNewVersion;
            this.radioButton3.Visible = this.device.IsNewVersion;
            this.radioButton4.Checked = true;
            break;
        }
        if (!this.isAllDisVisibility)
          return;
        this.basicPanel.Visible = false;
        this.networkPanel.Visible = false;
        this.serverPanel.Visible = false;
        this.emailPanel.Visible = false;
        this.triggerPanel.Visible = false;
        this.inputTriggerPanel.Visible = false;
        this.histlistPanel.Visible = false;
        this.serialPanel.Visible = false;
        this.connectionPanel.Visible = false;
        this.passwordPanel.Visible = false;
        this.pinsPanel.Visible = false;
        this.pppPanel.Visible = false;
        Graphics graphics = this.CreateGraphics();
        Font font = new Font(this.Font.FontFamily, 24f, FontStyle.Bold);
        SizeF sizeF = graphics.MeasureString("No Support!", font);
        graphics.DrawString("Not Support!", font, Brushes.Gray, new PointF((float) (((double) this.Width - (double) sizeF.Width) / 2.0), (float) (((double) this.Height - (double) sizeF.Height) / 2.0)));
        this.Refresh();
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        Program.ShowMessage(ex.Message, true);
      }
    }

    public bool setValue()
    {
      bool flag = this.setDevicePara();
      if (flag)
        Program.ShowMessage(Message.SetOK, false);
      else
        Program.ShowMessage(Message.SetError + ":" + this.device.GetMessage(), true);
      return flag;
    }

    private bool setDevicePara()
    {
      try
      {
        string message = "";
        this.device.IsChecked = true;
        this.device.ClearMessage();
        bool isDevice;
        switch (this.panelType)
        {
          case PanelTypes.BasicSetting:
            isDevice = true;
            this.device.DeviceName = this.nameTB.Text;
            this.device.TimeZone = this.timeZoneCB.Text;
            this.device.LocalTime = this.localTimeTB.Value;
            this.device.TimeServer = this.timeServerTB.Text;
            this.device.WebConsole = this.webCB.Checked ? BinaryOptions.Enable : BinaryOptions.Disable;
            this.device.TelnetConsole = this.telnetCB.Checked ? BinaryOptions.Enable : BinaryOptions.Disable;
            this.device.TerminalName = this.terminalTB.Text;
            break;
          case PanelTypes.NetworkSetting:
            isDevice = true;
            if (!Program.CheckIpStr(this.ipTB.Text))
            {
              this.device.AddMessage(Message.InvalidIP, "IPAddress");
              this.device.IsChecked = false;
              break;
            }
            if (!Program.CheckIpStr(this.subnetTB.Text))
            {
              this.device.AddMessage(Message.InvalidIP, "Subnet");
              this.device.IsChecked = false;
              break;
            }
            if (!Program.CheckIpStr(this.gatewayTB.Text))
            {
              this.device.AddMessage(Message.InvalidIP, "DefaultGateway");
              this.device.IsChecked = false;
              break;
            }
            if (!Program.CheckIpStr(this.pDNSTB.Text))
            {
              this.device.AddMessage(Message.InvalidIP, "PreferredDNSServer");
              this.device.IsChecked = false;
              break;
            }
            if (!Program.CheckIpStr(this.altDNSTB.Text))
            {
              this.device.AddMessage(Message.InvalidIP, "AlternateDNSServer");
              this.device.IsChecked = false;
              break;
            }
            this.device.IPConfiguration = this.autoCfRB.Checked ? Device.IPManner.Automatically : Device.IPManner.Manually;
            this.device.Bootp = this.bootpCB.Checked ? BinaryOptions.Enable : BinaryOptions.Disable;
            this.device.DHCP = this.dhcpCB.Checked ? BinaryOptions.Enable : BinaryOptions.Disable;
            this.device.AutoIP = this.autoIPCB.Checked ? BinaryOptions.Enable : BinaryOptions.Disable;
            this.device.DHCPHostName = this.dhcpNameTB.Text;
            this.device.IPAddress = IPAddress.Parse(this.ipTB.Text);
            this.device.Subnet = IPAddress.Parse(this.subnetTB.Text);
            this.device.DefaultGateway = IPAddress.Parse(this.gatewayTB.Text);
            this.device.PreferredDNSServer = IPAddress.Parse(this.pDNSTB.Text);
            this.device.AlternateDNSServer = IPAddress.Parse(this.altDNSTB.Text);
            this.device.AutoNegotiate = this.autoNegoCB.Checked;
            this.device.Speed = !(this.speedCB.SelectedItem.ToString() == "10M") ? Device.NetSpeed._100Mbps : Device.NetSpeed._10Mbps;
            this.device.Duplex = (Device.NetDuplex) this.duplexCB.SelectedIndex;
            this.device.MacAddress = this.macTB.Text;
            this.device.Ethernet = this.ethernetCB.Checked;
            this.device.PPP = this.pppCB.Checked;
            this.device.PPPoE = this.pppoeCB.Checked;
            this.device.GPRS = this.GPRSCB.Checked;
            break;
          case PanelTypes.ServerSetting:
            isDevice = true;
            if (this.arpNUD.Text == "" || this.httpPortNUD.Text == "")
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.ParameterError);
              break;
            }
            this.device.ARPcacheTimeout = (byte) this.arpNUD.Value;
            this.device.MonitorModeBootup = this.monitorCB.Checked ? BinaryOptions.Enable : BinaryOptions.Disable;
            this.device.CPUPerformanceMode = (Device.PerformanceMode) this.cpuCB.SelectedIndex;
            this.device.HTTPServerPort = (ushort) this.httpPortNUD.Value;
            break;
          case PanelTypes.EmailSetting:
            isDevice = true;
            if (this.smtpPNUD.Text == "")
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.ParameterError);
              break;
            }
            this.device.SMTPDomainName = this.smtpDTB.Text;
            this.device.SMTPPort = (ushort) this.smtpPNUD.Value;
            this.device.EmailAddress = this.emailTB.Text;
            this.device.EmailUsername = this.emailUserTB.Text;
            this.device.EmailPassword = this.emailPwdTB.Text;
            this.device.EmailAddress1 = this.email1TB.Text;
            this.device.EmailAddress2 = this.emial2TB.Text;
            this.device.EmailAddress3 = this.email3TB.Text;
            break;
          case PanelTypes.TriggerSetting:
            isDevice = true;
            if (this.minNotifyNUD.Text == "")
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.ParameterError);
              break;
            }
            this.device.ColdStart = (Device.enumMailOption) this.coldCB.SelectedIndex;
            this.device.WarmStart = (Device.enumMailOption) this.warmCB.SelectedIndex;
            this.device.DCDChanged = (Device.enumMailOption) this.dcdCB.SelectedIndex;
            this.device.DSRChanged = (Device.enumMailOption) this.dsrCB.SelectedIndex;
            this.device.AuthenticationFailure = (Device.enumMailOption) this.loginFailCB.SelectedIndex;
            this.device.IPAddressChanged = (Device.enumMailOption) this.ipChangeCB.SelectedIndex;
            this.device.PasswordChanged = (Device.enumMailOption) this.pwdChangeCB.SelectedIndex;
            this.device.EmailTriggerSubject = this.triggerMTB.Text;
            switch (this.priorityCB.SelectedIndex)
            {
              case 0:
                this.device.Priority = Device.enumPriority.Low;
                break;
              case 1:
                this.device.Priority = Device.enumPriority.Normal;
                break;
              case 2:
                this.device.Priority = Device.enumPriority.High;
                break;
            }
            this.device.MinNotificationInterval = (byte) this.minNotifyNUD.Value;
            break;
          case PanelTypes.InputTriggerSetting:
            isDevice = true;
            if (this.inputMNINUD.Text == "" || this.reNotifyNUD.Text == "")
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.ParameterError);
              break;
            }
            this.device.Input1 = (Device.enumPinType) this.input1CB.SelectedIndex;
            this.device.Input2 = (Device.enumPinType) this.input2CB.SelectedIndex;
            this.device.EnableSerialTriggerInput = this.enableSerialCB.Checked;
            this.device.SerialChannel = (Device.SerialChannels) this.channelsCB.SelectedIndex;
            this.device.SerialDataSize = (Device.enumSerialDataSize) this.dataSizeCB.SelectedIndex;
            this.device.SerialMatchData1 = this.char1TB.Text;
            this.device.SerialMatchData2 = this.char2TB.Text;
            this.device.SerialMatchData3 = this.char3TB.Text;
            this.device.EmailInputTriggerMessage = this.messageTB.Text;
            switch (this.inputPriorityCB.SelectedIndex)
            {
              case 0:
                this.device.InputPriority = Device.enumPriority.Low;
                break;
              case 1:
                this.device.InputPriority = Device.enumPriority.Normal;
                break;
              case 2:
                this.device.InputPriority = Device.enumPriority.High;
                break;
            }
            this.device.InputMinNotificationInterval = (byte) this.inputMNINUD.Value;
            this.device.RenotificationInterval = (byte) this.reNotifyNUD.Value;
            break;
          case PanelTypes.HostlistSetting:
            isDevice = false;
            if (this.retryCNUD.Text == "" || this.retryTNUD.Text == "")
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.ParameterError);
              break;
            }
            Channel channelByChannelNum1 = Controller.getChannelByChannelNum(this.device, this.channelNum);
            channelByChannelNum1.RetryCounter = (byte) this.retryCNUD.Value;
            channelByChannelNum1.RetryTimeout = (byte) this.retryTNUD.Value;
            channelByChannelNum1.EnableBackupLink = (BinaryOptions) this.backupLinkCB.SelectedIndex;
            for (int index = 0; index < 12 && index < channelByChannelNum1.HostList.Count; ++index)
            {
              bool flag = false;
              foreach (Control control in (ArrangedElementCollection) this.tableLayoutPanel1.Controls)
              {
                if (control is TextBox)
                {
                  if (control.Name == "hostIP" + (object) (index + 1) + "TB")
                  {
                    if (channelByChannelNum1.canDNS())
                    {
                      if (control.Text.Length > 30)
                      {
                        this.device.AddMessage(Message.TooLong, "HostList");
                        this.device.IsChecked = false;
                      }
                      else
                        channelByChannelNum1.HostList[index].IpAddress = control.Text;
                    }
                    else if (control.Text.Trim().Length == 0)
                      channelByChannelNum1.HostList[index].IpAddress = "0.0.0.0";
                    else if (Program.CheckIpStr(control.Text))
                    {
                      channelByChannelNum1.HostList[index].IpAddress = control.Text;
                    }
                    else
                    {
                      this.device.AddMessage(Message.InvalidIP, "HostList");
                      this.device.IsChecked = false;
                    }
                    if (!flag)
                      flag = true;
                    else
                      break;
                  }
                  else if (control.Name == "hostPort" + (object) (index + 1) + "TB")
                  {
                    ushort result;
                    if (ushort.TryParse(control.Text, out result))
                    {
                      channelByChannelNum1.HostList[index].Port = result;
                      if (!flag)
                        flag = true;
                      else
                        break;
                    }
                    else
                    {
                      this.device.IsChecked = false;
                      this.device.AddMessage(Message.InvalidPort);
                      return false;
                    }
                  }
                }
              }
            }
            break;
          case PanelTypes.SerialSetting:
            isDevice = false;
            Channel channelByChannelNum2 = Controller.getChannelByChannelNum(this.device, this.channelNum);
            channelByChannelNum2.SerialPortProtocol = (Channel.ProtocolType) System.Enum.Parse(typeof (Channel.ProtocolType), this.protocolCB.SelectedItem.ToString());
            channelByChannelNum2.SerialPortOptions = this.serialOptionCB.Checked ? BinaryOptions.Enable : BinaryOptions.Disable;
            channelByChannelNum2.FIFO = (Channel.FIFO_Depth) this.fifoCB.SelectedIndex;
            channelByChannelNum2.DataBits = (Channel.DataBitsNum) this.databitCB.SelectedIndex;
            uint result1;
            if (uint.TryParse(this.baudrateCB.Text.Trim(), out result1))
              channelByChannelNum2.BaudRate = result1;
            channelByChannelNum2.FlowControl = (Channel.enuFlowControl) System.Enum.Parse(typeof (Channel.enuFlowControl), this.flowCB.SelectedItem.ToString());
            channelByChannelNum2.Parity = (Channel.enuParity) this.parityCB.SelectedIndex;
            channelByChannelNum2.StopBits = (Channel.StopBitsNum) this.stopbitCB.SelectedIndex;
            channelByChannelNum2.EnablePacking = this.enablePackCB.Checked;
            channelByChannelNum2.IdleGapTime = (Channel.IdleGapTimeNum) this.idleCB.SelectedIndex;
            channelByChannelNum2.Match2ByteSequence = this.match2CB.Checked;
            channelByChannelNum2.FirstMatchByte = this.firstCharTB.Text;
            channelByChannelNum2.LastMatchByte = this.lastTB.Text;
            channelByChannelNum2.SendFrameOnly = this.sendFrameCB.Checked;
            channelByChannelNum2.SendTrailingBytes = (Channel.enuSendTrailingByte) this.sendBytesCB.SelectedIndex;
            if ((int) this.channelNum == 1)
            {
              this.panelType = PanelTypes.PinsSetting;
              this.getValue();
              this.initPinsIOType(channelByChannelNum2.SerialPortProtocol, channelByChannelNum2.FlowControl, this.device.IO1, this.device.IO2);
              this.setValue();
              this.device.PinsSetting = false;
              this.panelType = PanelTypes.SerialSetting;
              break;
            }
            break;
          case PanelTypes.ConnectionSetting:
            isDevice = false;
            if (this.udpLocalPortNUD.Text == "" || this.udpRemotePortNUD.Text == "" || (this.udpUCLPNUD.Text == "" || this.tcpLocalPortNUD.Text == "") || (this.tcpRemotePortNUD.Text == "" || this.inactivityNUD.Text == ""))
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.ParameterError);
              break;
            }
            Channel channelByChannelNum3 = Controller.getChannelByChannelNum(this.device, this.channelNum);
            channelByChannelNum3.NetProtocol = (Channel.enumNetProtocol) this.netProtocolCB.SelectedIndex;
            if (!Program.CheckIpStr(this.udpSegmentTB.Text))
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.InvalidIP, "UDPNetSegment");
            }
            channelByChannelNum3.DatagramType = (Channel.enumDatagramType) this.datagramCB.SelectedIndex;
            channelByChannelNum3.AcceptIncoming = !this.device.IsNewVersion ? !this.udpAcceptCB.Checked : this.udpAcceptCB.Checked;
            channelByChannelNum3.UDPLocalPort = (ushort) this.udpLocalPortNUD.Value;
            channelByChannelNum3.UDPRemotePort = (ushort) this.udpRemotePortNUD.Value;
            channelByChannelNum3.UDPNetSegment = IPAddress.Parse(this.udpSegmentTB.Text);
            channelByChannelNum3.UDPUniCastLocalPort = (ushort) this.udpUCLPNUD.Value;
            for (int index = 0; index < 4 && index < channelByChannelNum3.DeviceAddressTable.Count; ++index)
            {
              byte num = (byte) 0;
              foreach (Control control in (ArrangedElementCollection) this.tableLayoutPanel2.Controls)
              {
                if (control is TextBox)
                {
                  if (control.Name == "bAddr" + (object) index + "TB")
                  {
                    channelByChannelNum3.DeviceAddressTable[index].BeginIPAddress = MyPanel.GetIP(control.Text);
                    if ((int) num != 2)
                      ++num;
                    else
                      break;
                  }
                  else if (control.Name == "eAddr" + (object) index + "TB")
                  {
                    channelByChannelNum3.DeviceAddressTable[index].EndIPAddress = MyPanel.GetIP(control.Text);
                    if ((int) num != 2)
                      ++num;
                    else
                      break;
                  }
                }
                else if (control is NumericUpDown && control.Name == "udpPort" + (object) index + "TB")
                {
                  ushort result2;
                  if (ushort.TryParse(control.Text, out result2))
                  {
                    channelByChannelNum3.DeviceAddressTable[index].Port = result2;
                    if ((int) num != 2)
                      ++num;
                    else
                      break;
                  }
                  else
                  {
                    this.device.IsChecked = false;
                    this.device.AddMessage(Message.InvalidPort);
                    return false;
                  }
                }
              }
            }
            if (this.device.IsNewVersion)
              channelByChannelNum3.TCPMode = (Channel.enumTCPMode) this.workasCB.SelectedIndex;
            else
              channelByChannelNum3.AcceptionIncoming = (Channel.enumAcceptionConnection) this.workasCB.SelectedIndex;
            channelByChannelNum3.ActiveConnect = (Channel.enumActiveConnect) this.tcpActiveCB.SelectedIndex;
            channelByChannelNum3.StartCharacter = this.startCharTB.Text;
            channelByChannelNum3.LocalPort = (ushort) this.tcpLocalPortNUD.Value;
            channelByChannelNum3.RemotePort = (ushort) this.tcpRemotePortNUD.Value;
            channelByChannelNum3.DNSQueryPeriod = (ushort) this.dnsQueryPeriodNUD.Value;
            if (channelByChannelNum3.canDNS())
              channelByChannelNum3.RemoteHost = this.tcpRomteHostTB.Text;
            else if (this.tcpRomteHostTB.Text.Trim().Length == 0)
              channelByChannelNum3.RemoteHost = "0.0.0.0";
            else if (Program.CheckIpStr(this.tcpRomteHostTB.Text))
            {
              channelByChannelNum3.RemoteHost = this.tcpRomteHostTB.Text;
            }
            else
            {
              this.device.AddMessage(Message.InvalidIP, "RemoteHost");
              this.device.IsChecked = false;
            }
            channelByChannelNum3.UseHostlist = this.useHostlistCB.Checked;
            channelByChannelNum3.ConnectResponse = (Channel.enumConnectResponse) this.connectResponseCB.SelectedIndex;
            channelByChannelNum3.OnDSRDrop = this.onDSRDropCB.Checked;
            channelByChannelNum3.HardDisconnect = this.hardDisconnectCB.Checked;
            channelByChannelNum3.CheckEOT = this.checkEOTCB.Checked;
            channelByChannelNum3.InactivityTimeout = (byte) this.inactivityNUD.Value;
            channelByChannelNum3.InputWithActiveConnect = this.iwacCB.Checked;
            channelByChannelNum3.InputWithPassiveConnect = this.iwpcCB.Checked;
            channelByChannelNum3.InputAtTimeofDisconnect = this.iatdCB.Checked;
            channelByChannelNum3.OutputWithActiveConnect = this.owacCB.Checked;
            channelByChannelNum3.OutputWithPassiveConnect = this.owpcCB.Checked;
            channelByChannelNum3.OutputAtTimeofDisconnect = this.oatdCB.Checked;
            break;
          case PanelTypes.ChangePassword:
            if (this.device.IsLogged && this.oldPwdTB.Text.Trim() == this.device.UserPsw && this.newPwdTB.Text.Trim() == this.retypePwdTB.Text.Trim())
            {
              this.device.NewUserPsw = this.newPwdTB.Text;
              if (!this.device.IsChecked)
                return false;
              ResponseTypes responseType = Controller.SetParameters(this.device, this.panelType, ref message, this.channelNum, this.device.LoginIndex, true);
              Controller.OptionMassage(responseType);
              if (responseType == ResponseTypes.OK)
                this.device.UserPsw = this.device.NewUserPsw;
              return responseType == ResponseTypes.OK;
            }
            this.device.IsChecked = false;
            this.device.AddMessage(Message.PasswordError);
            return false;
          case PanelTypes.PinsSetting:
            isDevice = true;
            this.device.IO1 = this.getInputOutputTypeValue(this.io1CB.SelectedItem.ToString());
            this.device.IO1Type = this.io1TypeCB.SelectedIndex >= 0 ? (Device.IOTypes) this.io1TypeCB.SelectedIndex : this.device.IO1Type;
            this.device.IO1State = this.io1EleCB.SelectedIndex >= 0 ? (Device.EleStates) this.io1EleCB.SelectedIndex : this.device.IO1State;
            this.device.IO2 = this.getInputOutputTypeValue(this.io2CB.SelectedItem.ToString());
            this.device.IO2Type = this.io2TypeCB.SelectedIndex >= 0 ? (Device.IOTypes) this.io2TypeCB.SelectedIndex : this.device.IO2Type;
            this.device.IO2State = this.io2EleCB.SelectedIndex >= 0 ? (Device.EleStates) this.io2EleCB.SelectedIndex : this.device.IO2State;
            if (this.device.ChannelList[1].SerialPortProtocol == Channel.ProtocolType.RS485 && this.device.IO1 != Device.InputOutputTypes.RS485_Controllor && this.device.IO2 != Device.InputOutputTypes.RS485_Controllor)
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.ParameterError);
              return false;
            }
            break;
          case PanelTypes.PPPOESetting:
            isDevice = true;
            if (this.pppoeMaxRTNUD.Text == "" || this.pppoeRINUD.Text == "" || this.ppoeIDLENUD.Text == "")
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.ParameterError);
              break;
            }
            this.device.PPPOEUserName = this.pppoeUserNameTB.Text;
            this.device.PPPOEPassword = this.pppoePwdTB.Text;
            this.device.PPPOEWorkMode = (Device.PPPOEWorkModes) this.pppoeWorkModeCB.SelectedIndex;
            this.device.PPPOEMaxRedialTimes = (byte) this.pppoeMaxRTNUD.Value;
            this.device.PPPOERedialInterval = (byte) this.pppoeRINUD.Value;
            this.device.PPPOEIDLETime = (ushort) this.ppoeIDLENUD.Value;
            break;
          case PanelTypes.PPPSetting:
            isDevice = true;
            if (this.pppMaxRTNUD.Text == "" || this.pppRINUD.Text == "" || (this.pppIDLENUD.Text == "" || this.pppComCB.Text == ""))
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.ParameterError);
              break;
            }
            this.device.PPPUserName = this.pppUserNameTB.Text;
            this.device.PPPPassword = this.pppPwdTB.Text;
            this.device.PPPWorkMode = (Device.PPPOEWorkModes) this.pppWorkModeCB.SelectedIndex;
            this.device.PPPMaxRedialTimes = (byte) this.pppMaxRTNUD.Value;
            this.device.PPPRedialInterval = (byte) this.pppRINUD.Value;
            this.device.PPPIDLETime = (ushort) this.pppIDLENUD.Value;
            this.device.PPPComID = byte.Parse(this.pppComCB.SelectedItem.ToString().Substring(3));
            break;
          case PanelTypes.GPRSSetting:
            isDevice = true;
            if (this.gprsMaxRTNUD.Text == "" || this.gprsRINUD.Text == "" || (this.gprsIDLENUD.Text == "" || this.gprsComCB.Text == ""))
            {
              this.device.IsChecked = false;
              this.device.AddMessage(Message.ParameterError);
              break;
            }
            this.device.ServiceCode = this.serviceCodeTB.Text;
            this.device.GPRSPPPUserName = this.gprsUserTB.Text;
            this.device.GPRSPPPPassword = this.gprsPwdTB.Text;
            this.device.GPRSSINUIMPIN = this.supinTB.Text;
            this.device.GPRSAPN = this.gprsAPNTB.Text;
            this.device.GPRSWorkMode = (Device.PPPOEWorkModes) this.gprsWorkModeCB.SelectedIndex;
            this.device.GPRSMaxRedialTimes = (byte) this.gprsMaxRTNUD.Value;
            this.device.GPRSRedialInterval = (byte) this.gprsRINUD.Value;
            this.device.GPRSIDLETime = (ushort) this.gprsIDLENUD.Value;
            this.device.GPRSComID = byte.Parse(this.gprsComCB.SelectedItem.ToString().Substring(3));
            break;
          case PanelTypes.PowerManage:
            if (this.radioButton1.Checked)
              this.rebootType = RebootTypes.LOAD_DEFAULTS;
            else if (this.radioButton2.Checked)
              this.rebootType = RebootTypes.LOAD_DEFS_N_REBOOT;
            else if (this.radioButton3.Checked)
              this.rebootType = RebootTypes.REBOOT;
            else if (this.radioButton4.Checked)
              this.rebootType = RebootTypes.SAVE_N_REBOOT;
            ResponseTypes responseType1 = Controller.RebootSystem(this.device, this.rebootType);
            Controller.OptionMassage(responseType1);
            return responseType1 == ResponseTypes.OK;
          default:
            return false;
        }
        if (!this.device.IsChecked)
          return false;
        ResponseTypes responseType2 = Controller.SetParameters(this.device, this.panelType, ref message, this.channelNum, isDevice);
        Controller.OptionMassage(responseType2);
        return responseType2 == ResponseTypes.OK;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        Program.ShowMessage(ex.Message, true);
        return false;
      }
    }

    private void telnetCB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.telnetCB.Checked)
        this.terminalTB.Enabled = true;
      else
        this.terminalTB.Enabled = false;
    }

    private void autoCfRB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.autoCfRB.Checked)
      {
        this.panel1.Enabled = true;
        this.panel2.Enabled = false;
      }
      else
      {
        this.panel1.Enabled = false;
        this.panel2.Enabled = true;
      }
    }

    private void autoNegoCB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.autoNegoCB.Checked)
        this.panel3.Enabled = false;
      else
        this.panel3.Enabled = true;
    }

    private void enableSerialCB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.enableSerialCB.Checked)
        this.panel5.Enabled = true;
      else
        this.panel5.Enabled = false;
    }

    private void dataSizeCB_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.dataSizeCB.SelectedIndex == 1)
      {
        this.label12.Visible = true;
        this.char3TB.Visible = true;
      }
      else
      {
        this.label12.Visible = false;
        this.char3TB.Visible = false;
      }
    }

    private static IPAddress GetIP(string ip)
    {
      if (ip == IPAddress.Any.ToString())
        return IPAddress.Any;
      return IPAddress.Parse(ip);
    }

    private void serialOptionCB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.serialOptionCB.Checked)
      {
        this.panel4.Enabled = true;
        if (this.device.CanPPP && Controller.getChannelByChannelNum(this.device, this.channelNum).ComIsUsed())
          this.panel9.Enabled = false;
        else
          this.panel9.Enabled = true;
      }
      else
      {
        this.panel4.Enabled = false;
        this.panel9.Enabled = false;
      }
    }

    private void enablePackCB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.enablePackCB.Checked)
        this.panel6.Enabled = true;
      else
        this.panel6.Enabled = false;
    }

    private void datagramCB_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.datagramCB.SelectedIndex == 1)
      {
        this.panel7.Enabled = true;
        this.udpUCLPNUD.Enabled = false;
        this.myLable82.Enabled = false;
        this.tableLayoutPanel2.Enabled = false;
      }
      else
      {
        this.panel7.Enabled = false;
        this.udpUCLPNUD.Enabled = true;
        this.myLable82.Enabled = true;
        this.tableLayoutPanel2.Enabled = true;
      }
    }

    private void netProtocolCB_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.netProtocolCB.SelectedIndex == 1)
        this.panel8.Visible = true;
      else
        this.panel8.Visible = false;
    }

    private void io1CB_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.canNotChange)
        return;
      ComboBox comboBox = (ComboBox) sender;
      if (comboBox.SelectedItem.ToString() == "Flow Control(RTS)" || comboBox.SelectedItem.ToString() == "Flow Control(CTS)")
      {
        if (comboBox.Name == this.io1CB.Name)
        {
          if (this.io2CB.SelectedIndex != -1 && this.io2CB.SelectedItem.ToString() != "Flow Control(CTS)")
          {
            for (int index = 0; index < this.io2CB.Items.Count; ++index)
            {
              if (this.io2CB.Items[index].ToString() == "Flow Control(CTS)")
              {
                this.io2CB.SelectedIndex = index;
                break;
              }
            }
          }
          this.io1TypeCB.Visible = false;
          this.io1EleCB.Visible = false;
        }
        else
        {
          if (this.io1CB.SelectedIndex != -1 && this.io1CB.SelectedItem.ToString() != "Flow Control(RTS)")
          {
            for (int index = 0; index < this.io1CB.Items.Count; ++index)
            {
              if (this.io1CB.Items[index].ToString() == "Flow Control(RTS)")
              {
                this.io1CB.SelectedIndex = index;
                break;
              }
            }
          }
          this.io2TypeCB.Visible = false;
          this.io2EleCB.Visible = false;
        }
      }
      else if (comboBox.Name == this.io1CB.Name)
      {
        if (this.io2CB.SelectedIndex != -1 && this.io2CB.SelectedItem.ToString() == "Flow Control(CTS)")
        {
          for (int index = 0; index < this.io2CB.Items.Count; ++index)
          {
            if (this.io2CB.Items[index].ToString() != "Flow Control(CTS)")
            {
              this.io2CB.SelectedIndex = index;
              break;
            }
          }
        }
        if (comboBox.SelectedItem.ToString() == "IO Mode")
        {
          this.io1TypeCB.Visible = true;
          this.io1EleCB.Visible = true;
        }
        else
        {
          this.io1TypeCB.Visible = false;
          this.io1EleCB.Visible = false;
        }
      }
      else
      {
        if (this.io1CB.SelectedIndex != -1 && this.io1CB.SelectedItem.ToString() == "Flow Control(RTS)")
        {
          for (int index = 0; index < this.io1CB.Items.Count; ++index)
          {
            if (this.io1CB.Items[index].ToString() != "Flow Control(RTS)")
            {
              this.io1CB.SelectedIndex = index;
              break;
            }
          }
        }
        if (comboBox.SelectedItem.ToString() == "IO Mode")
        {
          this.io2TypeCB.Visible = true;
          this.io2EleCB.Visible = true;
        }
        else
        {
          this.io2TypeCB.Visible = false;
          this.io2EleCB.Visible = false;
        }
      }
    }

    private void io1TypeCB_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
      if (comboBox.Name == this.io1TypeCB.Name)
      {
        if (comboBox.SelectedIndex == 0)
          this.io1EleCB.Enabled = false;
        else
          this.io1EleCB.Enabled = true;
      }
      else if (comboBox.SelectedIndex == 0)
        this.io2EleCB.Enabled = false;
      else
        this.io2EleCB.Enabled = true;
    }

    private Device.InputOutputTypes getInputOutputTypeValue(string text)
    {
      Device.InputOutputTypes inputOutputTypes;
      switch (text)
      {
        case "Flow Control(RTS)":
        case "Flow Control(CTS)":
          inputOutputTypes = Device.InputOutputTypes.Flow_Control_Mode;
          break;
        case "IO Mode":
          inputOutputTypes = Device.InputOutputTypes.IO_Mode;
          break;
        case "Connection Indicator Mode":
          inputOutputTypes = Device.InputOutputTypes.Connection_Indicator_Mode;
          break;
        case "RS422 Controllor":
          inputOutputTypes = Device.InputOutputTypes.RS422_Controllor;
          break;
        case "RS485 Controllor":
          inputOutputTypes = Device.InputOutputTypes.RS485_Controllor;
          break;
        case "Systerm led mode":
          inputOutputTypes = Device.InputOutputTypes.Systerm_led_mode;
          break;
        default:
          inputOutputTypes = Device.InputOutputTypes.Flow_Control_Mode;
          break;
      }
      return inputOutputTypes;
    }

    private void initPinsIOType(Channel.ProtocolType protocolType, Channel.enuFlowControl flowType, Device.InputOutputTypes io1, Device.InputOutputTypes io2)
    {
      this.canNotChange = true;
      this.io1CB.Items.Clear();
      this.io2CB.Items.Clear();
      string str1;
      switch (io1)
      {
        case Device.InputOutputTypes.IO_Mode:
          str1 = "IO Mode";
          break;
        case Device.InputOutputTypes.Systerm_led_mode:
          str1 = "Systerm led mode";
          break;
        case Device.InputOutputTypes.Connection_Indicator_Mode:
          str1 = "Connection Indicator Mode";
          break;
        case Device.InputOutputTypes.Flow_Control_Mode:
          str1 = "Flow Control(RTS)";
          break;
        case Device.InputOutputTypes.RS485_Controllor:
          str1 = "RS485 Controllor";
          break;
        case Device.InputOutputTypes.RS422_Controllor:
          str1 = "RS422 Controllor";
          break;
        default:
          str1 = "";
          break;
      }
      string str2;
      switch (io2)
      {
        case Device.InputOutputTypes.IO_Mode:
          str2 = "IO Mode";
          break;
        case Device.InputOutputTypes.Systerm_led_mode:
          str2 = "Systerm led mode";
          break;
        case Device.InputOutputTypes.Connection_Indicator_Mode:
          str2 = "Connection Indicator Mode";
          break;
        case Device.InputOutputTypes.Flow_Control_Mode:
          str2 = "Flow Control(CTS)";
          break;
        case Device.InputOutputTypes.RS485_Controllor:
          str2 = "RS485 Controllor";
          break;
        case Device.InputOutputTypes.RS422_Controllor:
          str2 = "RS422 Controllor";
          break;
        default:
          str2 = "";
          break;
      }
      switch (protocolType)
      {
        case Channel.ProtocolType.RS232:
          if (flowType == Channel.enuFlowControl.Hardware)
          {
            this.io1CB.Items.Add((object) "Flow Control(RTS)");
            this.io2CB.Items.Add((object) "Flow Control(CTS)");
            this.io1CB.SelectedIndex = 0;
            this.io2CB.SelectedIndex = 0;
            break;
          }
          this.io1CB.Items.AddRange((object[]) new string[3]
          {
            "Flow Control(RTS)",
            "IO Mode",
            "Connection Indicator Mode"
          });
          for (int index = 0; index < this.io1CB.Items.Count; ++index)
          {
            if (this.io1CB.Items[index].ToString() == str1)
            {
              this.io1CB.SelectedIndex = index;
              break;
            }
          }
          this.io2CB.Items.AddRange((object[]) new string[3]
          {
            "Flow Control(CTS)",
            "IO Mode",
            "Systerm led mode"
          });
          for (int index = 0; index < this.io2CB.Items.Count; ++index)
          {
            if (this.io2CB.Items[index].ToString() == str2)
            {
              this.io2CB.SelectedIndex = index;
              break;
            }
          }
          break;
        case Channel.ProtocolType.RS422:
          this.io1CB.Items.Add((object) "RS422 Controllor");
          this.io2CB.Items.Add((object) "RS422 Controllor");
          this.io1CB.SelectedIndex = 0;
          this.io2CB.SelectedIndex = 0;
          break;
        case Channel.ProtocolType.RS485:
          this.io1CB.Items.AddRange((object[]) new string[3]
          {
            "IO Mode",
            "Connection Indicator Mode",
            "RS485 Controllor"
          });
          this.io2CB.Items.AddRange((object[]) new string[3]
          {
            "IO Mode",
            "Systerm led mode",
            "RS485 Controllor"
          });
          if (io1 == Device.InputOutputTypes.RS485_Controllor || io2 == Device.InputOutputTypes.RS485_Controllor)
          {
            for (int index = 0; index < this.io1CB.Items.Count; ++index)
            {
              if (this.io1CB.Items[index].ToString() == str1)
              {
                this.io1CB.SelectedIndex = index;
                break;
              }
            }
            for (int index = 0; index < this.io2CB.Items.Count; ++index)
            {
              if (this.io2CB.Items[index].ToString() == str2)
              {
                this.io2CB.SelectedIndex = index;
                break;
              }
            }
            break;
          }
          for (int index = 0; index < this.io1CB.Items.Count; ++index)
          {
            if (this.io1CB.Items[index].ToString() == "RS485 Controllor")
            {
              this.io1CB.SelectedIndex = index;
              break;
            }
          }
          for (int index = 0; index < this.io2CB.Items.Count; ++index)
          {
            if (this.io2CB.Items[index].ToString() == "RS485 Controllor")
            {
              this.io2CB.SelectedIndex = index;
              break;
            }
          }
          break;
      }
      if (this.io1CB.SelectedIndex == -1)
        this.io1CB.SelectedIndex = 0;
      if (this.io2CB.SelectedIndex == -1)
        this.io2CB.SelectedIndex = 0;
      this.canNotChange = false;
      this.io1CB_SelectedIndexChanged((object) this.io1CB, (EventArgs) null);
      this.io1CB_SelectedIndexChanged((object) this.io2CB, (EventArgs) null);
    }

    private void protocolCB_SelectedIndexChanged(object sender, EventArgs e)
    {
      Channel channelByChannelNum = Controller.getChannelByChannelNum(this.device, this.channelNum);
      switch (this.protocolCB.SelectedItem.ToString())
      {
        case "RS232":
          if (channelByChannelNum.canModen())
          {
            if (this.flowCB.Items.Count == 2)
            {
              this.flowCB.Items.Insert(1, (object) "Hardware");
              break;
            }
            break;
          }
          if (this.flowCB.Items.Count == 3)
          {
            this.flowCB.Items.RemoveAt(1);
            break;
          }
          break;
        default:
          if (this.flowCB.Items.Count == 3)
          {
            this.flowCB.Items.RemoveAt(1);
            break;
          }
          break;
      }
      if (this.flowCB.SelectedIndex != -1)
        return;
      this.flowCB.SelectedIndex = 0;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.basicPanel = new Panel();
      this.telnetCB = new CheckBox();
      this.webCB = new CheckBox();
      this.myLable7 = new MyLable();
      this.propertyL = new Label();
      this.myLable6 = new MyLable();
      this.myLable5 = new MyLable();
      this.myLable4 = new MyLable();
      this.myLable3 = new MyLable();
      this.myLable2 = new MyLable();
      this.myLable1 = new MyLable();
      this.terminalTB = new TextBox();
      this.timeServerTB = new TextBox();
      this.localTimeTB = new DateTimePicker();
      this.timeZoneCB = new ComboBox();
      this.nameTB = new TextBox();
      this.networkPanel = new Panel();
      this.GPRSCB = new MyCheckBox();
      this.pppoeCB = new MyCheckBox();
      this.pppCB = new MyCheckBox();
      this.autoNegoCB = new MyCheckBox();
      this.ethernetCB = new MyCheckBox();
      this.macTB = new TextBox();
      this.myLable21 = new MyLable();
      this.panel3 = new Panel();
      this.duplexCB = new ComboBox();
      this.speedCB = new ComboBox();
      this.myLable20 = new MyLable();
      this.myLable19 = new MyLable();
      this.panel2 = new Panel();
      this.altDNSTB = new TextBox();
      this.pDNSTB = new TextBox();
      this.gatewayTB = new TextBox();
      this.subnetTB = new TextBox();
      this.ipTB = new TextBox();
      this.myLable18 = new MyLable();
      this.myLable17 = new MyLable();
      this.myLable16 = new MyLable();
      this.myLable15 = new MyLable();
      this.myLable13 = new MyLable();
      this.panel1 = new Panel();
      this.dhcpNameTB = new TextBox();
      this.myLable12 = new MyLable();
      this.autoIPCB = new CheckBox();
      this.myLable11 = new MyLable();
      this.dhcpCB = new CheckBox();
      this.myLable9 = new MyLable();
      this.bootpCB = new CheckBox();
      this.myLable8 = new MyLable();
      this.userCfRB = new RadioButton();
      this.autoCfRB = new RadioButton();
      this.myLable14 = new MyLable();
      this.serverPanel = new Panel();
      this.cpuCB = new ComboBox();
      this.monitorCB = new CheckBox();
      this.mtuTB = new TextBox();
      this.httpPortNUD = new NumericUpDown();
      this.arpNUD = new NumericUpDown();
      this.myLable26 = new MyLable();
      this.myLable25 = new MyLable();
      this.myLable24 = new MyLable();
      this.myLable23 = new MyLable();
      this.myLable22 = new MyLable();
      this.emailPanel = new Panel();
      this.email3TB = new TextBox();
      this.emial2TB = new TextBox();
      this.email1TB = new TextBox();
      this.myLable34 = new MyLable();
      this.myLable33 = new MyLable();
      this.myLable32 = new MyLable();
      this.emailPwdTB = new TextBox();
      this.emailUserTB = new TextBox();
      this.emailTB = new TextBox();
      this.smtpPNUD = new NumericUpDown();
      this.smtpDTB = new TextBox();
      this.myLable27 = new MyLable();
      this.myLable28 = new MyLable();
      this.myLable29 = new MyLable();
      this.myLable30 = new MyLable();
      this.myLable31 = new MyLable();
      this.triggerPanel = new Panel();
      this.minNotifyNUD = new NumericUpDown();
      this.priorityCB = new ComboBox();
      this.myLable44 = new MyLable();
      this.myLable43 = new MyLable();
      this.triggerMTB = new TextBox();
      this.myLable42 = new MyLable();
      this.pwdChangeCB = new ComboBox();
      this.ipChangeCB = new ComboBox();
      this.loginFailCB = new ComboBox();
      this.dsrCB = new ComboBox();
      this.dcdCB = new ComboBox();
      this.warmCB = new ComboBox();
      this.coldCB = new ComboBox();
      this.myLable41 = new MyLable();
      this.myLable40 = new MyLable();
      this.myLable39 = new MyLable();
      this.myLable38 = new MyLable();
      this.myLable37 = new MyLable();
      this.myLable36 = new MyLable();
      this.myLable35 = new MyLable();
      this.inputTriggerPanel = new Panel();
      this.reNotifyNUD = new NumericUpDown();
      this.myLable51 = new MyLable();
      this.panel5 = new Panel();
      this.char3TB = new TextBox();
      this.char2TB = new TextBox();
      this.char1TB = new TextBox();
      this.label12 = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.dataSizeCB = new ComboBox();
      this.channelsCB = new ComboBox();
      this.myLable49 = new MyLable();
      this.myLable48 = new MyLable();
      this.myLable50 = new MyLable();
      this.enableSerialCB = new CheckBox();
      this.inputMNINUD = new NumericUpDown();
      this.inputPriorityCB = new ComboBox();
      this.myLable45 = new MyLable();
      this.myLable46 = new MyLable();
      this.messageTB = new TextBox();
      this.myLable47 = new MyLable();
      this.input2CB = new ComboBox();
      this.input1CB = new ComboBox();
      this.myLable53 = new MyLable();
      this.myLable54 = new MyLable();
      this.histlistPanel = new Panel();
      this.backupLinkCB = new ComboBox();
      this.myLable109 = new MyLable();
      this.tableLayoutPanel1 = new TableLayoutPanel();
      this.hostPort12TB = new TextBox();
      this.hostIP12TB = new TextBox();
      this.hostPort11TB = new TextBox();
      this.hostIP11TB = new TextBox();
      this.hostPort10TB = new TextBox();
      this.hostIP10TB = new TextBox();
      this.hostPort9TB = new TextBox();
      this.hostIP9TB = new TextBox();
      this.hostPort8TB = new TextBox();
      this.hostIP8TB = new TextBox();
      this.hostPort7TB = new TextBox();
      this.hostIP7TB = new TextBox();
      this.hostPort6TB = new TextBox();
      this.hostIP6TB = new TextBox();
      this.hostPort5TB = new TextBox();
      this.hostIP5TB = new TextBox();
      this.hostPort4TB = new TextBox();
      this.hostIP4TB = new TextBox();
      this.hostPort3TB = new TextBox();
      this.hostIP3TB = new TextBox();
      this.hostPort2TB = new TextBox();
      this.hostIP2TB = new TextBox();
      this.hostPort1TB = new TextBox();
      this.label20 = new Label();
      this.label19 = new Label();
      this.label18 = new Label();
      this.label17 = new Label();
      this.label16 = new Label();
      this.label15 = new Label();
      this.label14 = new Label();
      this.label21 = new Label();
      this.label22 = new Label();
      this.label23 = new Label();
      this.label24 = new Label();
      this.label25 = new Label();
      this.label26 = new Label();
      this.label27 = new Label();
      this.label28 = new Label();
      this.label29 = new Label();
      this.label30 = new Label();
      this.label31 = new Label();
      this.hostIP1TB = new TextBox();
      this.retryTNUD = new NumericUpDown();
      this.retryCNUD = new NumericUpDown();
      this.myLable55 = new MyLable();
      this.myLable52 = new MyLable();
      this.channelNameL = new Label();
      this.passwordPanel = new Panel();
      this.groupBox1 = new GroupBox();
      this.oldPwdTB = new TextBox();
      this.retypePwdTB = new TextBox();
      this.newPwdTB = new TextBox();
      this.userNameTB = new TextBox();
      this.label46 = new Label();
      this.label45 = new Label();
      this.label44 = new Label();
      this.label43 = new Label();
      this.pinsPanel = new Panel();
      this.groupBox3 = new GroupBox();
      this.myLable97 = new MyLable();
      this.io2CB = new ComboBox();
      this.io2EleCB = new ComboBox();
      this.io2TypeCB = new ComboBox();
      this.groupBox2 = new GroupBox();
      this.myLable96 = new MyLable();
      this.io1CB = new ComboBox();
      this.io1EleCB = new ComboBox();
      this.io1TypeCB = new ComboBox();
      this.pppoePanel = new Panel();
      this.pppoeDNS2TB = new TextBox();
      this.pppoeDNS1TB = new TextBox();
      this.pppoeGatewayTB = new TextBox();
      this.pppoeIPTB = new TextBox();
      this.pppoeStatusTB = new TextBox();
      this.ppoeIDLENUD = new NumericUpDown();
      this.pppoeRINUD = new NumericUpDown();
      this.pppoeMaxRTNUD = new NumericUpDown();
      this.pppoeWorkModeCB = new ComboBox();
      this.pppoePwdTB = new TextBox();
      this.pppoeUserNameTB = new TextBox();
      this.myLable108 = new MyLable();
      this.myLable107 = new MyLable();
      this.myLable106 = new MyLable();
      this.myLable105 = new MyLable();
      this.myLable104 = new MyLable();
      this.myLable103 = new MyLable();
      this.myLable102 = new MyLable();
      this.myLable101 = new MyLable();
      this.myLable100 = new MyLable();
      this.myLable99 = new MyLable();
      this.myLable98 = new MyLable();
      this.connectionPanel = new Panel();
      this.panel8 = new Panel();
      this.inactivityNUD = new NumericUpDown();
      this.groupBox5 = new GroupBox();
      this.myLable70 = new MyLable();
      this.myLable74 = new MyLable();
      this.oatdCB = new CheckBox();
      this.myLable75 = new MyLable();
      this.owacCB = new CheckBox();
      this.owpcCB = new CheckBox();
      this.workasCB = new ComboBox();
      this.groupBox4 = new GroupBox();
      this.myLable72 = new MyLable();
      this.myLable73 = new MyLable();
      this.myLable69 = new MyLable();
      this.iwacCB = new CheckBox();
      this.iwpcCB = new CheckBox();
      this.iatdCB = new CheckBox();
      this.dnsQueryPeriodNUD = new NumericUpDown();
      this.myLable56 = new MyLable();
      this.hardDisconnectCB = new CheckBox();
      this.checkEOTCB = new CheckBox();
      this.onDSRDropCB = new CheckBox();
      this.connectResponseCB = new ComboBox();
      this.tcpRomteHostTB = new TextBox();
      this.useHostlistCB = new CheckBox();
      this.tcpRemotePortNUD = new NumericUpDown();
      this.tcpLocalPortNUD = new NumericUpDown();
      this.startCharTB = new TextBox();
      this.label42 = new Label();
      this.tcpActiveCB = new ComboBox();
      this.myLable95 = new MyLable();
      this.myLable94 = new MyLable();
      this.myLable93 = new MyLable();
      this.myLable92 = new MyLable();
      this.myLable91 = new MyLable();
      this.myLable90 = new MyLable();
      this.myLable89 = new MyLable();
      this.myLable88 = new MyLable();
      this.myLable87 = new MyLable();
      this.myLable86 = new MyLable();
      this.myLable85 = new MyLable();
      this.myLable84 = new MyLable();
      this.udpUCLPNUD = new NumericUpDown();
      this.tableLayoutPanel2 = new TableLayoutPanel();
      this.eAddr3TB = new TextBox();
      this.bAddr3TB = new TextBox();
      this.eAddr2TB = new TextBox();
      this.bAddr2TB = new TextBox();
      this.eAddr1TB = new TextBox();
      this.bAddr1TB = new TextBox();
      this.eAddr0TB = new TextBox();
      this.bAddr0TB = new TextBox();
      this.label38 = new Label();
      this.label37 = new Label();
      this.label36 = new Label();
      this.label35 = new Label();
      this.label32 = new Label();
      this.label39 = new Label();
      this.label40 = new Label();
      this.label41 = new Label();
      this.udpPort0TB = new NumericUpDown();
      this.udpPort1TB = new NumericUpDown();
      this.udpPort2TB = new NumericUpDown();
      this.udpPort3TB = new NumericUpDown();
      this.panel7 = new Panel();
      this.udpSegmentTB = new TextBox();
      this.udpRemotePortNUD = new NumericUpDown();
      this.udpLocalPortNUD = new NumericUpDown();
      this.myLable79 = new MyLable();
      this.myLable80 = new MyLable();
      this.myLable81 = new MyLable();
      this.udpAcceptCB = new CheckBox();
      this.datagramCB = new ComboBox();
      this.myLable83 = new MyLable();
      this.myLable82 = new MyLable();
      this.myLable78 = new MyLable();
      this.myLable77 = new MyLable();
      this.netProtocolCB = new ComboBox();
      this.myLable76 = new MyLable();
      this.channelNameL2 = new Label();
      this.serialPanel = new Panel();
      this.panel9 = new Panel();
      this.panel6 = new Panel();
      this.lastTB = new TextBox();
      this.firstCharTB = new TextBox();
      this.label34 = new Label();
      this.label33 = new Label();
      this.sendBytesCB = new ComboBox();
      this.match2CB = new CheckBox();
      this.sendFrameCB = new CheckBox();
      this.idleCB = new ComboBox();
      this.myLable66 = new MyLable();
      this.myLable67 = new MyLable();
      this.myLable68 = new MyLable();
      this.myLable71 = new MyLable();
      this.enablePackCB = new CheckBox();
      this.myLable65 = new MyLable();
      this.panel4 = new Panel();
      this.protocolCB = new ComboBox();
      this.stopbitCB = new ComboBox();
      this.parityCB = new ComboBox();
      this.databitCB = new ComboBox();
      this.baudrateCB = new ComboBox();
      this.flowCB = new ComboBox();
      this.fifoCB = new ComboBox();
      this.myLable64 = new MyLable();
      this.myLable63 = new MyLable();
      this.myLable62 = new MyLable();
      this.myLable61 = new MyLable();
      this.myLable60 = new MyLable();
      this.myLable59 = new MyLable();
      this.myLable58 = new MyLable();
      this.serialOptionCB = new CheckBox();
      this.myLable57 = new MyLable();
      this.channelNameL1 = new Label();
      this.powerPanel = new Panel();
      this.radioButton4 = new RadioButton();
      this.radioButton3 = new RadioButton();
      this.radioButton2 = new RadioButton();
      this.radioButton1 = new RadioButton();
      this.pppPanel = new Panel();
      this.myLable120 = new MyLable();
      this.pppComCB = new ComboBox();
      this.pppDNS2TB = new TextBox();
      this.pppDNS1TB = new TextBox();
      this.pppGatewayTB = new TextBox();
      this.pppIPTB = new TextBox();
      this.pppStatusTB = new TextBox();
      this.pppIDLENUD = new NumericUpDown();
      this.pppRINUD = new NumericUpDown();
      this.pppMaxRTNUD = new NumericUpDown();
      this.pppWorkModeCB = new ComboBox();
      this.pppPwdTB = new TextBox();
      this.pppUserNameTB = new TextBox();
      this.myLable10 = new MyLable();
      this.myLable110 = new MyLable();
      this.myLable111 = new MyLable();
      this.myLable112 = new MyLable();
      this.myLable113 = new MyLable();
      this.myLable114 = new MyLable();
      this.myLable115 = new MyLable();
      this.myLable116 = new MyLable();
      this.myLable117 = new MyLable();
      this.myLable118 = new MyLable();
      this.myLable119 = new MyLable();
      this.gprsPanel = new Panel();
      this.gprsDNS2TB = new TextBox();
      this.gprsDNS1TB = new TextBox();
      this.gprsGatewayTB = new TextBox();
      this.gprsIPTB = new TextBox();
      this.gprsStatusTB = new TextBox();
      this.myLable131 = new MyLable();
      this.myLable132 = new MyLable();
      this.myLable133 = new MyLable();
      this.myLable134 = new MyLable();
      this.myLable135 = new MyLable();
      this.myLable126 = new MyLable();
      this.gprsComCB = new ComboBox();
      this.gprsIDLENUD = new NumericUpDown();
      this.gprsRINUD = new NumericUpDown();
      this.gprsMaxRTNUD = new NumericUpDown();
      this.gprsWorkModeCB = new ComboBox();
      this.myLable127 = new MyLable();
      this.myLable128 = new MyLable();
      this.myLable129 = new MyLable();
      this.myLable130 = new MyLable();
      this.myLable125 = new MyLable();
      this.gprsAPNTB = new TextBox();
      this.myLable121 = new MyLable();
      this.myLable124 = new MyLable();
      this.serviceCodeTB = new TextBox();
      this.myLable123 = new MyLable();
      this.gprsPwdTB = new TextBox();
      this.myLable122 = new MyLable();
      this.supinTB = new TextBox();
      this.gprsUserTB = new TextBox();
      this.basicPanel.SuspendLayout();
      this.networkPanel.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.serverPanel.SuspendLayout();
      this.httpPortNUD.BeginInit();
      this.arpNUD.BeginInit();
      this.emailPanel.SuspendLayout();
      this.smtpPNUD.BeginInit();
      this.triggerPanel.SuspendLayout();
      this.minNotifyNUD.BeginInit();
      this.inputTriggerPanel.SuspendLayout();
      this.reNotifyNUD.BeginInit();
      this.panel5.SuspendLayout();
      this.inputMNINUD.BeginInit();
      this.histlistPanel.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.retryTNUD.BeginInit();
      this.retryCNUD.BeginInit();
      this.passwordPanel.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.pinsPanel.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.pppoePanel.SuspendLayout();
      this.ppoeIDLENUD.BeginInit();
      this.pppoeRINUD.BeginInit();
      this.pppoeMaxRTNUD.BeginInit();
      this.connectionPanel.SuspendLayout();
      this.panel8.SuspendLayout();
      this.inactivityNUD.BeginInit();
      this.groupBox5.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.dnsQueryPeriodNUD.BeginInit();
      this.tcpRemotePortNUD.BeginInit();
      this.tcpLocalPortNUD.BeginInit();
      this.udpUCLPNUD.BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.udpPort0TB.BeginInit();
      this.udpPort1TB.BeginInit();
      this.udpPort2TB.BeginInit();
      this.udpPort3TB.BeginInit();
      this.panel7.SuspendLayout();
      this.udpRemotePortNUD.BeginInit();
      this.udpLocalPortNUD.BeginInit();
      this.serialPanel.SuspendLayout();
      this.panel9.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel4.SuspendLayout();
      this.powerPanel.SuspendLayout();
      this.pppPanel.SuspendLayout();
      this.pppIDLENUD.BeginInit();
      this.pppRINUD.BeginInit();
      this.pppMaxRTNUD.BeginInit();
      this.gprsPanel.SuspendLayout();
      this.gprsIDLENUD.BeginInit();
      this.gprsRINUD.BeginInit();
      this.gprsMaxRTNUD.BeginInit();
      this.SuspendLayout();
      this.basicPanel.Controls.Add((Control) this.telnetCB);
      this.basicPanel.Controls.Add((Control) this.webCB);
      this.basicPanel.Controls.Add((Control) this.myLable7);
      this.basicPanel.Controls.Add((Control) this.myLable6);
      this.basicPanel.Controls.Add((Control) this.myLable5);
      this.basicPanel.Controls.Add((Control) this.myLable4);
      this.basicPanel.Controls.Add((Control) this.myLable3);
      this.basicPanel.Controls.Add((Control) this.myLable2);
      this.basicPanel.Controls.Add((Control) this.myLable1);
      this.basicPanel.Controls.Add((Control) this.terminalTB);
      this.basicPanel.Controls.Add((Control) this.timeServerTB);
      this.basicPanel.Controls.Add((Control) this.localTimeTB);
      this.basicPanel.Controls.Add((Control) this.timeZoneCB);
      this.basicPanel.Controls.Add((Control) this.nameTB);
      this.basicPanel.Location = new Point(0, 0);
      this.basicPanel.Name = "basicPanel";
      this.basicPanel.Size = new Size(408, 273);
      this.basicPanel.TabIndex = 4;
      this.basicPanel.Visible = false;
      this.telnetCB.AutoSize = true;
      this.telnetCB.Location = new Point(330, 211);
      this.telnetCB.Name = "telnetCB";
      this.telnetCB.Size = new Size(60, 16);
      this.telnetCB.TabIndex = 27;
      this.telnetCB.Text = "Enable";
      this.telnetCB.UseVisualStyleBackColor = true;
      this.telnetCB.Visible = false;
      this.telnetCB.CheckedChanged += new EventHandler(this.telnetCB_CheckedChanged);
      this.webCB.AutoSize = true;
      this.webCB.Location = new Point(129, 211);
      this.webCB.Name = "webCB";
      this.webCB.Size = new Size(60, 16);
      this.webCB.TabIndex = 26;
      this.webCB.Text = "Enable";
      this.webCB.UseVisualStyleBackColor = true;
      this.webCB.Visible = false;
      this.myLable7.Location = new Point(40, 241);
      this.myLable7.Name = "myLable7";
      this.myLable7.PropertyLabel = this.propertyL;
      this.myLable7.PropertyName = "TerminalName";
      this.myLable7.Size = new Size(85, 14);
      this.myLable7.TabIndex = 25;
      this.myLable7.Text = "Terminal Name";
      this.myLable7.Visible = false;
      this.propertyL.BorderStyle = BorderStyle.FixedSingle;
      this.propertyL.ForeColor = Color.SteelBlue;
      this.propertyL.Location = new Point(0, 276);
      this.propertyL.Margin = new Padding(3);
      this.propertyL.Name = "propertyL";
      this.propertyL.Padding = new Padding(3);
      this.propertyL.Size = new Size(408, 39);
      this.propertyL.TabIndex = 28;
      this.myLable6.Location = new Point(216, 212);
      this.myLable6.Name = "myLable6";
      this.myLable6.PropertyLabel = this.propertyL;
      this.myLable6.PropertyName = "TelnetConsole";
      this.myLable6.Size = new Size(91, 14);
      this.myLable6.TabIndex = 24;
      this.myLable6.Text = "Telnet Console";
      this.myLable6.Visible = false;
      this.myLable5.Location = new Point(40, 212);
      this.myLable5.Name = "myLable5";
      this.myLable5.PropertyLabel = this.propertyL;
      this.myLable5.PropertyName = "WebConsole";
      this.myLable5.Size = new Size(73, 14);
      this.myLable5.TabIndex = 23;
      this.myLable5.Text = "Web Console";
      this.myLable5.Visible = false;
      this.myLable4.Location = new Point(40, 140);
      this.myLable4.Name = "myLable4";
      this.myLable4.PropertyLabel = this.propertyL;
      this.myLable4.PropertyName = "TimeServer";
      this.myLable4.Size = new Size(73, 14);
      this.myLable4.TabIndex = 22;
      this.myLable4.Text = "Time Server";
      this.myLable4.Visible = false;
      this.myLable3.Location = new Point(40, 113);
      this.myLable3.Name = "myLable3";
      this.myLable3.PropertyLabel = this.propertyL;
      this.myLable3.PropertyName = "LocalTime";
      this.myLable3.Size = new Size(66, 14);
      this.myLable3.TabIndex = 21;
      this.myLable3.Text = "Local Time";
      this.myLable3.Visible = false;
      this.myLable2.Location = new Point(40, 84);
      this.myLable2.Name = "myLable2";
      this.myLable2.PropertyLabel = this.propertyL;
      this.myLable2.PropertyName = "TimeZone";
      this.myLable2.Size = new Size(60, 14);
      this.myLable2.TabIndex = 20;
      this.myLable2.Text = "Time Zone";
      this.myLable2.Visible = false;
      this.myLable1.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.myLable1.Location = new Point(25, 23);
      this.myLable1.Name = "myLable1";
      this.myLable1.PropertyLabel = this.propertyL;
      this.myLable1.PropertyName = "DeviceName";
      this.myLable1.Size = new Size(75, 14);
      this.myLable1.TabIndex = 19;
      this.myLable1.Text = "Device Name";
      this.myLable1.Visible = false;
      this.terminalTB.Location = new Point(129, 237);
      this.terminalTB.Name = "terminalTB";
      this.terminalTB.Size = new Size(266, 21);
      this.terminalTB.TabIndex = 18;
      this.terminalTB.Visible = false;
      this.timeServerTB.Location = new Point(133, 136);
      this.timeServerTB.Name = "timeServerTB";
      this.timeServerTB.Size = new Size(266, 21);
      this.timeServerTB.TabIndex = 13;
      this.timeServerTB.Visible = false;
      this.localTimeTB.CustomFormat = "yyyy-MM-dd HH:mm:ss";
      this.localTimeTB.Format = DateTimePickerFormat.Custom;
      this.localTimeTB.Location = new Point(133, 108);
      this.localTimeTB.Name = "localTimeTB";
      this.localTimeTB.ShowUpDown = true;
      this.localTimeTB.Size = new Size(266, 21);
      this.localTimeTB.TabIndex = 12;
      this.localTimeTB.Visible = false;
      this.timeZoneCB.FormattingEnabled = true;
      this.timeZoneCB.Location = new Point(133, 81);
      this.timeZoneCB.Name = "timeZoneCB";
      this.timeZoneCB.Size = new Size(266, 20);
      this.timeZoneCB.TabIndex = 11;
      this.timeZoneCB.Visible = false;
      this.nameTB.Location = new Point(133, 19);
      this.nameTB.Name = "nameTB";
      this.nameTB.Size = new Size(266, 21);
      this.nameTB.TabIndex = 10;
      this.nameTB.Visible = false;
      this.networkPanel.Controls.Add((Control) this.GPRSCB);
      this.networkPanel.Controls.Add((Control) this.pppoeCB);
      this.networkPanel.Controls.Add((Control) this.pppCB);
      this.networkPanel.Controls.Add((Control) this.autoNegoCB);
      this.networkPanel.Controls.Add((Control) this.ethernetCB);
      this.networkPanel.Controls.Add((Control) this.macTB);
      this.networkPanel.Controls.Add((Control) this.myLable21);
      this.networkPanel.Controls.Add((Control) this.panel3);
      this.networkPanel.Controls.Add((Control) this.panel2);
      this.networkPanel.Controls.Add((Control) this.panel1);
      this.networkPanel.Controls.Add((Control) this.userCfRB);
      this.networkPanel.Controls.Add((Control) this.autoCfRB);
      this.networkPanel.Controls.Add((Control) this.myLable14);
      this.networkPanel.Location = new Point(0, 0);
      this.networkPanel.Name = "networkPanel";
      this.networkPanel.Size = new Size(408, 273);
      this.networkPanel.TabIndex = 29;
      this.networkPanel.Visible = false;
      this.GPRSCB.AutoSize = true;
      this.GPRSCB.Location = new Point(324, 254);
      this.GPRSCB.Name = "GPRSCB";
      this.GPRSCB.PropertyLabel = this.propertyL;
      this.GPRSCB.PropertyName = "GPRS";
      this.GPRSCB.Size = new Size(48, 16);
      this.GPRSCB.TabIndex = 48;
      this.GPRSCB.Text = "GPRS";
      this.GPRSCB.UseVisualStyleBackColor = true;
      this.pppoeCB.AutoSize = true;
      this.pppoeCB.Location = new Point(229, 254);
      this.pppoeCB.Name = "pppoeCB";
      this.pppoeCB.PropertyLabel = this.propertyL;
      this.pppoeCB.PropertyName = "PPPoE";
      this.pppoeCB.Size = new Size(54, 16);
      this.pppoeCB.TabIndex = 47;
      this.pppoeCB.Text = "PPPoE";
      this.pppoeCB.UseVisualStyleBackColor = true;
      this.pppCB.AutoSize = true;
      this.pppCB.Location = new Point(324, 237);
      this.pppCB.Name = "pppCB";
      this.pppCB.PropertyLabel = this.propertyL;
      this.pppCB.PropertyName = "PPP";
      this.pppCB.Size = new Size(42, 16);
      this.pppCB.TabIndex = 46;
      this.pppCB.Text = "PPP";
      this.pppCB.UseVisualStyleBackColor = true;
      this.autoNegoCB.AutoSize = true;
      this.autoNegoCB.Location = new Point(3, 197);
      this.autoNegoCB.Name = "autoNegoCB";
      this.autoNegoCB.PropertyLabel = this.propertyL;
      this.autoNegoCB.PropertyName = "AutoNegotiate";
      this.autoNegoCB.Size = new Size(108, 16);
      this.autoNegoCB.TabIndex = 45;
      this.autoNegoCB.Text = "Auto Negotiate";
      this.autoNegoCB.UseVisualStyleBackColor = true;
      this.ethernetCB.AutoSize = true;
      this.ethernetCB.Location = new Point(229, 236);
      this.ethernetCB.Name = "ethernetCB";
      this.ethernetCB.PropertyLabel = this.propertyL;
      this.ethernetCB.PropertyName = "Ethernet";
      this.ethernetCB.Size = new Size(72, 16);
      this.ethernetCB.TabIndex = 44;
      this.ethernetCB.Text = "Ethernet";
      this.ethernetCB.UseVisualStyleBackColor = true;
      this.macTB.Location = new Point(16, 175);
      this.macTB.Name = "macTB";
      this.macTB.Size = new Size(204, 21);
      this.macTB.TabIndex = 35;
      this.macTB.Visible = false;
      this.myLable21.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.myLable21.Location = new Point(3, 162);
      this.myLable21.Name = "myLable21";
      this.myLable21.PropertyLabel = this.propertyL;
      this.myLable21.PropertyName = "MacAddress";
      this.myLable21.Size = new Size(75, 14);
      this.myLable21.TabIndex = 32;
      this.myLable21.Text = "Mac Address";
      this.myLable21.Visible = false;
      this.panel3.Controls.Add((Control) this.duplexCB);
      this.panel3.Controls.Add((Control) this.speedCB);
      this.panel3.Controls.Add((Control) this.myLable20);
      this.panel3.Controls.Add((Control) this.myLable19);
      this.panel3.Location = new Point(16, 213);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(158, 56);
      this.panel3.TabIndex = 30;
      this.duplexCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.duplexCB.FormattingEnabled = true;
      this.duplexCB.Items.AddRange(new object[2]
      {
        (object) "Half",
        (object) "Full"
      });
      this.duplexCB.Location = new Point(81, 28);
      this.duplexCB.Name = "duplexCB";
      this.duplexCB.Size = new Size(65, 20);
      this.duplexCB.TabIndex = 31;
      this.duplexCB.Visible = false;
      this.speedCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.speedCB.FormattingEnabled = true;
      this.speedCB.Location = new Point(81, 4);
      this.speedCB.Name = "speedCB";
      this.speedCB.Size = new Size(65, 20);
      this.speedCB.TabIndex = 30;
      this.speedCB.Visible = false;
      this.myLable20.Location = new Point(3, 30);
      this.myLable20.Name = "myLable20";
      this.myLable20.PropertyLabel = this.propertyL;
      this.myLable20.PropertyName = "Duplex";
      this.myLable20.Size = new Size(42, 14);
      this.myLable20.TabIndex = 29;
      this.myLable20.Text = "Duplex";
      this.myLable20.Visible = false;
      this.myLable19.Location = new Point(3, 8);
      this.myLable19.Name = "myLable19";
      this.myLable19.PropertyLabel = this.propertyL;
      this.myLable19.PropertyName = "Speed";
      this.myLable19.Size = new Size(35, 14);
      this.myLable19.TabIndex = 28;
      this.myLable19.Text = "Speed";
      this.myLable19.Visible = false;
      this.panel2.Controls.Add((Control) this.altDNSTB);
      this.panel2.Controls.Add((Control) this.pDNSTB);
      this.panel2.Controls.Add((Control) this.gatewayTB);
      this.panel2.Controls.Add((Control) this.subnetTB);
      this.panel2.Controls.Add((Control) this.ipTB);
      this.panel2.Controls.Add((Control) this.myLable18);
      this.panel2.Controls.Add((Control) this.myLable17);
      this.panel2.Controls.Add((Control) this.myLable16);
      this.panel2.Controls.Add((Control) this.myLable15);
      this.panel2.Controls.Add((Control) this.myLable13);
      this.panel2.Location = new Point(226, 59);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(179, 173);
      this.panel2.TabIndex = 29;
      this.altDNSTB.Location = new Point(79, 143);
      this.altDNSTB.Name = "altDNSTB";
      this.altDNSTB.Size = new Size(97, 21);
      this.altDNSTB.TabIndex = 43;
      this.altDNSTB.Visible = false;
      this.pDNSTB.Location = new Point(79, 101);
      this.pDNSTB.Name = "pDNSTB";
      this.pDNSTB.Size = new Size(97, 21);
      this.pDNSTB.TabIndex = 42;
      this.pDNSTB.Visible = false;
      this.gatewayTB.Location = new Point(79, 57);
      this.gatewayTB.Name = "gatewayTB";
      this.gatewayTB.Size = new Size(97, 21);
      this.gatewayTB.TabIndex = 41;
      this.gatewayTB.Visible = false;
      this.subnetTB.Location = new Point(79, 30);
      this.subnetTB.Name = "subnetTB";
      this.subnetTB.Size = new Size(97, 21);
      this.subnetTB.TabIndex = 40;
      this.subnetTB.Visible = false;
      this.ipTB.Location = new Point(79, 3);
      this.ipTB.Name = "ipTB";
      this.ipTB.Size = new Size(97, 21);
      this.ipTB.TabIndex = 39;
      this.ipTB.Visible = false;
      this.myLable18.Location = new Point(3, 128);
      this.myLable18.Name = "myLable18";
      this.myLable18.PropertyLabel = this.propertyL;
      this.myLable18.PropertyName = "AlternateDNSServer";
      this.myLable18.Size = new Size(128, 14);
      this.myLable18.TabIndex = 38;
      this.myLable18.Text = "Alternate DNS Server";
      this.myLable18.Visible = false;
      this.myLable17.Location = new Point(0, 85);
      this.myLable17.Name = "myLable17";
      this.myLable17.PropertyLabel = this.propertyL;
      this.myLable17.PropertyName = "PreferredDNSServer";
      this.myLable17.Size = new Size(128, 14);
      this.myLable17.TabIndex = 37;
      this.myLable17.Text = "Preferred DNS Server";
      this.myLable17.Visible = false;
      this.myLable16.Location = new Point(3, 61);
      this.myLable16.Name = "myLable16";
      this.myLable16.PropertyLabel = this.propertyL;
      this.myLable16.PropertyName = "DefaultGateway";
      this.myLable16.Size = new Size(48, 14);
      this.myLable16.TabIndex = 36;
      this.myLable16.Text = "Gateway";
      this.myLable16.Visible = false;
      this.myLable15.Location = new Point(3, 34);
      this.myLable15.Name = "myLable15";
      this.myLable15.PropertyLabel = this.propertyL;
      this.myLable15.PropertyName = "Subnet";
      this.myLable15.Size = new Size(42, 14);
      this.myLable15.TabIndex = 35;
      this.myLable15.Text = "Subnet";
      this.myLable15.Visible = false;
      this.myLable13.Location = new Point(3, 8);
      this.myLable13.Name = "myLable13";
      this.myLable13.PropertyLabel = this.propertyL;
      this.myLable13.PropertyName = "IPAddress";
      this.myLable13.Size = new Size(66, 14);
      this.myLable13.TabIndex = 34;
      this.myLable13.Text = "IP Address";
      this.myLable13.Visible = false;
      this.panel1.Controls.Add((Control) this.dhcpNameTB);
      this.panel1.Controls.Add((Control) this.myLable12);
      this.panel1.Controls.Add((Control) this.autoIPCB);
      this.panel1.Controls.Add((Control) this.myLable11);
      this.panel1.Controls.Add((Control) this.dhcpCB);
      this.panel1.Controls.Add((Control) this.myLable9);
      this.panel1.Controls.Add((Control) this.bootpCB);
      this.panel1.Controls.Add((Control) this.myLable8);
      this.panel1.Location = new Point(16, 59);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(204, 97);
      this.panel1.TabIndex = 26;
      this.dhcpNameTB.Location = new Point(98, 70);
      this.dhcpNameTB.Name = "dhcpNameTB";
      this.dhcpNameTB.Size = new Size(97, 21);
      this.dhcpNameTB.TabIndex = 34;
      this.dhcpNameTB.Visible = false;
      this.myLable12.Location = new Point(3, 73);
      this.myLable12.Name = "myLable12";
      this.myLable12.PropertyLabel = this.propertyL;
      this.myLable12.PropertyName = "DHCPHostName";
      this.myLable12.Size = new Size(91, 14);
      this.myLable12.TabIndex = 33;
      this.myLable12.Text = "DHCP Host Name";
      this.myLable12.Visible = false;
      this.autoIPCB.AutoSize = true;
      this.autoIPCB.Location = new Point(98, 48);
      this.autoIPCB.Name = "autoIPCB";
      this.autoIPCB.Size = new Size(60, 16);
      this.autoIPCB.TabIndex = 32;
      this.autoIPCB.Text = "Enable";
      this.autoIPCB.UseVisualStyleBackColor = true;
      this.autoIPCB.Visible = false;
      this.myLable11.Location = new Point(3, 49);
      this.myLable11.Name = "myLable11";
      this.myLable11.PropertyLabel = this.propertyL;
      this.myLable11.PropertyName = "AutoIP";
      this.myLable11.Size = new Size(48, 14);
      this.myLable11.TabIndex = 31;
      this.myLable11.Text = "Auto IP";
      this.myLable11.Visible = false;
      this.dhcpCB.AutoSize = true;
      this.dhcpCB.Location = new Point(98, 28);
      this.dhcpCB.Name = "dhcpCB";
      this.dhcpCB.Size = new Size(60, 16);
      this.dhcpCB.TabIndex = 30;
      this.dhcpCB.Text = "Enable";
      this.dhcpCB.UseVisualStyleBackColor = true;
      this.dhcpCB.Visible = false;
      this.myLable9.Location = new Point(3, 29);
      this.myLable9.Name = "myLable9";
      this.myLable9.PropertyLabel = this.propertyL;
      this.myLable9.PropertyName = "DHCP";
      this.myLable9.Size = new Size(29, 14);
      this.myLable9.TabIndex = 29;
      this.myLable9.Text = "DHCP";
      this.myLable9.Visible = false;
      this.bootpCB.AutoSize = true;
      this.bootpCB.Location = new Point(98, 8);
      this.bootpCB.Name = "bootpCB";
      this.bootpCB.Size = new Size(60, 16);
      this.bootpCB.TabIndex = 28;
      this.bootpCB.Text = "Enable";
      this.bootpCB.UseVisualStyleBackColor = true;
      this.bootpCB.Visible = false;
      this.myLable8.Location = new Point(3, 8);
      this.myLable8.Name = "myLable8";
      this.myLable8.PropertyLabel = this.propertyL;
      this.myLable8.PropertyName = "Bootp";
      this.myLable8.Size = new Size(35, 14);
      this.myLable8.TabIndex = 27;
      this.myLable8.Text = "BOOTP";
      this.myLable8.Visible = false;
      this.userCfRB.AutoSize = true;
      this.userCfRB.Location = new Point(220, 37);
      this.userCfRB.Name = "userCfRB";
      this.userCfRB.Size = new Size(89, 16);
      this.userCfRB.TabIndex = 25;
      this.userCfRB.TabStop = true;
      this.userCfRB.Text = "User config";
      this.userCfRB.UseVisualStyleBackColor = true;
      this.userCfRB.Visible = false;
      this.autoCfRB.AutoSize = true;
      this.autoCfRB.Location = new Point(3, 41);
      this.autoCfRB.Name = "autoCfRB";
      this.autoCfRB.Size = new Size(143, 16);
      this.autoCfRB.TabIndex = 24;
      this.autoCfRB.TabStop = true;
      this.autoCfRB.Text = "Obtain automatically";
      this.autoCfRB.UseVisualStyleBackColor = true;
      this.autoCfRB.Visible = false;
      this.autoCfRB.CheckedChanged += new EventHandler(this.autoCfRB_CheckedChanged);
      this.myLable14.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.myLable14.Location = new Point(14, 17);
      this.myLable14.Name = "myLable14";
      this.myLable14.PropertyLabel = this.propertyL;
      this.myLable14.PropertyName = "IPConfiguration";
      this.myLable14.Size = new Size(107, 14);
      this.myLable14.TabIndex = 19;
      this.myLable14.Text = "IP Configuration";
      this.myLable14.Visible = false;
      this.serverPanel.Controls.Add((Control) this.cpuCB);
      this.serverPanel.Controls.Add((Control) this.monitorCB);
      this.serverPanel.Controls.Add((Control) this.mtuTB);
      this.serverPanel.Controls.Add((Control) this.httpPortNUD);
      this.serverPanel.Controls.Add((Control) this.arpNUD);
      this.serverPanel.Controls.Add((Control) this.myLable26);
      this.serverPanel.Controls.Add((Control) this.myLable25);
      this.serverPanel.Controls.Add((Control) this.myLable24);
      this.serverPanel.Controls.Add((Control) this.myLable23);
      this.serverPanel.Controls.Add((Control) this.myLable22);
      this.serverPanel.Location = new Point(0, 0);
      this.serverPanel.Name = "serverPanel";
      this.serverPanel.Size = new Size(408, 273);
      this.serverPanel.TabIndex = 30;
      this.serverPanel.Visible = false;
      this.cpuCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cpuCB.FormattingEnabled = true;
      this.cpuCB.Items.AddRange(new object[2]
      {
        (object) "High",
        (object) "Regular"
      });
      this.cpuCB.Location = new Point(238, 131);
      this.cpuCB.Name = "cpuCB";
      this.cpuCB.Size = new Size(60, 20);
      this.cpuCB.TabIndex = 44;
      this.cpuCB.Visible = false;
      this.monitorCB.AutoSize = true;
      this.monitorCB.Location = new Point(238, 101);
      this.monitorCB.Name = "monitorCB";
      this.monitorCB.Size = new Size(60, 16);
      this.monitorCB.TabIndex = 35;
      this.monitorCB.Text = "Enable";
      this.monitorCB.UseVisualStyleBackColor = true;
      this.monitorCB.Visible = false;
      this.mtuTB.Enabled = false;
      this.mtuTB.Location = new Point(238, 203);
      this.mtuTB.Name = "mtuTB";
      this.mtuTB.Size = new Size(60, 21);
      this.mtuTB.TabIndex = 42;
      this.mtuTB.Visible = false;
      this.httpPortNUD.Location = new Point(238, 166);
      NumericUpDown numericUpDown1 = this.httpPortNUD;
      int[] bits1 = new int[4];
      bits1[0] = (int) ushort.MaxValue;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      NumericUpDown numericUpDown2 = this.httpPortNUD;
      int[] bits2 = new int[4];
      bits2[0] = 1;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Minimum = num2;
      this.httpPortNUD.Name = "httpPortNUD";
      this.httpPortNUD.Size = new Size(60, 21);
      this.httpPortNUD.TabIndex = 34;
      NumericUpDown numericUpDown3 = this.httpPortNUD;
      int[] bits3 = new int[4];
      bits3[0] = 1;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Value = num3;
      this.httpPortNUD.Visible = false;
      this.arpNUD.Location = new Point(238, 64);
      NumericUpDown numericUpDown4 = this.arpNUD;
      int[] bits4 = new int[4];
      bits4[0] = (int) byte.MaxValue;
      Decimal num4 = new Decimal(bits4);
      numericUpDown4.Maximum = num4;
      NumericUpDown numericUpDown5 = this.arpNUD;
      int[] bits5 = new int[4];
      bits5[0] = 60;
      Decimal num5 = new Decimal(bits5);
      numericUpDown5.Minimum = num5;
      this.arpNUD.Name = "arpNUD";
      this.arpNUD.Size = new Size(60, 21);
      this.arpNUD.TabIndex = 33;
      NumericUpDown numericUpDown6 = this.arpNUD;
      int[] bits6 = new int[4];
      bits6[0] = 60;
      Decimal num6 = new Decimal(bits6);
      numericUpDown6.Value = num6;
      this.arpNUD.Visible = false;
      this.myLable26.Location = new Point(99, 202);
      this.myLable26.Name = "myLable26";
      this.myLable26.PropertyLabel = this.propertyL;
      this.myLable26.PropertyName = "MTUSize";
      this.myLable26.Size = new Size(48, 14);
      this.myLable26.TabIndex = 32;
      this.myLable26.Text = "MTUSize";
      this.myLable26.Visible = false;
      this.myLable25.Location = new Point(99, 168);
      this.myLable25.Name = "myLable25";
      this.myLable25.PropertyLabel = this.propertyL;
      this.myLable25.PropertyName = "HTTPServerPort";
      this.myLable25.Size = new Size(103, 14);
      this.myLable25.TabIndex = 31;
      this.myLable25.Text = "HTTP Server Port";
      this.myLable25.Visible = false;
      this.myLable24.Location = new Point(99, 134);
      this.myLable24.Name = "myLable24";
      this.myLable24.PropertyLabel = this.propertyL;
      this.myLable24.PropertyName = "CPUPerformanceMode";
      this.myLable24.Size = new Size(128, 14);
      this.myLable24.TabIndex = 30;
      this.myLable24.Text = "CPU Performance Mode";
      this.myLable24.Visible = false;
      this.myLable23.Location = new Point(99, 101);
      this.myLable23.Name = "myLable23";
      this.myLable23.PropertyLabel = this.propertyL;
      this.myLable23.PropertyName = "MonitorModeBootup";
      this.myLable23.Size = new Size(122, 14);
      this.myLable23.TabIndex = 29;
      this.myLable23.Text = "Monitor Mode Bootup";
      this.myLable23.Visible = false;
      this.myLable22.Location = new Point(99, 67);
      this.myLable22.Name = "myLable22";
      this.myLable22.PropertyLabel = this.propertyL;
      this.myLable22.PropertyName = "ARPcacheTimeout";
      this.myLable22.Size = new Size(103, 14);
      this.myLable22.TabIndex = 28;
      this.myLable22.Text = "ARPcache Timeout";
      this.myLable22.Visible = false;
      this.emailPanel.Controls.Add((Control) this.email3TB);
      this.emailPanel.Controls.Add((Control) this.emial2TB);
      this.emailPanel.Controls.Add((Control) this.email1TB);
      this.emailPanel.Controls.Add((Control) this.myLable34);
      this.emailPanel.Controls.Add((Control) this.myLable33);
      this.emailPanel.Controls.Add((Control) this.myLable32);
      this.emailPanel.Controls.Add((Control) this.emailPwdTB);
      this.emailPanel.Controls.Add((Control) this.emailUserTB);
      this.emailPanel.Controls.Add((Control) this.emailTB);
      this.emailPanel.Controls.Add((Control) this.smtpPNUD);
      this.emailPanel.Controls.Add((Control) this.smtpDTB);
      this.emailPanel.Controls.Add((Control) this.myLable27);
      this.emailPanel.Controls.Add((Control) this.myLable28);
      this.emailPanel.Controls.Add((Control) this.myLable29);
      this.emailPanel.Controls.Add((Control) this.myLable30);
      this.emailPanel.Controls.Add((Control) this.myLable31);
      this.emailPanel.Location = new Point(0, 0);
      this.emailPanel.Name = "emailPanel";
      this.emailPanel.Size = new Size(408, 273);
      this.emailPanel.TabIndex = 31;
      this.emailPanel.Visible = false;
      this.email3TB.Location = new Point(138, 230);
      this.email3TB.Name = "email3TB";
      this.email3TB.Size = new Size(142, 21);
      this.email3TB.TabIndex = 55;
      this.email3TB.Visible = false;
      this.emial2TB.Location = new Point(138, 203);
      this.emial2TB.Name = "emial2TB";
      this.emial2TB.Size = new Size(142, 21);
      this.emial2TB.TabIndex = 54;
      this.emial2TB.Visible = false;
      this.email1TB.Location = new Point(138, 176);
      this.email1TB.Name = "email1TB";
      this.email1TB.Size = new Size(142, 21);
      this.email1TB.TabIndex = 53;
      this.email1TB.Visible = false;
      this.myLable34.Location = new Point(31, 234);
      this.myLable34.Name = "myLable34";
      this.myLable34.PropertyLabel = this.propertyL;
      this.myLable34.PropertyName = "EmailAddress3";
      this.myLable34.Size = new Size(103, 14);
      this.myLable34.TabIndex = 52;
      this.myLable34.Text = "Email Address3";
      this.myLable34.Visible = false;
      this.myLable33.Location = new Point(31, 207);
      this.myLable33.Name = "myLable33";
      this.myLable33.PropertyLabel = this.propertyL;
      this.myLable33.PropertyName = "EmailAddress2";
      this.myLable33.Size = new Size(103, 14);
      this.myLable33.TabIndex = 51;
      this.myLable33.Text = "Email Address2";
      this.myLable33.Visible = false;
      this.myLable32.Location = new Point(31, 179);
      this.myLable32.Name = "myLable32";
      this.myLable32.PropertyLabel = this.propertyL;
      this.myLable32.PropertyName = "EmailAddress1";
      this.myLable32.Size = new Size(103, 14);
      this.myLable32.TabIndex = 50;
      this.myLable32.Text = "Email Address1";
      this.myLable32.Visible = false;
      this.emailPwdTB.Location = new Point(138, 126);
      this.emailPwdTB.Name = "emailPwdTB";
      this.emailPwdTB.PasswordChar = '*';
      this.emailPwdTB.Size = new Size(142, 21);
      this.emailPwdTB.TabIndex = 49;
      this.emailPwdTB.Visible = false;
      this.emailUserTB.Location = new Point(138, 99);
      this.emailUserTB.Name = "emailUserTB";
      this.emailUserTB.Size = new Size(142, 21);
      this.emailUserTB.TabIndex = 48;
      this.emailUserTB.Visible = false;
      this.emailTB.Location = new Point(138, 72);
      this.emailTB.Name = "emailTB";
      this.emailTB.Size = new Size(142, 21);
      this.emailTB.TabIndex = 47;
      this.emailTB.Visible = false;
      this.smtpPNUD.Location = new Point(345, 46);
      NumericUpDown numericUpDown7 = this.smtpPNUD;
      int[] bits7 = new int[4];
      bits7[0] = (int) ushort.MaxValue;
      Decimal num7 = new Decimal(bits7);
      numericUpDown7.Maximum = num7;
      NumericUpDown numericUpDown8 = this.smtpPNUD;
      int[] bits8 = new int[4];
      bits8[0] = 1;
      Decimal num8 = new Decimal(bits8);
      numericUpDown8.Minimum = num8;
      this.smtpPNUD.Name = "smtpPNUD";
      this.smtpPNUD.Size = new Size(60, 21);
      this.smtpPNUD.TabIndex = 45;
      NumericUpDown numericUpDown9 = this.smtpPNUD;
      int[] bits9 = new int[4];
      bits9[0] = 1;
      Decimal num9 = new Decimal(bits9);
      numericUpDown9.Value = num9;
      this.smtpPNUD.Visible = false;
      this.smtpDTB.Location = new Point(138, 45);
      this.smtpDTB.Name = "smtpDTB";
      this.smtpDTB.Size = new Size(142, 21);
      this.smtpDTB.TabIndex = 46;
      this.smtpDTB.Visible = false;
      this.myLable27.Location = new Point(31, 103);
      this.myLable27.Name = "myLable27";
      this.myLable27.PropertyLabel = this.propertyL;
      this.myLable27.PropertyName = "EmailUsername";
      this.myLable27.Size = new Size(91, 14);
      this.myLable27.TabIndex = 32;
      this.myLable27.Text = "Email Username";
      this.myLable27.Visible = false;
      this.myLable28.Location = new Point(31, 131);
      this.myLable28.Name = "myLable28";
      this.myLable28.PropertyLabel = this.propertyL;
      this.myLable28.PropertyName = "EmailPassword";
      this.myLable28.Size = new Size(91, 14);
      this.myLable28.TabIndex = 31;
      this.myLable28.Text = "Email Password";
      this.myLable28.Visible = false;
      this.myLable29.Location = new Point(31, 76);
      this.myLable29.Name = "myLable29";
      this.myLable29.PropertyLabel = this.propertyL;
      this.myLable29.PropertyName = "EmailAddress";
      this.myLable29.Size = new Size(79, 14);
      this.myLable29.TabIndex = 30;
      this.myLable29.Text = "Email Address";
      this.myLable29.Visible = false;
      this.myLable30.Location = new Point(284, 50);
      this.myLable30.Name = "myLable30";
      this.myLable30.PropertyLabel = this.propertyL;
      this.myLable30.PropertyName = "SMTPPort";
      this.myLable30.Size = new Size(60, 14);
      this.myLable30.TabIndex = 29;
      this.myLable30.Text = "SMTP Port";
      this.myLable30.Visible = false;
      this.myLable31.Location = new Point(31, 48);
      this.myLable31.Name = "myLable31";
      this.myLable31.PropertyLabel = this.propertyL;
      this.myLable31.PropertyName = "SMTPDomainName";
      this.myLable31.Size = new Size(103, 14);
      this.myLable31.TabIndex = 28;
      this.myLable31.Text = "SMTP Domain Name";
      this.myLable31.Visible = false;
      this.triggerPanel.Controls.Add((Control) this.minNotifyNUD);
      this.triggerPanel.Controls.Add((Control) this.priorityCB);
      this.triggerPanel.Controls.Add((Control) this.myLable44);
      this.triggerPanel.Controls.Add((Control) this.myLable43);
      this.triggerPanel.Controls.Add((Control) this.triggerMTB);
      this.triggerPanel.Controls.Add((Control) this.myLable42);
      this.triggerPanel.Controls.Add((Control) this.pwdChangeCB);
      this.triggerPanel.Controls.Add((Control) this.ipChangeCB);
      this.triggerPanel.Controls.Add((Control) this.loginFailCB);
      this.triggerPanel.Controls.Add((Control) this.dsrCB);
      this.triggerPanel.Controls.Add((Control) this.dcdCB);
      this.triggerPanel.Controls.Add((Control) this.warmCB);
      this.triggerPanel.Controls.Add((Control) this.coldCB);
      this.triggerPanel.Controls.Add((Control) this.myLable41);
      this.triggerPanel.Controls.Add((Control) this.myLable40);
      this.triggerPanel.Controls.Add((Control) this.myLable39);
      this.triggerPanel.Controls.Add((Control) this.myLable38);
      this.triggerPanel.Controls.Add((Control) this.myLable37);
      this.triggerPanel.Controls.Add((Control) this.myLable36);
      this.triggerPanel.Controls.Add((Control) this.myLable35);
      this.triggerPanel.Location = new Point(0, 0);
      this.triggerPanel.Name = "triggerPanel";
      this.triggerPanel.Size = new Size(408, 273);
      this.triggerPanel.TabIndex = 32;
      this.triggerPanel.Visible = false;
      this.minNotifyNUD.Location = new Point(218, 238);
      NumericUpDown numericUpDown10 = this.minNotifyNUD;
      int[] bits10 = new int[4];
      bits10[0] = (int) byte.MaxValue;
      Decimal num10 = new Decimal(bits10);
      numericUpDown10.Maximum = num10;
      this.minNotifyNUD.Name = "minNotifyNUD";
      this.minNotifyNUD.Size = new Size(60, 21);
      this.minNotifyNUD.TabIndex = 60;
      this.minNotifyNUD.Visible = false;
      this.priorityCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.priorityCB.FormattingEnabled = true;
      this.priorityCB.Items.AddRange(new object[3]
      {
        (object) "Low",
        (object) "Normal",
        (object) "High"
      });
      this.priorityCB.Location = new Point(179, 211);
      this.priorityCB.Name = "priorityCB";
      this.priorityCB.Size = new Size(67, 20);
      this.priorityCB.TabIndex = 59;
      this.priorityCB.Visible = false;
      this.myLable44.Location = new Point(44, 241);
      this.myLable44.Name = "myLable44";
      this.myLable44.PropertyLabel = this.propertyL;
      this.myLable44.PropertyName = "MinNotificationInterval";
      this.myLable44.Size = new Size(159, 14);
      this.myLable44.TabIndex = 58;
      this.myLable44.Text = "Min Notification Interval";
      this.myLable44.Visible = false;
      this.myLable43.Location = new Point(44, 215);
      this.myLable43.Name = "myLable43";
      this.myLable43.PropertyLabel = this.propertyL;
      this.myLable43.PropertyName = "Priority";
      this.myLable43.Size = new Size(54, 14);
      this.myLable43.TabIndex = 57;
      this.myLable43.Text = "Priority";
      this.myLable43.Visible = false;
      this.triggerMTB.Location = new Point(179, 184);
      this.triggerMTB.Name = "triggerMTB";
      this.triggerMTB.Size = new Size(202, 21);
      this.triggerMTB.TabIndex = 56;
      this.triggerMTB.Visible = false;
      this.myLable42.Location = new Point(44, 190);
      this.myLable42.Name = "myLable42";
      this.myLable42.PropertyLabel = this.propertyL;
      this.myLable42.PropertyName = "EmailTriggerSubject";
      this.myLable42.Size = new Size(134, 14);
      this.myLable42.TabIndex = 52;
      this.myLable42.Text = "Email Trigger Subject";
      this.myLable42.Visible = false;
      this.pwdChangeCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.pwdChangeCB.FormattingEnabled = true;
      this.pwdChangeCB.Items.AddRange(new object[2]
      {
        (object) "Mail off",
        (object) "Mail on"
      });
      this.pwdChangeCB.Location = new Point(327, 98);
      this.pwdChangeCB.Name = "pwdChangeCB";
      this.pwdChangeCB.Size = new Size(76, 20);
      this.pwdChangeCB.TabIndex = 51;
      this.pwdChangeCB.Visible = false;
      this.ipChangeCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ipChangeCB.FormattingEnabled = true;
      this.ipChangeCB.Items.AddRange(new object[2]
      {
        (object) "Mail off",
        (object) "Mail on"
      });
      this.ipChangeCB.Location = new Point(327, 72);
      this.ipChangeCB.Name = "ipChangeCB";
      this.ipChangeCB.Size = new Size(76, 20);
      this.ipChangeCB.TabIndex = 50;
      this.ipChangeCB.Visible = false;
      this.loginFailCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.loginFailCB.FormattingEnabled = true;
      this.loginFailCB.Items.AddRange(new object[2]
      {
        (object) "Mail off",
        (object) "Mail on"
      });
      this.loginFailCB.Location = new Point(327, 46);
      this.loginFailCB.Name = "loginFailCB";
      this.loginFailCB.Size = new Size(76, 20);
      this.loginFailCB.TabIndex = 49;
      this.loginFailCB.Visible = false;
      this.dsrCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.dsrCB.FormattingEnabled = true;
      this.dsrCB.Items.AddRange(new object[2]
      {
        (object) "Mail off",
        (object) "Mail on"
      });
      this.dsrCB.Location = new Point(124, 124);
      this.dsrCB.Name = "dsrCB";
      this.dsrCB.Size = new Size(76, 20);
      this.dsrCB.TabIndex = 48;
      this.dsrCB.Visible = false;
      this.dcdCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.dcdCB.FormattingEnabled = true;
      this.dcdCB.Items.AddRange(new object[2]
      {
        (object) "Mail off",
        (object) "Mail on"
      });
      this.dcdCB.Location = new Point(124, 98);
      this.dcdCB.Name = "dcdCB";
      this.dcdCB.Size = new Size(76, 20);
      this.dcdCB.TabIndex = 47;
      this.dcdCB.Visible = false;
      this.warmCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.warmCB.FormattingEnabled = true;
      this.warmCB.Items.AddRange(new object[2]
      {
        (object) "Mail off",
        (object) "Mail on"
      });
      this.warmCB.Location = new Point(124, 72);
      this.warmCB.Name = "warmCB";
      this.warmCB.Size = new Size(76, 20);
      this.warmCB.TabIndex = 46;
      this.warmCB.Visible = false;
      this.coldCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.coldCB.FormattingEnabled = true;
      this.coldCB.Items.AddRange(new object[2]
      {
        (object) "Mail off",
        (object) "Mail on"
      });
      this.coldCB.Location = new Point(124, 46);
      this.coldCB.Name = "coldCB";
      this.coldCB.Size = new Size(76, 20);
      this.coldCB.TabIndex = 45;
      this.coldCB.Visible = false;
      this.myLable41.Location = new Point(207, 101);
      this.myLable41.Name = "myLable41";
      this.myLable41.PropertyLabel = this.propertyL;
      this.myLable41.PropertyName = "PasswordChanged";
      this.myLable41.Size = new Size(103, 14);
      this.myLable41.TabIndex = 35;
      this.myLable41.Text = "Password Changed";
      this.myLable41.Visible = false;
      this.myLable40.Location = new Point(207, 75);
      this.myLable40.Name = "myLable40";
      this.myLable40.PropertyLabel = this.propertyL;
      this.myLable40.PropertyName = "IPAddressChanged";
      this.myLable40.Size = new Size(66, 14);
      this.myLable40.TabIndex = 34;
      this.myLable40.Text = "IP changed";
      this.myLable40.Visible = false;
      this.myLable39.Location = new Point(207, 50);
      this.myLable39.Name = "myLable39";
      this.myLable39.PropertyLabel = this.propertyL;
      this.myLable39.PropertyName = "AuthenticationFailure";
      this.myLable39.Size = new Size(116, 14);
      this.myLable39.TabIndex = 33;
      this.myLable39.Text = "Login auth failure";
      this.myLable39.Visible = false;
      this.myLable38.Location = new Point(44, 128);
      this.myLable38.Name = "myLable38";
      this.myLable38.PropertyLabel = this.propertyL;
      this.myLable38.PropertyName = "DSRChanged";
      this.myLable38.Size = new Size(73, 14);
      this.myLable38.TabIndex = 32;
      this.myLable38.Text = "DSR Changed";
      this.myLable38.Visible = false;
      this.myLable37.Location = new Point(44, 101);
      this.myLable37.Name = "myLable37";
      this.myLable37.PropertyLabel = this.propertyL;
      this.myLable37.PropertyName = "DCDChanged";
      this.myLable37.Size = new Size(73, 14);
      this.myLable37.TabIndex = 31;
      this.myLable37.Text = "DCD Changed";
      this.myLable37.Visible = false;
      this.myLable36.Location = new Point(44, 75);
      this.myLable36.Name = "myLable36";
      this.myLable36.PropertyLabel = this.propertyL;
      this.myLable36.PropertyName = "WarmStart";
      this.myLable36.Size = new Size(66, 14);
      this.myLable36.TabIndex = 30;
      this.myLable36.Text = "Warm Start";
      this.myLable36.Visible = false;
      this.myLable35.Location = new Point(44, 50);
      this.myLable35.Name = "myLable35";
      this.myLable35.PropertyLabel = this.propertyL;
      this.myLable35.PropertyName = "ColdStart";
      this.myLable35.Size = new Size(66, 14);
      this.myLable35.TabIndex = 29;
      this.myLable35.Text = "Cold Start";
      this.myLable35.Visible = false;
      this.inputTriggerPanel.Controls.Add((Control) this.reNotifyNUD);
      this.inputTriggerPanel.Controls.Add((Control) this.myLable51);
      this.inputTriggerPanel.Controls.Add((Control) this.panel5);
      this.inputTriggerPanel.Controls.Add((Control) this.myLable50);
      this.inputTriggerPanel.Controls.Add((Control) this.enableSerialCB);
      this.inputTriggerPanel.Controls.Add((Control) this.inputMNINUD);
      this.inputTriggerPanel.Controls.Add((Control) this.inputPriorityCB);
      this.inputTriggerPanel.Controls.Add((Control) this.myLable45);
      this.inputTriggerPanel.Controls.Add((Control) this.myLable46);
      this.inputTriggerPanel.Controls.Add((Control) this.messageTB);
      this.inputTriggerPanel.Controls.Add((Control) this.myLable47);
      this.inputTriggerPanel.Controls.Add((Control) this.input2CB);
      this.inputTriggerPanel.Controls.Add((Control) this.input1CB);
      this.inputTriggerPanel.Controls.Add((Control) this.myLable53);
      this.inputTriggerPanel.Controls.Add((Control) this.myLable54);
      this.inputTriggerPanel.Location = new Point(0, 0);
      this.inputTriggerPanel.Name = "inputTriggerPanel";
      this.inputTriggerPanel.Size = new Size(408, 273);
      this.inputTriggerPanel.TabIndex = 33;
      this.inputTriggerPanel.Visible = false;
      this.reNotifyNUD.Location = new Point(218, 247);
      NumericUpDown numericUpDown11 = this.reNotifyNUD;
      int[] bits11 = new int[4];
      bits11[0] = (int) byte.MaxValue;
      Decimal num11 = new Decimal(bits11);
      numericUpDown11.Maximum = num11;
      this.reNotifyNUD.Name = "reNotifyNUD";
      this.reNotifyNUD.Size = new Size(60, 21);
      this.reNotifyNUD.TabIndex = 65;
      this.reNotifyNUD.Visible = false;
      this.myLable51.Location = new Point(44, 250);
      this.myLable51.Name = "myLable51";
      this.myLable51.PropertyLabel = this.propertyL;
      this.myLable51.PropertyName = "RenotificationInterval";
      this.myLable51.Size = new Size(147, 14);
      this.myLable51.TabIndex = 64;
      this.myLable51.Text = "Renotification Interval";
      this.myLable51.Visible = false;
      this.panel5.Controls.Add((Control) this.char3TB);
      this.panel5.Controls.Add((Control) this.char2TB);
      this.panel5.Controls.Add((Control) this.char1TB);
      this.panel5.Controls.Add((Control) this.label12);
      this.panel5.Controls.Add((Control) this.label11);
      this.panel5.Controls.Add((Control) this.label10);
      this.panel5.Controls.Add((Control) this.dataSizeCB);
      this.panel5.Controls.Add((Control) this.channelsCB);
      this.panel5.Controls.Add((Control) this.myLable49);
      this.panel5.Controls.Add((Control) this.myLable48);
      this.panel5.Location = new Point(205, 57);
      this.panel5.Name = "panel5";
      this.panel5.Size = new Size(200, 87);
      this.panel5.TabIndex = 63;
      this.char3TB.Location = new Point(156, 60);
      this.char3TB.Name = "char3TB";
      this.char3TB.Size = new Size(32, 21);
      this.char3TB.TabIndex = 71;
      this.char3TB.Visible = false;
      this.char2TB.Location = new Point(102, 60);
      this.char2TB.Name = "char2TB";
      this.char2TB.Size = new Size(32, 21);
      this.char2TB.TabIndex = 70;
      this.char2TB.Visible = false;
      this.char1TB.Location = new Point(47, 60);
      this.char1TB.Name = "char1TB";
      this.char1TB.Size = new Size(32, 21);
      this.char1TB.TabIndex = 69;
      this.char1TB.Visible = false;
      this.label12.AutoSize = true;
      this.label12.Location = new Point(137, 64);
      this.label12.Name = "label12";
      this.label12.Size = new Size(17, 12);
      this.label12.TabIndex = 68;
      this.label12.Text = "0x";
      this.label12.Visible = false;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(83, 64);
      this.label11.Name = "label11";
      this.label11.Size = new Size(17, 12);
      this.label11.TabIndex = 67;
      this.label11.Text = "0x";
      this.label11.Visible = false;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(27, 64);
      this.label10.Name = "label10";
      this.label10.Size = new Size(17, 12);
      this.label10.TabIndex = 66;
      this.label10.Text = "0x";
      this.label10.Visible = false;
      this.dataSizeCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.dataSizeCB.FormattingEnabled = true;
      this.dataSizeCB.Items.AddRange(new object[2]
      {
        (object) "TwoBytes",
        (object) "ThreeBytes"
      });
      this.dataSizeCB.Location = new Point(112, 31);
      this.dataSizeCB.Name = "dataSizeCB";
      this.dataSizeCB.Size = new Size(76, 20);
      this.dataSizeCB.TabIndex = 65;
      this.dataSizeCB.Visible = false;
      this.dataSizeCB.SelectedIndexChanged += new EventHandler(this.dataSizeCB_SelectedIndexChanged);
      this.channelsCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.channelsCB.FormattingEnabled = true;
      this.channelsCB.Items.AddRange(new object[2]
      {
        (object) "Channel2",
        (object) "Channel1"
      });
      this.channelsCB.Location = new Point(112, 6);
      this.channelsCB.Name = "channelsCB";
      this.channelsCB.Size = new Size(76, 20);
      this.channelsCB.TabIndex = 64;
      this.channelsCB.Visible = false;
      this.myLable49.Location = new Point(11, 9);
      this.myLable49.Name = "myLable49";
      this.myLable49.PropertyLabel = this.propertyL;
      this.myLable49.PropertyName = "SerialChannel";
      this.myLable49.Size = new Size(91, 14);
      this.myLable49.TabIndex = 34;
      this.myLable49.Text = "Serial Channel";
      this.myLable49.Visible = false;
      this.myLable48.Location = new Point(11, 35);
      this.myLable48.Name = "myLable48";
      this.myLable48.PropertyLabel = this.propertyL;
      this.myLable48.PropertyName = "SerialDataSize";
      this.myLable48.Size = new Size(103, 14);
      this.myLable48.TabIndex = 35;
      this.myLable48.Text = "Serial Data Size";
      this.myLable48.Visible = false;
      this.myLable50.Location = new Point(226, 40);
      this.myLable50.Name = "myLable50";
      this.myLable50.PropertyLabel = this.propertyL;
      this.myLable50.PropertyName = "EnableSerialTriggerInput";
      this.myLable50.Size = new Size(172, 14);
      this.myLable50.TabIndex = 62;
      this.myLable50.Text = "Enable Serial Trigger Input";
      this.myLable50.Visible = false;
      this.enableSerialCB.AutoSize = true;
      this.enableSerialCB.Location = new Point(205, 40);
      this.enableSerialCB.Name = "enableSerialCB";
      this.enableSerialCB.Size = new Size(15, 14);
      this.enableSerialCB.TabIndex = 61;
      this.enableSerialCB.UseVisualStyleBackColor = true;
      this.enableSerialCB.Visible = false;
      this.enableSerialCB.CheckedChanged += new EventHandler(this.enableSerialCB_CheckedChanged);
      this.inputMNINUD.Location = new Point(218, 219);
      NumericUpDown numericUpDown12 = this.inputMNINUD;
      int[] bits12 = new int[4];
      bits12[0] = (int) byte.MaxValue;
      Decimal num12 = new Decimal(bits12);
      numericUpDown12.Maximum = num12;
      this.inputMNINUD.Name = "inputMNINUD";
      this.inputMNINUD.Size = new Size(60, 21);
      this.inputMNINUD.TabIndex = 60;
      this.inputMNINUD.Visible = false;
      this.inputPriorityCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.inputPriorityCB.FormattingEnabled = true;
      this.inputPriorityCB.Items.AddRange(new object[3]
      {
        (object) "Low",
        (object) "Normal",
        (object) "High"
      });
      this.inputPriorityCB.Location = new Point(179, 192);
      this.inputPriorityCB.Name = "inputPriorityCB";
      this.inputPriorityCB.Size = new Size(67, 20);
      this.inputPriorityCB.TabIndex = 59;
      this.inputPriorityCB.Visible = false;
      this.myLable45.Location = new Point(44, 222);
      this.myLable45.Name = "myLable45";
      this.myLable45.PropertyLabel = this.propertyL;
      this.myLable45.PropertyName = "MinNotificationInterval";
      this.myLable45.Size = new Size(159, 14);
      this.myLable45.TabIndex = 58;
      this.myLable45.Text = "Min Notification Interval";
      this.myLable45.Visible = false;
      this.myLable46.Location = new Point(44, 196);
      this.myLable46.Name = "myLable46";
      this.myLable46.PropertyLabel = this.propertyL;
      this.myLable46.PropertyName = "Priority";
      this.myLable46.Size = new Size(54, 14);
      this.myLable46.TabIndex = 57;
      this.myLable46.Text = "Priority";
      this.myLable46.Visible = false;
      this.messageTB.Location = new Point(179, 165);
      this.messageTB.Name = "messageTB";
      this.messageTB.Size = new Size(202, 21);
      this.messageTB.TabIndex = 56;
      this.messageTB.Visible = false;
      this.myLable47.Location = new Point(44, 171);
      this.myLable47.Name = "myLable47";
      this.myLable47.PropertyLabel = this.propertyL;
      this.myLable47.PropertyName = "EmailTriggerMessage";
      this.myLable47.Size = new Size(134, 14);
      this.myLable47.TabIndex = 52;
      this.myLable47.Text = "Email Trigger Message";
      this.myLable47.Visible = false;
      this.input2CB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.input2CB.FormattingEnabled = true;
      this.input2CB.Items.AddRange(new object[3]
      {
        (object) "Low",
        (object) "High",
        (object) "None"
      });
      this.input2CB.Location = new Point(118, 82);
      this.input2CB.Name = "input2CB";
      this.input2CB.Size = new Size(76, 20);
      this.input2CB.TabIndex = 46;
      this.input2CB.Visible = false;
      this.input1CB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.input1CB.FormattingEnabled = true;
      this.input1CB.Items.AddRange(new object[3]
      {
        (object) "Low",
        (object) "High",
        (object) "None"
      });
      this.input1CB.Location = new Point(118, 56);
      this.input1CB.Name = "input1CB";
      this.input1CB.Size = new Size(76, 20);
      this.input1CB.TabIndex = 45;
      this.input1CB.Visible = false;
      this.myLable53.Location = new Point(38, 85);
      this.myLable53.Name = "myLable53";
      this.myLable53.PropertyLabel = this.propertyL;
      this.myLable53.PropertyName = "Input2";
      this.myLable53.Size = new Size(66, 14);
      this.myLable53.TabIndex = 30;
      this.myLable53.Text = "I/O Input2";
      this.myLable53.Visible = false;
      this.myLable54.Location = new Point(38, 60);
      this.myLable54.Name = "myLable54";
      this.myLable54.PropertyLabel = this.propertyL;
      this.myLable54.PropertyName = "Input1";
      this.myLable54.Size = new Size(66, 14);
      this.myLable54.TabIndex = 29;
      this.myLable54.Text = "I/O Input1";
      this.myLable54.Visible = false;
      this.histlistPanel.Controls.Add((Control) this.backupLinkCB);
      this.histlistPanel.Controls.Add((Control) this.myLable109);
      this.histlistPanel.Controls.Add((Control) this.tableLayoutPanel1);
      this.histlistPanel.Controls.Add((Control) this.retryTNUD);
      this.histlistPanel.Controls.Add((Control) this.retryCNUD);
      this.histlistPanel.Controls.Add((Control) this.myLable55);
      this.histlistPanel.Controls.Add((Control) this.myLable52);
      this.histlistPanel.Controls.Add((Control) this.channelNameL);
      this.histlistPanel.Location = new Point(0, 0);
      this.histlistPanel.Name = "histlistPanel";
      this.histlistPanel.Size = new Size(408, 273);
      this.histlistPanel.TabIndex = 34;
      this.histlistPanel.Visible = false;
      this.backupLinkCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.backupLinkCB.FormattingEnabled = true;
      this.backupLinkCB.Items.AddRange(new object[2]
      {
        (object) "Disable",
        (object) "Enable"
      });
      this.backupLinkCB.Location = new Point(133, 244);
      this.backupLinkCB.Name = "backupLinkCB";
      this.backupLinkCB.Size = new Size(100, 20);
      this.backupLinkCB.TabIndex = 101;
      this.backupLinkCB.Visible = false;
      this.myLable109.Location = new Point(42, 248);
      this.myLable109.Name = "myLable109";
      this.myLable109.PropertyLabel = this.propertyL;
      this.myLable109.PropertyName = "EnableBackupLink";
      this.myLable109.Size = new Size(73, 14);
      this.myLable109.TabIndex = 100;
      this.myLable109.Text = "Input/Output 1";
      this.myLable109.Visible = false;
      this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
      this.tableLayoutPanel1.ColumnCount = 6;
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.461742f));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.34575f));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.18962f));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.463036f));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.34968f));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.19017f));
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort12TB, 5, 6);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP12TB, 4, 6);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort11TB, 2, 6);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP11TB, 1, 6);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort10TB, 5, 5);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP10TB, 4, 5);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort9TB, 2, 5);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP9TB, 1, 5);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort8TB, 5, 4);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP8TB, 4, 4);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort7TB, 2, 4);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP7TB, 1, 4);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort6TB, 5, 3);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP6TB, 4, 3);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort5TB, 2, 3);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP5TB, 1, 3);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort4TB, 5, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP4TB, 4, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort3TB, 2, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP3TB, 1, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort2TB, 5, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP2TB, 4, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostPort1TB, 2, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.label20, 0, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.label19, 5, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.label18, 4, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.label17, 3, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.label16, 2, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.label15, 1, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.label14, 0, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.label21, 0, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.label22, 0, 3);
      this.tableLayoutPanel1.Controls.Add((Control) this.label23, 0, 4);
      this.tableLayoutPanel1.Controls.Add((Control) this.label24, 0, 5);
      this.tableLayoutPanel1.Controls.Add((Control) this.label25, 0, 6);
      this.tableLayoutPanel1.Controls.Add((Control) this.label26, 3, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.label27, 3, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.label28, 3, 3);
      this.tableLayoutPanel1.Controls.Add((Control) this.label29, 3, 4);
      this.tableLayoutPanel1.Controls.Add((Control) this.label30, 3, 5);
      this.tableLayoutPanel1.Controls.Add((Control) this.label31, 3, 6);
      this.tableLayoutPanel1.Controls.Add((Control) this.hostIP1TB, 1, 1);
      this.tableLayoutPanel1.Location = new Point(3, 72);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 7;
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
      this.tableLayoutPanel1.Size = new Size(402, 167);
      this.tableLayoutPanel1.TabIndex = 64;
      this.tableLayoutPanel1.Visible = false;
      this.hostPort12TB.Dock = DockStyle.Fill;
      this.hostPort12TB.Location = new Point(353, 142);
      this.hostPort12TB.Name = "hostPort12TB";
      this.hostPort12TB.Size = new Size(45, 21);
      this.hostPort12TB.TabIndex = 41;
      this.hostIP12TB.Dock = DockStyle.Fill;
      this.hostIP12TB.Location = new Point(233, 142);
      this.hostIP12TB.Name = "hostIP12TB";
      this.hostIP12TB.Size = new Size(113, 21);
      this.hostIP12TB.TabIndex = 40;
      this.hostPort11TB.Dock = DockStyle.Fill;
      this.hostPort11TB.Location = new Point(154, 142);
      this.hostPort11TB.Name = "hostPort11TB";
      this.hostPort11TB.Size = new Size(42, 21);
      this.hostPort11TB.TabIndex = 39;
      this.hostIP11TB.Dock = DockStyle.Fill;
      this.hostIP11TB.Location = new Point(34, 142);
      this.hostIP11TB.Name = "hostIP11TB";
      this.hostIP11TB.Size = new Size(113, 21);
      this.hostIP11TB.TabIndex = 38;
      this.hostPort10TB.Dock = DockStyle.Fill;
      this.hostPort10TB.Location = new Point(353, 119);
      this.hostPort10TB.Name = "hostPort10TB";
      this.hostPort10TB.Size = new Size(45, 21);
      this.hostPort10TB.TabIndex = 37;
      this.hostIP10TB.Dock = DockStyle.Fill;
      this.hostIP10TB.Location = new Point(233, 119);
      this.hostIP10TB.Name = "hostIP10TB";
      this.hostIP10TB.Size = new Size(113, 21);
      this.hostIP10TB.TabIndex = 36;
      this.hostPort9TB.Dock = DockStyle.Fill;
      this.hostPort9TB.Location = new Point(154, 119);
      this.hostPort9TB.Name = "hostPort9TB";
      this.hostPort9TB.Size = new Size(42, 21);
      this.hostPort9TB.TabIndex = 35;
      this.hostIP9TB.Dock = DockStyle.Fill;
      this.hostIP9TB.Location = new Point(34, 119);
      this.hostIP9TB.Name = "hostIP9TB";
      this.hostIP9TB.Size = new Size(113, 21);
      this.hostIP9TB.TabIndex = 34;
      this.hostPort8TB.Dock = DockStyle.Fill;
      this.hostPort8TB.Location = new Point(353, 96);
      this.hostPort8TB.Name = "hostPort8TB";
      this.hostPort8TB.Size = new Size(45, 21);
      this.hostPort8TB.TabIndex = 33;
      this.hostIP8TB.Dock = DockStyle.Fill;
      this.hostIP8TB.Location = new Point(233, 96);
      this.hostIP8TB.Name = "hostIP8TB";
      this.hostIP8TB.Size = new Size(113, 21);
      this.hostIP8TB.TabIndex = 32;
      this.hostPort7TB.Dock = DockStyle.Fill;
      this.hostPort7TB.Location = new Point(154, 96);
      this.hostPort7TB.Name = "hostPort7TB";
      this.hostPort7TB.Size = new Size(42, 21);
      this.hostPort7TB.TabIndex = 31;
      this.hostIP7TB.Dock = DockStyle.Fill;
      this.hostIP7TB.Location = new Point(34, 96);
      this.hostIP7TB.Name = "hostIP7TB";
      this.hostIP7TB.Size = new Size(113, 21);
      this.hostIP7TB.TabIndex = 30;
      this.hostPort6TB.Dock = DockStyle.Fill;
      this.hostPort6TB.Location = new Point(353, 73);
      this.hostPort6TB.Name = "hostPort6TB";
      this.hostPort6TB.Size = new Size(45, 21);
      this.hostPort6TB.TabIndex = 29;
      this.hostIP6TB.Dock = DockStyle.Fill;
      this.hostIP6TB.Location = new Point(233, 73);
      this.hostIP6TB.Name = "hostIP6TB";
      this.hostIP6TB.Size = new Size(113, 21);
      this.hostIP6TB.TabIndex = 28;
      this.hostPort5TB.Dock = DockStyle.Fill;
      this.hostPort5TB.Location = new Point(154, 73);
      this.hostPort5TB.Name = "hostPort5TB";
      this.hostPort5TB.Size = new Size(42, 21);
      this.hostPort5TB.TabIndex = 27;
      this.hostIP5TB.Dock = DockStyle.Fill;
      this.hostIP5TB.Location = new Point(34, 73);
      this.hostIP5TB.Name = "hostIP5TB";
      this.hostIP5TB.Size = new Size(113, 21);
      this.hostIP5TB.TabIndex = 26;
      this.hostPort4TB.Dock = DockStyle.Fill;
      this.hostPort4TB.Location = new Point(353, 50);
      this.hostPort4TB.Name = "hostPort4TB";
      this.hostPort4TB.Size = new Size(45, 21);
      this.hostPort4TB.TabIndex = 25;
      this.hostIP4TB.Dock = DockStyle.Fill;
      this.hostIP4TB.Location = new Point(233, 50);
      this.hostIP4TB.Name = "hostIP4TB";
      this.hostIP4TB.Size = new Size(113, 21);
      this.hostIP4TB.TabIndex = 24;
      this.hostPort3TB.Dock = DockStyle.Fill;
      this.hostPort3TB.Location = new Point(154, 50);
      this.hostPort3TB.Name = "hostPort3TB";
      this.hostPort3TB.Size = new Size(42, 21);
      this.hostPort3TB.TabIndex = 23;
      this.hostIP3TB.Dock = DockStyle.Fill;
      this.hostIP3TB.Location = new Point(34, 50);
      this.hostIP3TB.Name = "hostIP3TB";
      this.hostIP3TB.Size = new Size(113, 21);
      this.hostIP3TB.TabIndex = 22;
      this.hostPort2TB.Dock = DockStyle.Fill;
      this.hostPort2TB.Location = new Point(353, 27);
      this.hostPort2TB.Name = "hostPort2TB";
      this.hostPort2TB.Size = new Size(45, 21);
      this.hostPort2TB.TabIndex = 21;
      this.hostIP2TB.Dock = DockStyle.Fill;
      this.hostIP2TB.Location = new Point(233, 27);
      this.hostIP2TB.Name = "hostIP2TB";
      this.hostIP2TB.Size = new Size(113, 21);
      this.hostIP2TB.TabIndex = 20;
      this.hostPort1TB.Dock = DockStyle.Fill;
      this.hostPort1TB.Location = new Point(154, 27);
      this.hostPort1TB.Name = "hostPort1TB";
      this.hostPort1TB.Size = new Size(42, 21);
      this.hostPort1TB.TabIndex = 19;
      this.label20.AutoSize = true;
      this.label20.Dock = DockStyle.Fill;
      this.label20.Location = new Point(4, 24);
      this.label20.Name = "label20";
      this.label20.Size = new Size(23, 22);
      this.label20.TabIndex = 6;
      this.label20.Text = "1";
      this.label20.TextAlign = ContentAlignment.MiddleCenter;
      this.label19.AutoSize = true;
      this.label19.Dock = DockStyle.Fill;
      this.label19.Location = new Point(353, 1);
      this.label19.Name = "label19";
      this.label19.Size = new Size(45, 22);
      this.label19.TabIndex = 5;
      this.label19.Text = "Port";
      this.label19.TextAlign = ContentAlignment.MiddleCenter;
      this.label18.AutoSize = true;
      this.label18.Dock = DockStyle.Fill;
      this.label18.Location = new Point(233, 1);
      this.label18.Name = "label18";
      this.label18.Size = new Size(113, 22);
      this.label18.TabIndex = 4;
      this.label18.Text = "HOST Address";
      this.label18.TextAlign = ContentAlignment.MiddleCenter;
      this.label17.AutoSize = true;
      this.label17.Dock = DockStyle.Fill;
      this.label17.Location = new Point(203, 1);
      this.label17.Name = "label17";
      this.label17.Size = new Size(23, 22);
      this.label17.TabIndex = 3;
      this.label17.Text = "No";
      this.label17.TextAlign = ContentAlignment.MiddleCenter;
      this.label16.AutoSize = true;
      this.label16.Dock = DockStyle.Fill;
      this.label16.Location = new Point(154, 1);
      this.label16.Name = "label16";
      this.label16.Size = new Size(42, 22);
      this.label16.TabIndex = 2;
      this.label16.Text = "Port";
      this.label16.TextAlign = ContentAlignment.MiddleCenter;
      this.label15.AutoSize = true;
      this.label15.Dock = DockStyle.Fill;
      this.label15.Location = new Point(34, 1);
      this.label15.Name = "label15";
      this.label15.Size = new Size(113, 22);
      this.label15.TabIndex = 1;
      this.label15.Text = "HOST Address";
      this.label15.TextAlign = ContentAlignment.MiddleCenter;
      this.label14.AutoSize = true;
      this.label14.Dock = DockStyle.Fill;
      this.label14.Location = new Point(4, 1);
      this.label14.Name = "label14";
      this.label14.Size = new Size(23, 22);
      this.label14.TabIndex = 0;
      this.label14.Text = "No";
      this.label14.TextAlign = ContentAlignment.MiddleCenter;
      this.label21.AutoSize = true;
      this.label21.Dock = DockStyle.Fill;
      this.label21.Location = new Point(4, 47);
      this.label21.Name = "label21";
      this.label21.Size = new Size(23, 22);
      this.label21.TabIndex = 7;
      this.label21.Text = "3";
      this.label21.TextAlign = ContentAlignment.MiddleCenter;
      this.label22.AutoSize = true;
      this.label22.Dock = DockStyle.Fill;
      this.label22.Location = new Point(4, 70);
      this.label22.Name = "label22";
      this.label22.Size = new Size(23, 22);
      this.label22.TabIndex = 8;
      this.label22.Text = "5";
      this.label22.TextAlign = ContentAlignment.MiddleCenter;
      this.label23.AutoSize = true;
      this.label23.Dock = DockStyle.Fill;
      this.label23.Location = new Point(4, 93);
      this.label23.Name = "label23";
      this.label23.Size = new Size(23, 22);
      this.label23.TabIndex = 9;
      this.label23.Text = "7";
      this.label23.TextAlign = ContentAlignment.MiddleCenter;
      this.label24.AutoSize = true;
      this.label24.Dock = DockStyle.Fill;
      this.label24.Location = new Point(4, 116);
      this.label24.Name = "label24";
      this.label24.Size = new Size(23, 22);
      this.label24.TabIndex = 10;
      this.label24.Text = "9";
      this.label24.TextAlign = ContentAlignment.MiddleCenter;
      this.label25.AutoSize = true;
      this.label25.Dock = DockStyle.Fill;
      this.label25.Location = new Point(4, 139);
      this.label25.Name = "label25";
      this.label25.Size = new Size(23, 27);
      this.label25.TabIndex = 11;
      this.label25.Text = "11";
      this.label25.TextAlign = ContentAlignment.MiddleCenter;
      this.label26.AutoSize = true;
      this.label26.Dock = DockStyle.Fill;
      this.label26.Location = new Point(203, 24);
      this.label26.Name = "label26";
      this.label26.Size = new Size(23, 22);
      this.label26.TabIndex = 12;
      this.label26.Text = "2";
      this.label26.TextAlign = ContentAlignment.MiddleCenter;
      this.label27.AutoSize = true;
      this.label27.Dock = DockStyle.Fill;
      this.label27.Location = new Point(203, 47);
      this.label27.Name = "label27";
      this.label27.Size = new Size(23, 22);
      this.label27.TabIndex = 13;
      this.label27.Text = "4";
      this.label27.TextAlign = ContentAlignment.MiddleCenter;
      this.label28.AutoSize = true;
      this.label28.Dock = DockStyle.Fill;
      this.label28.Location = new Point(203, 70);
      this.label28.Name = "label28";
      this.label28.Size = new Size(23, 22);
      this.label28.TabIndex = 14;
      this.label28.Text = "6";
      this.label28.TextAlign = ContentAlignment.MiddleCenter;
      this.label29.AutoSize = true;
      this.label29.Dock = DockStyle.Fill;
      this.label29.Location = new Point(203, 93);
      this.label29.Name = "label29";
      this.label29.Size = new Size(23, 22);
      this.label29.TabIndex = 15;
      this.label29.Text = "8";
      this.label29.TextAlign = ContentAlignment.MiddleCenter;
      this.label30.AutoSize = true;
      this.label30.Dock = DockStyle.Fill;
      this.label30.Location = new Point(203, 116);
      this.label30.Name = "label30";
      this.label30.Size = new Size(23, 22);
      this.label30.TabIndex = 16;
      this.label30.Text = "10";
      this.label30.TextAlign = ContentAlignment.MiddleCenter;
      this.label31.AutoSize = true;
      this.label31.Dock = DockStyle.Fill;
      this.label31.Location = new Point(203, 139);
      this.label31.Name = "label31";
      this.label31.Size = new Size(23, 27);
      this.label31.TabIndex = 17;
      this.label31.Text = "12";
      this.label31.TextAlign = ContentAlignment.MiddleCenter;
      this.hostIP1TB.Dock = DockStyle.Fill;
      this.hostIP1TB.Location = new Point(34, 27);
      this.hostIP1TB.Name = "hostIP1TB";
      this.hostIP1TB.Size = new Size(113, 21);
      this.hostIP1TB.TabIndex = 18;
      this.retryTNUD.Location = new Point(310, 49);
      NumericUpDown numericUpDown13 = this.retryTNUD;
      int[] bits13 = new int[4];
      bits13[0] = (int) byte.MaxValue;
      Decimal num13 = new Decimal(bits13);
      numericUpDown13.Maximum = num13;
      this.retryTNUD.Name = "retryTNUD";
      this.retryTNUD.Size = new Size(60, 21);
      this.retryTNUD.TabIndex = 62;
      this.retryTNUD.Visible = false;
      this.retryCNUD.Location = new Point(133, 48);
      NumericUpDown numericUpDown14 = this.retryCNUD;
      int[] bits14 = new int[4];
      bits14[0] = (int) byte.MaxValue;
      Decimal num14 = new Decimal(bits14);
      numericUpDown14.Maximum = num14;
      this.retryCNUD.Name = "retryCNUD";
      this.retryCNUD.Size = new Size(60, 21);
      this.retryCNUD.TabIndex = 61;
      this.retryCNUD.Visible = false;
      this.myLable55.Location = new Point(221, 54);
      this.myLable55.Name = "myLable55";
      this.myLable55.PropertyLabel = this.propertyL;
      this.myLable55.PropertyName = "RetryTimeout";
      this.myLable55.Size = new Size(85, 14);
      this.myLable55.TabIndex = 31;
      this.myLable55.Text = "Retry Timeout";
      this.myLable55.Visible = false;
      this.myLable52.Location = new Point(42, 53);
      this.myLable52.Name = "myLable52";
      this.myLable52.PropertyLabel = this.propertyL;
      this.myLable52.PropertyName = "RetryCounter";
      this.myLable52.Size = new Size(85, 14);
      this.myLable52.TabIndex = 30;
      this.myLable52.Text = "Retry Counter";
      this.myLable52.Visible = false;
      this.channelNameL.AutoSize = true;
      this.channelNameL.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.channelNameL.Location = new Point(23, 19);
      this.channelNameL.Name = "channelNameL";
      this.channelNameL.Size = new Size(0, 12);
      this.channelNameL.TabIndex = 2;
      this.passwordPanel.Controls.Add((Control) this.groupBox1);
      this.passwordPanel.Location = new Point(0, 0);
      this.passwordPanel.Name = "passwordPanel";
      this.passwordPanel.Size = new Size(408, 273);
      this.passwordPanel.TabIndex = 37;
      this.passwordPanel.Visible = false;
      this.groupBox1.Controls.Add((Control) this.oldPwdTB);
      this.groupBox1.Controls.Add((Control) this.retypePwdTB);
      this.groupBox1.Controls.Add((Control) this.newPwdTB);
      this.groupBox1.Controls.Add((Control) this.userNameTB);
      this.groupBox1.Controls.Add((Control) this.label46);
      this.groupBox1.Controls.Add((Control) this.label45);
      this.groupBox1.Controls.Add((Control) this.label44);
      this.groupBox1.Controls.Add((Control) this.label43);
      this.groupBox1.Location = new Point(51, 38);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(315, 198);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "ChangePassword";
      this.oldPwdTB.Location = new Point(143, 72);
      this.oldPwdTB.Name = "oldPwdTB";
      this.oldPwdTB.PasswordChar = '*';
      this.oldPwdTB.Size = new Size(137, 21);
      this.oldPwdTB.TabIndex = 100;
      this.retypePwdTB.Location = new Point(143, 137);
      this.retypePwdTB.Name = "retypePwdTB";
      this.retypePwdTB.PasswordChar = '*';
      this.retypePwdTB.Size = new Size(137, 21);
      this.retypePwdTB.TabIndex = 102;
      this.newPwdTB.Location = new Point(143, 105);
      this.newPwdTB.Name = "newPwdTB";
      this.newPwdTB.PasswordChar = '*';
      this.newPwdTB.Size = new Size(137, 21);
      this.newPwdTB.TabIndex = 101;
      this.userNameTB.Enabled = false;
      this.userNameTB.Location = new Point(143, 37);
      this.userNameTB.Name = "userNameTB";
      this.userNameTB.Size = new Size(137, 21);
      this.userNameTB.TabIndex = 99;
      this.label46.AutoSize = true;
      this.label46.Location = new Point(42, 75);
      this.label46.Name = "label46";
      this.label46.Size = new Size(77, 12);
      this.label46.TabIndex = 3;
      this.label46.Text = "Old Password";
      this.label45.AutoSize = true;
      this.label45.Location = new Point(41, 140);
      this.label45.Name = "label45";
      this.label45.Size = new Size(95, 12);
      this.label45.TabIndex = 2;
      this.label45.Text = "Retype Password";
      this.label44.AutoSize = true;
      this.label44.Location = new Point(42, 111);
      this.label44.Name = "label44";
      this.label44.Size = new Size(77, 12);
      this.label44.TabIndex = 1;
      this.label44.Text = "New Password";
      this.label43.AutoSize = true;
      this.label43.Location = new Point(42, 38);
      this.label43.Name = "label43";
      this.label43.Size = new Size(53, 12);
      this.label43.TabIndex = 0;
      this.label43.Text = "UserName";
      this.pinsPanel.Controls.Add((Control) this.groupBox3);
      this.pinsPanel.Controls.Add((Control) this.groupBox2);
      this.pinsPanel.Location = new Point(0, 0);
      this.pinsPanel.Name = "pinsPanel";
      this.pinsPanel.Size = new Size(408, 273);
      this.pinsPanel.TabIndex = 38;
      this.pinsPanel.Visible = false;
      this.groupBox3.Controls.Add((Control) this.myLable97);
      this.groupBox3.Controls.Add((Control) this.io2CB);
      this.groupBox3.Controls.Add((Control) this.io2EleCB);
      this.groupBox3.Controls.Add((Control) this.io2TypeCB);
      this.groupBox3.Location = new Point(212, 33);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(186, 201);
      this.groupBox3.TabIndex = 102;
      this.groupBox3.TabStop = false;
      this.myLable97.Location = new Point(13, 41);
      this.myLable97.Name = "myLable97";
      this.myLable97.PropertyLabel = this.propertyL;
      this.myLable97.PropertyName = "IO2";
      this.myLable97.Size = new Size(91, 14);
      this.myLable97.TabIndex = 95;
      this.myLable97.Text = "Input/Output 2";
      this.io2CB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.io2CB.FormattingEnabled = true;
      this.io2CB.Location = new Point(20, 63);
      this.io2CB.Name = "io2CB";
      this.io2CB.Size = new Size(154, 20);
      this.io2CB.TabIndex = 96;
      this.io2CB.SelectedIndexChanged += new EventHandler(this.io1CB_SelectedIndexChanged);
      this.io2EleCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.io2EleCB.FormattingEnabled = true;
      this.io2EleCB.Items.AddRange(new object[2]
      {
        (object) "Low",
        (object) "High"
      });
      this.io2EleCB.Location = new Point(20, 140);
      this.io2EleCB.Name = "io2EleCB";
      this.io2EleCB.Size = new Size(78, 20);
      this.io2EleCB.TabIndex = 100;
      this.io2TypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.io2TypeCB.FormattingEnabled = true;
      this.io2TypeCB.Items.AddRange(new object[2]
      {
        (object) "Input",
        (object) "Output"
      });
      this.io2TypeCB.Location = new Point(20, 100);
      this.io2TypeCB.Name = "io2TypeCB";
      this.io2TypeCB.Size = new Size(78, 20);
      this.io2TypeCB.TabIndex = 98;
      this.io2TypeCB.SelectedIndexChanged += new EventHandler(this.io1TypeCB_SelectedIndexChanged);
      this.groupBox2.Controls.Add((Control) this.myLable96);
      this.groupBox2.Controls.Add((Control) this.io1CB);
      this.groupBox2.Controls.Add((Control) this.io1EleCB);
      this.groupBox2.Controls.Add((Control) this.io1TypeCB);
      this.groupBox2.Location = new Point(17, 33);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(186, 201);
      this.groupBox2.TabIndex = 101;
      this.groupBox2.TabStop = false;
      this.myLable96.Location = new Point(13, 41);
      this.myLable96.Name = "myLable96";
      this.myLable96.PropertyLabel = this.propertyL;
      this.myLable96.PropertyName = "IO1";
      this.myLable96.Size = new Size(91, 14);
      this.myLable96.TabIndex = 83;
      this.myLable96.Text = "Input/Output 1";
      this.io1CB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.io1CB.FormattingEnabled = true;
      this.io1CB.Location = new Point(20, 63);
      this.io1CB.Name = "io1CB";
      this.io1CB.Size = new Size(154, 20);
      this.io1CB.TabIndex = 94;
      this.io1CB.SelectedIndexChanged += new EventHandler(this.io1CB_SelectedIndexChanged);
      this.io1EleCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.io1EleCB.FormattingEnabled = true;
      this.io1EleCB.Items.AddRange(new object[2]
      {
        (object) "Low",
        (object) "High"
      });
      this.io1EleCB.Location = new Point(20, 140);
      this.io1EleCB.Name = "io1EleCB";
      this.io1EleCB.Size = new Size(78, 20);
      this.io1EleCB.TabIndex = 99;
      this.io1TypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.io1TypeCB.FormattingEnabled = true;
      this.io1TypeCB.Items.AddRange(new object[2]
      {
        (object) "Input",
        (object) "Output"
      });
      this.io1TypeCB.Location = new Point(20, 100);
      this.io1TypeCB.Name = "io1TypeCB";
      this.io1TypeCB.Size = new Size(78, 20);
      this.io1TypeCB.TabIndex = 97;
      this.io1TypeCB.SelectedIndexChanged += new EventHandler(this.io1TypeCB_SelectedIndexChanged);
      this.pppoePanel.Controls.Add((Control) this.pppoeDNS2TB);
      this.pppoePanel.Controls.Add((Control) this.pppoeDNS1TB);
      this.pppoePanel.Controls.Add((Control) this.pppoeGatewayTB);
      this.pppoePanel.Controls.Add((Control) this.pppoeIPTB);
      this.pppoePanel.Controls.Add((Control) this.pppoeStatusTB);
      this.pppoePanel.Controls.Add((Control) this.ppoeIDLENUD);
      this.pppoePanel.Controls.Add((Control) this.pppoeRINUD);
      this.pppoePanel.Controls.Add((Control) this.pppoeMaxRTNUD);
      this.pppoePanel.Controls.Add((Control) this.pppoeWorkModeCB);
      this.pppoePanel.Controls.Add((Control) this.pppoePwdTB);
      this.pppoePanel.Controls.Add((Control) this.pppoeUserNameTB);
      this.pppoePanel.Controls.Add((Control) this.myLable108);
      this.pppoePanel.Controls.Add((Control) this.myLable107);
      this.pppoePanel.Controls.Add((Control) this.myLable106);
      this.pppoePanel.Controls.Add((Control) this.myLable105);
      this.pppoePanel.Controls.Add((Control) this.myLable104);
      this.pppoePanel.Controls.Add((Control) this.myLable103);
      this.pppoePanel.Controls.Add((Control) this.myLable102);
      this.pppoePanel.Controls.Add((Control) this.myLable101);
      this.pppoePanel.Controls.Add((Control) this.myLable100);
      this.pppoePanel.Controls.Add((Control) this.myLable99);
      this.pppoePanel.Controls.Add((Control) this.myLable98);
      this.pppoePanel.Location = new Point(0, 0);
      this.pppoePanel.Name = "pppoePanel";
      this.pppoePanel.Size = new Size(408, 273);
      this.pppoePanel.TabIndex = 39;
      this.pppoePanel.Visible = false;
      this.pppoeDNS2TB.Enabled = false;
      this.pppoeDNS2TB.Location = new Point(292, 153);
      this.pppoeDNS2TB.Name = "pppoeDNS2TB";
      this.pppoeDNS2TB.Size = new Size(100, 21);
      this.pppoeDNS2TB.TabIndex = 113;
      this.pppoeDNS2TB.Visible = false;
      this.pppoeDNS1TB.Enabled = false;
      this.pppoeDNS1TB.Location = new Point(292, 126);
      this.pppoeDNS1TB.Name = "pppoeDNS1TB";
      this.pppoeDNS1TB.Size = new Size(100, 21);
      this.pppoeDNS1TB.TabIndex = 112;
      this.pppoeDNS1TB.Visible = false;
      this.pppoeGatewayTB.Enabled = false;
      this.pppoeGatewayTB.Location = new Point(292, 99);
      this.pppoeGatewayTB.Name = "pppoeGatewayTB";
      this.pppoeGatewayTB.Size = new Size(100, 21);
      this.pppoeGatewayTB.TabIndex = 111;
      this.pppoeGatewayTB.Visible = false;
      this.pppoeIPTB.Enabled = false;
      this.pppoeIPTB.Location = new Point(292, 72);
      this.pppoeIPTB.Name = "pppoeIPTB";
      this.pppoeIPTB.Size = new Size(100, 21);
      this.pppoeIPTB.TabIndex = 110;
      this.pppoeIPTB.Visible = false;
      this.pppoeStatusTB.Enabled = false;
      this.pppoeStatusTB.Location = new Point(292, 45);
      this.pppoeStatusTB.Name = "pppoeStatusTB";
      this.pppoeStatusTB.Size = new Size(100, 21);
      this.pppoeStatusTB.TabIndex = 109;
      this.pppoeStatusTB.Visible = false;
      this.ppoeIDLENUD.Location = new Point(141, 179);
      NumericUpDown numericUpDown15 = this.ppoeIDLENUD;
      int[] bits15 = new int[4];
      bits15[0] = (int) ushort.MaxValue;
      Decimal num15 = new Decimal(bits15);
      numericUpDown15.Maximum = num15;
      this.ppoeIDLENUD.Name = "ppoeIDLENUD";
      this.ppoeIDLENUD.Size = new Size(60, 21);
      this.ppoeIDLENUD.TabIndex = 108;
      NumericUpDown numericUpDown16 = this.ppoeIDLENUD;
      int[] bits16 = new int[4];
      bits16[0] = 1;
      Decimal num16 = new Decimal(bits16);
      numericUpDown16.Value = num16;
      this.ppoeIDLENUD.Visible = false;
      this.pppoeRINUD.Location = new Point(141, 152);
      NumericUpDown numericUpDown17 = this.pppoeRINUD;
      int[] bits17 = new int[4];
      bits17[0] = (int) byte.MaxValue;
      Decimal num17 = new Decimal(bits17);
      numericUpDown17.Maximum = num17;
      this.pppoeRINUD.Name = "pppoeRINUD";
      this.pppoeRINUD.Size = new Size(60, 21);
      this.pppoeRINUD.TabIndex = 107;
      NumericUpDown numericUpDown18 = this.pppoeRINUD;
      int[] bits18 = new int[4];
      bits18[0] = 1;
      Decimal num18 = new Decimal(bits18);
      numericUpDown18.Value = num18;
      this.pppoeRINUD.Visible = false;
      this.pppoeMaxRTNUD.Location = new Point(141, 125);
      NumericUpDown numericUpDown19 = this.pppoeMaxRTNUD;
      int[] bits19 = new int[4];
      bits19[0] = (int) byte.MaxValue;
      Decimal num19 = new Decimal(bits19);
      numericUpDown19.Maximum = num19;
      this.pppoeMaxRTNUD.Name = "pppoeMaxRTNUD";
      this.pppoeMaxRTNUD.Size = new Size(60, 21);
      this.pppoeMaxRTNUD.TabIndex = 106;
      NumericUpDown numericUpDown20 = this.pppoeMaxRTNUD;
      int[] bits20 = new int[4];
      bits20[0] = 1;
      Decimal num20 = new Decimal(bits20);
      numericUpDown20.Value = num20;
      this.pppoeMaxRTNUD.Visible = false;
      this.pppoeWorkModeCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.pppoeWorkModeCB.FormattingEnabled = true;
      this.pppoeWorkModeCB.Items.AddRange(new object[4]
      {
        (object) "Disable",
        (object) "Dial_on_Demand",
        (object) "Auto_Dial",
        (object) "Adaptive"
      });
      this.pppoeWorkModeCB.Location = new Point(101, 99);
      this.pppoeWorkModeCB.Name = "pppoeWorkModeCB";
      this.pppoeWorkModeCB.Size = new Size(100, 20);
      this.pppoeWorkModeCB.TabIndex = 99;
      this.pppoeWorkModeCB.Visible = false;
      this.pppoePwdTB.Location = new Point(101, 72);
      this.pppoePwdTB.Name = "pppoePwdTB";
      this.pppoePwdTB.PasswordChar = '*';
      this.pppoePwdTB.Size = new Size(100, 21);
      this.pppoePwdTB.TabIndex = 96;
      this.pppoePwdTB.Visible = false;
      this.pppoeUserNameTB.Location = new Point(101, 45);
      this.pppoeUserNameTB.Name = "pppoeUserNameTB";
      this.pppoeUserNameTB.Size = new Size(100, 21);
      this.pppoeUserNameTB.TabIndex = 95;
      this.pppoeUserNameTB.Visible = false;
      this.myLable108.Location = new Point(207, 157);
      this.myLable108.Name = "myLable108";
      this.myLable108.PropertyLabel = this.propertyL;
      this.myLable108.PropertyName = "PPPOEDNS2";
      this.myLable108.Size = new Size(66, 14);
      this.myLable108.TabIndex = 94;
      this.myLable108.Text = "Input/Output 1";
      this.myLable108.Visible = false;
      this.myLable107.Location = new Point(207, 129);
      this.myLable107.Name = "myLable107";
      this.myLable107.PropertyLabel = this.propertyL;
      this.myLable107.PropertyName = "PPPOEDNS1";
      this.myLable107.Size = new Size(66, 14);
      this.myLable107.TabIndex = 93;
      this.myLable107.Text = "Input/Output 1";
      this.myLable107.Visible = false;
      this.myLable106.Location = new Point(207, 104);
      this.myLable106.Name = "myLable106";
      this.myLable106.PropertyLabel = this.propertyL;
      this.myLable106.PropertyName = "PPPOEGateway";
      this.myLable106.Size = new Size(85, 14);
      this.myLable106.TabIndex = 92;
      this.myLable106.Text = "Input/Output 1";
      this.myLable106.Visible = false;
      this.myLable105.Location = new Point(207, 76);
      this.myLable105.Name = "myLable105";
      this.myLable105.PropertyLabel = this.propertyL;
      this.myLable105.PropertyName = "PPPOEIP";
      this.myLable105.Size = new Size(54, 14);
      this.myLable105.TabIndex = 91;
      this.myLable105.Text = "Input/Output 1";
      this.myLable105.Visible = false;
      this.myLable104.Location = new Point(207, 49);
      this.myLable104.Name = "myLable104";
      this.myLable104.PropertyLabel = this.propertyL;
      this.myLable104.PropertyName = "PPPOEStatus";
      this.myLable104.Size = new Size(79, 14);
      this.myLable104.TabIndex = 90;
      this.myLable104.Text = "Input/Output 1";
      this.myLable104.Visible = false;
      this.myLable103.Location = new Point(22, 183);
      this.myLable103.Name = "myLable103";
      this.myLable103.PropertyLabel = this.propertyL;
      this.myLable103.PropertyName = "PPPOEIDLETime";
      this.myLable103.Size = new Size(60, 14);
      this.myLable103.TabIndex = 89;
      this.myLable103.Text = "Input/Output 1";
      this.myLable103.Visible = false;
      this.myLable102.Location = new Point(22, 156);
      this.myLable102.Name = "myLable102";
      this.myLable102.PropertyLabel = this.propertyL;
      this.myLable102.PropertyName = "PPPOERedialInterval";
      this.myLable102.Size = new Size(97, 14);
      this.myLable102.TabIndex = 88;
      this.myLable102.Text = "Input/Output 1";
      this.myLable102.Visible = false;
      this.myLable101.Location = new Point(22, 129);
      this.myLable101.Name = "myLable101";
      this.myLable101.PropertyLabel = this.propertyL;
      this.myLable101.PropertyName = "PPPOEMaxRedialTimes";
      this.myLable101.Size = new Size(103, 14);
      this.myLable101.TabIndex = 87;
      this.myLable101.Text = "Input/Output 1";
      this.myLable101.Visible = false;
      this.myLable100.Location = new Point(22, 102);
      this.myLable100.Name = "myLable100";
      this.myLable100.PropertyLabel = this.propertyL;
      this.myLable100.PropertyName = "PPPOEWorkMode";
      this.myLable100.Size = new Size(60, 14);
      this.myLable100.TabIndex = 86;
      this.myLable100.Text = "Input/Output 1";
      this.myLable100.Visible = false;
      this.myLable99.Location = new Point(22, 75);
      this.myLable99.Name = "myLable99";
      this.myLable99.PropertyLabel = this.propertyL;
      this.myLable99.PropertyName = "PPPOEPassword";
      this.myLable99.Size = new Size(54, 14);
      this.myLable99.TabIndex = 85;
      this.myLable99.Text = "Input/Output 1";
      this.myLable99.Visible = false;
      this.myLable98.Location = new Point(22, 48);
      this.myLable98.Name = "myLable98";
      this.myLable98.PropertyLabel = this.propertyL;
      this.myLable98.PropertyName = "PPPOEUserName";
      this.myLable98.Size = new Size(60, 14);
      this.myLable98.TabIndex = 84;
      this.myLable98.Text = "Input/Output 1";
      this.myLable98.Visible = false;
      this.connectionPanel.Controls.Add((Control) this.panel8);
      this.connectionPanel.Controls.Add((Control) this.udpUCLPNUD);
      this.connectionPanel.Controls.Add((Control) this.tableLayoutPanel2);
      this.connectionPanel.Controls.Add((Control) this.panel7);
      this.connectionPanel.Controls.Add((Control) this.udpAcceptCB);
      this.connectionPanel.Controls.Add((Control) this.datagramCB);
      this.connectionPanel.Controls.Add((Control) this.myLable83);
      this.connectionPanel.Controls.Add((Control) this.myLable82);
      this.connectionPanel.Controls.Add((Control) this.myLable78);
      this.connectionPanel.Controls.Add((Control) this.myLable77);
      this.connectionPanel.Controls.Add((Control) this.netProtocolCB);
      this.connectionPanel.Controls.Add((Control) this.myLable76);
      this.connectionPanel.Controls.Add((Control) this.channelNameL2);
      this.connectionPanel.Location = new Point(0, 0);
      this.connectionPanel.Name = "connectionPanel";
      this.connectionPanel.Size = new Size(408, 273);
      this.connectionPanel.TabIndex = 40;
      this.connectionPanel.Visible = false;
      this.panel8.Controls.Add((Control) this.inactivityNUD);
      this.panel8.Controls.Add((Control) this.groupBox5);
      this.panel8.Controls.Add((Control) this.workasCB);
      this.panel8.Controls.Add((Control) this.groupBox4);
      this.panel8.Controls.Add((Control) this.dnsQueryPeriodNUD);
      this.panel8.Controls.Add((Control) this.myLable56);
      this.panel8.Controls.Add((Control) this.hardDisconnectCB);
      this.panel8.Controls.Add((Control) this.checkEOTCB);
      this.panel8.Controls.Add((Control) this.onDSRDropCB);
      this.panel8.Controls.Add((Control) this.connectResponseCB);
      this.panel8.Controls.Add((Control) this.tcpRomteHostTB);
      this.panel8.Controls.Add((Control) this.useHostlistCB);
      this.panel8.Controls.Add((Control) this.tcpRemotePortNUD);
      this.panel8.Controls.Add((Control) this.tcpLocalPortNUD);
      this.panel8.Controls.Add((Control) this.startCharTB);
      this.panel8.Controls.Add((Control) this.label42);
      this.panel8.Controls.Add((Control) this.tcpActiveCB);
      this.panel8.Controls.Add((Control) this.myLable95);
      this.panel8.Controls.Add((Control) this.myLable94);
      this.panel8.Controls.Add((Control) this.myLable93);
      this.panel8.Controls.Add((Control) this.myLable92);
      this.panel8.Controls.Add((Control) this.myLable91);
      this.panel8.Controls.Add((Control) this.myLable90);
      this.panel8.Controls.Add((Control) this.myLable89);
      this.panel8.Controls.Add((Control) this.myLable88);
      this.panel8.Controls.Add((Control) this.myLable87);
      this.panel8.Controls.Add((Control) this.myLable86);
      this.panel8.Controls.Add((Control) this.myLable85);
      this.panel8.Controls.Add((Control) this.myLable84);
      this.panel8.Location = new Point(3, 32);
      this.panel8.Name = "panel8";
      this.panel8.Size = new Size(402, 240);
      this.panel8.TabIndex = 83;
      this.inactivityNUD.Location = new Point(128, 217);
      NumericUpDown numericUpDown21 = this.inactivityNUD;
      int[] bits21 = new int[4];
      bits21[0] = (int) byte.MaxValue;
      Decimal num21 = new Decimal(bits21);
      numericUpDown21.Maximum = num21;
      this.inactivityNUD.Name = "inactivityNUD";
      this.inactivityNUD.Size = new Size(43, 21);
      this.inactivityNUD.TabIndex = 107;
      this.inactivityNUD.Visible = false;
      this.groupBox5.Controls.Add((Control) this.myLable70);
      this.groupBox5.Controls.Add((Control) this.myLable74);
      this.groupBox5.Controls.Add((Control) this.oatdCB);
      this.groupBox5.Controls.Add((Control) this.myLable75);
      this.groupBox5.Controls.Add((Control) this.owacCB);
      this.groupBox5.Controls.Add((Control) this.owpcCB);
      this.groupBox5.Location = new Point(183, 165);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(217, 70);
      this.groupBox5.TabIndex = 85;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Flush Output Buffer";
      this.myLable70.Location = new Point(1, 12);
      this.myLable70.Name = "myLable70";
      this.myLable70.PropertyLabel = this.propertyL;
      this.myLable70.PropertyName = "OutputWithActiveConnect";
      this.myLable70.Size = new Size(122, 14);
      this.myLable70.TabIndex = 74;
      this.myLable70.Text = "Output With Active Connect";
      this.myLable70.Visible = false;
      this.myLable74.Location = new Point(1, 32);
      this.myLable74.Name = "myLable74";
      this.myLable74.PropertyLabel = this.propertyL;
      this.myLable74.PropertyName = "OutputWithPassiveConnect";
      this.myLable74.Size = new Size(128, 14);
      this.myLable74.TabIndex = 75;
      this.myLable74.Text = "Output With Passive Connect";
      this.myLable74.Visible = false;
      this.oatdCB.AutoSize = true;
      this.oatdCB.Location = new Point(174, 52);
      this.oatdCB.Name = "oatdCB";
      this.oatdCB.Size = new Size(42, 16);
      this.oatdCB.TabIndex = 82;
      this.oatdCB.Text = "Yes";
      this.oatdCB.UseVisualStyleBackColor = true;
      this.oatdCB.Visible = false;
      this.myLable75.Location = new Point(1, 53);
      this.myLable75.Name = "myLable75";
      this.myLable75.PropertyLabel = this.propertyL;
      this.myLable75.PropertyName = "OutputAtTimeofDisconnect";
      this.myLable75.Size = new Size(128, 14);
      this.myLable75.TabIndex = 76;
      this.myLable75.Text = "Output At Timeof Disconnect";
      this.myLable75.Visible = false;
      this.owacCB.AutoSize = true;
      this.owacCB.Location = new Point(174, 10);
      this.owacCB.Name = "owacCB";
      this.owacCB.Size = new Size(42, 16);
      this.owacCB.TabIndex = 80;
      this.owacCB.Text = "Yes";
      this.owacCB.UseVisualStyleBackColor = true;
      this.owacCB.Visible = false;
      this.owpcCB.AutoSize = true;
      this.owpcCB.Location = new Point(174, 31);
      this.owpcCB.Name = "owpcCB";
      this.owpcCB.Size = new Size(42, 16);
      this.owpcCB.TabIndex = 81;
      this.owpcCB.Text = "Yes";
      this.owpcCB.UseVisualStyleBackColor = true;
      this.owpcCB.Visible = false;
      this.workasCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.workasCB.FormattingEnabled = true;
      this.workasCB.Items.AddRange(new object[3]
      {
        (object) "Client",
        (object) "Server",
        (object) "Both"
      });
      this.workasCB.Location = new Point(79, 9);
      this.workasCB.Name = "workasCB";
      this.workasCB.Size = new Size(92, 20);
      this.workasCB.TabIndex = 106;
      this.workasCB.Visible = false;
      this.groupBox4.Controls.Add((Control) this.myLable72);
      this.groupBox4.Controls.Add((Control) this.myLable73);
      this.groupBox4.Controls.Add((Control) this.myLable69);
      this.groupBox4.Controls.Add((Control) this.iwacCB);
      this.groupBox4.Controls.Add((Control) this.iwpcCB);
      this.groupBox4.Controls.Add((Control) this.iatdCB);
      this.groupBox4.Location = new Point(181, 88);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(217, 70);
      this.groupBox4.TabIndex = 84;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Flush Input Buffer";
      this.myLable72.Location = new Point(2, 14);
      this.myLable72.Name = "myLable72";
      this.myLable72.PropertyLabel = this.propertyL;
      this.myLable72.PropertyName = "InputWithActiveConnect";
      this.myLable72.Size = new Size(122, 14);
      this.myLable72.TabIndex = 70;
      this.myLable72.Text = "Input With Active Connect";
      this.myLable72.Visible = false;
      this.myLable73.Location = new Point(2, 34);
      this.myLable73.Name = "myLable73";
      this.myLable73.PropertyLabel = this.propertyL;
      this.myLable73.PropertyName = "InputWithPassiveConnect";
      this.myLable73.Size = new Size(128, 14);
      this.myLable73.TabIndex = 71;
      this.myLable73.Text = "Input With Passive Connect";
      this.myLable73.Visible = false;
      this.myLable69.Location = new Point(2, 53);
      this.myLable69.Name = "myLable69";
      this.myLable69.PropertyLabel = this.propertyL;
      this.myLable69.PropertyName = "InputAtTimeofDisconnect";
      this.myLable69.Size = new Size(128, 14);
      this.myLable69.TabIndex = 73;
      this.myLable69.Text = "Input At Timeof Disconnect";
      this.myLable69.Visible = false;
      this.iwacCB.AutoSize = true;
      this.iwacCB.Location = new Point(174, 13);
      this.iwacCB.Name = "iwacCB";
      this.iwacCB.Size = new Size(42, 16);
      this.iwacCB.TabIndex = 77;
      this.iwacCB.Text = "Yes";
      this.iwacCB.UseVisualStyleBackColor = true;
      this.iwacCB.Visible = false;
      this.iwpcCB.AutoSize = true;
      this.iwpcCB.Location = new Point(174, 32);
      this.iwpcCB.Name = "iwpcCB";
      this.iwpcCB.Size = new Size(42, 16);
      this.iwpcCB.TabIndex = 78;
      this.iwpcCB.Text = "Yes";
      this.iwpcCB.UseVisualStyleBackColor = true;
      this.iwpcCB.Visible = false;
      this.iatdCB.AutoSize = true;
      this.iatdCB.Location = new Point(174, 52);
      this.iatdCB.Name = "iatdCB";
      this.iatdCB.Size = new Size(42, 16);
      this.iatdCB.TabIndex = 79;
      this.iatdCB.Text = "Yes";
      this.iatdCB.UseVisualStyleBackColor = true;
      this.iatdCB.Visible = false;
      this.dnsQueryPeriodNUD.Location = new Point(292, 56);
      NumericUpDown numericUpDown22 = this.dnsQueryPeriodNUD;
      int[] bits22 = new int[4];
      bits22[0] = (int) ushort.MaxValue;
      Decimal num22 = new Decimal(bits22);
      numericUpDown22.Maximum = num22;
      this.dnsQueryPeriodNUD.Name = "dnsQueryPeriodNUD";
      this.dnsQueryPeriodNUD.Size = new Size(60, 21);
      this.dnsQueryPeriodNUD.TabIndex = 105;
      NumericUpDown numericUpDown23 = this.dnsQueryPeriodNUD;
      int[] bits23 = new int[4];
      bits23[0] = 1;
      Decimal num23 = new Decimal(bits23);
      numericUpDown23.Value = num23;
      this.dnsQueryPeriodNUD.Visible = false;
      this.myLable56.Location = new Point(185, 59);
      this.myLable56.Name = "myLable56";
      this.myLable56.PropertyLabel = this.propertyL;
      this.myLable56.PropertyName = "DNSQueryPeriod";
      this.myLable56.Size = new Size(103, 14);
      this.myLable56.TabIndex = 104;
      this.myLable56.Text = "Remote Host";
      this.myLable56.Visible = false;
      this.hardDisconnectCB.AutoSize = true;
      this.hardDisconnectCB.Location = new Point(129, 199);
      this.hardDisconnectCB.Name = "hardDisconnectCB";
      this.hardDisconnectCB.Size = new Size(42, 16);
      this.hardDisconnectCB.TabIndex = 102;
      this.hardDisconnectCB.Text = "Yes";
      this.hardDisconnectCB.UseVisualStyleBackColor = true;
      this.hardDisconnectCB.Visible = false;
      this.checkEOTCB.AutoSize = true;
      this.checkEOTCB.Location = new Point(129, 179);
      this.checkEOTCB.Name = "checkEOTCB";
      this.checkEOTCB.Size = new Size(42, 16);
      this.checkEOTCB.TabIndex = 101;
      this.checkEOTCB.Text = "Yes";
      this.checkEOTCB.UseVisualStyleBackColor = true;
      this.checkEOTCB.Visible = false;
      this.onDSRDropCB.AutoSize = true;
      this.onDSRDropCB.Location = new Point(129, 159);
      this.onDSRDropCB.Name = "onDSRDropCB";
      this.onDSRDropCB.Size = new Size(42, 16);
      this.onDSRDropCB.TabIndex = 100;
      this.onDSRDropCB.Text = "Yes";
      this.onDSRDropCB.UseVisualStyleBackColor = true;
      this.onDSRDropCB.Visible = false;
      this.connectResponseCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.connectResponseCB.FormattingEnabled = true;
      this.connectResponseCB.Items.AddRange(new object[2]
      {
        (object) "None",
        (object) "ACT"
      });
      this.connectResponseCB.Location = new Point(104, 113);
      this.connectResponseCB.Name = "connectResponseCB";
      this.connectResponseCB.Size = new Size(67, 20);
      this.connectResponseCB.TabIndex = 99;
      this.connectResponseCB.Visible = false;
      this.tcpRomteHostTB.Location = new Point(79, 32);
      this.tcpRomteHostTB.Name = "tcpRomteHostTB";
      this.tcpRomteHostTB.Size = new Size(92, 21);
      this.tcpRomteHostTB.TabIndex = 98;
      this.tcpRomteHostTB.Visible = false;
      this.useHostlistCB.AutoSize = true;
      this.useHostlistCB.Location = new Point(129, 139);
      this.useHostlistCB.Name = "useHostlistCB";
      this.useHostlistCB.Size = new Size(42, 16);
      this.useHostlistCB.TabIndex = 97;
      this.useHostlistCB.Text = "Yes";
      this.useHostlistCB.UseVisualStyleBackColor = true;
      this.useHostlistCB.Visible = false;
      this.tcpRemotePortNUD.Location = new Point(111, 59);
      NumericUpDown numericUpDown24 = this.tcpRemotePortNUD;
      int[] bits24 = new int[4];
      bits24[0] = (int) ushort.MaxValue;
      Decimal num24 = new Decimal(bits24);
      numericUpDown24.Maximum = num24;
      this.tcpRemotePortNUD.Name = "tcpRemotePortNUD";
      this.tcpRemotePortNUD.Size = new Size(60, 21);
      this.tcpRemotePortNUD.TabIndex = 96;
      NumericUpDown numericUpDown25 = this.tcpRemotePortNUD;
      int[] bits25 = new int[4];
      bits25[0] = 1;
      Decimal num25 = new Decimal(bits25);
      numericUpDown25.Value = num25;
      this.tcpRemotePortNUD.Visible = false;
      this.tcpLocalPortNUD.Location = new Point(111, 86);
      NumericUpDown numericUpDown26 = this.tcpLocalPortNUD;
      int[] bits26 = new int[4];
      bits26[0] = (int) ushort.MaxValue;
      Decimal num26 = new Decimal(bits26);
      numericUpDown26.Maximum = num26;
      this.tcpLocalPortNUD.Name = "tcpLocalPortNUD";
      this.tcpLocalPortNUD.Size = new Size(60, 21);
      this.tcpLocalPortNUD.TabIndex = 95;
      NumericUpDown numericUpDown27 = this.tcpLocalPortNUD;
      int[] bits27 = new int[4];
      bits27[0] = 1;
      Decimal num27 = new Decimal(bits27);
      numericUpDown27.Value = num27;
      this.tcpLocalPortNUD.Visible = false;
      this.startCharTB.Location = new Point(310, 29);
      this.startCharTB.Name = "startCharTB";
      this.startCharTB.Size = new Size(37, 21);
      this.startCharTB.TabIndex = 79;
      this.startCharTB.Visible = false;
      this.label42.AutoSize = true;
      this.label42.Location = new Point(290, 36);
      this.label42.Name = "label42";
      this.label42.Size = new Size(17, 12);
      this.label42.TabIndex = 94;
      this.label42.Text = "0x";
      this.label42.Visible = false;
      this.tcpActiveCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.tcpActiveCB.FormattingEnabled = true;
      this.tcpActiveCB.Items.AddRange(new object[4]
      {
        (object) "None",
        (object) "WithAnyCharacter",
        (object) "WithStartCharacter",
        (object) "AutoStart"
      });
      this.tcpActiveCB.Location = new Point(292, 7);
      this.tcpActiveCB.Name = "tcpActiveCB";
      this.tcpActiveCB.Size = new Size(107, 20);
      this.tcpActiveCB.TabIndex = 93;
      this.tcpActiveCB.Visible = false;
      this.myLable95.Location = new Point(6, 219);
      this.myLable95.Name = "myLable95";
      this.myLable95.PropertyLabel = this.propertyL;
      this.myLable95.PropertyName = "InactivityTimeout";
      this.myLable95.Size = new Size(116, 14);
      this.myLable95.TabIndex = 92;
      this.myLable95.Text = "Inactivity Timeout";
      this.myLable95.Visible = false;
      this.myLable94.Location = new Point(6, 179);
      this.myLable94.Name = "myLable94";
      this.myLable94.PropertyLabel = this.propertyL;
      this.myLable94.PropertyName = "CheckEOT";
      this.myLable94.Size = new Size(60, 14);
      this.myLable94.TabIndex = 91;
      this.myLable94.Text = "Check EOT";
      this.myLable94.Visible = false;
      this.myLable93.Location = new Point(6, 199);
      this.myLable93.Name = "myLable93";
      this.myLable93.PropertyLabel = this.propertyL;
      this.myLable93.PropertyName = "HardDisconnect";
      this.myLable93.Size = new Size(97, 14);
      this.myLable93.TabIndex = 90;
      this.myLable93.Text = "Hard Disconnect";
      this.myLable93.Visible = false;
      this.myLable92.Location = new Point(6, 159);
      this.myLable92.Name = "myLable92";
      this.myLable92.PropertyLabel = this.propertyL;
      this.myLable92.PropertyName = "OnDSRDrop";
      this.myLable92.Size = new Size(73, 14);
      this.myLable92.TabIndex = 89;
      this.myLable92.Text = "On DSR Drop";
      this.myLable92.Visible = false;
      this.myLable91.Location = new Point(6, 140);
      this.myLable91.Name = "myLable91";
      this.myLable91.PropertyLabel = this.propertyL;
      this.myLable91.PropertyName = "UseHostlist";
      this.myLable91.Size = new Size(73, 14);
      this.myLable91.TabIndex = 88;
      this.myLable91.Text = "UseHostlist";
      this.myLable91.Visible = false;
      this.myLable90.Location = new Point(6, 116);
      this.myLable90.Name = "myLable90";
      this.myLable90.PropertyLabel = this.propertyL;
      this.myLable90.PropertyName = "ConnectResponse";
      this.myLable90.Size = new Size(103, 14);
      this.myLable90.TabIndex = 87;
      this.myLable90.Text = "Connect Response";
      this.myLable90.Visible = false;
      this.myLable89.Location = new Point(6, 36);
      this.myLable89.Name = "myLable89";
      this.myLable89.PropertyLabel = this.propertyL;
      this.myLable89.PropertyName = "RemoteHost";
      this.myLable89.Size = new Size(73, 14);
      this.myLable89.TabIndex = 86;
      this.myLable89.Text = "Remote Host";
      this.myLable89.Visible = false;
      this.myLable88.Location = new Point(6, 62);
      this.myLable88.Name = "myLable88";
      this.myLable88.PropertyLabel = this.propertyL;
      this.myLable88.PropertyName = "RemotePort";
      this.myLable88.Size = new Size(73, 14);
      this.myLable88.TabIndex = 85;
      this.myLable88.Text = "Remote Port";
      this.myLable88.Visible = false;
      this.myLable87.Location = new Point(6, 89);
      this.myLable87.Name = "myLable87";
      this.myLable87.PropertyLabel = this.propertyL;
      this.myLable87.PropertyName = "LocalPort";
      this.myLable87.Size = new Size(66, 14);
      this.myLable87.TabIndex = 84;
      this.myLable87.Text = "Local Port";
      this.myLable87.Visible = false;
      this.myLable86.Location = new Point(185, 37);
      this.myLable86.Name = "myLable86";
      this.myLable86.PropertyLabel = this.propertyL;
      this.myLable86.PropertyName = "StartCharacter";
      this.myLable86.Size = new Size(97, 14);
      this.myLable86.TabIndex = 83;
      this.myLable86.Text = "Start Character";
      this.myLable86.Visible = false;
      this.myLable85.Location = new Point(185, 13);
      this.myLable85.Name = "myLable85";
      this.myLable85.PropertyLabel = this.propertyL;
      this.myLable85.PropertyName = "ActiveConnect";
      this.myLable85.Size = new Size(91, 14);
      this.myLable85.TabIndex = 82;
      this.myLable85.Text = "Active Connect";
      this.myLable85.Visible = false;
      this.myLable84.Location = new Point(6, 12);
      this.myLable84.Name = "myLable84";
      this.myLable84.PropertyLabel = this.propertyL;
      this.myLable84.PropertyName = "TCPMode";
      this.myLable84.Size = new Size(60, 14);
      this.myLable84.TabIndex = 80;
      this.myLable84.Text = "Acception Incoming";
      this.myLable84.Visible = false;
      this.udpUCLPNUD.Location = new Point(337, (int) sbyte.MaxValue);
      NumericUpDown numericUpDown28 = this.udpUCLPNUD;
      int[] bits28 = new int[4];
      bits28[0] = (int) ushort.MaxValue;
      Decimal num28 = new Decimal(bits28);
      numericUpDown28.Maximum = num28;
      this.udpUCLPNUD.Name = "udpUCLPNUD";
      this.udpUCLPNUD.Size = new Size(60, 21);
      this.udpUCLPNUD.TabIndex = 82;
      NumericUpDown numericUpDown29 = this.udpUCLPNUD;
      int[] bits29 = new int[4];
      bits29[0] = 1;
      Decimal num29 = new Decimal(bits29);
      numericUpDown29.Value = num29;
      this.udpUCLPNUD.Visible = false;
      this.tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
      this.tableLayoutPanel2.ColumnCount = 4;
      this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.02005f));
      this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.34586f));
      this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.34085f));
      this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.29323f));
      this.tableLayoutPanel2.Controls.Add((Control) this.eAddr3TB, 2, 4);
      this.tableLayoutPanel2.Controls.Add((Control) this.bAddr3TB, 1, 4);
      this.tableLayoutPanel2.Controls.Add((Control) this.eAddr2TB, 2, 3);
      this.tableLayoutPanel2.Controls.Add((Control) this.bAddr2TB, 1, 3);
      this.tableLayoutPanel2.Controls.Add((Control) this.eAddr1TB, 2, 2);
      this.tableLayoutPanel2.Controls.Add((Control) this.bAddr1TB, 1, 2);
      this.tableLayoutPanel2.Controls.Add((Control) this.eAddr0TB, 2, 1);
      this.tableLayoutPanel2.Controls.Add((Control) this.bAddr0TB, 1, 1);
      this.tableLayoutPanel2.Controls.Add((Control) this.label38, 0, 1);
      this.tableLayoutPanel2.Controls.Add((Control) this.label37, 3, 0);
      this.tableLayoutPanel2.Controls.Add((Control) this.label36, 2, 0);
      this.tableLayoutPanel2.Controls.Add((Control) this.label35, 1, 0);
      this.tableLayoutPanel2.Controls.Add((Control) this.label32, 0, 0);
      this.tableLayoutPanel2.Controls.Add((Control) this.label39, 0, 2);
      this.tableLayoutPanel2.Controls.Add((Control) this.label40, 0, 3);
      this.tableLayoutPanel2.Controls.Add((Control) this.label41, 0, 4);
      this.tableLayoutPanel2.Controls.Add((Control) this.udpPort0TB, 3, 1);
      this.tableLayoutPanel2.Controls.Add((Control) this.udpPort1TB, 3, 2);
      this.tableLayoutPanel2.Controls.Add((Control) this.udpPort2TB, 3, 3);
      this.tableLayoutPanel2.Controls.Add((Control) this.udpPort3TB, 3, 4);
      this.tableLayoutPanel2.Location = new Point(3, 149);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 5;
      this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.97849f));
      this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.50538f));
      this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.50538f));
      this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.50538f));
      this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.50538f));
      this.tableLayoutPanel2.Size = new Size(402, 121);
      this.tableLayoutPanel2.TabIndex = 81;
      this.tableLayoutPanel2.Visible = false;
      this.eAddr3TB.Dock = DockStyle.Fill;
      this.eAddr3TB.Location = new Point(189, 96);
      this.eAddr3TB.Name = "eAddr3TB";
      this.eAddr3TB.Size = new Size(138, 21);
      this.eAddr3TB.TabIndex = 87;
      this.bAddr3TB.Dock = DockStyle.Fill;
      this.bAddr3TB.Location = new Point(36, 96);
      this.bAddr3TB.Name = "bAddr3TB";
      this.bAddr3TB.Size = new Size(146, 21);
      this.bAddr3TB.TabIndex = 86;
      this.eAddr2TB.Dock = DockStyle.Fill;
      this.eAddr2TB.Location = new Point(189, 71);
      this.eAddr2TB.Name = "eAddr2TB";
      this.eAddr2TB.Size = new Size(138, 21);
      this.eAddr2TB.TabIndex = 85;
      this.bAddr2TB.Dock = DockStyle.Fill;
      this.bAddr2TB.Location = new Point(36, 71);
      this.bAddr2TB.Name = "bAddr2TB";
      this.bAddr2TB.Size = new Size(146, 21);
      this.bAddr2TB.TabIndex = 84;
      this.eAddr1TB.Dock = DockStyle.Fill;
      this.eAddr1TB.Location = new Point(189, 46);
      this.eAddr1TB.Name = "eAddr1TB";
      this.eAddr1TB.Size = new Size(138, 21);
      this.eAddr1TB.TabIndex = 83;
      this.bAddr1TB.Dock = DockStyle.Fill;
      this.bAddr1TB.Location = new Point(36, 46);
      this.bAddr1TB.Name = "bAddr1TB";
      this.bAddr1TB.Size = new Size(146, 21);
      this.bAddr1TB.TabIndex = 82;
      this.eAddr0TB.Dock = DockStyle.Fill;
      this.eAddr0TB.Location = new Point(189, 21);
      this.eAddr0TB.Name = "eAddr0TB";
      this.eAddr0TB.Size = new Size(138, 21);
      this.eAddr0TB.TabIndex = 81;
      this.bAddr0TB.Dock = DockStyle.Fill;
      this.bAddr0TB.Location = new Point(36, 21);
      this.bAddr0TB.Name = "bAddr0TB";
      this.bAddr0TB.Size = new Size(146, 21);
      this.bAddr0TB.TabIndex = 79;
      this.label38.AutoSize = true;
      this.label38.Dock = DockStyle.Fill;
      this.label38.Location = new Point(4, 18);
      this.label38.Name = "label38";
      this.label38.Size = new Size(25, 24);
      this.label38.TabIndex = 4;
      this.label38.Text = "0";
      this.label38.TextAlign = ContentAlignment.MiddleCenter;
      this.label37.AutoSize = true;
      this.label37.Dock = DockStyle.Fill;
      this.label37.Location = new Point(334, 1);
      this.label37.Name = "label37";
      this.label37.Size = new Size(64, 16);
      this.label37.TabIndex = 3;
      this.label37.Text = "Port";
      this.label37.TextAlign = ContentAlignment.MiddleCenter;
      this.label36.AutoSize = true;
      this.label36.Dock = DockStyle.Fill;
      this.label36.Location = new Point(189, 1);
      this.label36.Name = "label36";
      this.label36.Size = new Size(138, 16);
      this.label36.TabIndex = 2;
      this.label36.Text = "Host Address";
      this.label36.TextAlign = ContentAlignment.MiddleCenter;
      this.label35.AutoSize = true;
      this.label35.Dock = DockStyle.Fill;
      this.label35.Location = new Point(36, 1);
      this.label35.Name = "label35";
      this.label35.Size = new Size(146, 16);
      this.label35.TabIndex = 1;
      this.label35.Text = "Host Address";
      this.label35.TextAlign = ContentAlignment.MiddleCenter;
      this.label32.AutoSize = true;
      this.label32.Dock = DockStyle.Fill;
      this.label32.Location = new Point(4, 1);
      this.label32.Name = "label32";
      this.label32.Size = new Size(25, 16);
      this.label32.TabIndex = 0;
      this.label32.Text = "No.";
      this.label32.TextAlign = ContentAlignment.MiddleCenter;
      this.label39.AutoSize = true;
      this.label39.Dock = DockStyle.Fill;
      this.label39.Location = new Point(4, 43);
      this.label39.Name = "label39";
      this.label39.Size = new Size(25, 24);
      this.label39.TabIndex = 5;
      this.label39.Text = "1";
      this.label39.TextAlign = ContentAlignment.MiddleCenter;
      this.label40.AutoSize = true;
      this.label40.Dock = DockStyle.Fill;
      this.label40.Location = new Point(4, 68);
      this.label40.Name = "label40";
      this.label40.Size = new Size(25, 24);
      this.label40.TabIndex = 6;
      this.label40.Text = "2";
      this.label40.TextAlign = ContentAlignment.MiddleCenter;
      this.label41.AutoSize = true;
      this.label41.Dock = DockStyle.Fill;
      this.label41.Location = new Point(4, 93);
      this.label41.Name = "label41";
      this.label41.Size = new Size(25, 27);
      this.label41.TabIndex = 7;
      this.label41.Text = "3";
      this.label41.TextAlign = ContentAlignment.MiddleCenter;
      this.udpPort0TB.Dock = DockStyle.Fill;
      this.udpPort0TB.Location = new Point(334, 21);
      NumericUpDown numericUpDown30 = this.udpPort0TB;
      int[] bits30 = new int[4];
      bits30[0] = (int) ushort.MaxValue;
      Decimal num30 = new Decimal(bits30);
      numericUpDown30.Maximum = num30;
      this.udpPort0TB.Name = "udpPort0TB";
      this.udpPort0TB.Size = new Size(64, 21);
      this.udpPort0TB.TabIndex = 77;
      NumericUpDown numericUpDown31 = this.udpPort0TB;
      int[] bits31 = new int[4];
      bits31[0] = 1;
      Decimal num31 = new Decimal(bits31);
      numericUpDown31.Value = num31;
      this.udpPort1TB.Dock = DockStyle.Fill;
      this.udpPort1TB.Location = new Point(334, 46);
      NumericUpDown numericUpDown32 = this.udpPort1TB;
      int[] bits32 = new int[4];
      bits32[0] = (int) ushort.MaxValue;
      Decimal num32 = new Decimal(bits32);
      numericUpDown32.Maximum = num32;
      this.udpPort1TB.Name = "udpPort1TB";
      this.udpPort1TB.Size = new Size(64, 21);
      this.udpPort1TB.TabIndex = 78;
      NumericUpDown numericUpDown33 = this.udpPort1TB;
      int[] bits33 = new int[4];
      bits33[0] = 1;
      Decimal num33 = new Decimal(bits33);
      numericUpDown33.Value = num33;
      this.udpPort2TB.Dock = DockStyle.Fill;
      this.udpPort2TB.Location = new Point(334, 71);
      NumericUpDown numericUpDown34 = this.udpPort2TB;
      int[] bits34 = new int[4];
      bits34[0] = (int) ushort.MaxValue;
      Decimal num34 = new Decimal(bits34);
      numericUpDown34.Maximum = num34;
      this.udpPort2TB.Name = "udpPort2TB";
      this.udpPort2TB.Size = new Size(64, 21);
      this.udpPort2TB.TabIndex = 79;
      NumericUpDown numericUpDown35 = this.udpPort2TB;
      int[] bits35 = new int[4];
      bits35[0] = 1;
      Decimal num35 = new Decimal(bits35);
      numericUpDown35.Value = num35;
      this.udpPort3TB.Dock = DockStyle.Fill;
      this.udpPort3TB.Location = new Point(334, 96);
      NumericUpDown numericUpDown36 = this.udpPort3TB;
      int[] bits36 = new int[4];
      bits36[0] = (int) ushort.MaxValue;
      Decimal num36 = new Decimal(bits36);
      numericUpDown36.Maximum = num36;
      this.udpPort3TB.Name = "udpPort3TB";
      this.udpPort3TB.Size = new Size(64, 21);
      this.udpPort3TB.TabIndex = 80;
      NumericUpDown numericUpDown37 = this.udpPort3TB;
      int[] bits37 = new int[4];
      bits37[0] = 1;
      Decimal num37 = new Decimal(bits37);
      numericUpDown37.Value = num37;
      this.panel7.Controls.Add((Control) this.udpSegmentTB);
      this.panel7.Controls.Add((Control) this.udpRemotePortNUD);
      this.panel7.Controls.Add((Control) this.udpLocalPortNUD);
      this.panel7.Controls.Add((Control) this.myLable79);
      this.panel7.Controls.Add((Control) this.myLable80);
      this.panel7.Controls.Add((Control) this.myLable81);
      this.panel7.Location = new Point(3, 68);
      this.panel7.Name = "panel7";
      this.panel7.Size = new Size(402, 59);
      this.panel7.TabIndex = 80;
      this.udpSegmentTB.Location = new Point(114, 32);
      this.udpSegmentTB.Name = "udpSegmentTB";
      this.udpSegmentTB.Size = new Size(120, 21);
      this.udpSegmentTB.TabIndex = 78;
      this.udpSegmentTB.Visible = false;
      this.udpRemotePortNUD.Location = new Point(339, 5);
      NumericUpDown numericUpDown38 = this.udpRemotePortNUD;
      int[] bits38 = new int[4];
      bits38[0] = (int) ushort.MaxValue;
      Decimal num38 = new Decimal(bits38);
      numericUpDown38.Maximum = num38;
      this.udpRemotePortNUD.Name = "udpRemotePortNUD";
      this.udpRemotePortNUD.Size = new Size(60, 21);
      this.udpRemotePortNUD.TabIndex = 77;
      NumericUpDown numericUpDown39 = this.udpRemotePortNUD;
      int[] bits39 = new int[4];
      bits39[0] = 1;
      Decimal num39 = new Decimal(bits39);
      numericUpDown39.Value = num39;
      this.udpRemotePortNUD.Visible = false;
      this.udpLocalPortNUD.Location = new Point(114, 6);
      NumericUpDown numericUpDown40 = this.udpLocalPortNUD;
      int[] bits40 = new int[4];
      bits40[0] = (int) ushort.MaxValue;
      Decimal num40 = new Decimal(bits40);
      numericUpDown40.Maximum = num40;
      this.udpLocalPortNUD.Name = "udpLocalPortNUD";
      this.udpLocalPortNUD.Size = new Size(60, 21);
      this.udpLocalPortNUD.TabIndex = 76;
      NumericUpDown numericUpDown41 = this.udpLocalPortNUD;
      int[] bits41 = new int[4];
      bits41[0] = 1;
      Decimal num41 = new Decimal(bits41);
      numericUpDown41.Value = num41;
      this.udpLocalPortNUD.Visible = false;
      this.myLable79.Location = new Point(15, 10);
      this.myLable79.Name = "myLable79";
      this.myLable79.PropertyLabel = this.propertyL;
      this.myLable79.PropertyName = "UDPLocalPort";
      this.myLable79.Size = new Size(91, 14);
      this.myLable79.TabIndex = 73;
      this.myLable79.Text = "UDP Local Port";
      this.myLable79.Visible = false;
      this.myLable80.Location = new Point(230, 11);
      this.myLable80.Name = "myLable80";
      this.myLable80.PropertyLabel = this.propertyL;
      this.myLable80.PropertyName = "UDPRemotePort";
      this.myLable80.Size = new Size(97, 14);
      this.myLable80.TabIndex = 74;
      this.myLable80.Text = "UDP Remote Port";
      this.myLable80.Visible = false;
      this.myLable81.Location = new Point(15, 36);
      this.myLable81.Name = "myLable81";
      this.myLable81.PropertyLabel = this.propertyL;
      this.myLable81.PropertyName = "UDPNetSegment";
      this.myLable81.Size = new Size(97, 14);
      this.myLable81.TabIndex = 75;
      this.myLable81.Text = "UDP Net Segment";
      this.myLable81.Visible = false;
      this.udpAcceptCB.AutoSize = true;
      this.udpAcceptCB.Location = new Point(342, 49);
      this.udpAcceptCB.Name = "udpAcceptCB";
      this.udpAcceptCB.Size = new Size(42, 16);
      this.udpAcceptCB.TabIndex = 79;
      this.udpAcceptCB.Text = "Yes";
      this.udpAcceptCB.UseVisualStyleBackColor = true;
      this.udpAcceptCB.Visible = false;
      this.datagramCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.datagramCB.FormattingEnabled = true;
      this.datagramCB.Items.AddRange(new object[2]
      {
        (object) "Uni_Cast",
        (object) "Multi_Cast"
      });
      this.datagramCB.Location = new Point(117, 45);
      this.datagramCB.Name = "datagramCB";
      this.datagramCB.Size = new Size(88, 20);
      this.datagramCB.TabIndex = 78;
      this.datagramCB.Visible = false;
      this.datagramCB.SelectedIndexChanged += new EventHandler(this.datagramCB_SelectedIndexChanged);
      this.myLable83.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.myLable83.Location = new Point(18, 130);
      this.myLable83.Name = "myLable83";
      this.myLable83.PropertyLabel = this.propertyL;
      this.myLable83.PropertyName = "UseHostlist";
      this.myLable83.Size = new Size(75, 14);
      this.myLable83.TabIndex = 77;
      this.myLable83.Text = "UseHostlist";
      this.myLable83.Visible = false;
      this.myLable82.Location = new Point(188, 132);
      this.myLable82.Name = "myLable82";
      this.myLable82.PropertyLabel = this.propertyL;
      this.myLable82.PropertyName = "UDPUniCastLocalPort";
      this.myLable82.Size = new Size(141, 14);
      this.myLable82.TabIndex = 76;
      this.myLable82.Text = "UDP UniCast Local Port";
      this.myLable82.Visible = false;
      this.myLable78.Location = new Point(233, 49);
      this.myLable78.Name = "myLable78";
      this.myLable78.PropertyLabel = this.propertyL;
      this.myLable78.PropertyName = "AcceptIncoming";
      this.myLable78.Size = new Size(97, 14);
      this.myLable78.TabIndex = 72;
      this.myLable78.Text = "Accept Incoming";
      this.myLable78.Visible = false;
      this.myLable77.Location = new Point(18, 48);
      this.myLable77.Name = "myLable77";
      this.myLable77.PropertyLabel = this.propertyL;
      this.myLable77.PropertyName = "DatagramType";
      this.myLable77.Size = new Size(85, 14);
      this.myLable77.TabIndex = 71;
      this.myLable77.Text = "Datagram Type";
      this.myLable77.Visible = false;
      this.netProtocolCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.netProtocolCB.FormattingEnabled = true;
      this.netProtocolCB.Items.AddRange(new object[2]
      {
        (object) "UDP",
        (object) "TCP"
      });
      this.netProtocolCB.Location = new Point(347, 10);
      this.netProtocolCB.Name = "netProtocolCB";
      this.netProtocolCB.Size = new Size(50, 20);
      this.netProtocolCB.TabIndex = 68;
      this.netProtocolCB.Visible = false;
      this.netProtocolCB.SelectedIndexChanged += new EventHandler(this.netProtocolCB_SelectedIndexChanged);
      this.myLable76.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.myLable76.Location = new Point(252, 13);
      this.myLable76.Name = "myLable76";
      this.myLable76.PropertyLabel = this.propertyL;
      this.myLable76.PropertyName = "NetProtocol";
      this.myLable76.Size = new Size(82, 14);
      this.myLable76.TabIndex = 67;
      this.myLable76.Text = "Net Protocol";
      this.myLable76.Visible = false;
      this.channelNameL2.AutoSize = true;
      this.channelNameL2.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.channelNameL2.Location = new Point(18, 14);
      this.channelNameL2.Name = "channelNameL2";
      this.channelNameL2.Size = new Size(0, 12);
      this.channelNameL2.TabIndex = 4;
      this.serialPanel.Controls.Add((Control) this.panel9);
      this.serialPanel.Controls.Add((Control) this.panel4);
      this.serialPanel.Controls.Add((Control) this.serialOptionCB);
      this.serialPanel.Controls.Add((Control) this.myLable57);
      this.serialPanel.Controls.Add((Control) this.channelNameL1);
      this.serialPanel.Location = new Point(0, 0);
      this.serialPanel.Name = "serialPanel";
      this.serialPanel.Size = new Size(408, 273);
      this.serialPanel.TabIndex = 41;
      this.serialPanel.Visible = false;
      this.panel9.Controls.Add((Control) this.panel6);
      this.panel9.Controls.Add((Control) this.enablePackCB);
      this.panel9.Controls.Add((Control) this.myLable65);
      this.panel9.Location = new Point(3, 125);
      this.panel9.Name = "panel9";
      this.panel9.Size = new Size(402, 148);
      this.panel9.TabIndex = 44;
      this.panel6.Controls.Add((Control) this.lastTB);
      this.panel6.Controls.Add((Control) this.firstCharTB);
      this.panel6.Controls.Add((Control) this.label34);
      this.panel6.Controls.Add((Control) this.label33);
      this.panel6.Controls.Add((Control) this.sendBytesCB);
      this.panel6.Controls.Add((Control) this.match2CB);
      this.panel6.Controls.Add((Control) this.sendFrameCB);
      this.panel6.Controls.Add((Control) this.idleCB);
      this.panel6.Controls.Add((Control) this.myLable66);
      this.panel6.Controls.Add((Control) this.myLable67);
      this.panel6.Controls.Add((Control) this.myLable68);
      this.panel6.Controls.Add((Control) this.myLable71);
      this.panel6.Location = new Point(3, 26);
      this.panel6.Name = "panel6";
      this.panel6.Size = new Size(396, 117);
      this.panel6.TabIndex = 72;
      this.lastTB.Location = new Point(323, 31);
      this.lastTB.Name = "lastTB";
      this.lastTB.Size = new Size(32, 21);
      this.lastTB.TabIndex = 76;
      this.lastTB.Visible = false;
      this.firstCharTB.Location = new Point(269, 32);
      this.firstCharTB.Name = "firstCharTB";
      this.firstCharTB.Size = new Size(32, 21);
      this.firstCharTB.TabIndex = 75;
      this.firstCharTB.Visible = false;
      this.label34.AutoSize = true;
      this.label34.Location = new Point(306, 37);
      this.label34.Name = "label34";
      this.label34.Size = new Size(17, 12);
      this.label34.TabIndex = 74;
      this.label34.Text = "0x";
      this.label34.Visible = false;
      this.label33.AutoSize = true;
      this.label33.Location = new Point(251, 36);
      this.label33.Name = "label33";
      this.label33.Size = new Size(17, 12);
      this.label33.TabIndex = 73;
      this.label33.Text = "0x";
      this.label33.Visible = false;
      this.sendBytesCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.sendBytesCB.FormattingEnabled = true;
      this.sendBytesCB.Items.AddRange(new object[3]
      {
        (object) "None",
        (object) "One",
        (object) "Two"
      });
      this.sendBytesCB.Location = new Point(189, 86);
      this.sendBytesCB.Name = "sendBytesCB";
      this.sendBytesCB.Size = new Size(73, 20);
      this.sendBytesCB.TabIndex = 73;
      this.sendBytesCB.Visible = false;
      this.match2CB.AutoSize = true;
      this.match2CB.Location = new Point(189, 35);
      this.match2CB.Name = "match2CB";
      this.match2CB.Size = new Size(42, 16);
      this.match2CB.TabIndex = 72;
      this.match2CB.Text = "Yes";
      this.match2CB.UseVisualStyleBackColor = true;
      this.match2CB.Visible = false;
      this.sendFrameCB.AutoSize = true;
      this.sendFrameCB.Location = new Point(189, 61);
      this.sendFrameCB.Name = "sendFrameCB";
      this.sendFrameCB.Size = new Size(42, 16);
      this.sendFrameCB.TabIndex = 71;
      this.sendFrameCB.Text = "Yes";
      this.sendFrameCB.UseVisualStyleBackColor = true;
      this.sendFrameCB.Visible = false;
      this.idleCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.idleCB.FormattingEnabled = true;
      this.idleCB.Items.AddRange(new object[3]
      {
        (object) "12msec",
        (object) "11msec",
        (object) "10msec"
      });
      this.idleCB.Location = new Point(189, 7);
      this.idleCB.Name = "idleCB";
      this.idleCB.Size = new Size(62, 20);
      this.idleCB.TabIndex = 70;
      this.idleCB.Visible = false;
      this.myLable66.Location = new Point(21, 7);
      this.myLable66.Name = "myLable66";
      this.myLable66.PropertyLabel = this.propertyL;
      this.myLable66.PropertyName = "IdleGapTime";
      this.myLable66.Size = new Size(85, 14);
      this.myLable66.TabIndex = 39;
      this.myLable66.Text = "Idle Gap Time";
      this.myLable66.Visible = false;
      this.myLable67.Location = new Point(21, 35);
      this.myLable67.Name = "myLable67";
      this.myLable67.PropertyLabel = this.propertyL;
      this.myLable67.PropertyName = "Match2ByteSequence";
      this.myLable67.Size = new Size(134, 14);
      this.myLable67.TabIndex = 40;
      this.myLable67.Text = "Match 2 Byte Sequence";
      this.myLable67.Visible = false;
      this.myLable68.Location = new Point(21, 63);
      this.myLable68.Name = "myLable68";
      this.myLable68.PropertyLabel = this.propertyL;
      this.myLable68.PropertyName = "SendFrameOnly";
      this.myLable68.Size = new Size(85, 14);
      this.myLable68.TabIndex = 41;
      this.myLable68.Text = "SendFrameOnly";
      this.myLable68.Visible = false;
      this.myLable71.Location = new Point(21, 89);
      this.myLable71.Name = "myLable71";
      this.myLable71.PropertyLabel = this.propertyL;
      this.myLable71.PropertyName = "SendTrailingBytes";
      this.myLable71.Size = new Size(122, 14);
      this.myLable71.TabIndex = 69;
      this.myLable71.Text = "Send Trailing Bytes";
      this.myLable71.Visible = false;
      this.enablePackCB.AutoSize = true;
      this.enablePackCB.Location = new Point(128, 5);
      this.enablePackCB.Name = "enablePackCB";
      this.enablePackCB.Size = new Size(60, 16);
      this.enablePackCB.TabIndex = 66;
      this.enablePackCB.Text = "Enable";
      this.enablePackCB.UseVisualStyleBackColor = true;
      this.enablePackCB.Visible = false;
      this.enablePackCB.CheckedChanged += new EventHandler(this.enablePackCB_CheckedChanged);
      this.myLable65.Location = new Point(24, 5);
      this.myLable65.Name = "myLable65";
      this.myLable65.PropertyLabel = this.propertyL;
      this.myLable65.PropertyName = "EnablePacking";
      this.myLable65.Size = new Size(91, 14);
      this.myLable65.TabIndex = 38;
      this.myLable65.Text = "Enable Packing";
      this.myLable65.Visible = false;
      this.panel4.Controls.Add((Control) this.protocolCB);
      this.panel4.Controls.Add((Control) this.stopbitCB);
      this.panel4.Controls.Add((Control) this.parityCB);
      this.panel4.Controls.Add((Control) this.databitCB);
      this.panel4.Controls.Add((Control) this.baudrateCB);
      this.panel4.Controls.Add((Control) this.flowCB);
      this.panel4.Controls.Add((Control) this.fifoCB);
      this.panel4.Controls.Add((Control) this.myLable64);
      this.panel4.Controls.Add((Control) this.myLable63);
      this.panel4.Controls.Add((Control) this.myLable62);
      this.panel4.Controls.Add((Control) this.myLable61);
      this.panel4.Controls.Add((Control) this.myLable60);
      this.panel4.Controls.Add((Control) this.myLable59);
      this.panel4.Controls.Add((Control) this.myLable58);
      this.panel4.Location = new Point(3, 40);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(402, 85);
      this.panel4.TabIndex = 66;
      this.protocolCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.protocolCB.FormattingEnabled = true;
      this.protocolCB.Location = new Point(104, 10);
      this.protocolCB.Name = "protocolCB";
      this.protocolCB.Size = new Size(64, 20);
      this.protocolCB.TabIndex = 83;
      this.protocolCB.Visible = false;
      this.protocolCB.SelectedIndexChanged += new EventHandler(this.protocolCB_SelectedIndexChanged);
      this.stopbitCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.stopbitCB.FormattingEnabled = true;
      this.stopbitCB.Items.AddRange(new object[3]
      {
        (object) "1",
        (object) "1.5",
        (object) "2"
      });
      this.stopbitCB.Location = new Point(311, 61);
      this.stopbitCB.Name = "stopbitCB";
      this.stopbitCB.Size = new Size(45, 20);
      this.stopbitCB.TabIndex = 48;
      this.stopbitCB.Visible = false;
      this.parityCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.parityCB.FormattingEnabled = true;
      this.parityCB.Items.AddRange(new object[5]
      {
        (object) "NONE",
        (object) "ODD",
        (object) "EVEN",
        (object) "MARK",
        (object) "SPACE"
      });
      this.parityCB.Location = new Point(104, 61);
      this.parityCB.Name = "parityCB";
      this.parityCB.Size = new Size(88, 20);
      this.parityCB.TabIndex = 47;
      this.parityCB.Visible = false;
      this.databitCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.databitCB.FormattingEnabled = true;
      this.databitCB.Items.AddRange(new object[4]
      {
        (object) "5",
        (object) "6",
        (object) "7",
        (object) "8"
      });
      this.databitCB.Location = new Point(354, 10);
      this.databitCB.Name = "databitCB";
      this.databitCB.Size = new Size(45, 20);
      this.databitCB.TabIndex = 46;
      this.databitCB.Visible = false;
      this.baudrateCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.baudrateCB.FormattingEnabled = true;
      this.baudrateCB.Items.AddRange(new object[18]
      {
        (object) "110",
        (object) "134",
        (object) "150",
        (object) "300",
        (object) "600",
        (object) "1200",
        (object) "1800",
        (object) "2400",
        (object) "4800",
        (object) "7200",
        (object) "9600",
        (object) "14400",
        (object) "19200",
        (object) "38400",
        (object) "57600",
        (object) "115200",
        (object) "230400",
        (object) "460800"
      });
      this.baudrateCB.Location = new Point(104, 35);
      this.baudrateCB.Name = "baudrateCB";
      this.baudrateCB.Size = new Size(98, 20);
      this.baudrateCB.TabIndex = 45;
      this.baudrateCB.Visible = false;
      this.flowCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.flowCB.FormattingEnabled = true;
      this.flowCB.Items.AddRange(new object[3]
      {
        (object) "None",
        (object) "Hardware",
        (object) "Software"
      });
      this.flowCB.Location = new Point(311, 36);
      this.flowCB.Name = "flowCB";
      this.flowCB.Size = new Size(88, 20);
      this.flowCB.TabIndex = 44;
      this.flowCB.Visible = false;
      this.fifoCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.fifoCB.FormattingEnabled = true;
      this.fifoCB.Items.AddRange(new object[3]
      {
        (object) "14",
        (object) "8",
        (object) "4"
      });
      this.fifoCB.Location = new Point(221, 10);
      this.fifoCB.Name = "fifoCB";
      this.fifoCB.Size = new Size(45, 20);
      this.fifoCB.TabIndex = 43;
      this.fifoCB.Visible = false;
      this.myLable64.Location = new Point(219, 65);
      this.myLable64.Name = "myLable64";
      this.myLable64.PropertyLabel = this.propertyL;
      this.myLable64.PropertyName = "StopBits";
      this.myLable64.Size = new Size(60, 14);
      this.myLable64.TabIndex = 37;
      this.myLable64.Text = "Stop Bits";
      this.myLable64.Visible = false;
      this.myLable63.Location = new Point(24, 65);
      this.myLable63.Name = "myLable63";
      this.myLable63.PropertyLabel = this.propertyL;
      this.myLable63.PropertyName = "Parity";
      this.myLable63.Size = new Size(42, 14);
      this.myLable63.TabIndex = 36;
      this.myLable63.Text = "Parity";
      this.myLable63.Visible = false;
      this.myLable62.Location = new Point(272, 15);
      this.myLable62.Name = "myLable62";
      this.myLable62.PropertyLabel = this.propertyL;
      this.myLable62.PropertyName = "DataBits";
      this.myLable62.Size = new Size(60, 14);
      this.myLable62.TabIndex = 35;
      this.myLable62.Text = "Data Bits";
      this.myLable62.Visible = false;
      this.myLable61.Location = new Point(24, 38);
      this.myLable61.Name = "myLable61";
      this.myLable61.PropertyLabel = this.propertyL;
      this.myLable61.PropertyName = "BaudRate";
      this.myLable61.Size = new Size(60, 14);
      this.myLable61.TabIndex = 34;
      this.myLable61.Text = "Baud Rate";
      this.myLable61.Visible = false;
      this.myLable60.Location = new Point(219, 38);
      this.myLable60.Name = "myLable60";
      this.myLable60.PropertyLabel = this.propertyL;
      this.myLable60.PropertyName = "FlowControl";
      this.myLable60.Size = new Size(79, 14);
      this.myLable60.TabIndex = 33;
      this.myLable60.Text = "Flow Control";
      this.myLable60.Visible = false;
      this.myLable59.Location = new Point(173, 13);
      this.myLable59.Name = "myLable59";
      this.myLable59.PropertyLabel = this.propertyL;
      this.myLable59.PropertyName = "FIFO";
      this.myLable59.Size = new Size(29, 14);
      this.myLable59.TabIndex = 32;
      this.myLable59.Text = "FIFO";
      this.myLable59.Visible = false;
      this.myLable58.Location = new Point(24, 13);
      this.myLable58.Name = "myLable58";
      this.myLable58.PropertyLabel = this.propertyL;
      this.myLable58.PropertyName = "SerialPortProtocol";
      this.myLable58.Size = new Size(54, 14);
      this.myLable58.TabIndex = 31;
      this.myLable58.Text = "Protocol";
      this.myLable58.Visible = false;
      this.serialOptionCB.AutoSize = true;
      this.serialOptionCB.Location = new Point(339, 18);
      this.serialOptionCB.Name = "serialOptionCB";
      this.serialOptionCB.Size = new Size(60, 16);
      this.serialOptionCB.TabIndex = 65;
      this.serialOptionCB.Text = "Enable";
      this.serialOptionCB.UseVisualStyleBackColor = true;
      this.serialOptionCB.Visible = false;
      this.serialOptionCB.CheckedChanged += new EventHandler(this.serialOptionCB_CheckedChanged);
      this.myLable57.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.myLable57.Location = new Point(195, 19);
      this.myLable57.Name = "myLable57";
      this.myLable57.PropertyLabel = this.propertyL;
      this.myLable57.PropertyName = "SerialPortOptions";
      this.myLable57.Size = new Size((int) sbyte.MaxValue, 14);
      this.myLable57.TabIndex = 64;
      this.myLable57.Text = "Serial Port Options";
      this.myLable57.Visible = false;
      this.channelNameL1.AutoSize = true;
      this.channelNameL1.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.channelNameL1.Location = new Point(24, 17);
      this.channelNameL1.Name = "channelNameL1";
      this.channelNameL1.Size = new Size(0, 12);
      this.channelNameL1.TabIndex = 3;
      this.powerPanel.Controls.Add((Control) this.radioButton4);
      this.powerPanel.Controls.Add((Control) this.radioButton3);
      this.powerPanel.Controls.Add((Control) this.radioButton2);
      this.powerPanel.Controls.Add((Control) this.radioButton1);
      this.powerPanel.Location = new Point(0, 0);
      this.powerPanel.Name = "powerPanel";
      this.powerPanel.Size = new Size(408, 273);
      this.powerPanel.TabIndex = 42;
      this.radioButton4.AutoSize = true;
      this.radioButton4.Checked = true;
      this.radioButton4.Location = new Point(133, 174);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new Size(113, 16);
      this.radioButton4.TabIndex = 7;
      this.radioButton4.TabStop = true;
      this.radioButton4.Text = "Save and reboot";
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new Point(133, 138);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new Size(59, 16);
      this.radioButton3.TabIndex = 6;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "Reboot";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new Point(133, 100);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new Size(167, 16);
      this.radioButton2.TabIndex = 5;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Load defaults and reboot";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new Point(133, 62);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new Size(101, 16);
      this.radioButton1.TabIndex = 4;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Load defaults";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.pppPanel.Controls.Add((Control) this.myLable120);
      this.pppPanel.Controls.Add((Control) this.pppComCB);
      this.pppPanel.Controls.Add((Control) this.pppDNS2TB);
      this.pppPanel.Controls.Add((Control) this.pppDNS1TB);
      this.pppPanel.Controls.Add((Control) this.pppGatewayTB);
      this.pppPanel.Controls.Add((Control) this.pppIPTB);
      this.pppPanel.Controls.Add((Control) this.pppStatusTB);
      this.pppPanel.Controls.Add((Control) this.pppIDLENUD);
      this.pppPanel.Controls.Add((Control) this.pppRINUD);
      this.pppPanel.Controls.Add((Control) this.pppMaxRTNUD);
      this.pppPanel.Controls.Add((Control) this.pppWorkModeCB);
      this.pppPanel.Controls.Add((Control) this.pppPwdTB);
      this.pppPanel.Controls.Add((Control) this.pppUserNameTB);
      this.pppPanel.Controls.Add((Control) this.myLable10);
      this.pppPanel.Controls.Add((Control) this.myLable110);
      this.pppPanel.Controls.Add((Control) this.myLable111);
      this.pppPanel.Controls.Add((Control) this.myLable112);
      this.pppPanel.Controls.Add((Control) this.myLable113);
      this.pppPanel.Controls.Add((Control) this.myLable114);
      this.pppPanel.Controls.Add((Control) this.myLable115);
      this.pppPanel.Controls.Add((Control) this.myLable116);
      this.pppPanel.Controls.Add((Control) this.myLable117);
      this.pppPanel.Controls.Add((Control) this.myLable118);
      this.pppPanel.Controls.Add((Control) this.myLable119);
      this.pppPanel.Location = new Point(0, 0);
      this.pppPanel.Name = "pppPanel";
      this.pppPanel.Size = new Size(408, 273);
      this.pppPanel.TabIndex = 43;
      this.pppPanel.Visible = false;
      this.myLable120.Location = new Point(22, 214);
      this.myLable120.Name = "myLable120";
      this.myLable120.PropertyLabel = this.propertyL;
      this.myLable120.PropertyName = "PPPComID";
      this.myLable120.Size = new Size(66, 14);
      this.myLable120.TabIndex = 116;
      this.myLable120.Text = "Input/Output 1";
      this.myLable120.Visible = false;
      this.pppComCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.pppComCB.FormattingEnabled = true;
      this.pppComCB.Location = new Point(141, 211);
      this.pppComCB.Name = "pppComCB";
      this.pppComCB.Size = new Size(60, 20);
      this.pppComCB.TabIndex = 115;
      this.pppComCB.Visible = false;
      this.pppDNS2TB.Enabled = false;
      this.pppDNS2TB.Location = new Point(292, 153);
      this.pppDNS2TB.Name = "pppDNS2TB";
      this.pppDNS2TB.Size = new Size(100, 21);
      this.pppDNS2TB.TabIndex = 113;
      this.pppDNS2TB.Visible = false;
      this.pppDNS1TB.Enabled = false;
      this.pppDNS1TB.Location = new Point(292, 126);
      this.pppDNS1TB.Name = "pppDNS1TB";
      this.pppDNS1TB.Size = new Size(100, 21);
      this.pppDNS1TB.TabIndex = 112;
      this.pppDNS1TB.Visible = false;
      this.pppGatewayTB.Enabled = false;
      this.pppGatewayTB.Location = new Point(292, 99);
      this.pppGatewayTB.Name = "pppGatewayTB";
      this.pppGatewayTB.Size = new Size(100, 21);
      this.pppGatewayTB.TabIndex = 111;
      this.pppGatewayTB.Visible = false;
      this.pppIPTB.Enabled = false;
      this.pppIPTB.Location = new Point(292, 72);
      this.pppIPTB.Name = "pppIPTB";
      this.pppIPTB.Size = new Size(100, 21);
      this.pppIPTB.TabIndex = 110;
      this.pppIPTB.Visible = false;
      this.pppStatusTB.Enabled = false;
      this.pppStatusTB.Location = new Point(292, 45);
      this.pppStatusTB.Name = "pppStatusTB";
      this.pppStatusTB.Size = new Size(100, 21);
      this.pppStatusTB.TabIndex = 109;
      this.pppStatusTB.Visible = false;
      this.pppIDLENUD.Location = new Point(141, 179);
      NumericUpDown numericUpDown42 = this.pppIDLENUD;
      int[] bits42 = new int[4];
      bits42[0] = (int) ushort.MaxValue;
      Decimal num42 = new Decimal(bits42);
      numericUpDown42.Maximum = num42;
      this.pppIDLENUD.Name = "pppIDLENUD";
      this.pppIDLENUD.Size = new Size(60, 21);
      this.pppIDLENUD.TabIndex = 108;
      NumericUpDown numericUpDown43 = this.pppIDLENUD;
      int[] bits43 = new int[4];
      bits43[0] = 1;
      Decimal num43 = new Decimal(bits43);
      numericUpDown43.Value = num43;
      this.pppIDLENUD.Visible = false;
      this.pppRINUD.Location = new Point(141, 152);
      NumericUpDown numericUpDown44 = this.pppRINUD;
      int[] bits44 = new int[4];
      bits44[0] = (int) byte.MaxValue;
      Decimal num44 = new Decimal(bits44);
      numericUpDown44.Maximum = num44;
      this.pppRINUD.Name = "pppRINUD";
      this.pppRINUD.Size = new Size(60, 21);
      this.pppRINUD.TabIndex = 107;
      NumericUpDown numericUpDown45 = this.pppRINUD;
      int[] bits45 = new int[4];
      bits45[0] = 1;
      Decimal num45 = new Decimal(bits45);
      numericUpDown45.Value = num45;
      this.pppRINUD.Visible = false;
      this.pppMaxRTNUD.Location = new Point(141, 125);
      NumericUpDown numericUpDown46 = this.pppMaxRTNUD;
      int[] bits46 = new int[4];
      bits46[0] = (int) byte.MaxValue;
      Decimal num46 = new Decimal(bits46);
      numericUpDown46.Maximum = num46;
      this.pppMaxRTNUD.Name = "pppMaxRTNUD";
      this.pppMaxRTNUD.Size = new Size(60, 21);
      this.pppMaxRTNUD.TabIndex = 106;
      NumericUpDown numericUpDown47 = this.pppMaxRTNUD;
      int[] bits47 = new int[4];
      bits47[0] = 1;
      Decimal num47 = new Decimal(bits47);
      numericUpDown47.Value = num47;
      this.pppMaxRTNUD.Visible = false;
      this.pppWorkModeCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.pppWorkModeCB.FormattingEnabled = true;
      this.pppWorkModeCB.Items.AddRange(new object[4]
      {
        (object) "Disable",
        (object) "Dial_on_Demand",
        (object) "Auto_Dial",
        (object) "Adaptive"
      });
      this.pppWorkModeCB.Location = new Point(101, 99);
      this.pppWorkModeCB.Name = "pppWorkModeCB";
      this.pppWorkModeCB.Size = new Size(100, 20);
      this.pppWorkModeCB.TabIndex = 99;
      this.pppWorkModeCB.Visible = false;
      this.pppPwdTB.Location = new Point(101, 72);
      this.pppPwdTB.Name = "pppPwdTB";
      this.pppPwdTB.PasswordChar = '*';
      this.pppPwdTB.Size = new Size(100, 21);
      this.pppPwdTB.TabIndex = 96;
      this.pppPwdTB.Visible = false;
      this.pppUserNameTB.Location = new Point(101, 45);
      this.pppUserNameTB.Name = "pppUserNameTB";
      this.pppUserNameTB.Size = new Size(100, 21);
      this.pppUserNameTB.TabIndex = 95;
      this.pppUserNameTB.Visible = false;
      this.myLable10.Location = new Point(207, 157);
      this.myLable10.Name = "myLable10";
      this.myLable10.PropertyLabel = this.propertyL;
      this.myLable10.PropertyName = "PPPDNS2";
      this.myLable10.Size = new Size(54, 14);
      this.myLable10.TabIndex = 94;
      this.myLable10.Text = "Input/Output 1";
      this.myLable10.Visible = false;
      this.myLable110.Location = new Point(207, 129);
      this.myLable110.Name = "myLable110";
      this.myLable110.PropertyLabel = this.propertyL;
      this.myLable110.PropertyName = "PPPDNS1";
      this.myLable110.Size = new Size(54, 14);
      this.myLable110.TabIndex = 93;
      this.myLable110.Text = "Input/Output 1";
      this.myLable110.Visible = false;
      this.myLable111.Location = new Point(207, 104);
      this.myLable111.Name = "myLable111";
      this.myLable111.PropertyLabel = this.propertyL;
      this.myLable111.PropertyName = "PPPGateway";
      this.myLable111.Size = new Size(73, 14);
      this.myLable111.TabIndex = 92;
      this.myLable111.Text = "Input/Output 1";
      this.myLable111.Visible = false;
      this.myLable112.Location = new Point(207, 76);
      this.myLable112.Name = "myLable112";
      this.myLable112.PropertyLabel = this.propertyL;
      this.myLable112.PropertyName = "PPPIP";
      this.myLable112.Size = new Size(42, 14);
      this.myLable112.TabIndex = 91;
      this.myLable112.Text = "Input/Output 1";
      this.myLable112.Visible = false;
      this.myLable113.Location = new Point(207, 49);
      this.myLable113.Name = "myLable113";
      this.myLable113.PropertyLabel = this.propertyL;
      this.myLable113.PropertyName = "PPPStatus";
      this.myLable113.Size = new Size(66, 14);
      this.myLable113.TabIndex = 90;
      this.myLable113.Text = "Input/Output 1";
      this.myLable113.Visible = false;
      this.myLable114.Location = new Point(22, 183);
      this.myLable114.Name = "myLable114";
      this.myLable114.PropertyLabel = this.propertyL;
      this.myLable114.PropertyName = "PPPIDLETime";
      this.myLable114.Size = new Size(60, 14);
      this.myLable114.TabIndex = 89;
      this.myLable114.Text = "Input/Output 1";
      this.myLable114.Visible = false;
      this.myLable115.Location = new Point(22, 156);
      this.myLable115.Name = "myLable115";
      this.myLable115.PropertyLabel = this.propertyL;
      this.myLable115.PropertyName = "PPPRedialInterval";
      this.myLable115.Size = new Size(97, 14);
      this.myLable115.TabIndex = 88;
      this.myLable115.Text = "Input/Output 1";
      this.myLable115.Visible = false;
      this.myLable116.Location = new Point(22, 129);
      this.myLable116.Name = "myLable116";
      this.myLable116.PropertyLabel = this.propertyL;
      this.myLable116.PropertyName = "PPPMaxRedialTimes";
      this.myLable116.Size = new Size(103, 14);
      this.myLable116.TabIndex = 87;
      this.myLable116.Text = "Input/Output 1";
      this.myLable116.Visible = false;
      this.myLable117.Location = new Point(22, 102);
      this.myLable117.Name = "myLable117";
      this.myLable117.PropertyLabel = this.propertyL;
      this.myLable117.PropertyName = "PPPWorkMode";
      this.myLable117.Size = new Size(60, 14);
      this.myLable117.TabIndex = 86;
      this.myLable117.Text = "Input/Output 1";
      this.myLable117.Visible = false;
      this.myLable118.Location = new Point(22, 75);
      this.myLable118.Name = "myLable118";
      this.myLable118.PropertyLabel = this.propertyL;
      this.myLable118.PropertyName = "PPPPassword";
      this.myLable118.Size = new Size(54, 14);
      this.myLable118.TabIndex = 85;
      this.myLable118.Text = "Input/Output 1";
      this.myLable118.Visible = false;
      this.myLable119.Location = new Point(22, 48);
      this.myLable119.Name = "myLable119";
      this.myLable119.PropertyLabel = this.propertyL;
      this.myLable119.PropertyName = "PPPUserName";
      this.myLable119.Size = new Size(60, 14);
      this.myLable119.TabIndex = 84;
      this.myLable119.Text = "Input/Output 1";
      this.myLable119.Visible = false;
      this.gprsPanel.Controls.Add((Control) this.gprsDNS2TB);
      this.gprsPanel.Controls.Add((Control) this.gprsDNS1TB);
      this.gprsPanel.Controls.Add((Control) this.gprsGatewayTB);
      this.gprsPanel.Controls.Add((Control) this.gprsIPTB);
      this.gprsPanel.Controls.Add((Control) this.gprsStatusTB);
      this.gprsPanel.Controls.Add((Control) this.myLable131);
      this.gprsPanel.Controls.Add((Control) this.myLable132);
      this.gprsPanel.Controls.Add((Control) this.myLable133);
      this.gprsPanel.Controls.Add((Control) this.myLable134);
      this.gprsPanel.Controls.Add((Control) this.myLable135);
      this.gprsPanel.Controls.Add((Control) this.myLable126);
      this.gprsPanel.Controls.Add((Control) this.gprsComCB);
      this.gprsPanel.Controls.Add((Control) this.gprsIDLENUD);
      this.gprsPanel.Controls.Add((Control) this.gprsRINUD);
      this.gprsPanel.Controls.Add((Control) this.gprsMaxRTNUD);
      this.gprsPanel.Controls.Add((Control) this.gprsWorkModeCB);
      this.gprsPanel.Controls.Add((Control) this.myLable127);
      this.gprsPanel.Controls.Add((Control) this.myLable128);
      this.gprsPanel.Controls.Add((Control) this.myLable129);
      this.gprsPanel.Controls.Add((Control) this.myLable130);
      this.gprsPanel.Controls.Add((Control) this.myLable125);
      this.gprsPanel.Controls.Add((Control) this.gprsAPNTB);
      this.gprsPanel.Controls.Add((Control) this.myLable121);
      this.gprsPanel.Controls.Add((Control) this.myLable124);
      this.gprsPanel.Controls.Add((Control) this.serviceCodeTB);
      this.gprsPanel.Controls.Add((Control) this.myLable123);
      this.gprsPanel.Controls.Add((Control) this.gprsPwdTB);
      this.gprsPanel.Controls.Add((Control) this.myLable122);
      this.gprsPanel.Controls.Add((Control) this.supinTB);
      this.gprsPanel.Controls.Add((Control) this.gprsUserTB);
      this.gprsPanel.Location = new Point(0, 0);
      this.gprsPanel.Name = "gprsPanel";
      this.gprsPanel.Size = new Size(408, 273);
      this.gprsPanel.TabIndex = 44;
      this.gprsPanel.Visible = false;
      this.gprsDNS2TB.Enabled = false;
      this.gprsDNS2TB.Location = new Point(296, 224);
      this.gprsDNS2TB.Name = "gprsDNS2TB";
      this.gprsDNS2TB.Size = new Size(100, 21);
      this.gprsDNS2TB.TabIndex = 136;
      this.gprsDNS2TB.Visible = false;
      this.gprsDNS1TB.Enabled = false;
      this.gprsDNS1TB.Location = new Point(296, 197);
      this.gprsDNS1TB.Name = "gprsDNS1TB";
      this.gprsDNS1TB.Size = new Size(100, 21);
      this.gprsDNS1TB.TabIndex = 135;
      this.gprsDNS1TB.Visible = false;
      this.gprsGatewayTB.Enabled = false;
      this.gprsGatewayTB.Location = new Point(296, 170);
      this.gprsGatewayTB.Name = "gprsGatewayTB";
      this.gprsGatewayTB.Size = new Size(100, 21);
      this.gprsGatewayTB.TabIndex = 134;
      this.gprsGatewayTB.Visible = false;
      this.gprsIPTB.Enabled = false;
      this.gprsIPTB.Location = new Point(296, 143);
      this.gprsIPTB.Name = "gprsIPTB";
      this.gprsIPTB.Size = new Size(100, 21);
      this.gprsIPTB.TabIndex = 133;
      this.gprsIPTB.Visible = false;
      this.gprsStatusTB.Enabled = false;
      this.gprsStatusTB.Location = new Point(296, 116);
      this.gprsStatusTB.Name = "gprsStatusTB";
      this.gprsStatusTB.Size = new Size(100, 21);
      this.gprsStatusTB.TabIndex = 132;
      this.gprsStatusTB.Visible = false;
      this.myLable131.Location = new Point(211, 228);
      this.myLable131.Name = "myLable131";
      this.myLable131.PropertyLabel = this.propertyL;
      this.myLable131.PropertyName = "GPRSDNS2";
      this.myLable131.Size = new Size(60, 14);
      this.myLable131.TabIndex = 131;
      this.myLable131.Text = "Input/Output 1";
      this.myLable131.Visible = false;
      this.myLable132.Location = new Point(211, 200);
      this.myLable132.Name = "myLable132";
      this.myLable132.PropertyLabel = this.propertyL;
      this.myLable132.PropertyName = "GPRSDNS1";
      this.myLable132.Size = new Size(60, 14);
      this.myLable132.TabIndex = 130;
      this.myLable132.Text = "Input/Output 1";
      this.myLable132.Visible = false;
      this.myLable133.Location = new Point(211, 175);
      this.myLable133.Name = "myLable133";
      this.myLable133.PropertyLabel = this.propertyL;
      this.myLable133.PropertyName = "GPRSGateway";
      this.myLable133.Size = new Size(79, 14);
      this.myLable133.TabIndex = 129;
      this.myLable133.Text = "Input/Output 1";
      this.myLable133.Visible = false;
      this.myLable134.Location = new Point(211, 147);
      this.myLable134.Name = "myLable134";
      this.myLable134.PropertyLabel = this.propertyL;
      this.myLable134.PropertyName = "GPRSIP";
      this.myLable134.Size = new Size(48, 14);
      this.myLable134.TabIndex = 128;
      this.myLable134.Text = "Input/Output 1";
      this.myLable134.Visible = false;
      this.myLable135.Location = new Point(211, 120);
      this.myLable135.Name = "myLable135";
      this.myLable135.PropertyLabel = this.propertyL;
      this.myLable135.PropertyName = "GPRSStatus";
      this.myLable135.Size = new Size(73, 14);
      this.myLable135.TabIndex = (int) sbyte.MaxValue;
      this.myLable135.Text = "Input/Output 1";
      this.myLable135.Visible = false;
      this.myLable126.Location = new Point(14, 227);
      this.myLable126.Name = "myLable126";
      this.myLable126.PropertyLabel = this.propertyL;
      this.myLable126.PropertyName = "GPRSComID";
      this.myLable126.Size = new Size(73, 14);
      this.myLable126.TabIndex = 126;
      this.myLable126.Text = "Input/Output 1";
      this.myLable126.Visible = false;
      this.gprsComCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.gprsComCB.FormattingEnabled = true;
      this.gprsComCB.Location = new Point(143, 223);
      this.gprsComCB.Name = "gprsComCB";
      this.gprsComCB.Size = new Size(60, 20);
      this.gprsComCB.TabIndex = 125;
      this.gprsComCB.Visible = false;
      this.gprsIDLENUD.Location = new Point(143, 196);
      NumericUpDown numericUpDown48 = this.gprsIDLENUD;
      int[] bits48 = new int[4];
      bits48[0] = (int) ushort.MaxValue;
      Decimal num48 = new Decimal(bits48);
      numericUpDown48.Maximum = num48;
      this.gprsIDLENUD.Name = "gprsIDLENUD";
      this.gprsIDLENUD.Size = new Size(60, 21);
      this.gprsIDLENUD.TabIndex = 124;
      NumericUpDown numericUpDown49 = this.gprsIDLENUD;
      int[] bits49 = new int[4];
      bits49[0] = 1;
      Decimal num49 = new Decimal(bits49);
      numericUpDown49.Value = num49;
      this.gprsIDLENUD.Visible = false;
      this.gprsRINUD.Location = new Point(143, 169);
      NumericUpDown numericUpDown50 = this.gprsRINUD;
      int[] bits50 = new int[4];
      bits50[0] = (int) byte.MaxValue;
      Decimal num50 = new Decimal(bits50);
      numericUpDown50.Maximum = num50;
      this.gprsRINUD.Name = "gprsRINUD";
      this.gprsRINUD.Size = new Size(60, 21);
      this.gprsRINUD.TabIndex = 123;
      NumericUpDown numericUpDown51 = this.gprsRINUD;
      int[] bits51 = new int[4];
      bits51[0] = 1;
      Decimal num51 = new Decimal(bits51);
      numericUpDown51.Value = num51;
      this.gprsRINUD.Visible = false;
      this.gprsMaxRTNUD.Location = new Point(143, 142);
      NumericUpDown numericUpDown52 = this.gprsMaxRTNUD;
      int[] bits52 = new int[4];
      bits52[0] = (int) byte.MaxValue;
      Decimal num52 = new Decimal(bits52);
      numericUpDown52.Maximum = num52;
      this.gprsMaxRTNUD.Name = "gprsMaxRTNUD";
      this.gprsMaxRTNUD.Size = new Size(60, 21);
      this.gprsMaxRTNUD.TabIndex = 122;
      NumericUpDown numericUpDown53 = this.gprsMaxRTNUD;
      int[] bits53 = new int[4];
      bits53[0] = 1;
      Decimal num53 = new Decimal(bits53);
      numericUpDown53.Value = num53;
      this.gprsMaxRTNUD.Visible = false;
      this.gprsWorkModeCB.DropDownStyle = ComboBoxStyle.DropDownList;
      this.gprsWorkModeCB.FormattingEnabled = true;
      this.gprsWorkModeCB.Items.AddRange(new object[4]
      {
        (object) "Disable",
        (object) "Dial_on_Demand",
        (object) "Auto_Dial",
        (object) "Adaptive"
      });
      this.gprsWorkModeCB.Location = new Point(103, 116);
      this.gprsWorkModeCB.Name = "gprsWorkModeCB";
      this.gprsWorkModeCB.Size = new Size(100, 20);
      this.gprsWorkModeCB.TabIndex = 121;
      this.gprsWorkModeCB.Visible = false;
      this.myLable127.Location = new Point(14, 200);
      this.myLable127.Name = "myLable127";
      this.myLable127.PropertyLabel = this.propertyL;
      this.myLable127.PropertyName = "GPRSIDLETime";
      this.myLable127.Size = new Size(60, 14);
      this.myLable127.TabIndex = 120;
      this.myLable127.Text = "Input/Output 1";
      this.myLable127.Visible = false;
      this.myLable128.Location = new Point(14, 173);
      this.myLable128.Name = "myLable128";
      this.myLable128.PropertyLabel = this.propertyL;
      this.myLable128.PropertyName = "GPRSRedialInterval";
      this.myLable128.Size = new Size(97, 14);
      this.myLable128.TabIndex = 119;
      this.myLable128.Text = "Input/Output 1";
      this.myLable128.Visible = false;
      this.myLable129.Location = new Point(14, 146);
      this.myLable129.Name = "myLable129";
      this.myLable129.PropertyLabel = this.propertyL;
      this.myLable129.PropertyName = "GPRSMaxRedialTimes";
      this.myLable129.Size = new Size(103, 14);
      this.myLable129.TabIndex = 118;
      this.myLable129.Text = "Input/Output 1";
      this.myLable129.Visible = false;
      this.myLable130.Location = new Point(14, 119);
      this.myLable130.Name = "myLable130";
      this.myLable130.PropertyLabel = this.propertyL;
      this.myLable130.PropertyName = "PPPWorkMode";
      this.myLable130.Size = new Size(60, 14);
      this.myLable130.TabIndex = 117;
      this.myLable130.Text = "Input/Output 1";
      this.myLable130.Visible = false;
      this.myLable125.Location = new Point(210, 66);
      this.myLable125.Name = "myLable125";
      this.myLable125.PropertyLabel = this.propertyL;
      this.myLable125.PropertyName = "GPRSAPN";
      this.myLable125.Size = new Size(110, 14);
      this.myLable125.TabIndex = 108;
      this.myLable125.Text = "Input/Output 1";
      this.myLable125.Visible = false;
      this.gprsAPNTB.Location = new Point(296, 88);
      this.gprsAPNTB.Name = "gprsAPNTB";
      this.gprsAPNTB.Size = new Size(100, 21);
      this.gprsAPNTB.TabIndex = 107;
      this.myLable121.Location = new Point(14, 40);
      this.myLable121.Name = "myLable121";
      this.myLable121.PropertyLabel = this.propertyL;
      this.myLable121.PropertyName = "ServiceCode";
      this.myLable121.Size = new Size(79, 14);
      this.myLable121.TabIndex = 103;
      this.myLable121.Text = "Input/Output 1";
      this.myLable121.Visible = false;
      this.myLable124.Location = new Point(210, 40);
      this.myLable124.Name = "myLable124";
      this.myLable124.PropertyLabel = this.propertyL;
      this.myLable124.PropertyName = "GPRSSINUIMPIN";
      this.myLable124.Size = new Size(73, 14);
      this.myLable124.TabIndex = 106;
      this.myLable124.Text = "Input/Output 1";
      this.myLable124.Visible = false;
      this.serviceCodeTB.Location = new Point(103, 35);
      this.serviceCodeTB.Name = "serviceCodeTB";
      this.serviceCodeTB.Size = new Size(100, 21);
      this.serviceCodeTB.TabIndex = 99;
      this.myLable123.Location = new Point(14, 92);
      this.myLable123.Name = "myLable123";
      this.myLable123.PropertyLabel = this.propertyL;
      this.myLable123.PropertyName = "GPRSPPPPassword";
      this.myLable123.Size = new Size(79, 14);
      this.myLable123.TabIndex = 105;
      this.myLable123.Text = "Input/Output 1";
      this.myLable123.Visible = false;
      this.gprsPwdTB.Location = new Point(103, 89);
      this.gprsPwdTB.Name = "gprsPwdTB";
      this.gprsPwdTB.PasswordChar = '*';
      this.gprsPwdTB.Size = new Size(100, 21);
      this.gprsPwdTB.TabIndex = 101;
      this.myLable122.Location = new Point(14, 66);
      this.myLable122.Name = "myLable122";
      this.myLable122.PropertyLabel = this.propertyL;
      this.myLable122.PropertyName = "GPRSPPPUserName";
      this.myLable122.Size = new Size(85, 14);
      this.myLable122.TabIndex = 104;
      this.myLable122.Text = "Input/Output 1";
      this.myLable122.Visible = false;
      this.supinTB.Location = new Point(296, 36);
      this.supinTB.Name = "supinTB";
      this.supinTB.Size = new Size(100, 21);
      this.supinTB.TabIndex = 102;
      this.gprsUserTB.Location = new Point(103, 62);
      this.gprsUserTB.Name = "gprsUserTB";
      this.gprsUserTB.Size = new Size(100, 21);
      this.gprsUserTB.TabIndex = 100;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.networkPanel);
      this.Controls.Add((Control) this.propertyL);
      this.Controls.Add((Control) this.basicPanel);
      this.Controls.Add((Control) this.gprsPanel);
      this.Controls.Add((Control) this.pppPanel);
      this.Controls.Add((Control) this.powerPanel);
      this.Controls.Add((Control) this.serialPanel);
      this.Controls.Add((Control) this.connectionPanel);
      this.Controls.Add((Control) this.pppoePanel);
      this.Controls.Add((Control) this.pinsPanel);
      this.Controls.Add((Control) this.passwordPanel);
      this.Controls.Add((Control) this.histlistPanel);
      this.Controls.Add((Control) this.inputTriggerPanel);
      this.Controls.Add((Control) this.triggerPanel);
      this.Controls.Add((Control) this.emailPanel);
      this.Controls.Add((Control) this.serverPanel);
      this.Name = "MyPanel";
      this.Size = new Size(822, 315);
      this.basicPanel.ResumeLayout(false);
      this.basicPanel.PerformLayout();
      this.networkPanel.ResumeLayout(false);
      this.networkPanel.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.serverPanel.ResumeLayout(false);
      this.serverPanel.PerformLayout();
      this.httpPortNUD.EndInit();
      this.arpNUD.EndInit();
      this.emailPanel.ResumeLayout(false);
      this.emailPanel.PerformLayout();
      this.smtpPNUD.EndInit();
      this.triggerPanel.ResumeLayout(false);
      this.triggerPanel.PerformLayout();
      this.minNotifyNUD.EndInit();
      this.inputTriggerPanel.ResumeLayout(false);
      this.inputTriggerPanel.PerformLayout();
      this.reNotifyNUD.EndInit();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.inputMNINUD.EndInit();
      this.histlistPanel.ResumeLayout(false);
      this.histlistPanel.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.retryTNUD.EndInit();
      this.retryCNUD.EndInit();
      this.passwordPanel.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.pinsPanel.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.pppoePanel.ResumeLayout(false);
      this.pppoePanel.PerformLayout();
      this.ppoeIDLENUD.EndInit();
      this.pppoeRINUD.EndInit();
      this.pppoeMaxRTNUD.EndInit();
      this.connectionPanel.ResumeLayout(false);
      this.connectionPanel.PerformLayout();
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      this.inactivityNUD.EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.dnsQueryPeriodNUD.EndInit();
      this.tcpRemotePortNUD.EndInit();
      this.tcpLocalPortNUD.EndInit();
      this.udpUCLPNUD.EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.udpPort0TB.EndInit();
      this.udpPort1TB.EndInit();
      this.udpPort2TB.EndInit();
      this.udpPort3TB.EndInit();
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.udpRemotePortNUD.EndInit();
      this.udpLocalPortNUD.EndInit();
      this.serialPanel.ResumeLayout(false);
      this.serialPanel.PerformLayout();
      this.panel9.ResumeLayout(false);
      this.panel9.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.powerPanel.ResumeLayout(false);
      this.powerPanel.PerformLayout();
      this.pppPanel.ResumeLayout(false);
      this.pppPanel.PerformLayout();
      this.pppIDLENUD.EndInit();
      this.pppRINUD.EndInit();
      this.pppMaxRTNUD.EndInit();
      this.gprsPanel.ResumeLayout(false);
      this.gprsPanel.PerformLayout();
      this.gprsIDLENUD.EndInit();
      this.gprsRINUD.EndInit();
      this.gprsMaxRTNUD.EndInit();
      this.ResumeLayout(false);
    }
  }
}
