# 记一次反编译修复软件bug的有趣经历

修复DeviceManager的bug
修复DeviceManager不能远程连接硬件的bug
根本原因是默认使用广播模式来远程连接，导致不在同一个网段的设备无法正常连接。
通过强制使用UDP连接方式修复该bug。


### 前言
最近在忙一个硬件相关的项目，该硬件包含一个网络模块，上位机可以通过网络与硬件连接，并修改硬件配置。在尝试修改硬件配置时，发现定点搜索可以搜到硬件设备，但是在连接时却连不上，故事就这样发生了...

### 问题描述
首先看下连接软件的截图和相关功能：

![上位机软件截图.png](https://note.youdao.com/yws/api/personal/file/973B7E68CBA24A43AF74DE49A6393EA5?method=download&shareKey=b91a41f4bfc698c985ba237e76791bb3)

已知有两种情况：
1. 可以正常搜索并连接的

    有一个设备与电脑当前网络处于同一网关，该软件可通过搜索和指定搜索功能搜索到该设备，且双击输入密码后可正常连接。

    连接截图：![设备已连接截图.png](https://note.youdao.com/yws/api/personal/file/386828A3A43E42E1A5CF5CED0A1022C1?method=download&shareKey=55cf63e6dc09d09c281272a56085a766)

2. 不同网段的可指定搜索，但不能正常连接

    不能通过搜索是因为不在同一个网关下面，而搜索其实是通过广播方式进行的，指定搜索可以搜索到，但是连接不上，这个是有点奇怪的。

    连接失败截图：![设备连接失败截图.png](https://note.youdao.com/yws/api/personal/file/A64CD0B41E4C433EBAD9F2B21EC1C579?method=download&shareKey=c7c296a04f95e7ea5d02c01f8f42fef2)

那么基本可以推断是网段的原因了，问题是，既然能搜索到，使用定点连接为何不行呢。难道是因为软件只支持定点搜索，而不提供定点连接。或者是定点搜索的到，但是连接时出了问题？

为了确认原因，拿出了抓包神器wireshark。

### 抓包分析

#### 一、对搜索进行抓包分析

##### 对同网段设备搜索进行抓包分析：

> ip.dst == 10.73.177.223 || ip.src == 10.73.177.223 || ip.src == 255.255.255.255 || ip.dst == 255.255.255.255

![搜索同网段抓包](https://note.youdao.com/yws/api/personal/file/79F8076CAF204764B1311D9B98DED25A?method=download&shareKey=748b0b06b7d1ce95f2064b4d61c9a68d)

可以看到四个一组。

1. 第一个包，使用了TAPA协议，向255.255.255.255的5000端口发起一个广播。TAPA是基于UDP的协议，一个设备发现的协议。
2. 第二个包，使用了UDP协议，都是发往的5000端口。
3. 第三个包，在设备收到该广播时，会使用UDP协议回复该广播，第一条回复地址是广播源地址和端口，即直接向广播发起方进行回复。
4. 第四个包，设备又回复了一个广播，广播内容与第三个包内容相同，以防第三个包无法被软件处理。

第三个包和第四个包内容相同，包含了一些设备信息，如软件版本等。

##### 对同网段指定搜索进行抓包

接着对同网段进行指定搜索，观察一下如何发现设备的![指定搜索同网段抓包.png](https://note.youdao.com/yws/api/personal/file/2ECC9FCCD3604859BB279090C889AC7F?method=download&shareKey=e89a8ccfe580544aa71f1dbc00489132)

与非指定搜索有一个不同：

1. 发送UDP广播，与非指定搜索相同
2. 点对点发送TAPA数据包，直接向目标IP的5000端口发送TAPA数据包，同非指定搜索的广播TAPA包。
3. 设备回复一个广播UDP包。同非指定搜索的第四个包。
4. 直接向请求IP回复UDP包，包内容同3.

##### 对不同网段的指定搜索抓包

> ip.dst == 10.72.216.250 || ip.src == 10.72.216.250 || ip.src == 255.255.255.255 || ip.dst == 255.255.255.255

不废话，直接看结果![指定搜索不同网段抓包.png](https://note.youdao.com/yws/api/personal/file/D58F749241E44DBA9E9938ECCF983716?method=download&shareKey=144bd63ee8eff84f3edd402d3d36e820)

1. 点对点发送的TAPA数据包。
2. 发一个UDP广播包
3. 收到设备点对点回复的UDP包

这里没有其他包是因为设备的广播包在软件所在网段是收不到的。

#### 二、对连接进行抓包分析

##### 同网段设备的连接分析

![同网段连接抓包.png](https://note.youdao.com/yws/api/personal/file/755DEA4744B84315ABC2D579B16A301F?method=download&shareKey=f4d7307ad4fec711b9f9cc4e59288e31)

1. 软件发送UDP广播包申请连接，包内容包含了加密的用户名和密码(其实后来知道是base64，不算加密)
2. 设备通过UDP广播包回复接受连接
3. 软件通过UDP广播发送连接成功，申请获取设备参数(猜测)
4. 设备通过UDP广播回复设备参数

可以看到，连接竟然是使用的广播方式，难怪非同网段的连接不了。那么看下不同网段的连接是否和猜想一样

##### 不同网段设备的连接分析

![不同网段设备连接抓包](https://note.youdao.com/yws/api/personal/file/1CF83362C6294D21B10A163996E8B3F8?method=download&shareKey=df29cde00c7d7284083990e982f887a9)

发现有四个相同的包，应该是同一个包的重发。因为不能收到设备的接受连接广播包，所以无法正常连接，这就是报错的原因。

那么就是只支持广播方式连接设备？感觉不太可能，但是目前只能查到这里，直到发现了一个特殊的设备，竟然可以远程连接...

#### 三、对可远程连接设备进行抓包分析

在尝试过程中，竟然发现了一个可以远程连接的设备，赶紧对其连接过程进行抓包分析：

> ip.dst == 10.71.2.251 || ip.src == 10.71.2.251 || ip.src == 255.255.255.255 || ip.dst == 255.255.255.255

搜索的数据包同上面不同网段的数据包，直接看连接数据包：

![不同网段可连接设备抓包](https://note.youdao.com/yws/api/personal/file/088B33FEBA5C45C3B6B7063AB551E0A2?method=download&shareKey=24445b11bbfdfc20dd455378647c7a4b)

对比同网段可连接设备的数据包和不同网段不能连接的数据包，发现有个很大不同
1. 软件点对点发送TAPA数据包，而不是发送广播包进行连接。这个TAPA数据包类似于指定搜索的数据包。
2. 设备回复点对点UDP数据包，接受连接。
3. 软件通过点对点UDP发送连接成功包，请求设备参数
4. 设备通过点对点UDP回复自身参数给软件

可以看到包的内容基本上与同网段的连接包相同，唯一的区别就是原来的广播方式变成了点对点的UDP通信。

据此判断，远程连接是肯定支持的，是因为某种原因导致连接时误用了广播模式，而非点对点UDP模式导致的。

为了确认其他设备是可以通过点对点UDP来连接的，通过网络调试助手，直接对目标设备发送对应数据包，查看结果。

#### 四、网络调试助手模拟发送数据包

1. 获取可远程连接设备的初始TAPA数据包内容：
> 05 17 00 14 59 57 52 74 61 57 34 67 59 57 52 74 61 57 34 3d
2. 对目标10.72.216.250的5000发送UDP数据包，内容如上。并得到回复数据包。
![网络调试助手模拟发送连接数据包.png](https://note.youdao.com/yws/api/personal/file/C3554B27AAB44A33AB685F92A244435B?method=download&shareKey=291ff1bcb6d14f696783639a147962a3)
3. 通过抓包软件可以看到，2中发送的数据包的回复内容，同可连接设备的回复内容。上图也可以看到，两者恢复内容是相同的。
4. 有戏，继续发送请求参数包
> 01 1f 00 28 00 88 03 00 bf 03 00 c0 03 00 c1 03 00 c2 03 00 c3 03 00 c4 03 00 c5 03 00 c6 03 00 c7 03 00 c8 03 00 c9 03

得到回复数据包

![网络调试助手模拟发送请求参数数据包.png](https://note.youdao.com/yws/api/personal/file/65963BB5879F4D1B894D376FD4A91A6C?method=download&shareKey=d4ed11c075cee1e184181c6be76b8e62)

5. 比较两者的回复数据包和抓包软件中的数据包，除了部分字节不同外，大部分是相同的，由此可判断，确实是可远程连接的，只不过是连接软件有bug导致部分设备无法使用UDP远程连接，只能通过广播方式连接。

### 修复连接软件BUG！

既然事已至此，就只能怀疑是软件bug了。事到如今，只有以下几个方法了
1. 获取数据包解码方式，模拟软件执行一些操作
2. 反编译软件，修复bug后再编译回去

第一步都只能反编译，通过观察推测，该软件使用的是.net编写，最近发现的一个反编译神器正好可以使用。

使用JetBrains dotPeek进行反编译，直接导出工程
![dotPeek导出反编译项目.png](https://note.youdao.com/yws/api/personal/file/1572DCF4D7B1401F9FF94B4DEAFA9F66?method=download&shareKey=9ef307d419cd4f3828f7bf391de6425d)
使用Visual Studio打开工程，修复一些反编译错误：
![VS打开项目.png](https://note.youdao.com/yws/api/personal/file/46CFCA041494478D9489B8E26CA60C7E?method=download&shareKey=1a85e35e6f11b687eb507433ac61150a)
图中错误是无法识别ref参数，错误的反编译了引用复制，直接按照下面方式修复即可。

修复后成功启动，找到软件登录框点击登录后的回调
```
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
```
通过调试发现，报错的位置在Controller.AuthUser(this.currentDevice)中，打开源码：
```
public static ResponseTypes AuthUser(Device currentDevice)
{
  try
  {
    string s = currentDevice.UserName + " " + currentDevice.UserPsw;
    long length = (long) (4.0 / 3.0 * (double) s.Length);
    if (length % 4L != 0L)
      length += 4L - length % 4L;
    char[] outArray = new char[length];
    Convert.ToBase64CharArray(Encoding.ASCII.GetBytes(s), 0, s.Length, outArray, 0);
    // 使用base64进行数据包处理
    byte num1 = (byte) (4UL + (ulong) length);
    ushort num2 = (ushort) 4;
    byte[] sendCommand;
    IPAddress ip;
    switch (currentDevice.CommunicationType)
    {
      case CommunicationTypes.UDP:
        sendCommand = new byte[(int) num1];
        sendCommand[0] = (byte) 5;
        ip = currentDevice.IP;
        break;
      case CommunicationTypes.Broadcast:
        num1 += (byte) 4;
      // ......
    }
  }
}
```
继续调试，发现是进入了分支CommunicationTypes.Broadcast:也就是说直接使用了广播模式进行连接，看来是因为currentDevice.CommunicationType的值不太对。

那么可能就不是软件bug了，因为这个信息是从搜索设备时的相应中获得的，那就是设备中固定使用广播模式来进行连接。

但是对于我这种需要强制进行远程连接的用户来说，这个判断就不是必要的了，直接强制修改：
> currentDevice.CommunicationType = CommunicationTypes.UDP;

再进行调试发现果然可以成功连接(顺便修改了软件的标题证明自己的劳动成功)：
![修改后软件成功连接.png](https://note.youdao.com/yws/api/personal/file/2BFD607561FD47A98499D8B0BDF97584?method=download&shareKey=115758cdf6f12e3f2483ea08c9618400)


该源码项目已放到github中开源：https://github.com/HikariShine/DecompileDeviceManager

### 后记
写这篇文章嘛有两个目的：
1. 炫技
2. 提供下解决问题的思路：对比分析、透过问题看本质、由浅入深循序渐进

有什么意见和建议欢迎大家提出哈，谢谢阅读


### 相关知识
1. 网络协议
2. 抓包
3. 反编译
4. C#

### 相关软件
1. WireShark
2. 网络调试助手
3. DotPeek
4. Visual Studio

### 参考链接
1. [.net反编译的九款神器](https://www.cnblogs.com/zsuxiong/p/5117465.html)
2. [修复反编译错误](https://stackoverflow.com/questions/11067395/what-is-the-ampersand-character-at-the-end-of-an-object-type)
