// Decompiled with JetBrains decompiler
// Type: DeviceManagement.CommunicationClass
// Assembly: DeviceManagement, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C274FE6-3F3D-446D-BA81-1D4C16975A33
// Assembly location: C:\Users\Administrator\Downloads\钥匙箱相关资料20150409\钥匙箱相关\钥匙箱配置\兰德华\网卡模块设置\Device Manager SPCNML.exe

using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DeviceManagement
{
  public class CommunicationClass
  {
    private static int REMOTEPORT = 5000;

    public static void InitUdpSocket(ref Batman batman, IPAddress ip, bool startRev)
    {
      batman = new Batman();
      batman.WorkSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, System.Net.Sockets.ProtocolType.Udp);
      batman.WorkSocket.ReceiveBufferSize = (int) ushort.MaxValue;
      EndPoint localEP = (EndPoint) new IPEndPoint(ip, 0);
      batman.WorkSocket.Bind(localEP);
      batman.WorkSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
      if (!startRev)
        return;
      ThreadPool.QueueUserWorkItem(new WaitCallback(CommunicationClass.ReceiveData), (object) batman);
    }

    public static void CloseSocket(Batman batman)
    {
      try
      {
        batman.WorkSocket.Close();
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
      }
    }

    private static void ReceiveData(object o)
    {
      Batman workBatman = (Batman) o;
      EndPoint remoteEP = (EndPoint) new IPEndPoint(IPAddress.Any, 0);
      try
      {
        while (!Program.IsCloseReceive)
        {
          int length;
          if ((length = workBatman.WorkSocket.ReceiveFrom(workBatman.RevBuffer, ref remoteEP)) > 0)
          {
            byte[] response = new byte[length];
            Array.Copy((Array) workBatman.RevBuffer, (Array) response, length);
            Array.Clear((Array) workBatman.RevBuffer, 0, Batman.BUFFERSIZE);
            byte num1 = response[1];
            if ((int) Controller.currentCommandID == (int) num1 || (int) num1 == (int) byte.MaxValue)
            {
              int num2 = (int) BitConverter.ToUInt16(new byte[2]
              {
                response[3],
                response[2]
              }, 0);
              if (response.Length == num2 && (int) response[0] % 2 == 0)
                DataListManger.AddRevFrameClass(new FrameClass(response, ((IPEndPoint) remoteEP).Address, workBatman));
            }
          }
        }
      }
      catch (SocketException ex)
      {
        Log.WriteException((Exception) ex);
        if (ex.ErrorCode == 10054 || ex.ErrorCode == 10004 || ex.ErrorCode == 10040)
          return;
        DataListManger.AddRevFrameClass(new FrameClass(new byte[4]
        {
          (byte) 254,
          byte.MaxValue,
          (byte) 0,
          (byte) 4
        }, ((IPEndPoint) remoteEP).Address, workBatman));
        Program.ShowMessage(ex.Message, true);
      }
      catch (ObjectDisposedException ex)
      {
        Log.WriteException((Exception) ex);
      }
      catch (Exception ex)
      {
        Log.WriteException(ex);
        DataListManger.AddRevFrameClass(new FrameClass(new byte[4]
        {
          (byte) 254,
          byte.MaxValue,
          (byte) 0,
          (byte) 4
        }, ((IPEndPoint) remoteEP).Address, workBatman));
        Program.ShowMessage(ex.Message, true);
      }
    }

    public static void SendUdp(FrameClass sendCommand, Batman batman)
    {
      sendCommand.Frame.CopyTo((Array) batman.SendBuffer, 0);
      IPEndPoint ipEndPoint = new IPEndPoint(sendCommand.CommIP, CommunicationClass.REMOTEPORT);
      batman.WorkSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
      batman.WorkSocket.SendTo(batman.SendBuffer, 0, (int) sendCommand.Length, SocketFlags.None, (EndPoint) ipEndPoint);
    }

    public static FrameClass SendAndReceive(byte[] sendCommand, IPAddress checkIP, IPAddress ip, byte identifier, Batman batman)
    {
      DataListManger.ClearFrameClass(identifier);
      sendCommand[1] = identifier;
      IPEndPoint ipEndPoint = new IPEndPoint(ip, CommunicationClass.REMOTEPORT);
      batman.WorkSocket.SendTo(sendCommand, (EndPoint) ipEndPoint);
      Thread.Sleep(50);
      FrameClass revFrameClass = DataListManger.GetRevFrameClass(identifier, checkIP);
      int num1 = 0;
      int num2 = 200;
      while (revFrameClass == null && num1 < 6)
      {
        Thread.Sleep(num2 * ++num1);
        revFrameClass = DataListManger.GetRevFrameClass(identifier, checkIP);
        if (revFrameClass == null && num1 % 2 == 1)
        {
          identifier = Controller.GetNewCommandID();
          sendCommand[1] = identifier;
          batman.WorkSocket.SendTo(sendCommand, (EndPoint) ipEndPoint);
        }
      }
      DataListManger.ClearFrameClass(identifier);
      return revFrameClass;
    }

    public static FrameClass SendAndReceive(FrameClass sendCommand, Batman batman)
    {
      DataListManger.ClearFrameClass(sendCommand.Identifier);
      CommunicationClass.SendUdp(sendCommand, batman);
      Thread.Sleep(50);
      FrameClass revFrameClass = DataListManger.GetRevFrameClass(sendCommand.Identifier, sendCommand.IpAddr);
      int num1 = 0;
      int num2 = 200;
      while (revFrameClass == null && num1 < 6)
      {
        Thread.Sleep(num2 * ++num1);
        revFrameClass = DataListManger.GetRevFrameClass(sendCommand.Identifier, sendCommand.IpAddr);
        if (revFrameClass == null && num1 % 2 == 1)
          CommunicationClass.SendUdp(sendCommand, batman);
      }
      DataListManger.ClearFrameClass(sendCommand.Identifier);
      return revFrameClass;
    }
  }
}
