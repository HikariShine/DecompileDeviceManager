// Decompiled with JetBrains decompiler
// Type: DeviceManagement.Key
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DeviceManagement
{
  public class Key : Form
  {
    private IContainer components;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private TextBox textBox6;
    private TextBox textBox7;
    private Button button1;
    private Button button2;
    private Button button3;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private TextBox textBox8;

    public Key()
    {
      this.InitializeComponent();
    }

    private void cancelOld(int index, string text)
    {
      for (int index1 = 1; index1 < 9; ++index1)
      {
        if (index1 != index)
        {
          Control[] controlArray = this.Controls.Find("textBox" + (object) index1, false);
          if (controlArray.Length > 0)
          {
            TextBox textBox = (TextBox) controlArray[0];
            if (!(textBox.Text == ""))
            {
              if (text.IndexOf('+') == -1)
              {
                if (text == textBox.Text)
                  textBox.Text = "";
              }
              else if (textBox.Text.IndexOf('+') != -1 && (text.IndexOf("CTRL + ") == -1 && textBox.Text.IndexOf("CTRL + ") == -1 || text.IndexOf("CTRL + ") > -1 && textBox.Text.IndexOf("CTRL + ") > -1) && ((text.IndexOf("ALT + ") == -1 && textBox.Text.IndexOf("ALT + ") == -1 || text.IndexOf("ALT + ") > -1 && textBox.Text.IndexOf("ALT + ") > -1) && (text.IndexOf("SHIFT + ") == -1 && textBox.Text.IndexOf("SHIFT + ") == -1 || text.IndexOf("SHIFT + ") > -1 && textBox.Text.IndexOf("SHIFT + ") > -1)) && text.Substring(text.LastIndexOf('+')) == textBox.Text.Substring(textBox.Text.LastIndexOf('+')))
                textBox.Text = "";
            }
          }
        }
      }
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
      TextBox textBox = (TextBox) sender;
      string str = "";
      if (e.Control)
        str += "CTRL + ";
      if (e.Alt)
        str += "ALT + ";
      if (e.Shift)
        str += "SHIFT + ";
      if (e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Menu && e.KeyCode != Keys.ShiftKey)
        str += e.KeyCode.ToString();
      textBox.Text = str;
    }

    private bool setValue(TextBox t, int index)
    {
      if (!(t.Text != this.getString((ShortcutKeyType) index)))
        return true;
      if (t.Text == "")
      {
        Program.MyShortcutKeys[index] = (MyShortcutKey) null;
        Win32.WritePrivateProfileString("Keys", "K" + (object) (index + 1), "", Program.PATH + "\\Setting.ini");
        return true;
      }
      try
      {
        Program.MyShortcutKeys[index] = new MyShortcutKey(t.Text);
        Win32.WritePrivateProfileString("Keys", "K" + (object) (index + 1), t.Text, Program.PATH + "\\Setting.ini");
        return true;
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        return false;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!this.setValue(this.textBox1, 0) || !this.setValue(this.textBox2, 1) || (!this.setValue(this.textBox3, 2) || !this.setValue(this.textBox4, 3)) || (!this.setValue(this.textBox5, 4) || !this.setValue(this.textBox6, 5) || (!this.setValue(this.textBox7, 6) || !this.setValue(this.textBox8, 7))))
      {
        int num1 = (int) MessageBox.Show("Set Error!");
      }
      else
      {
        int num2 = (int) MessageBox.Show("Set OK!");
        this.DialogResult = DialogResult.OK;
      }
    }

    private void Key_Load(object sender, EventArgs e)
    {
      switch (Program.cultureInfo.Name)
      {
        case "zh-CHS":
          this.label1.Text = "搜索";
          this.label2.Text = "指定搜索";
          this.label3.Text = "配置";
          this.label4.Text = "清除";
          this.label5.Text = "退出";
          this.label6.Text = "IE";
          this.label7.Text = "Telnet";
          this.label8.Text = "Ping";
          this.button1.Text = "确定";
          this.button2.Text = "默认";
          this.button3.Text = "取消";
          break;
        case "zh-CHT":
          this.label1.Text = "搜索";
          this.label2.Text = "指定搜索";
          this.label3.Text = "配置";
          this.label4.Text = "清除";
          this.label5.Text = "退出";
          this.label6.Text = "IE";
          this.label7.Text = "Telnet";
          this.label8.Text = "Ping";
          this.button1.Text = "確定";
          this.button2.Text = "默認";
          this.button3.Text = "取消";
          break;
        default:
          this.label1.Text = "Search";
          this.label2.Text = "Specify Search";
          this.label3.Text = "Config";
          this.label4.Text = "Clear";
          this.label5.Text = "Exit";
          this.label6.Text = "IE";
          this.label7.Text = "Telnet";
          this.label8.Text = "Ping";
          this.button1.Text = "OK";
          this.button2.Text = "Default";
          this.button3.Text = "Cancel";
          break;
      }
      this.textBox1.Text = this.getString(ShortcutKeyType.SearchKey);
      this.textBox2.Text = this.getString(ShortcutKeyType.SpecifySearchKey);
      this.textBox3.Text = this.getString(ShortcutKeyType.ConfigKey);
      this.textBox4.Text = this.getString(ShortcutKeyType.ClearKey);
      this.textBox5.Text = this.getString(ShortcutKeyType.ExitKey);
      this.textBox6.Text = this.getString(ShortcutKeyType.IEKey);
      this.textBox7.Text = this.getString(ShortcutKeyType.TelnetKey);
      this.textBox8.Text = this.getString(ShortcutKeyType.PingKey);
    }

    private string getString(ShortcutKeyType types)
    {
      MyShortcutKey myShortcutKey = Program.MyShortcutKeys[(int) (byte) types];
      if (myShortcutKey == null)
        return "";
      return myShortcutKey.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.textBox1.Text = Program.DefaultMyShortcutKeys[0].ToString();
      this.textBox2.Text = Program.DefaultMyShortcutKeys[1].ToString();
      this.textBox3.Text = Program.DefaultMyShortcutKeys[2].ToString();
      this.textBox4.Text = Program.DefaultMyShortcutKeys[3].ToString();
      this.textBox5.Text = Program.DefaultMyShortcutKeys[4].ToString();
      this.textBox6.Text = Program.DefaultMyShortcutKeys[5].ToString();
      this.textBox7.Text = Program.DefaultMyShortcutKeys[6].ToString();
      this.textBox8.Text = Program.DefaultMyShortcutKeys[7].ToString();
    }

    private void textBox8_KeyUp(object sender, KeyEventArgs e)
    {
      TextBox textBox = (TextBox) sender;
      string str = textBox.Text.Replace(" ", "");
      if (str.LastIndexOf('+') == str.Length - 1)
        textBox.Text = "";
      else
        this.cancelOld(int.Parse(textBox.Name.Substring(textBox.Name.Length - 1)), textBox.Text);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.textBox3 = new TextBox();
      this.textBox4 = new TextBox();
      this.textBox5 = new TextBox();
      this.textBox6 = new TextBox();
      this.textBox7 = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.button3 = new Button();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.label8 = new Label();
      this.textBox8 = new TextBox();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(39, 13);
      this.label1.Name = "label1";
      this.label1.Size = new Size(41, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(39, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(41, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "label2";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(39, 65);
      this.label3.Name = "label3";
      this.label3.Size = new Size(41, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "label3";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(39, 92);
      this.label4.Name = "label4";
      this.label4.Size = new Size(41, 12);
      this.label4.TabIndex = 3;
      this.label4.Text = "label4";
      this.textBox1.BackColor = SystemColors.ActiveCaptionText;
      this.textBox1.Location = new Point(129, 9);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new Size(159, 21);
      this.textBox1.TabIndex = 4;
      this.textBox1.KeyUp += new KeyEventHandler(this.textBox8_KeyUp);
      this.textBox1.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
      this.textBox2.BackColor = SystemColors.ActiveCaptionText;
      this.textBox2.Location = new Point(129, 36);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new Size(159, 21);
      this.textBox2.TabIndex = 5;
      this.textBox2.KeyUp += new KeyEventHandler(this.textBox8_KeyUp);
      this.textBox2.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
      this.textBox3.BackColor = SystemColors.ActiveCaptionText;
      this.textBox3.Location = new Point(129, 61);
      this.textBox3.Name = "textBox3";
      this.textBox3.ReadOnly = true;
      this.textBox3.Size = new Size(159, 21);
      this.textBox3.TabIndex = 6;
      this.textBox3.KeyUp += new KeyEventHandler(this.textBox8_KeyUp);
      this.textBox3.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
      this.textBox4.BackColor = SystemColors.ActiveCaptionText;
      this.textBox4.Location = new Point(129, 88);
      this.textBox4.Name = "textBox4";
      this.textBox4.ReadOnly = true;
      this.textBox4.Size = new Size(159, 21);
      this.textBox4.TabIndex = 7;
      this.textBox4.KeyUp += new KeyEventHandler(this.textBox8_KeyUp);
      this.textBox4.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
      this.textBox5.BackColor = SystemColors.ActiveCaptionText;
      this.textBox5.Location = new Point(129, 115);
      this.textBox5.Name = "textBox5";
      this.textBox5.ReadOnly = true;
      this.textBox5.Size = new Size(159, 21);
      this.textBox5.TabIndex = 8;
      this.textBox5.KeyUp += new KeyEventHandler(this.textBox8_KeyUp);
      this.textBox5.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
      this.textBox6.BackColor = SystemColors.ActiveCaptionText;
      this.textBox6.Location = new Point(129, 142);
      this.textBox6.Name = "textBox6";
      this.textBox6.ReadOnly = true;
      this.textBox6.Size = new Size(159, 21);
      this.textBox6.TabIndex = 9;
      this.textBox6.KeyUp += new KeyEventHandler(this.textBox8_KeyUp);
      this.textBox6.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
      this.textBox7.BackColor = SystemColors.ActiveCaptionText;
      this.textBox7.Location = new Point(129, 169);
      this.textBox7.Name = "textBox7";
      this.textBox7.ReadOnly = true;
      this.textBox7.Size = new Size(159, 21);
      this.textBox7.TabIndex = 10;
      this.textBox7.KeyUp += new KeyEventHandler(this.textBox8_KeyUp);
      this.textBox7.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
      this.button1.Location = new Point(155, 223);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 11;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(12, 223);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 12;
      this.button2.Text = "Default";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.DialogResult = DialogResult.Cancel;
      this.button3.Location = new Point(236, 223);
      this.button3.Name = "button3";
      this.button3.Size = new Size(75, 23);
      this.button3.TabIndex = 13;
      this.button3.Text = "Cancel";
      this.button3.UseVisualStyleBackColor = true;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(39, 119);
      this.label5.Name = "label5";
      this.label5.Size = new Size(41, 12);
      this.label5.TabIndex = 14;
      this.label5.Text = "label5";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(39, 146);
      this.label6.Name = "label6";
      this.label6.Size = new Size(41, 12);
      this.label6.TabIndex = 15;
      this.label6.Text = "label6";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(39, 200);
      this.label7.Name = "label7";
      this.label7.Size = new Size(41, 12);
      this.label7.TabIndex = 16;
      this.label7.Text = "label7";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(39, 173);
      this.label8.Name = "label8";
      this.label8.Size = new Size(41, 12);
      this.label8.TabIndex = 17;
      this.label8.Text = "label8";
      this.textBox8.BackColor = SystemColors.ActiveCaptionText;
      this.textBox8.Location = new Point(129, 196);
      this.textBox8.Name = "textBox8";
      this.textBox8.ReadOnly = true;
      this.textBox8.Size = new Size(159, 21);
      this.textBox8.TabIndex = 18;
      this.textBox8.KeyUp += new KeyEventHandler(this.textBox8_KeyUp);
      this.textBox8.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
      this.AcceptButton = (IButtonControl) this.button1;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button3;
      this.ClientSize = new Size(323, 256);
      this.Controls.Add((Control) this.textBox8);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox7);
      this.Controls.Add((Control) this.textBox6);
      this.Controls.Add((Control) this.textBox5);
      this.Controls.Add((Control) this.textBox4);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "Key";
      this.RightToLeftLayout = true;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Load += new EventHandler(this.Key_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
