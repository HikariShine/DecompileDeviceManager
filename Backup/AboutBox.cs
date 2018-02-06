// Decompiled with JetBrains decompiler
// Type: DeviceManagement.AboutBox
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DeviceManagement
{
  internal class AboutBox : Form
  {
    private IContainer components;
    private TableLayoutPanel tableLayoutPanel;
    private PictureBox logoPictureBox;
    private Label labelProductName;
    private Label labelVersion;
    private Label labelCopyright;
    private Label labelCompanyName;
    private TextBox textBoxDescription;
    private Button okButton;

    public AboutBox()
    {
      this.InitializeComponent();
      SoftInfor softInfor = SoftInfor.GetSoftInfor();
      this.Text = "About " + softInfor.ProductName;
      this.labelProductName.Text = "Software name:" + softInfor.ProductName;
      this.labelVersion.Text = "Version:" + softInfor.Version;
      this.labelCopyright.Text = "CopyRight©:" + softInfor.CopyRight;
      this.labelCompanyName.Text = "CompanyName:" + softInfor.CompanyName;
      this.textBoxDescription.Text = softInfor.Description;
      this.logoPictureBox.Image = softInfor.Logo;
    }

    private void labelCopyright_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.tableLayoutPanel = new TableLayoutPanel();
      this.logoPictureBox = new PictureBox();
      this.labelProductName = new Label();
      this.labelVersion = new Label();
      this.labelCopyright = new Label();
      this.labelCompanyName = new Label();
      this.okButton = new Button();
      this.textBoxDescription = new TextBox();
      this.tableLayoutPanel.SuspendLayout();
      ((ISupportInitialize) this.logoPictureBox).BeginInit();
      this.SuspendLayout();
      this.tableLayoutPanel.ColumnCount = 2;
      this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.72182f));
      this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.27818f));
      this.tableLayoutPanel.Controls.Add((Control) this.logoPictureBox, 0, 0);
      this.tableLayoutPanel.Controls.Add((Control) this.labelProductName, 1, 0);
      this.tableLayoutPanel.Controls.Add((Control) this.labelVersion, 1, 1);
      this.tableLayoutPanel.Controls.Add((Control) this.labelCopyright, 1, 2);
      this.tableLayoutPanel.Controls.Add((Control) this.labelCompanyName, 1, 3);
      this.tableLayoutPanel.Controls.Add((Control) this.okButton, 0, 5);
      this.tableLayoutPanel.Controls.Add((Control) this.textBoxDescription, 0, 4);
      this.tableLayoutPanel.Dock = DockStyle.Fill;
      this.tableLayoutPanel.Location = new Point(9, 8);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 6;
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
      this.tableLayoutPanel.Size = new Size(417, 245);
      this.tableLayoutPanel.TabIndex = 0;
      this.logoPictureBox.Dock = DockStyle.Fill;
      this.logoPictureBox.Location = new Point(3, 3);
      this.logoPictureBox.Name = "logoPictureBox";
      this.tableLayoutPanel.SetRowSpan((Control) this.logoPictureBox, 4);
      this.logoPictureBox.Size = new Size(192, 90);
      this.logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
      this.logoPictureBox.TabIndex = 12;
      this.logoPictureBox.TabStop = false;
      this.labelProductName.Dock = DockStyle.Fill;
      this.labelProductName.Location = new Point(204, 0);
      this.labelProductName.Margin = new Padding(6, 0, 3, 0);
      this.labelProductName.MaximumSize = new Size(0, 16);
      this.labelProductName.Name = "labelProductName";
      this.labelProductName.Size = new Size(210, 16);
      this.labelProductName.TabIndex = 19;
      this.labelProductName.Text = "产品名称";
      this.labelProductName.TextAlign = ContentAlignment.MiddleLeft;
      this.labelVersion.Dock = DockStyle.Fill;
      this.labelVersion.Location = new Point(204, 24);
      this.labelVersion.Margin = new Padding(6, 0, 3, 0);
      this.labelVersion.MaximumSize = new Size(0, 16);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new Size(210, 16);
      this.labelVersion.TabIndex = 0;
      this.labelVersion.Text = "版本";
      this.labelVersion.TextAlign = ContentAlignment.MiddleLeft;
      this.labelCopyright.Dock = DockStyle.Fill;
      this.labelCopyright.Location = new Point(204, 48);
      this.labelCopyright.Margin = new Padding(6, 0, 3, 0);
      this.labelCopyright.MaximumSize = new Size(0, 16);
      this.labelCopyright.Name = "labelCopyright";
      this.labelCopyright.Size = new Size(210, 16);
      this.labelCopyright.TabIndex = 21;
      this.labelCopyright.Text = "Copyright ©";
      this.labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
      this.labelCopyright.Click += new EventHandler(this.labelCopyright_Click);
      this.labelCompanyName.Dock = DockStyle.Fill;
      this.labelCompanyName.Location = new Point(204, 72);
      this.labelCompanyName.Margin = new Padding(6, 0, 3, 0);
      this.labelCompanyName.MaximumSize = new Size(0, 16);
      this.labelCompanyName.Name = "labelCompanyName";
      this.labelCompanyName.Size = new Size(210, 16);
      this.labelCompanyName.TabIndex = 22;
      this.labelCompanyName.Text = "公司名称";
      this.labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
      this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.tableLayoutPanel.SetColumnSpan((Control) this.okButton, 2);
      this.okButton.DialogResult = DialogResult.Cancel;
      this.okButton.Location = new Point(339, 221);
      this.okButton.Name = "okButton";
      this.okButton.Size = new Size(75, 21);
      this.okButton.TabIndex = 24;
      this.okButton.Text = "确定(&O)";
      this.tableLayoutPanel.SetColumnSpan((Control) this.textBoxDescription, 2);
      this.textBoxDescription.Dock = DockStyle.Fill;
      this.textBoxDescription.Location = new Point(6, 99);
      this.textBoxDescription.Margin = new Padding(6, 3, 3, 3);
      this.textBoxDescription.Multiline = true;
      this.textBoxDescription.Name = "textBoxDescription";
      this.textBoxDescription.ReadOnly = true;
      this.textBoxDescription.ScrollBars = ScrollBars.Both;
      this.textBoxDescription.Size = new Size(408, 116);
      this.textBoxDescription.TabIndex = 23;
      this.textBoxDescription.TabStop = false;
      this.textBoxDescription.Text = "说明";
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(435, 261);
      this.Controls.Add((Control) this.tableLayoutPanel);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutBox";
      this.Padding = new Padding(9, 8, 9, 8);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "AboutBox";
      this.tableLayoutPanel.ResumeLayout(false);
      this.tableLayoutPanel.PerformLayout();
      ((ISupportInitialize) this.logoPictureBox).EndInit();
      this.ResumeLayout(false);
    }
  }
}
