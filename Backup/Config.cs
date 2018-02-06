// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Config
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DeviceManagement
{
  public class Config : Form
  {
    internal const string DEFAULT_PANEL_NAME = "Basic Setting";
    private byte channelID;
    private bool canNotChange;
    private PanelTypes panelType;
    private IContainer components;
    private TableLayoutPanel tableLayoutPanel1;
    private TreeView treeView1;
    private Panel buttonPanel;
    private Button button2;
    private Button button1;
    private Button button4;
    private MyPanel myPanel1;

    public PanelTypes PanelType
    {
      get
      {
        return this.panelType;
      }
      set
      {
        this.panelType = value;
      }
    }

    public Device SelectDevice
    {
      get
      {
        return this.myPanel1.SelectDevice;
      }
      set
      {
        this.SetSelectDevice(value);
      }
    }

    public Config()
    {
      this.InitializeComponent();
    }

    private void setNodeVisable(string text, bool visable)
    {
      for (int index = 0; index < this.treeView1.Nodes.Count; ++index)
      {
        if (this.treeView1.Nodes[index].Text == text)
        {
          if (visable)
            return;
          this.treeView1.Nodes.RemoveAt(index);
          return;
        }
      }
      if (!visable)
        return;
      TreeNode node = new TreeNode(text);
      if (text == "Email")
      {
        node.Nodes.Add("Email Settings");
        node.Nodes.Add("Trigger Settings");
        node.Nodes.Add("Input Trigger Settings");
      }
      this.treeView1.Nodes.Insert(4, node);
    }

    private TreeNode GetSelectNode(string nodeText, TreeNodeCollection nodes)
    {
      if (nodes == null || nodes.Count == 0)
        return (TreeNode) null;
      foreach (TreeNode treeNode in nodes)
      {
        if (treeNode.Text == nodeText)
          return treeNode;
        TreeNode selectNode = this.GetSelectNode(nodeText, treeNode.Nodes);
        if (selectNode != null)
          return selectNode;
      }
      return (TreeNode) null;
    }

    private PanelTypes GetPanelType(string nodeText, ref byte channelNumber)
    {
      switch (nodeText)
      {
        case "Basic Setting":
          return PanelTypes.BasicSetting;
        case "Network":
          return PanelTypes.NetworkSetting;
        case "Server":
          return PanelTypes.ServerSetting;
        case "Email Settings":
          return PanelTypes.EmailSetting;
        case "Trigger Settings":
          return PanelTypes.TriggerSetting;
        case "Input Trigger Settings":
          return PanelTypes.InputTriggerSetting;
        case "Pins Configurations":
          return PanelTypes.PinsSetting;
        case "Password Setting":
          return PanelTypes.ChangePassword;
        case "Apply Settings/Restart":
          return PanelTypes.PowerManage;
        default:
          if (nodeText.IndexOf("Hostlist") != -1)
          {
            channelNumber = byte.Parse(nodeText.Substring(8));
            return PanelTypes.HostlistSetting;
          }
          if (nodeText.IndexOf("Serial Setting") != -1)
          {
            channelNumber = byte.Parse(nodeText.Substring(14));
            return PanelTypes.SerialSetting;
          }
          if (nodeText.IndexOf("Connection") == -1)
            return PanelTypes.BasicSetting;
          channelNumber = byte.Parse(nodeText.Substring(10));
          return PanelTypes.ConnectionSetting;
      }
    }

    private void SetSelectDevice(Device device)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new Config.SetSelectDeviceDele(this.SetSelectDevice), (object) device);
      }
      else
      {
        switch (device.lastPanelType)
        {
          case "Log Out":
            this.treeView1.SelectedNode = this.treeView1.Nodes[0];
            break;
        }
        if (this.myPanel1.SelectDevice == device)
          return;
        this.canNotChange = true;
        this.treeView1.Nodes[3].Nodes.Clear();
        Controller.GetChannels(device);
        if (device.ChannelList.Count == 0)
        {
          Program.ShowMessage("No Serial!", true);
          this.Close();
        }
        else
        {
          for (int index = 0; index < device.ChannelList.Count; ++index)
          {
            this.treeView1.Nodes[3].Nodes.Add("Channel" + device.ChannelList[index].getChannelName());
            this.treeView1.Nodes[3].Nodes[index].Nodes.Add("Hostlist" + device.ChannelList[index].getChannelName());
            this.treeView1.Nodes[3].Nodes[index].Nodes.Add("Serial Setting" + device.ChannelList[index].getChannelName());
            this.treeView1.Nodes[3].Nodes[index].Nodes.Add("Connection" + device.ChannelList[index].getChannelName());
            if (index == 0)
              this.channelID = device.ChannelList[index].GetChannelNum();
          }
          this.setNodeVisable("Pins Configurations", device.CanPins);
          this.setNodeVisable("Email", device.CanEmail);
          this.setNodeVisable("GPRS Setting", device.CanGPRS);
          this.setNodeVisable("PPP Setting", device.CanPPP);
          this.setNodeVisable("PPPOE Setting", device.CanPPPOE);
          this.treeView1.SelectedNode = this.GetSelectNode(device.lastPanelType, this.treeView1.Nodes);
          this.panelType = this.GetPanelType(this.treeView1.SelectedNode.Text, ref this.channelID);
          this.canNotChange = false;
          this.myPanel1.SetSelectDevice(device, this.panelType, this.channelID);
        }
      }
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (this.canNotChange)
        return;
      switch (e.Node.Text)
      {
        case "Basic Setting":
          this.panelType = PanelTypes.BasicSetting;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "Network":
          this.panelType = PanelTypes.NetworkSetting;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "Server":
          this.panelType = PanelTypes.ServerSetting;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "Email Settings":
          this.panelType = PanelTypes.EmailSetting;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "Trigger Settings":
          this.panelType = PanelTypes.TriggerSetting;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "Input Trigger Settings":
          this.panelType = PanelTypes.InputTriggerSetting;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "Pins Configurations":
          this.panelType = PanelTypes.PinsSetting;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "Password Setting":
          this.panelType = PanelTypes.ChangePassword;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "PPPOE Setting":
          this.panelType = PanelTypes.PPPOESetting;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "PPP Setting":
          this.panelType = PanelTypes.PPPSetting;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "GPRS Setting":
          this.panelType = PanelTypes.GPRSSetting;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "Apply Settings/Restart":
          this.panelType = PanelTypes.PowerManage;
          this.myPanel1.initPanel(this.panelType);
          break;
        case "Log Out":
          if (MessageBox.Show((IWin32Window) this, Message.LogOut, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
          {
            ResponseTypes responseType = Controller.Logout(this.SelectDevice);
            Controller.OptionMassage(responseType);
            if (responseType == ResponseTypes.OK)
            {
              this.DialogResult = DialogResult.Cancel;
              this.SelectDevice.UserName = "";
              this.SelectDevice.UserPsw = "";
              this.SelectDevice.IsLogged = false;
              this.SelectDevice.BasicSetting = false;
              this.SelectDevice.NetworkSetting = false;
              this.SelectDevice.ServerSetting = false;
              this.SelectDevice.EmailSetting = false;
              this.SelectDevice.TriggerSetting = false;
              this.SelectDevice.InputTriggerSetting = false;
              this.SelectDevice.PinsSetting = false;
              this.SelectDevice.PPPOESetting = false;
              IEnumerator enumerator = this.SelectDevice.ChannelList.GetEnumerator();
              try
              {
                while (enumerator.MoveNext())
                {
                  Channel channel = (Channel) enumerator.Current;
                  channel.ConnectionSetting = false;
                  channel.SerialSetting = false;
                  channel.HostlistSetting = false;
                }
                break;
              }
              finally
              {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable != null)
                  disposable.Dispose();
              }
            }
            else
              break;
          }
          else
          {
            this.treeView1.SelectedNode = this.GetSelectNode(this.myPanel1.SelectDevice.lastPanelType, this.treeView1.Nodes);
            break;
          }
        default:
          if (e.Node.Text.IndexOf("Hostlist") != -1)
          {
            this.panelType = PanelTypes.HostlistSetting;
            this.myPanel1.initPanel(this.panelType, Channel.getChannelID(e.Node.Text.Substring(8)));
            break;
          }
          if (e.Node.Text.IndexOf("Serial Setting") != -1)
          {
            this.panelType = PanelTypes.SerialSetting;
            this.myPanel1.initPanel(this.panelType, Channel.getChannelID(e.Node.Text.Substring(14)));
            break;
          }
          if (e.Node.Text.IndexOf("Connection") != -1)
          {
            this.panelType = PanelTypes.ConnectionSetting;
            this.myPanel1.initPanel(this.panelType, Channel.getChannelID(e.Node.Text.Substring(10)));
            break;
          }
          break;
      }
      this.myPanel1.SelectDevice.lastPanelType = e.Node.Text;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.button4.Enabled = false;
      Program.ShowMessage(Message.Updateing, false);
      if (this.panelType == PanelTypes.PowerManage)
      {
        if (this.myPanel1.setValue())
        {
          if (this.SelectDevice.IsNewVersion)
          {
            if (this.myPanel1.RebootType == RebootTypes.LOAD_DEFAULTS)
            {
              this.SelectDevice.ResetSetting();
            }
            else
            {
              Program.mainForm.DeleteDevice(this.SelectDevice);
              this.DialogResult = DialogResult.Cancel;
            }
          }
          else
          {
            Program.mainForm.DeleteDevice(this.SelectDevice);
            this.DialogResult = DialogResult.Cancel;
          }
        }
      }
      else
      {
        this.myPanel1.setValue();
        if (this.panelType != PanelTypes.ChangePassword)
          this.myPanel1.getValue();
        this.myPanel1.initValue();
      }
      this.button4.Enabled = true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.button1.Enabled = false;
      Program.ShowMessage(Message.Refreshing, false);
      this.myPanel1.getValue();
      this.myPanel1.initValue();
      this.button1.Enabled = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      TreeNode treeNode1 = new TreeNode("Basic Setting");
      TreeNode treeNode2 = new TreeNode("Network");
      TreeNode treeNode3 = new TreeNode("Server");
      TreeNode treeNode4 = new TreeNode("Channels");
      TreeNode treeNode5 = new TreeNode("Email Settings");
      TreeNode treeNode6 = new TreeNode("Trigger Settings");
      TreeNode treeNode7 = new TreeNode("Input Trigger Settings");
      TreeNode treeNode8 = new TreeNode("Email", new TreeNode[3]
      {
        treeNode5,
        treeNode6,
        treeNode7
      });
      TreeNode treeNode9 = new TreeNode("Pins Configurations");
      TreeNode treeNode10 = new TreeNode("Password Setting");
      TreeNode treeNode11 = new TreeNode("Apply Settings/Restart");
      TreeNode treeNode12 = new TreeNode("Log Out");
      this.tableLayoutPanel1 = new TableLayoutPanel();
      this.treeView1 = new TreeView();
      this.buttonPanel = new Panel();
      this.button4 = new Button();
      this.button2 = new Button();
      this.button1 = new Button();
      this.myPanel1 = new MyPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.buttonPanel.SuspendLayout();
      this.SuspendLayout();
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75f));
      this.tableLayoutPanel1.Controls.Add((Control) this.treeView1, 0, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.buttonPanel, 1, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.myPanel1, 1, 0);
      this.tableLayoutPanel1.Dock = DockStyle.Fill;
      this.tableLayoutPanel1.Location = new Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.56047f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.439528f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel1.Size = new Size(552, 355);
      this.tableLayoutPanel1.TabIndex = 0;
      this.treeView1.Dock = DockStyle.Fill;
      this.treeView1.Location = new Point(3, 3);
      this.treeView1.Name = "treeView1";
      treeNode1.Name = "basicNode";
      treeNode1.Text = "Basic Setting";
      treeNode2.Name = "networkNode";
      treeNode2.Text = "Network";
      treeNode3.Name = "serverNode";
      treeNode3.Text = "Server";
      treeNode4.Name = "channelsNode";
      treeNode4.Text = "Channels";
      treeNode5.Name = "emailsetNode";
      treeNode5.Text = "Email Settings";
      treeNode6.Name = "triggerNode";
      treeNode6.Text = "Trigger Settings";
      treeNode7.Name = "inputTNode";
      treeNode7.Text = "Input Trigger Settings";
      treeNode8.Name = "emailNode";
      treeNode8.Text = "Email";
      treeNode9.Name = "pinsNode";
      treeNode9.Text = "Pins Configurations";
      treeNode10.Name = "passwordNode";
      treeNode10.Text = "Password Setting";
      treeNode11.Name = "applyNode";
      treeNode11.Text = "Apply Settings/Restart";
      treeNode12.Name = "logoutNode";
      treeNode12.Text = "Log Out";
      this.treeView1.Nodes.AddRange(new TreeNode[9]
      {
        treeNode1,
        treeNode2,
        treeNode3,
        treeNode4,
        treeNode8,
        treeNode9,
        treeNode10,
        treeNode11,
        treeNode12
      });
      this.tableLayoutPanel1.SetRowSpan((Control) this.treeView1, 2);
      this.treeView1.Size = new Size(132, 349);
      this.treeView1.TabIndex = 0;
      this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
      this.buttonPanel.Controls.Add((Control) this.button4);
      this.buttonPanel.Controls.Add((Control) this.button2);
      this.buttonPanel.Controls.Add((Control) this.button1);
      this.buttonPanel.Dock = DockStyle.Fill;
      this.buttonPanel.Location = new Point(141, 324);
      this.buttonPanel.Name = "buttonPanel";
      this.buttonPanel.Size = new Size(408, 28);
      this.buttonPanel.TabIndex = 2;
      this.button4.Location = new Point(249, 3);
      this.button4.Name = "button4";
      this.button4.Size = new Size(75, 23);
      this.button4.TabIndex = 2;
      this.button4.Text = "OK";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button2.DialogResult = DialogResult.Cancel;
      this.button2.Location = new Point(330, 3);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Close";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.Location = new Point(3, 3);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Refresh";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.myPanel1.Dock = DockStyle.Fill;
      this.myPanel1.Location = new Point(141, 3);
      this.myPanel1.Name = "myPanel1";
      this.myPanel1.Size = new Size(408, 315);
      this.myPanel1.TabIndex = 3;
      this.AcceptButton = (IButtonControl) this.button4;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button2;
      this.ClientSize = new Size(552, 355);
      this.Controls.Add((Control) this.tableLayoutPanel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "Config";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Config";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.buttonPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private delegate void SetSelectDeviceDele(Device device);
  }
}
