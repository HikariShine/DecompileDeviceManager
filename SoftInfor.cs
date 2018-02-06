// Decompiled with JetBrains decompiler
// Type: DeviceManagement.SoftInfor
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using DeviceManagement.Properties;
using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Resources;

namespace DeviceManagement
{
  public sealed class SoftInfor
  {
    private static SoftInfor singleton;
    private string resourcesName;
    private string productName;
    private string softTitle;
    private string version;
    private string copyRight;
    private string companyName;
    private string description;
    private Image logo;
    private Image deviceLargePic;
    private Image deviceSmallPic;

    public string ProductName
    {
      get
      {
        return this.productName;
      }
      set
      {
        this.productName = value;
      }
    }

    public string SoftTitle
    {
      get
      {
        return this.softTitle;
      }
      set
      {
        this.softTitle = value;
      }
    }

    public string Version
    {
      get
      {
        return this.version;
      }
      set
      {
        this.version = value;
      }
    }

    public string CopyRight
    {
      get
      {
        return this.copyRight;
      }
      set
      {
        this.copyRight = value;
      }
    }

    public string CompanyName
    {
      get
      {
        return this.companyName;
      }
      set
      {
        this.companyName = value;
      }
    }

    public string Description
    {
      get
      {
        return this.description;
      }
      set
      {
        this.description = value;
      }
    }

    public Image Logo
    {
      get
      {
        return this.logo;
      }
      set
      {
        this.logo = value;
      }
    }

    public Image DeviceLargePic
    {
      get
      {
        return this.deviceLargePic;
      }
      set
      {
        this.deviceLargePic = value;
      }
    }

    public Image DeviceSmallPic
    {
      get
      {
        return this.deviceSmallPic;
      }
      set
      {
        this.deviceSmallPic = value;
      }
    }

    private void LoadSoftInforDefaultValue()
    {
      this.productName = "DeviceManager";
      this.softTitle = "DeviceManager 2.0";
      this.version = "2.0.0.0";
      this.copyRight = "(C) 2009 iLink";
      this.companyName = "iLink";
      this.description = "device manage tool";
      this.logo = (Image) Resources.logo;
      this.deviceLargePic = (Image) Resources.deviceLargePic;
      this.deviceSmallPic = (Image) Resources.deviceSmallPic;
    }

    public static SoftInfor GetSoftInfor()
    {
      if (SoftInfor.singleton == null)
      {
        SoftInfor.singleton = new SoftInfor();
        SoftInfor.singleton.resourcesName = Environment.CurrentDirectory + "\\resources.dll";
        if (!SoftInfor.singleton.ReadSoftInforResources(SoftInfor.singleton.resourcesName))
        {
          SoftInfor.singleton.LoadSoftInforDefaultValue();
          SoftInfor.singleton.WriteSoftInforResources(SoftInfor.singleton.resourcesName);
        }
      }
      return SoftInfor.singleton;
    }

    private bool WriteSoftInforResources(string resourcesFileName)
    {
      try
      {
        using (ResourceWriter resourceWriter = new ResourceWriter(resourcesFileName))
        {
          foreach (PropertyInfo propertyInfo in SoftInfor.singleton.GetType().GetProperties())
          {
            object obj = propertyInfo.GetValue((object) SoftInfor.singleton, (object[]) null);
            resourceWriter.AddResource(propertyInfo.Name.ToLower(), obj);
          }
          resourceWriter.Generate();
        }
        return true;
      }
      catch
      {
        return false;
      }
    }

    private bool ReadSoftInforResources(string resourcesFileName)
    {
      try
      {
        using (ResourceReader resourceReader = new ResourceReader(resourcesFileName))
        {
          IDictionaryEnumerator enumerator = resourceReader.GetEnumerator();
          foreach (FieldInfo fieldInfo in SoftInfor.singleton.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
          {
            while (enumerator.MoveNext())
            {
              if (enumerator.Key.ToString().Equals(fieldInfo.Name.ToLower()))
              {
                fieldInfo.SetValue((object) SoftInfor.singleton, enumerator.Value);
                break;
              }
            }
            enumerator.Reset();
          }
        }
        return true;
      }
      catch
      {
        return false;
      }
    }

    public bool SaveSoftInforResources()
    {
      return SoftInfor.singleton.WriteSoftInforResources(SoftInfor.singleton.resourcesName);
    }
  }
}
