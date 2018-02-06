// Decompiled with JetBrains decompiler
// Type: DeviceManagement.MainForm
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using DeviceManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DeviceManagement
{
  public class MainForm : Form
  {
    private static object syncRoot = new object();
    private List<Device> deviceList = new List<Device>();
    private SearchForm searchDialog = new SearchForm();
    private bool isSearch;
    private Config _configD;
    private IContainer components;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem operateToolStripMenuItem;
    private ToolStripMenuItem searchToolStripMenuItem;
    private ToolStripMenuItem specifySearchToolStripMenuItem;
    private ToolStripMenuItem clearToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem languageToolStripMenuItem;
    private ToolStripMenuItem englishToolStripMenuItem;
    private ToolStripMenuItem chineseSimplifiedToolStripMenuItem;
    private ToolStripMenuItem chineseTraditionalToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem updateToolStripMenuItem;
    private ToolStripButton searchTSB;
    private ToolStripButton spSearchTSB;
    private ToolStripButton clearTSB;
    private StatusStrip statusStrip1;
    private ToolStripProgressBar toolStripProgressBar1;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton IETSB;
    private ToolStripButton telnetTSB;
    private ToolStripButton pingTSB;
    private Panel panel1;
    private ListView deviceListView;
    private PictureBox pictureBox1;
    private TableLayoutPanel tableLayoutPanel1;
    private Label label1;
    private Label label3;
    private Label label2;
    private Label sysL;
    private Label label6;
    private Label label4;
    private Label label7;
    private Label nameL;
    private Label macL;
    private Label ipL;
    private Label serialL;
    private Label firmwareL;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripStatusLabel statusLabel1;
    private ToolStripButton configTSB;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem configToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripButton closeTSB;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem iEToolStripMenuItem;
    private ToolStripMenuItem telnetToolStripMenuItem;
    private ToolStripMenuItem pingToolStripMenuItem;
    private Label label14;
    private Label label5;
    private ToolStrip toolStrip1;
    private ColumnHeader deviceName;
    private ColumnHeader ipAddress;
    private ColumnHeader physical;
    private ImageList imageList1;
    private ImageList imageList2;
    private ToolStripDropDownButton viewTSB;
    private ToolStripMenuItem largeIconToolStripMenuItem;
    private ToolStripMenuItem detailsToolStripMenuItem;
    private ToolStripMenuItem smallIconToolStripMenuItem;
    private ToolStripMenuItem listToolStripMenuItem;
    private ToolStripMenuItem tileToolStripMenuItem;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem searchToolStripMenuItem1;
    private ToolStripMenuItem specifySearchToolStripMenuItem1;
    private ToolStripMenuItem clearToolStripMenuItem1;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripMenuItem configToolStripMenuItem1;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripMenuItem iEToolStripMenuItem1;
    private ToolStripMenuItem telnetToolStripMenuItem1;
    private ToolStripMenuItem pingToolStripMenuItem1;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripMenuItem exitToolStripMenuItem1;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem largeToolStripMenuItem;
    private ToolStripMenuItem tileToolStripMenuItem1;
    private ToolStripMenuItem smallIconToolStripMenuItem1;
    private ToolStripMenuItem listToolStripMenuItem1;
    private ToolStripMenuItem detailsToolStripMenuItem1;
    private ToolStripSeparator toolStripSeparator9;
    private System.Windows.Forms.Timer timer1;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripMenuItem shortcutKeyToolStripMenuItem;

    private Config configDialog
    {
      get
      {
        if (this._configD == null || this._configD.IsDisposed)
          this._configD = new Config();
        return this._configD;
      }
      set
      {
        this._configD = value;
      }
    }

    public MainForm()
    {
      this.InitializeComponent();
      Controller.InitWorkBatman();
      CultureInfo cultureInfo = Application.CurrentCulture;
      if (cultureInfo.Parent != null)
        cultureInfo = cultureInfo.Parent;
      switch (cultureInfo.Name)
      {
        case "zh-CHS":
          this.englishToolStripMenuItem.Checked = false;
          this.chineseSimplifiedToolStripMenuItem.Checked = true;
          this.chineseTraditionalToolStripMenuItem.Checked = false;
          this.resetText("zh-CHS");
          break;
        case "en":
          this.englishToolStripMenuItem.Checked = true;
          this.chineseSimplifiedToolStripMenuItem.Checked = false;
          this.chineseTraditionalToolStripMenuItem.Checked = false;
          this.resetText("en");
          break;
        case "zh-CHT":
          this.englishToolStripMenuItem.Checked = false;
          this.chineseSimplifiedToolStripMenuItem.Checked = false;
          this.chineseTraditionalToolStripMenuItem.Checked = true;
          this.resetText("zh-CHT");
          break;
        default:
          this.englishToolStripMenuItem_Click((object) null, (EventArgs) null);
          break;
      }
      Thread.CurrentThread.CurrentUICulture = cultureInfo;
      Program.cultureInfo = cultureInfo;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      SoftInfor softInfor = SoftInfor.GetSoftInfor();
      this.deviceListView.LargeImageList.Images.Add(softInfor.DeviceLargePic);
      this.deviceListView.SmallImageList.Images.Add(softInfor.DeviceSmallPic);
      this.pictureBox1.BackgroundImage = softInfor.Logo;
      this.Text = softInfor.SoftTitle + " Modify By Guangshan";
    }

    private void searchThraed(object o)
    {
      IPAddress deviceIP = (IPAddress) o;
      this.isSearch = true;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.setProThread));
      Controller.Seachdevice(deviceIP);
      this.SetMessage("", Message.Communicating);
      this.isSearch = false;
    }

    private void setProThread(object o)
    {
      int num = 0;
      this.SetProVisible(true);
      while (this.isSearch)
      {
        this.SetProValue(num);
        Thread.Sleep(510);
        num = (num + 5) % 100;
      }
      this.SetProVisible(false);
      if (this.deviceList.Count != 0)
        return;
      Program.ShowMessage(Message.NoDevice, false);
    }

    private void searchTSB_Click(object sender, EventArgs e)
    {
      if (this.isSearch)
        return;
      this.ClearDevice();
      this.SetMessage(Message.Communicating);
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.searchThraed), (object) IPAddress.Broadcast);
    }

    private void AddDevice(Device device)
    {
      if (device == null)
        return;
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MainForm.AddDeviceDele(this.AddDevice), (object) device);
      else
        this.deviceListView.Items.Add(new ListViewItem(new string[3]
        {
          device.DeviceName,
          device.IP.ToString(),
          device.MacAddress
        })
        {
          ImageIndex = 0
        });
    }

    private void SetProValue(int value)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MainForm.SetProValueDele(this.SetProValue), (object) value);
      else
        this.toolStripProgressBar1.Value = value;
    }

    private void SetProVisible(bool visible)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MainForm.SetProVisibleDele(this.SetProVisible), (object) (bool) (visible ? true : false));
      else
        this.toolStripProgressBar1.Visible = visible;
    }

    public bool AddNewDevice(Device d)
    {
      lock (Program.syncRoot)
      {
        for (int local_0 = 0; local_0 < this.deviceList.Count; ++local_0)
        {
          if (this.deviceList[local_0].IP.Equals((object) d.IP))
            return false;
        }
        this.deviceList.Add(d);
      }
      this.AddDevice(d);
      return true;
    }

    public bool GetDeviceVersion(IPAddress ip, Batman workBatman)
    {
      lock (Program.syncRoot)
      {
        for (int local_0 = 0; local_0 < this.deviceList.Count; ++local_0)
        {
          if (this.deviceList[local_0].IP.Equals((object) ip))
            return this.deviceList[local_0].IsNewVersion;
        }
        return false;
      }
    }

    public Device GetDeviceByIP(IPAddress ip, Batman workBatman)
    {
      lock (Program.syncRoot)
      {
        for (int local_0 = 0; local_0 < this.deviceList.Count; ++local_0)
        {
          if (this.deviceList[local_0].IP.Equals((object) ip))
            return this.deviceList[local_0];
        }
        return (Device) null;
      }
    }

    private void refreshDevice()
    {
      for (int index = 0; index < this.deviceList.Count; ++index)
      {
        ListViewItem listViewItem = this.deviceListView.Items[index];
        listViewItem.Text = this.deviceList[index].DeviceName;
        listViewItem.SubItems[0].Text = this.deviceList[index].DeviceName;
        listViewItem.SubItems[1].Text = this.deviceList[index].IP.ToString();
        listViewItem.SubItems[2].Text = this.deviceList[index].MacAddress;
      }
    }

    public void RefreshDevice(Device device)
    {
      if (device == null)
        return;
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new MainForm.RefreshDeviceDele(this.RefreshDevice), (object) device);
      }
      else
      {
        for (int index = 0; index < this.deviceList.Count; ++index)
        {
          if (this.deviceList[index].IP == device.IP)
          {
            ListViewItem listViewItem = this.deviceListView.Items[index];
            listViewItem.Text = device.DeviceName;
            listViewItem.SubItems[0].Text = device.DeviceName;
            listViewItem.SubItems[1].Text = device.IP.ToString();
            listViewItem.SubItems[2].Text = device.MacAddress;
            break;
          }
        }
      }
    }

    public void DeleteDevice(Device device)
    {
      if (device == null)
        return;
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new MainForm.DeleteDeviceDele(this.DeleteDevice), (object) device);
      }
      else
      {
        for (int index = 0; index < this.deviceList.Count; ++index)
        {
          if (this.deviceList[index].IP == device.IP)
          {
            this.deviceList.RemoveAt(index);
            this.deviceListView.Items.RemoveAt(index);
            break;
          }
        }
      }
    }

    public void ClearDevice()
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MainForm.ClearDeviceDele(this.ClearDevice));
      else
        this.clearTSB_Click((object) null, (EventArgs) null);
    }

    private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.deviceListView.View = View.LargeIcon;
      this.largeIconToolStripMenuItem.Checked = true;
      this.detailsToolStripMenuItem.Checked = false;
      this.smallIconToolStripMenuItem.Checked = false;
      this.listToolStripMenuItem.Checked = false;
      this.tileToolStripMenuItem.Checked = false;
      this.largeToolStripMenuItem.Checked = true;
      this.detailsToolStripMenuItem1.Checked = false;
      this.smallIconToolStripMenuItem1.Checked = false;
      this.listToolStripMenuItem1.Checked = false;
      this.tileToolStripMenuItem1.Checked = false;
    }

    private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.deviceListView.View = View.Details;
      this.largeIconToolStripMenuItem.Checked = false;
      this.detailsToolStripMenuItem.Checked = true;
      this.smallIconToolStripMenuItem.Checked = false;
      this.listToolStripMenuItem.Checked = false;
      this.tileToolStripMenuItem.Checked = false;
      this.largeToolStripMenuItem.Checked = false;
      this.detailsToolStripMenuItem1.Checked = true;
      this.smallIconToolStripMenuItem1.Checked = false;
      this.listToolStripMenuItem1.Checked = false;
      this.tileToolStripMenuItem1.Checked = false;
      this.deviceName.Width = 165;
      this.ipAddress.Width = 101;
      this.physical.Width = 188;
    }

    private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.deviceListView.View = View.SmallIcon;
      this.largeIconToolStripMenuItem.Checked = false;
      this.detailsToolStripMenuItem.Checked = false;
      this.smallIconToolStripMenuItem.Checked = true;
      this.listToolStripMenuItem.Checked = false;
      this.tileToolStripMenuItem.Checked = false;
      this.largeToolStripMenuItem.Checked = false;
      this.detailsToolStripMenuItem1.Checked = false;
      this.smallIconToolStripMenuItem1.Checked = true;
      this.listToolStripMenuItem1.Checked = false;
      this.tileToolStripMenuItem1.Checked = false;
    }

    private void listToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.deviceListView.View = View.List;
      this.largeIconToolStripMenuItem.Checked = false;
      this.detailsToolStripMenuItem.Checked = false;
      this.smallIconToolStripMenuItem.Checked = false;
      this.listToolStripMenuItem.Checked = true;
      this.tileToolStripMenuItem.Checked = false;
      this.largeToolStripMenuItem.Checked = false;
      this.detailsToolStripMenuItem1.Checked = false;
      this.smallIconToolStripMenuItem1.Checked = false;
      this.listToolStripMenuItem1.Checked = true;
      this.tileToolStripMenuItem1.Checked = false;
      this.deviceName.Width = 165;
      this.ipAddress.Width = 101;
      this.physical.Width = 188;
    }

    private void tileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.deviceListView.View = View.Tile;
      this.largeIconToolStripMenuItem.Checked = false;
      this.detailsToolStripMenuItem.Checked = false;
      this.smallIconToolStripMenuItem.Checked = false;
      this.listToolStripMenuItem.Checked = false;
      this.tileToolStripMenuItem.Checked = true;
      this.largeToolStripMenuItem.Checked = false;
      this.detailsToolStripMenuItem1.Checked = false;
      this.smallIconToolStripMenuItem1.Checked = false;
      this.listToolStripMenuItem1.Checked = false;
      this.tileToolStripMenuItem1.Checked = true;
    }

    private void deviceListView_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        if (this.deviceListView.SelectedIndices.Count > 0 && this.deviceListView.SelectedIndices[0] != -1)
        {
          this.nameL.Text = this.deviceList[this.deviceListView.SelectedIndices[0]].DeviceName;
          this.macL.Text = this.deviceList[this.deviceListView.SelectedIndices[0]].MacAddress;
          this.ipL.Text = this.deviceList[this.deviceListView.SelectedIndices[0]].IP.ToString();
          this.serialL.Text = this.deviceList[this.deviceListView.SelectedIndices[0]].SerialNO;
          this.firmwareL.Text = this.deviceList[this.deviceListView.SelectedIndices[0]].Firmware;
          this.sysL.Text = this.deviceList[this.deviceListView.SelectedIndices[0]].UpTime;
          this.iEToolStripMenuItem.Enabled = true;
          this.telnetToolStripMenuItem.Enabled = true;
          this.pingToolStripMenuItem.Enabled = true;
          this.configToolStripMenuItem.Enabled = true;
          this.IETSB.Enabled = true;
          this.telnetTSB.Enabled = true;
          this.pingTSB.Enabled = true;
          this.configTSB.Enabled = true;
          this.iEToolStripMenuItem1.Enabled = true;
          this.telnetToolStripMenuItem1.Enabled = true;
          this.pingToolStripMenuItem1.Enabled = true;
          this.configToolStripMenuItem1.Enabled = true;
        }
        else
        {
          this.nameL.Text = "";
          this.macL.Text = "";
          this.ipL.Text = "";
          this.serialL.Text = "";
          this.firmwareL.Text = "";
          this.sysL.Text = "";
          this.iEToolStripMenuItem.Enabled = false;
          this.telnetToolStripMenuItem.Enabled = false;
          this.pingToolStripMenuItem.Enabled = false;
          this.configToolStripMenuItem.Enabled = false;
          this.IETSB.Enabled = false;
          this.telnetTSB.Enabled = false;
          this.pingTSB.Enabled = false;
          this.configTSB.Enabled = false;
          this.iEToolStripMenuItem1.Enabled = false;
          this.telnetToolStripMenuItem1.Enabled = false;
          this.pingToolStripMenuItem1.Enabled = false;
          this.configToolStripMenuItem1.Enabled = false;
        }
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        this.nameL.Text = "";
        this.macL.Text = "";
        this.ipL.Text = "";
        this.serialL.Text = "";
        this.firmwareL.Text = "";
        this.sysL.Text = "";
        this.iEToolStripMenuItem.Enabled = false;
        this.telnetToolStripMenuItem.Enabled = false;
        this.pingToolStripMenuItem.Enabled = false;
        this.configToolStripMenuItem.Enabled = false;
        this.IETSB.Enabled = false;
        this.telnetTSB.Enabled = false;
        this.pingTSB.Enabled = false;
        this.configTSB.Enabled = false;
        this.iEToolStripMenuItem1.Enabled = false;
        this.telnetToolStripMenuItem1.Enabled = false;
        this.pingToolStripMenuItem1.Enabled = false;
        this.configToolStripMenuItem1.Enabled = false;
      }
    }

    private void IETSB_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.deviceListView.SelectedIndices.Count <= 0 || this.deviceListView.SelectedIndices[0] == -1)
          return;
        Process.Start("iexplore.exe", "HTTP://" + this.deviceList[this.deviceListView.SelectedIndices[0]].IP.ToString());
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
      }
    }

    private void telnetTSB_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.deviceListView.SelectedIndices.Count <= 0 || this.deviceListView.SelectedIndices[0] == -1)
          return;
        Process.Start("telnet.exe", this.deviceList[this.deviceListView.SelectedIndices[0]].IP.ToString());
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
      }
    }

    private void pingTSB_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.deviceListView.SelectedIndices.Count <= 0 || this.deviceListView.SelectedIndices[0] == -1)
          return;
        Process.Start("ping.exe", this.deviceList[this.deviceListView.SelectedIndices[0]].IP.ToString() + " -t");
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
      }
    }

    private void closeTSB_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void configTSB_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.deviceListView.SelectedIndices.Count <= 0 || this.deviceListView.SelectedIndices[0] == -1)
          return;
        Device device = this.deviceList[this.deviceListView.SelectedIndices[0]];
        if (!device.IsLogged)
        {
          if (new LoginForm()
          {
            CurrentDevice = device
          }.ShowDialog((IWin32Window) this) != DialogResult.OK)
            return;
        }
        this.configDialog.SelectDevice = device;
        this._configD.PanelType = PanelTypes.BasicSetting;
        int num = (int) this._configD.ShowDialog((IWin32Window) this);
        this.refreshDevice();
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
      }
    }

    private void clearTSB_Click(object sender, EventArgs e)
    {
      this.deviceListView.Items.Clear();
      this.deviceList.Clear();
      this.deviceListView_SelectedIndexChanged((object) null, (EventArgs) null);
    }

    private void spSearchTSB_Click(object sender, EventArgs e)
    {
      if (this.searchDialog.ShowDialog((IWin32Window) this) != DialogResult.OK || this.isSearch)
        return;
      this.SetMessage(Message.Communicating);
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.searchThraed), (object) this.searchDialog.IP);
    }

    private void englishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CultureInfo cultureInfo = new CultureInfo("en");
      Thread.CurrentThread.CurrentUICulture = cultureInfo;
      Program.cultureInfo = cultureInfo;
      this.englishToolStripMenuItem.Checked = true;
      this.chineseSimplifiedToolStripMenuItem.Checked = false;
      this.chineseTraditionalToolStripMenuItem.Checked = false;
      this.resetText("en");
    }

    private void chineseSimplifiedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CultureInfo cultureInfo = new CultureInfo("zh-CHS");
      Thread.CurrentThread.CurrentUICulture = cultureInfo;
      Program.cultureInfo = cultureInfo;
      this.englishToolStripMenuItem.Checked = false;
      this.chineseSimplifiedToolStripMenuItem.Checked = true;
      this.chineseTraditionalToolStripMenuItem.Checked = false;
      this.resetText("zh-CHS");
    }

    private void chineseTraditionalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CultureInfo cultureInfo = new CultureInfo("zh-CHT");
      Thread.CurrentThread.CurrentUICulture = cultureInfo;
      Program.cultureInfo = cultureInfo;
      this.englishToolStripMenuItem.Checked = false;
      this.chineseSimplifiedToolStripMenuItem.Checked = false;
      this.chineseTraditionalToolStripMenuItem.Checked = true;
      this.resetText("zh-CHT");
    }

    private void resetText(string key)
    {
      switch (key)
      {
        case "en":
          this.operateToolStripMenuItem.Text = "&Operate";
          this.searchToolStripMenuItem.Text = "&Search";
          this.searchToolStripMenuItem1.Text = "&Search";
          this.searchTSB.Text = "Search";
          this.specifySearchToolStripMenuItem.Text = "Sp&ecify Search";
          this.specifySearchToolStripMenuItem1.Text = "Sp&ecify Search";
          this.spSearchTSB.Text = "Specify Search";
          this.searchDialog.Text = "Specify Search";
          this.configToolStripMenuItem.Text = "&Config";
          this.configToolStripMenuItem1.Text = "&Config";
          this.configTSB.Text = "Config";
          this.configDialog.Text = "Config";
          this.clearToolStripMenuItem.Text = "C&lear";
          this.clearToolStripMenuItem1.Text = "C&lear";
          this.clearTSB.Text = "Clear";
          this.exitToolStripMenuItem.Text = "E&xit";
          this.exitToolStripMenuItem1.Text = "E&xit";
          this.closeTSB.Text = "Exit";
          this.toolStripMenuItem1.Text = "&Tools";
          this.iEToolStripMenuItem.Text = "&IE";
          this.iEToolStripMenuItem1.Text = "&IE";
          this.IETSB.Text = "IE";
          this.telnetToolStripMenuItem.Text = "&Telnet";
          this.telnetToolStripMenuItem1.Text = "&Telnet";
          this.telnetTSB.Text = "Telnet";
          this.pingToolStripMenuItem.Text = "&Ping";
          this.pingToolStripMenuItem1.Text = "&Ping";
          this.pingTSB.Text = "Ping";
          this.languageToolStripMenuItem.Text = "&Language";
          this.englishToolStripMenuItem.Text = "&English";
          this.chineseSimplifiedToolStripMenuItem.Text = "&Chinese-Simplified";
          this.chineseTraditionalToolStripMenuItem.Text = "C&hinese-Traditional";
          this.helpToolStripMenuItem.Text = "&Help";
          this.aboutToolStripMenuItem.Text = "&About";
          this.updateToolStripMenuItem.Text = "&Update";
          this.viewToolStripMenuItem.Text = "View";
          this.largeIconToolStripMenuItem.Text = "LargeIcon";
          this.largeToolStripMenuItem.Text = "LargeIcon";
          this.tileToolStripMenuItem.Text = "Tile";
          this.tileToolStripMenuItem1.Text = "Tile";
          this.smallIconToolStripMenuItem.Text = "SmallIcon";
          this.smallIconToolStripMenuItem1.Text = "SmallIcon";
          this.listToolStripMenuItem.Text = "List";
          this.listToolStripMenuItem1.Text = "List";
          this.detailsToolStripMenuItem.Text = "Details";
          this.detailsToolStripMenuItem1.Text = "Details";
          this.shortcutKeyToolStripMenuItem.Text = "&Shortcut Key";
          break;
        case "zh-CHS":
          this.operateToolStripMenuItem.Text = "操作(&O)";
          this.searchToolStripMenuItem.Text = "搜索(&S)";
          this.searchToolStripMenuItem1.Text = "搜索(&S)";
          this.searchTSB.Text = "搜索";
          this.specifySearchToolStripMenuItem.Text = "指定搜索(&E)";
          this.specifySearchToolStripMenuItem1.Text = "指定搜索(&E)";
          this.spSearchTSB.Text = "指定搜索";
          this.searchDialog.Text = "指定搜索";
          this.configToolStripMenuItem.Text = "配置(&C)";
          this.configToolStripMenuItem1.Text = "配置(&C)";
          this.configTSB.Text = "配置";
          this.configDialog.Text = "配置";
          this.clearToolStripMenuItem.Text = "清除(&L)";
          this.clearToolStripMenuItem1.Text = "清除(&L)";
          this.clearTSB.Text = "清除";
          this.exitToolStripMenuItem.Text = "退出(&X)";
          this.exitToolStripMenuItem1.Text = "退出(&X)";
          this.closeTSB.Text = "退出";
          this.toolStripMenuItem1.Text = "工具(&T)";
          this.iEToolStripMenuItem.Text = "&IE";
          this.iEToolStripMenuItem1.Text = "&IE";
          this.IETSB.Text = "IE";
          this.telnetToolStripMenuItem.Text = "&Telnet";
          this.telnetToolStripMenuItem1.Text = "&Telnet";
          this.telnetTSB.Text = "Telnet";
          this.pingToolStripMenuItem.Text = "&Ping";
          this.pingToolStripMenuItem1.Text = "&Ping";
          this.pingTSB.Text = "Ping";
          this.languageToolStripMenuItem.Text = "语言(&L)";
          this.englishToolStripMenuItem.Text = "英语(&E)";
          this.chineseSimplifiedToolStripMenuItem.Text = "简体中文(&C)";
          this.chineseTraditionalToolStripMenuItem.Text = "繁体中文(&H)";
          this.helpToolStripMenuItem.Text = "帮助(&H)";
          this.aboutToolStripMenuItem.Text = "关于(&A)";
          this.updateToolStripMenuItem.Text = "更新(&U)";
          this.viewToolStripMenuItem.Text = "查看";
          this.largeIconToolStripMenuItem.Text = "缩略图";
          this.largeToolStripMenuItem.Text = "缩略图";
          this.tileToolStripMenuItem.Text = "平铺";
          this.tileToolStripMenuItem1.Text = "平铺";
          this.smallIconToolStripMenuItem.Text = "图标";
          this.smallIconToolStripMenuItem1.Text = "图标";
          this.listToolStripMenuItem.Text = "列表";
          this.listToolStripMenuItem1.Text = "列表";
          this.detailsToolStripMenuItem.Text = "详细";
          this.detailsToolStripMenuItem1.Text = "详细";
          this.shortcutKeyToolStripMenuItem.Text = "快捷键(&S)";
          break;
        case "zh-CHT":
          this.operateToolStripMenuItem.Text = "操作(&O)";
          this.searchToolStripMenuItem.Text = "搜索(&S)";
          this.searchToolStripMenuItem1.Text = "搜索(&S)";
          this.searchTSB.Text = "搜索";
          this.specifySearchToolStripMenuItem.Text = "指定搜索(&E)";
          this.specifySearchToolStripMenuItem1.Text = "指定搜索(&E)";
          this.spSearchTSB.Text = "指定搜索";
          this.searchDialog.Text = "指定搜索";
          this.configToolStripMenuItem.Text = "配置(&C)";
          this.configToolStripMenuItem1.Text = "配置(&C)";
          this.configTSB.Text = "配置";
          this.configDialog.Text = "配置";
          this.clearToolStripMenuItem.Text = "清除(&L)";
          this.clearToolStripMenuItem1.Text = "清除(&L)";
          this.clearTSB.Text = "清除";
          this.exitToolStripMenuItem.Text = "退出(&x)";
          this.exitToolStripMenuItem1.Text = "退出(&x)";
          this.closeTSB.Text = "退出";
          this.toolStripMenuItem1.Text = "工具(&T)";
          this.iEToolStripMenuItem.Text = "&IE";
          this.iEToolStripMenuItem1.Text = "&IE";
          this.IETSB.Text = "IE";
          this.telnetToolStripMenuItem.Text = "&Telnet";
          this.telnetToolStripMenuItem1.Text = "&Telnet";
          this.telnetTSB.Text = "Telnet";
          this.pingToolStripMenuItem.Text = "&Ping";
          this.pingToolStripMenuItem1.Text = "&Ping";
          this.pingTSB.Text = "Ping";
          this.languageToolStripMenuItem.Text = "語言(&L)";
          this.englishToolStripMenuItem.Text = "英語(&E)";
          this.chineseSimplifiedToolStripMenuItem.Text = "簡體中文(&C)";
          this.chineseTraditionalToolStripMenuItem.Text = "繁體中文(&H)";
          this.helpToolStripMenuItem.Text = "説明(&H)";
          this.aboutToolStripMenuItem.Text = "關於(&A)";
          this.updateToolStripMenuItem.Text = "更新(&U)";
          this.viewToolStripMenuItem.Text = "查看";
          this.largeIconToolStripMenuItem.Text = "縮略圖";
          this.largeToolStripMenuItem.Text = "縮略圖";
          this.tileToolStripMenuItem.Text = "平鋪";
          this.tileToolStripMenuItem1.Text = "平鋪";
          this.smallIconToolStripMenuItem.Text = "圖示";
          this.smallIconToolStripMenuItem1.Text = "圖示";
          this.listToolStripMenuItem.Text = "列表";
          this.listToolStripMenuItem1.Text = "列表";
          this.detailsToolStripMenuItem.Text = "詳細";
          this.detailsToolStripMenuItem1.Text = "詳細";
          this.shortcutKeyToolStripMenuItem.Text = "快捷鍵(&S)";
          break;
      }
    }

    public void SetMessage(string message)
    {
      this.SetMessage(message, (string) null);
    }

    private void SetMessage(string message, string oldMessage)
    {
      this.SetMessage(message, oldMessage, true);
    }

    private void SetMessage(string message, string oldMessage, bool isClear)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new MainForm.SetMessageDele(this.SetMessage), (object) message, (object) oldMessage, (object) (bool) (isClear ? true : false));
      }
      else
      {
        if (oldMessage == null || this.statusLabel1.Text == oldMessage)
          this.statusLabel1.Text = message;
        this.timer1.Enabled = isClear;
      }
    }

    private void updateToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new Process()
      {
        StartInfo = {
          FileName = (Application.StartupPath + "\\update.exe")
        }
      }.Start();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new AboutBox().ShowDialog((IWin32Window) this);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.SetMessage("", (string) null, false);
      this.timer1.Enabled = false;
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.isKey(e, ShortcutKeyType.SearchKey))
        this.searchTSB_Click((object) null, (EventArgs) null);
      else if (this.isKey(e, ShortcutKeyType.ConfigKey))
        this.configTSB_Click((object) null, (EventArgs) null);
      else if (this.isKey(e, ShortcutKeyType.SpecifySearchKey))
        this.spSearchTSB_Click((object) null, (EventArgs) null);
      else if (this.isKey(e, ShortcutKeyType.ClearKey))
        this.clearTSB_Click((object) null, (EventArgs) null);
      else if (this.isKey(e, ShortcutKeyType.ExitKey))
        this.closeTSB_Click((object) null, (EventArgs) null);
      else if (this.isKey(e, ShortcutKeyType.IEKey))
        this.IETSB_Click((object) null, (EventArgs) null);
      else if (this.isKey(e, ShortcutKeyType.TelnetKey))
      {
        this.telnetTSB_Click((object) null, (EventArgs) null);
      }
      else
      {
        if (!this.isKey(e, ShortcutKeyType.PingKey))
          return;
        this.pingTSB_Click((object) null, (EventArgs) null);
      }
    }

    private bool isKey(KeyEventArgs e, ShortcutKeyType type)
    {
      MyShortcutKey myShortcutKey = Program.MyShortcutKeys[(int) (byte) type];
      return myShortcutKey != null && myShortcutKey.IsAlt == e.Alt && (myShortcutKey.IsCtrl == e.Control && myShortcutKey.IsShift == e.Shift) && myShortcutKey.KeyCode == e.KeyCode;
    }

    private void shortcutKeyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new Key().ShowDialog((IWin32Window) this);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainForm));
      this.menuStrip1 = new MenuStrip();
      this.operateToolStripMenuItem = new ToolStripMenuItem();
      this.searchToolStripMenuItem = new ToolStripMenuItem();
      this.specifySearchToolStripMenuItem = new ToolStripMenuItem();
      this.configToolStripMenuItem = new ToolStripMenuItem();
      this.clearToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItem1 = new ToolStripMenuItem();
      this.iEToolStripMenuItem = new ToolStripMenuItem();
      this.telnetToolStripMenuItem = new ToolStripMenuItem();
      this.pingToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator10 = new ToolStripSeparator();
      this.shortcutKeyToolStripMenuItem = new ToolStripMenuItem();
      this.languageToolStripMenuItem = new ToolStripMenuItem();
      this.englishToolStripMenuItem = new ToolStripMenuItem();
      this.chineseSimplifiedToolStripMenuItem = new ToolStripMenuItem();
      this.chineseTraditionalToolStripMenuItem = new ToolStripMenuItem();
      this.helpToolStripMenuItem = new ToolStripMenuItem();
      this.aboutToolStripMenuItem = new ToolStripMenuItem();
      this.updateToolStripMenuItem = new ToolStripMenuItem();
      this.toolStrip1 = new ToolStrip();
      this.searchTSB = new ToolStripButton();
      this.spSearchTSB = new ToolStripButton();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.configTSB = new ToolStripButton();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.viewTSB = new ToolStripDropDownButton();
      this.largeIconToolStripMenuItem = new ToolStripMenuItem();
      this.tileToolStripMenuItem = new ToolStripMenuItem();
      this.smallIconToolStripMenuItem = new ToolStripMenuItem();
      this.listToolStripMenuItem = new ToolStripMenuItem();
      this.detailsToolStripMenuItem = new ToolStripMenuItem();
      this.clearTSB = new ToolStripButton();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.IETSB = new ToolStripButton();
      this.telnetTSB = new ToolStripButton();
      this.pingTSB = new ToolStripButton();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.closeTSB = new ToolStripButton();
      this.statusStrip1 = new StatusStrip();
      this.statusLabel1 = new ToolStripStatusLabel();
      this.toolStripProgressBar1 = new ToolStripProgressBar();
      this.panel1 = new Panel();
      this.tableLayoutPanel1 = new TableLayoutPanel();
      this.label14 = new Label();
      this.sysL = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.label6 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label7 = new Label();
      this.nameL = new Label();
      this.macL = new Label();
      this.ipL = new Label();
      this.serialL = new Label();
      this.firmwareL = new Label();
      this.pictureBox1 = new PictureBox();
      this.deviceListView = new ListView();
      this.deviceName = new ColumnHeader();
      this.ipAddress = new ColumnHeader();
      this.physical = new ColumnHeader();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.searchToolStripMenuItem1 = new ToolStripMenuItem();
      this.specifySearchToolStripMenuItem1 = new ToolStripMenuItem();
      this.clearToolStripMenuItem1 = new ToolStripMenuItem();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.configToolStripMenuItem1 = new ToolStripMenuItem();
      this.toolStripSeparator7 = new ToolStripSeparator();
      this.viewToolStripMenuItem = new ToolStripMenuItem();
      this.largeToolStripMenuItem = new ToolStripMenuItem();
      this.tileToolStripMenuItem1 = new ToolStripMenuItem();
      this.smallIconToolStripMenuItem1 = new ToolStripMenuItem();
      this.listToolStripMenuItem1 = new ToolStripMenuItem();
      this.detailsToolStripMenuItem1 = new ToolStripMenuItem();
      this.toolStripSeparator9 = new ToolStripSeparator();
      this.iEToolStripMenuItem1 = new ToolStripMenuItem();
      this.telnetToolStripMenuItem1 = new ToolStripMenuItem();
      this.pingToolStripMenuItem1 = new ToolStripMenuItem();
      this.toolStripSeparator8 = new ToolStripSeparator();
      this.exitToolStripMenuItem1 = new ToolStripMenuItem();
      this.imageList1 = new ImageList(this.components);
      this.imageList2 = new ImageList(this.components);
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.operateToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.languageToolStripMenuItem,
        (ToolStripItem) this.helpToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(776, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      this.operateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.searchToolStripMenuItem,
        (ToolStripItem) this.specifySearchToolStripMenuItem,
        (ToolStripItem) this.configToolStripMenuItem,
        (ToolStripItem) this.clearToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.exitToolStripMenuItem
      });
      this.operateToolStripMenuItem.Name = "operateToolStripMenuItem";
      this.operateToolStripMenuItem.Size = new Size(59, 20);
      this.operateToolStripMenuItem.Text = "&Operate";
      this.searchToolStripMenuItem.Image = (Image) Resources.Search;
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new Size(145, 22);
      this.searchToolStripMenuItem.Text = "&Search";
      this.searchToolStripMenuItem.Click += new EventHandler(this.searchTSB_Click);
      this.specifySearchToolStripMenuItem.Image = (Image) Resources.Specify_Search;
      this.specifySearchToolStripMenuItem.Name = "specifySearchToolStripMenuItem";
      this.specifySearchToolStripMenuItem.Size = new Size(145, 22);
      this.specifySearchToolStripMenuItem.Text = "Sp&ecify Search";
      this.specifySearchToolStripMenuItem.Click += new EventHandler(this.spSearchTSB_Click);
      this.configToolStripMenuItem.Enabled = false;
      this.configToolStripMenuItem.Image = (Image) Resources.Config;
      this.configToolStripMenuItem.Name = "configToolStripMenuItem";
      this.configToolStripMenuItem.Size = new Size(145, 22);
      this.configToolStripMenuItem.Text = "&Config";
      this.configToolStripMenuItem.Click += new EventHandler(this.configTSB_Click);
      this.clearToolStripMenuItem.Image = (Image) Resources.Clear;
      this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
      this.clearToolStripMenuItem.Size = new Size(145, 22);
      this.clearToolStripMenuItem.Text = "C&lear";
      this.clearToolStripMenuItem.Click += new EventHandler(this.clearTSB_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(142, 6);
      this.exitToolStripMenuItem.Image = (Image) Resources.Close;
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new Size(145, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new EventHandler(this.closeTSB_Click);
      this.toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.iEToolStripMenuItem,
        (ToolStripItem) this.telnetToolStripMenuItem,
        (ToolStripItem) this.pingToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator10,
        (ToolStripItem) this.shortcutKeyToolStripMenuItem
      });
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new Size(44, 20);
      this.toolStripMenuItem1.Text = "&Tools";
      this.iEToolStripMenuItem.Enabled = false;
      this.iEToolStripMenuItem.Image = (Image) Resources.IE;
      this.iEToolStripMenuItem.Name = "iEToolStripMenuItem";
      this.iEToolStripMenuItem.Size = new Size(136, 22);
      this.iEToolStripMenuItem.Text = "&IE";
      this.iEToolStripMenuItem.Click += new EventHandler(this.IETSB_Click);
      this.telnetToolStripMenuItem.Enabled = false;
      this.telnetToolStripMenuItem.Image = (Image) Resources.Telnet;
      this.telnetToolStripMenuItem.Name = "telnetToolStripMenuItem";
      this.telnetToolStripMenuItem.Size = new Size(136, 22);
      this.telnetToolStripMenuItem.Text = "&Telnet";
      this.telnetToolStripMenuItem.Click += new EventHandler(this.telnetTSB_Click);
      this.pingToolStripMenuItem.Enabled = false;
      this.pingToolStripMenuItem.Image = (Image) Resources.Ping;
      this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
      this.pingToolStripMenuItem.Size = new Size(136, 22);
      this.pingToolStripMenuItem.Text = "&Ping";
      this.pingToolStripMenuItem.Click += new EventHandler(this.pingTSB_Click);
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      this.toolStripSeparator10.Size = new Size(133, 6);
      this.shortcutKeyToolStripMenuItem.Name = "shortcutKeyToolStripMenuItem";
      this.shortcutKeyToolStripMenuItem.Size = new Size(136, 22);
      this.shortcutKeyToolStripMenuItem.Text = "&Shortcut Key";
      this.shortcutKeyToolStripMenuItem.Click += new EventHandler(this.shortcutKeyToolStripMenuItem_Click);
      this.languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.englishToolStripMenuItem,
        (ToolStripItem) this.chineseSimplifiedToolStripMenuItem,
        (ToolStripItem) this.chineseTraditionalToolStripMenuItem
      });
      this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
      this.languageToolStripMenuItem.Size = new Size(66, 20);
      this.languageToolStripMenuItem.Text = "&Language";
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new Size(166, 22);
      this.englishToolStripMenuItem.Text = "&English";
      this.englishToolStripMenuItem.Click += new EventHandler(this.englishToolStripMenuItem_Click);
      this.chineseSimplifiedToolStripMenuItem.Name = "chineseSimplifiedToolStripMenuItem";
      this.chineseSimplifiedToolStripMenuItem.Size = new Size(166, 22);
      this.chineseSimplifiedToolStripMenuItem.Text = "&Chinese-Simplified";
      this.chineseSimplifiedToolStripMenuItem.Click += new EventHandler(this.chineseSimplifiedToolStripMenuItem_Click);
      this.chineseTraditionalToolStripMenuItem.Name = "chineseTraditionalToolStripMenuItem";
      this.chineseTraditionalToolStripMenuItem.Size = new Size(166, 22);
      this.chineseTraditionalToolStripMenuItem.Text = "C&hinese-Traditional";
      this.chineseTraditionalToolStripMenuItem.Click += new EventHandler(this.chineseTraditionalToolStripMenuItem_Click);
      this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.aboutToolStripMenuItem,
        (ToolStripItem) this.updateToolStripMenuItem
      });
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new Size(40, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new Size(109, 22);
      this.aboutToolStripMenuItem.Text = "&About";
      this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
      this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
      this.updateToolStripMenuItem.Size = new Size(109, 22);
      this.updateToolStripMenuItem.Text = "&Update";
      this.updateToolStripMenuItem.Click += new EventHandler(this.updateToolStripMenuItem_Click);
      this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new ToolStripItem[13]
      {
        (ToolStripItem) this.searchTSB,
        (ToolStripItem) this.spSearchTSB,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.configTSB,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.viewTSB,
        (ToolStripItem) this.clearTSB,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.IETSB,
        (ToolStripItem) this.telnetTSB,
        (ToolStripItem) this.pingTSB,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.closeTSB
      });
      this.toolStrip1.Location = new Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(776, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      this.searchTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.searchTSB.Image = (Image) Resources.Search;
      this.searchTSB.ImageTransparentColor = Color.Magenta;
      this.searchTSB.Name = "searchTSB";
      this.searchTSB.Size = new Size(23, 22);
      this.searchTSB.Text = "Search";
      this.searchTSB.Click += new EventHandler(this.searchTSB_Click);
      this.spSearchTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.spSearchTSB.Image = (Image) Resources.Specify_Search;
      this.spSearchTSB.ImageTransparentColor = Color.Magenta;
      this.spSearchTSB.Name = "spSearchTSB";
      this.spSearchTSB.Size = new Size(23, 22);
      this.spSearchTSB.Text = "Specify Search";
      this.spSearchTSB.Click += new EventHandler(this.spSearchTSB_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(6, 25);
      this.configTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.configTSB.Enabled = false;
      this.configTSB.Image = (Image) Resources.Config;
      this.configTSB.ImageTransparentColor = Color.Magenta;
      this.configTSB.Name = "configTSB";
      this.configTSB.Size = new Size(23, 22);
      this.configTSB.Text = "Config";
      this.configTSB.Click += new EventHandler(this.configTSB_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(6, 25);
      this.viewTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.viewTSB.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.largeIconToolStripMenuItem,
        (ToolStripItem) this.tileToolStripMenuItem,
        (ToolStripItem) this.smallIconToolStripMenuItem,
        (ToolStripItem) this.listToolStripMenuItem,
        (ToolStripItem) this.detailsToolStripMenuItem
      });
      this.viewTSB.Image = (Image) Resources.View;
      this.viewTSB.ImageTransparentColor = Color.Magenta;
      this.viewTSB.Name = "viewTSB";
      this.viewTSB.Size = new Size(29, 22);
      this.viewTSB.Text = "View";
      this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
      this.largeIconToolStripMenuItem.Size = new Size(122, 22);
      this.largeIconToolStripMenuItem.Text = "LargeIcon";
      this.largeIconToolStripMenuItem.Click += new EventHandler(this.largeIconToolStripMenuItem_Click);
      this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
      this.tileToolStripMenuItem.Size = new Size(122, 22);
      this.tileToolStripMenuItem.Text = "Tile";
      this.tileToolStripMenuItem.Click += new EventHandler(this.tileToolStripMenuItem_Click);
      this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
      this.smallIconToolStripMenuItem.Size = new Size(122, 22);
      this.smallIconToolStripMenuItem.Text = "SmallIcon";
      this.smallIconToolStripMenuItem.Click += new EventHandler(this.smallIconToolStripMenuItem_Click);
      this.listToolStripMenuItem.Name = "listToolStripMenuItem";
      this.listToolStripMenuItem.Size = new Size(122, 22);
      this.listToolStripMenuItem.Text = "List";
      this.listToolStripMenuItem.Click += new EventHandler(this.listToolStripMenuItem_Click);
      this.detailsToolStripMenuItem.Checked = true;
      this.detailsToolStripMenuItem.CheckState = CheckState.Checked;
      this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
      this.detailsToolStripMenuItem.Size = new Size(122, 22);
      this.detailsToolStripMenuItem.Text = "Details";
      this.detailsToolStripMenuItem.Click += new EventHandler(this.detailsToolStripMenuItem_Click);
      this.clearTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.clearTSB.Image = (Image) Resources.Clear;
      this.clearTSB.ImageTransparentColor = Color.Magenta;
      this.clearTSB.Name = "clearTSB";
      this.clearTSB.Size = new Size(23, 22);
      this.clearTSB.Text = "Clear";
      this.clearTSB.Click += new EventHandler(this.clearTSB_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(6, 25);
      this.IETSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.IETSB.Enabled = false;
      this.IETSB.Image = (Image) Resources.IE;
      this.IETSB.ImageTransparentColor = Color.Magenta;
      this.IETSB.Name = "IETSB";
      this.IETSB.Size = new Size(23, 22);
      this.IETSB.Text = "IE";
      this.IETSB.Click += new EventHandler(this.IETSB_Click);
      this.telnetTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.telnetTSB.Enabled = false;
      this.telnetTSB.Image = (Image) Resources.Telnet;
      this.telnetTSB.ImageTransparentColor = Color.Magenta;
      this.telnetTSB.Name = "telnetTSB";
      this.telnetTSB.Size = new Size(23, 22);
      this.telnetTSB.Text = "Telnet";
      this.telnetTSB.Click += new EventHandler(this.telnetTSB_Click);
      this.pingTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.pingTSB.Enabled = false;
      this.pingTSB.Image = (Image) Resources.Ping;
      this.pingTSB.ImageTransparentColor = Color.Magenta;
      this.pingTSB.Name = "pingTSB";
      this.pingTSB.Size = new Size(23, 22);
      this.pingTSB.Text = "Ping";
      this.pingTSB.Click += new EventHandler(this.pingTSB_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(6, 25);
      this.closeTSB.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.closeTSB.Image = (Image) Resources.Close;
      this.closeTSB.ImageTransparentColor = Color.Magenta;
      this.closeTSB.Name = "closeTSB";
      this.closeTSB.Size = new Size(23, 22);
      this.closeTSB.Text = "Close";
      this.closeTSB.Click += new EventHandler(this.closeTSB_Click);
      this.statusStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.statusLabel1,
        (ToolStripItem) this.toolStripProgressBar1
      });
      this.statusStrip1.Location = new Point(0, 479);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new Size(776, 22);
      this.statusStrip1.TabIndex = 3;
      this.statusStrip1.Text = "statusStrip1";
      this.statusLabel1.AutoSize = false;
      this.statusLabel1.Name = "statusLabel1";
      this.statusLabel1.Size = new Size(231, 17);
      this.statusLabel1.Text = "Ready";
      this.statusLabel1.TextAlign = ContentAlignment.MiddleLeft;
      this.toolStripProgressBar1.Name = "toolStripProgressBar1";
      this.toolStripProgressBar1.Size = new Size(100, 16);
      this.toolStripProgressBar1.Visible = false;
      this.panel1.BackColor = SystemColors.Window;
      this.panel1.Controls.Add((Control) this.tableLayoutPanel1);
      this.panel1.Controls.Add((Control) this.pictureBox1);
      this.panel1.Dock = DockStyle.Right;
      this.panel1.Location = new Point(482, 49);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(294, 430);
      this.panel1.TabIndex = 4;
      this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45f));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55f));
      this.tableLayoutPanel1.Controls.Add((Control) this.label14, 0, 6);
      this.tableLayoutPanel1.Controls.Add((Control) this.sysL, 0, 6);
      this.tableLayoutPanel1.Controls.Add((Control) this.label3, 0, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.label2, 1, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.label6, 0, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.label4, 0, 3);
      this.tableLayoutPanel1.Controls.Add((Control) this.label5, 0, 4);
      this.tableLayoutPanel1.Controls.Add((Control) this.label7, 0, 5);
      this.tableLayoutPanel1.Controls.Add((Control) this.nameL, 1, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.macL, 1, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.ipL, 1, 3);
      this.tableLayoutPanel1.Controls.Add((Control) this.serialL, 1, 4);
      this.tableLayoutPanel1.Controls.Add((Control) this.firmwareL, 1, 5);
      this.tableLayoutPanel1.Dock = DockStyle.Top;
      this.tableLayoutPanel1.Location = new Point(0, 126);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.Padding = new Padding(3);
      this.tableLayoutPanel1.RowCount = 7;
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel1.Size = new Size(294, 154);
      this.tableLayoutPanel1.TabIndex = 1;
      this.label14.BackColor = SystemColors.Window;
      this.label14.Dock = DockStyle.Fill;
      this.label14.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.label14.Location = new Point(4, 130);
      this.label14.Margin = new Padding(0);
      this.label14.Name = "label14";
      this.label14.Size = new Size(128, 20);
      this.label14.TabIndex = 13;
      this.label14.Text = "System Uptime";
      this.label14.TextAlign = ContentAlignment.MiddleCenter;
      this.sysL.BackColor = SystemColors.Window;
      this.sysL.Dock = DockStyle.Fill;
      this.sysL.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.sysL.Location = new Point(133, 130);
      this.sysL.Margin = new Padding(0);
      this.sysL.Name = "sysL";
      this.sysL.Size = new Size(157, 20);
      this.sysL.TabIndex = 12;
      this.sysL.TextAlign = ContentAlignment.MiddleCenter;
      this.label3.BackColor = SystemColors.Window;
      this.label3.Dock = DockStyle.Fill;
      this.label3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.label3.Location = new Point(4, 25);
      this.label3.Margin = new Padding(0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(128, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Device Name";
      this.label3.TextAlign = ContentAlignment.MiddleCenter;
      this.label2.BackColor = SystemColors.Control;
      this.label2.Dock = DockStyle.Fill;
      this.label2.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label2.Location = new Point(133, 4);
      this.label2.Margin = new Padding(0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(157, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Value";
      this.label2.TextAlign = ContentAlignment.MiddleCenter;
      this.label1.BackColor = SystemColors.Control;
      this.label1.Dock = DockStyle.Fill;
      this.label1.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 134);
      this.label1.Location = new Point(4, 4);
      this.label1.Margin = new Padding(0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(128, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Property";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.label6.BackColor = SystemColors.Window;
      this.label6.Dock = DockStyle.Fill;
      this.label6.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.label6.Location = new Point(4, 46);
      this.label6.Margin = new Padding(0);
      this.label6.Name = "label6";
      this.label6.Size = new Size(128, 20);
      this.label6.TabIndex = 5;
      this.label6.Text = "MAC Address";
      this.label6.TextAlign = ContentAlignment.MiddleCenter;
      this.label4.BackColor = SystemColors.Window;
      this.label4.Dock = DockStyle.Fill;
      this.label4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.label4.Location = new Point(4, 67);
      this.label4.Margin = new Padding(0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(128, 20);
      this.label4.TabIndex = 3;
      this.label4.Text = "IP Address";
      this.label4.TextAlign = ContentAlignment.MiddleCenter;
      this.label5.BackColor = SystemColors.Window;
      this.label5.Dock = DockStyle.Fill;
      this.label5.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.label5.Location = new Point(4, 88);
      this.label5.Margin = new Padding(0);
      this.label5.Name = "label5";
      this.label5.Size = new Size(128, 20);
      this.label5.TabIndex = 4;
      this.label5.Text = "Serial No";
      this.label5.TextAlign = ContentAlignment.MiddleCenter;
      this.label7.BackColor = SystemColors.Window;
      this.label7.Dock = DockStyle.Fill;
      this.label7.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.label7.Location = new Point(4, 109);
      this.label7.Margin = new Padding(0);
      this.label7.Name = "label7";
      this.label7.Size = new Size(128, 20);
      this.label7.TabIndex = 6;
      this.label7.Text = "Firmware Version";
      this.label7.TextAlign = ContentAlignment.MiddleCenter;
      this.nameL.BackColor = SystemColors.Window;
      this.nameL.Dock = DockStyle.Fill;
      this.nameL.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.nameL.Location = new Point(133, 25);
      this.nameL.Margin = new Padding(0);
      this.nameL.Name = "nameL";
      this.nameL.Size = new Size(157, 20);
      this.nameL.TabIndex = 7;
      this.nameL.TextAlign = ContentAlignment.MiddleCenter;
      this.macL.BackColor = SystemColors.Window;
      this.macL.Dock = DockStyle.Fill;
      this.macL.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.macL.Location = new Point(133, 46);
      this.macL.Margin = new Padding(0);
      this.macL.Name = "macL";
      this.macL.Size = new Size(157, 20);
      this.macL.TabIndex = 8;
      this.macL.TextAlign = ContentAlignment.MiddleCenter;
      this.ipL.BackColor = SystemColors.Window;
      this.ipL.Dock = DockStyle.Fill;
      this.ipL.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.ipL.Location = new Point(133, 67);
      this.ipL.Margin = new Padding(0);
      this.ipL.Name = "ipL";
      this.ipL.Size = new Size(157, 20);
      this.ipL.TabIndex = 9;
      this.ipL.TextAlign = ContentAlignment.MiddleCenter;
      this.serialL.BackColor = SystemColors.Window;
      this.serialL.Dock = DockStyle.Fill;
      this.serialL.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.serialL.Location = new Point(133, 88);
      this.serialL.Margin = new Padding(0);
      this.serialL.Name = "serialL";
      this.serialL.Size = new Size(157, 20);
      this.serialL.TabIndex = 10;
      this.serialL.TextAlign = ContentAlignment.MiddleCenter;
      this.firmwareL.BackColor = SystemColors.Window;
      this.firmwareL.Dock = DockStyle.Fill;
      this.firmwareL.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.firmwareL.Location = new Point(133, 109);
      this.firmwareL.Margin = new Padding(0);
      this.firmwareL.Name = "firmwareL";
      this.firmwareL.Size = new Size(157, 20);
      this.firmwareL.TabIndex = 11;
      this.firmwareL.TextAlign = ContentAlignment.MiddleCenter;
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox1.Dock = DockStyle.Top;
      this.pictureBox1.Location = new Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(294, 126);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.deviceListView.BackgroundImageTiled = true;
      this.deviceListView.Columns.AddRange(new ColumnHeader[3]
      {
        this.deviceName,
        this.ipAddress,
        this.physical
      });
      this.deviceListView.ContextMenuStrip = this.contextMenuStrip1;
      this.deviceListView.Dock = DockStyle.Fill;
      this.deviceListView.FullRowSelect = true;
      this.deviceListView.LargeImageList = this.imageList1;
      this.deviceListView.Location = new Point(0, 49);
      this.deviceListView.MultiSelect = false;
      this.deviceListView.Name = "deviceListView";
      this.deviceListView.Size = new Size(482, 430);
      this.deviceListView.SmallImageList = this.imageList2;
      this.deviceListView.TabIndex = 5;
      this.deviceListView.UseCompatibleStateImageBehavior = false;
      this.deviceListView.View = View.Details;
      this.deviceListView.SelectedIndexChanged += new EventHandler(this.deviceListView_SelectedIndexChanged);
      this.deviceListView.DoubleClick += new EventHandler(this.configTSB_Click);
      this.deviceListView.KeyDown += new KeyEventHandler(this.MainForm_KeyDown);
      this.deviceName.Text = "DeviceName";
      this.deviceName.Width = 165;
      this.ipAddress.Text = "IP Address";
      this.ipAddress.Width = 101;
      this.physical.Text = "Physical Address";
      this.physical.Width = 188;
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[13]
      {
        (ToolStripItem) this.searchToolStripMenuItem1,
        (ToolStripItem) this.specifySearchToolStripMenuItem1,
        (ToolStripItem) this.clearToolStripMenuItem1,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.configToolStripMenuItem1,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.viewToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator9,
        (ToolStripItem) this.iEToolStripMenuItem1,
        (ToolStripItem) this.telnetToolStripMenuItem1,
        (ToolStripItem) this.pingToolStripMenuItem1,
        (ToolStripItem) this.toolStripSeparator8,
        (ToolStripItem) this.exitToolStripMenuItem1
      });
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new Size(146, 226);
      this.searchToolStripMenuItem1.Image = (Image) Resources.Search;
      this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
      this.searchToolStripMenuItem1.Size = new Size(145, 22);
      this.searchToolStripMenuItem1.Text = "&Search";
      this.searchToolStripMenuItem1.Click += new EventHandler(this.searchTSB_Click);
      this.specifySearchToolStripMenuItem1.Image = (Image) Resources.Specify_Search;
      this.specifySearchToolStripMenuItem1.Name = "specifySearchToolStripMenuItem1";
      this.specifySearchToolStripMenuItem1.Size = new Size(145, 22);
      this.specifySearchToolStripMenuItem1.Text = "Sp&ecify Search";
      this.specifySearchToolStripMenuItem1.Click += new EventHandler(this.spSearchTSB_Click);
      this.clearToolStripMenuItem1.Image = (Image) Resources.Clear;
      this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
      this.clearToolStripMenuItem1.Size = new Size(145, 22);
      this.clearToolStripMenuItem1.Text = "C&lear";
      this.clearToolStripMenuItem1.Click += new EventHandler(this.clearTSB_Click);
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new Size(142, 6);
      this.configToolStripMenuItem1.Enabled = false;
      this.configToolStripMenuItem1.Image = (Image) Resources.Config;
      this.configToolStripMenuItem1.Name = "configToolStripMenuItem1";
      this.configToolStripMenuItem1.Size = new Size(145, 22);
      this.configToolStripMenuItem1.Text = "&Config";
      this.configToolStripMenuItem1.Click += new EventHandler(this.configTSB_Click);
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new Size(142, 6);
      this.viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.largeToolStripMenuItem,
        (ToolStripItem) this.tileToolStripMenuItem1,
        (ToolStripItem) this.smallIconToolStripMenuItem1,
        (ToolStripItem) this.listToolStripMenuItem1,
        (ToolStripItem) this.detailsToolStripMenuItem1
      });
      this.viewToolStripMenuItem.Image = (Image) Resources.View;
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new Size(145, 22);
      this.viewToolStripMenuItem.Text = "&View";
      this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
      this.largeToolStripMenuItem.Size = new Size(122, 22);
      this.largeToolStripMenuItem.Text = "LargeIcon";
      this.largeToolStripMenuItem.Click += new EventHandler(this.largeIconToolStripMenuItem_Click);
      this.tileToolStripMenuItem1.Name = "tileToolStripMenuItem1";
      this.tileToolStripMenuItem1.Size = new Size(122, 22);
      this.tileToolStripMenuItem1.Text = "Tile";
      this.tileToolStripMenuItem1.Click += new EventHandler(this.tileToolStripMenuItem_Click);
      this.smallIconToolStripMenuItem1.Name = "smallIconToolStripMenuItem1";
      this.smallIconToolStripMenuItem1.Size = new Size(122, 22);
      this.smallIconToolStripMenuItem1.Text = "SmallIcon";
      this.smallIconToolStripMenuItem1.Click += new EventHandler(this.smallIconToolStripMenuItem_Click);
      this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
      this.listToolStripMenuItem1.Size = new Size(122, 22);
      this.listToolStripMenuItem1.Text = "List";
      this.listToolStripMenuItem1.Click += new EventHandler(this.listToolStripMenuItem_Click);
      this.detailsToolStripMenuItem1.Checked = true;
      this.detailsToolStripMenuItem1.CheckState = CheckState.Checked;
      this.detailsToolStripMenuItem1.Name = "detailsToolStripMenuItem1";
      this.detailsToolStripMenuItem1.Size = new Size(122, 22);
      this.detailsToolStripMenuItem1.Text = "Details";
      this.detailsToolStripMenuItem1.Click += new EventHandler(this.detailsToolStripMenuItem_Click);
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      this.toolStripSeparator9.Size = new Size(142, 6);
      this.iEToolStripMenuItem1.Enabled = false;
      this.iEToolStripMenuItem1.Image = (Image) Resources.IE;
      this.iEToolStripMenuItem1.Name = "iEToolStripMenuItem1";
      this.iEToolStripMenuItem1.Size = new Size(145, 22);
      this.iEToolStripMenuItem1.Text = "&IE";
      this.iEToolStripMenuItem1.Click += new EventHandler(this.IETSB_Click);
      this.telnetToolStripMenuItem1.Enabled = false;
      this.telnetToolStripMenuItem1.Image = (Image) Resources.Telnet;
      this.telnetToolStripMenuItem1.Name = "telnetToolStripMenuItem1";
      this.telnetToolStripMenuItem1.Size = new Size(145, 22);
      this.telnetToolStripMenuItem1.Text = "&Telnet";
      this.telnetToolStripMenuItem1.Click += new EventHandler(this.telnetTSB_Click);
      this.pingToolStripMenuItem1.Enabled = false;
      this.pingToolStripMenuItem1.Image = (Image) Resources.Ping;
      this.pingToolStripMenuItem1.Name = "pingToolStripMenuItem1";
      this.pingToolStripMenuItem1.Size = new Size(145, 22);
      this.pingToolStripMenuItem1.Text = "&Ping";
      this.pingToolStripMenuItem1.Click += new EventHandler(this.pingTSB_Click);
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new Size(142, 6);
      this.exitToolStripMenuItem1.Image = (Image) Resources.Close;
      this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
      this.exitToolStripMenuItem1.Size = new Size(145, 22);
      this.exitToolStripMenuItem1.Text = "E&xit";
      this.exitToolStripMenuItem1.Click += new EventHandler(this.closeTSB_Click);
      this.imageList1.ColorDepth = ColorDepth.Depth32Bit;
      this.imageList1.ImageSize = new Size(40, 40);
      this.imageList1.TransparentColor = Color.Transparent;
      this.imageList2.ColorDepth = ColorDepth.Depth8Bit;
      this.imageList2.ImageSize = new Size(20, 20);
      this.imageList2.TransparentColor = Color.Transparent;
      this.timer1.Interval = 2000;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(776, 501);
      this.Controls.Add((Control) this.deviceListView);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.statusStrip1);
      this.Controls.Add((Control) this.toolStrip1);
      this.Controls.Add((Control) this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new Size(784, 528);
      this.Name = "MainForm";
      this.Load += new EventHandler(this.MainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private delegate void AddDeviceDele(Device device);

    private delegate void RefreshDeviceDele(Device device);

    private delegate void DeleteDeviceDele(Device device);

    private delegate void ClearDeviceDele();

    private delegate void SetProValueDele(int value);

    private delegate void SetProVisibleDele(bool visible);

    private delegate void SetMessageDele(string message, string oldMessage, bool isClear);
  }
}
