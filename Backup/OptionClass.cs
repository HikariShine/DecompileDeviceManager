// Decompiled with JetBrains decompiler
// Type: DeviceManagement.OptionClass
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.Data;

namespace DeviceManagement
{
  public class OptionClass
  {
    private string propertyName = "";
    private string dataType = "";
    private byte[] option;
    private ushort optionType;
    private byte length;
    private byte maxLength;
    private byte[] optionData;

    public byte[] Option
    {
      get
      {
        return this.option;
      }
    }

    public ushort OptionType
    {
      get
      {
        return this.optionType;
      }
      set
      {
        this.optionType = value;
      }
    }

    public string PropertyName
    {
      get
      {
        return this.propertyName;
      }
      set
      {
        this.propertyName = value;
      }
    }

    public byte Length
    {
      get
      {
        return this.length;
      }
      set
      {
        this.length = value;
      }
    }

    public byte MaxLength
    {
      get
      {
        return this.maxLength;
      }
      set
      {
        this.maxLength = value;
      }
    }

    public byte[] OptionData
    {
      get
      {
        return this.optionData;
      }
      set
      {
        this.optionData = value;
      }
    }

    public string DataType
    {
      get
      {
        return this.dataType;
      }
      set
      {
        this.dataType = value;
      }
    }

    public OptionClass(DataRowView dr, byte[] data)
    {
      this.propertyName = ((string) dr["propertyName"]).Trim();
      this.optionData = data;
      this.optionType = (ushort) dr["code"];
      this.maxLength = (byte) ((uint) Convert.ToByte(dr["maxLength"].ToString().Trim()) + 3U);
      this.dataType = dr["dataType"].ToString().Trim();
      this.createOption();
    }

    public OptionClass(string property, byte[] data, bool isNewVersion)
    {
      this.propertyName = property;
      this.optionData = data;
      DataView dataView = ProtocolData.Translation(this.propertyName, isNewVersion);
      if (dataView != null && dataView.Count > 0)
      {
        this.optionType = (ushort) dataView[0]["code"];
        this.maxLength = (byte) ((uint) Convert.ToByte(dataView[0]["maxLength"].ToString().Trim()) + 3U);
        this.dataType = dataView[0]["dataType"].ToString().Trim();
        this.createOption();
      }
      else
        this.maxLength = (byte) 0;
    }

    public OptionClass(byte[] responseOption, bool isNewVersion)
    {
      this.option = responseOption;
      this.readOption();
      this.RefreshOption(isNewVersion);
      this.length = (byte) this.option.Length;
    }

    public void RefreshOption(bool isNewVersion)
    {
      DataRowView dataRowView = (int) this.optionType < 179 || (int) this.optionType >= 184 ? ((int) this.optionType < 184 || (int) this.optionType >= 189 ? ProtocolData.Translation(this.optionType, isNewVersion) : ProtocolData.Translation((ushort) 184, isNewVersion)) : ProtocolData.Translation((ushort) 179, isNewVersion);
      this.propertyName = dataRowView["propertyName"].ToString().Trim();
      this.dataType = dataRowView["dataType"].ToString().Trim();
      this.maxLength = (byte) ((uint) Convert.ToByte(dataRowView["maxLength"].ToString().Trim()) + 3U);
    }

    public void createOption()
    {
      if (this.optionData == null)
      {
        this.length = (byte) 3;
        this.option = new byte[3];
      }
      else
      {
        this.length = this.maxLength;
        this.option = new byte[(int) this.maxLength];
      }
      this.option[0] = (byte) Math.Floor((double) this.optionType / 256.0);
      this.option[1] = (byte) ((uint) this.optionType % 256U);
      this.option[2] = this.length;
      if (this.optionData == null)
        return;
      Array.Copy((Array) this.optionData, 0, (Array) this.option, 3, this.optionData.Length);
    }

    private void readOption()
    {
      this.optionType = BitConverter.ToUInt16(new byte[2]
      {
        this.option[1],
        this.option[0]
      }, 0);
      this.length = this.option[2];
      this.optionData = new byte[this.option.Length - 3];
      Array.Copy((Array) this.option, 3, (Array) this.optionData, 0, this.option.Length - 3);
    }
  }
}
