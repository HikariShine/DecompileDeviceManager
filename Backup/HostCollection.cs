// Decompiled with JetBrains decompiler
// Type: DeviceManagement.HostCollection
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.Collections;

namespace DeviceManagement
{
  public class HostCollection : ICollection, IEnumerable
  {
    private ArrayList _itemList;
    private bool canDNS;
    private Device dev;

    public Host this[int index]
    {
      get
      {
        return (Host) this._itemList[index];
      }
    }

    public int Count
    {
      get
      {
        return this._itemList.Count;
      }
    }

    public bool IsSynchronized
    {
      get
      {
        return this._itemList.IsSynchronized;
      }
    }

    public object SyncRoot
    {
      get
      {
        return this._itemList.SyncRoot;
      }
    }

    public HostCollection(bool canDNS, Device dev)
    {
      this._itemList = ArrayList.Synchronized(new ArrayList());
      this.canDNS = canDNS;
      this.dev = dev;
    }

    public void CopyTo(Array array, int index)
    {
      this._itemList.CopyTo(array, index);
    }

    public IEnumerator GetEnumerator()
    {
      return this._itemList.GetEnumerator();
    }

    public void Add(Host item)
    {
      this._itemList.Add((object) item);
      item.canDNS = this.canDNS;
      item.dev = this.dev;
    }

    public void Remove(Host item)
    {
      this._itemList.Remove((object) item);
    }

    public void RemoveAt(int index)
    {
      this._itemList.RemoveAt(index);
    }

    public void RemoveRange(int index, int count)
    {
      this._itemList.RemoveRange(index, count);
    }

    public void Insert(Host item, int index)
    {
      this._itemList.Insert(index, (object) item);
      item.canDNS = this.canDNS;
      item.dev = this.dev;
    }

    public Host[] ToArray()
    {
      return (Host[]) this._itemList.ToArray(typeof (Host));
    }
  }
}
