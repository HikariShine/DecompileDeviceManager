// Decompiled with JetBrains decompiler
// Type: DeviceManagement.SearchForm
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace DeviceManagement
{
  public class SearchForm : Form
  {
    private IPAddress ipAddress;
    private IContainer components;
    private Button button1;
    private Label label3;
    private TextBox txtUsername;

    public IPAddress IP
    {
      get
      {
        return this.ipAddress;
      }
    }

    public SearchForm()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        if (!IPAddress.TryParse(this.txtUsername.Text, out this.ipAddress))
          Program.ShowMessage(Message.InvalidIP, true);
        else
          this.DialogResult = DialogResult.OK;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        Program.ShowMessage(ex.Message, true);
        this.DialogResult = DialogResult.Cancel;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.button1 = new Button();
      this.label3 = new Label();
      this.txtUsername = new TextBox();
      this.SuspendLayout();
      this.button1.Location = new Point(142, 66);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Search";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label3.AutoSize = true;
      this.label3.Location = new Point(32, 33);
      this.label3.Name = "label3";
      this.label3.Size = new Size(65, 12);
      this.label3.TabIndex = 14;
      this.label3.Text = "IP Address";
      this.txtUsername.Location = new Point(105, 29);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new Size(163, 21);
      this.txtUsername.TabIndex = 13;
      this.AcceptButton = (IButtonControl) this.button1;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(289, 111);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.txtUsername);
      this.Controls.Add((Control) this.button1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "SearchForm";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "SearchDevice";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
