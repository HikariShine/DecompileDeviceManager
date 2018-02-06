// Decompiled with JetBrains decompiler
// Type: DeviceManagement.LoginForm
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DeviceManagement
{
  public class LoginForm : Form
  {
    private IContainer components;
    private TextBox txtPwd;
    private TextBox txtUsername;
    private Label label3;
    private Label label4;
    private Button loginbt;
    private Button cannelbt;
    private Device currentDevice;

    public Device CurrentDevice
    {
      set
      {
        this.currentDevice = value;
      }
    }

    public LoginForm()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.txtPwd = new TextBox();
      this.txtUsername = new TextBox();
      this.label3 = new Label();
      this.label4 = new Label();
      this.loginbt = new Button();
      this.cannelbt = new Button();
      this.SuspendLayout();
      this.txtPwd.Location = new Point(101, 48);
      this.txtPwd.Name = "txtPwd";
      this.txtPwd.PasswordChar = '*';
      this.txtPwd.Size = new Size(163, 21);
      this.txtPwd.TabIndex = 11;
      this.txtUsername.Location = new Point(101, 14);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new Size(163, 21);
      this.txtUsername.TabIndex = 10;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(36, 21);
      this.label3.Name = "label3";
      this.label3.Size = new Size(59, 12);
      this.label3.TabIndex = 12;
      this.label3.Text = "Username:";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(36, 52);
      this.label4.Name = "label4";
      this.label4.Size = new Size(59, 12);
      this.label4.TabIndex = 13;
      this.label4.Text = "Password:";
      this.loginbt.Location = new Point(70, 86);
      this.loginbt.Name = "loginbt";
      this.loginbt.Size = new Size(75, 23);
      this.loginbt.TabIndex = 14;
      this.loginbt.Text = "Login";
      this.loginbt.UseVisualStyleBackColor = true;
      this.loginbt.Click += new EventHandler(this.btnLogin_Click);
      this.cannelbt.Location = new Point(162, 86);
      this.cannelbt.Name = "cannelbt";
      this.cannelbt.Size = new Size(75, 23);
      this.cannelbt.TabIndex = 15;
      this.cannelbt.Text = "Cannel";
      this.cannelbt.UseVisualStyleBackColor = true;
      this.cannelbt.Click += new EventHandler(this.btnCancel_Click);
      this.AcceptButton = (IButtonControl) this.loginbt;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.cannelbt;
      this.ClientSize = new Size(291, 121);
      this.Controls.Add((Control) this.cannelbt);
      this.Controls.Add((Control) this.loginbt);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.txtPwd);
      this.Controls.Add((Control) this.txtUsername);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "LoginForm";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Login";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      this.currentDevice.UserName = this.txtUsername.Text.Trim();
      this.currentDevice.UserPsw = this.txtPwd.Text.Trim();
      ResponseTypes responseTypes;
      Controller.OptionMassage(responseTypes = Controller.AuthUser(this.currentDevice));
      if (responseTypes != ResponseTypes.OK)
        return;
      this.currentDevice.IsLogged = true;
      this.DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}
