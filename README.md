# 关于量化交易蒙特卡罗试验

[![AppVeyor build status](https://ci.appveyor.com/api/projects/status/github/softethervpn/softethervpn?branch=master&svg=true)](https://ci.appveyor.com/project/softethervpn/softethervpn) [![Travis CI build status](https://travis-ci.org/SoftEtherVPN/SoftEtherVPN.svg?branch=master)](https://travis-ci.org/SoftEtherVPN/SoftEtherVPN) [![gitlab-ci build status](https://gitlab.com/SoftEther/SoftEtherVPN/badges/master/build.svg)](https://gitlab.com/SoftEther/SoftEtherVPN/pipelines) [![Coverity Scan Build Status](https://scan.coverity.com/projects/16304/badge.svg)](https://scan.coverity.com/projects/softethervpn-softethervpn)

- 对于很多量化交易爱好者而言，回测是进入实盘交易的必经之路，对于自己有相当的ＩＴ－计算机程序方面基础的交易员而言，大量的随机性试验在自建平台上是可以很轻松实现的，但是对于使用第三方量化交易软件的量化交易者而言，大量的随机性和移动式区间回测，样本内外回测，观察资金曲线在蒙特卡罗样本下的集合性表现就是一个比较难去实现的关卡。基于这个考量，笔者在Multicharts的基础上开发了可以进行蒙特卡罗回测的交易工具，可以在这个基础上进行高密度的策略压力测试，以观察自己策略的普适性和潜在的过度拟合的嫌疑，能更加客观的面对自己的交易策略的表现。

* * *
### 预期测试效果 - 1.静态终结果
*
![image](https://github.com/handayu/OandaTrading/blob/master/image/backtest.jpg)


### 预期测试效果 - 2.动态回测过程
*
![image](https://github.com/handayu/OandaTrading/blob/master/image/trading.gif)

### 问题的提出？

- 对于任意策略，Multicharts无法生成任意时间区间段的时间长度集合进行回测，虽然在[参数优化]这个功能里有移动区间取样功能，但是还是存在时间随机指定的局限，甚至于对于有些特殊图形交易者而言，静态图的移动取样，因为起始点是静态的，所以，测出来的回测结果也只是那个起始点情境下的移动取样和移动样本回测。

- 我们需要大量的随机试验和样本内外，甚至更加极限状态下的回测模式。

* * *

### 技术应用？
- ThirdPartySoftWare Multicharts
- Trade Strategy交易策略
- Use Multicharts PowerLanguage Edit
- 事件引擎
- Windows Hook
- .Net Framework4.6.1


### 参与本项目？

如有兴趣的量化－程序化交易员或者团队:
   请加 QQ：578931169。
   WeChart: hanyu196910
   
   <h3 id="weibo-weixin">微信</h3>
 *「DotNet」：专注 .NET量化交易平台开发，量化交易，程序化交易，投资组合构建。
   <br><img src="https://github.com/handayu/OandaTrading/blob/master/image/wechart.jpg" width=150 height=150>
* * *

### Ｋ线图表和特殊图表－问题的初衷

- 我们会发现，和时间序列下的回测不一样的是。时间序列下的回测，无论测试时间长度前面增加多少数据(多少比tick或者多少天)，都不会影响原来测试区间的回测曲线。

- 例如，我们测试2019年1月1日到2019年1月20日，策略为Bolland的策略，Bar-Type为普通时间序列K线。那么，无论我们在2019年1月1日之前增加多少数据，测试下来都不会影响1.1-1.20本身的资金曲线，始终是一致的。
   
- 但，对于Renko-Chart来说，情况却并非这样。
   
- 我们生成的Renko始终和前一笔行情是有关系的。例如1.1日-1.20日的k线行情是 　　　-1，0，1，1，2，4，3，4，5。砖为2。那么几块砖的起点分别为-1，1，3，5。我们按照这个行情测试下来的曲线为1。此时，我们在1.1日的前面增加几笔数据，新的K线行情为，-4，-2，-2，-1，0，1，2，3，4，5，6，7.砖依旧是2。那么几块砖的起点分别为-4,-2,0,2,4,6。所以，在砖图原来测试区间的前面增加哪怕一笔Tic，回测出的曲线也会和之前一样的区间回测出的绩效有一些差异，当然猜想是，这个差异在一个巨大的时间区间下，随着时间推演，信号会慢慢被抹平，和其他增加和不增加数据的资金曲线不会差异太大，反而会缩小这种差异，最终会呈现一样的曲线。

- 但是这仅仅是个猜想，在用砖图交易的过程中，到底用哪个起始点作为回测或者实盘的绘制砖图的起点，一直是个困扰，因为有时候，短期内，曲线的差异还是有点大的(相同的砖)。还是说无论你用2018年1.1日9：00作为起始点，还是2018年1.1日9:01作为起始点，还是说用2018年1.2日10：00作为起始点，终点为2019年1.1日10：00.曲线都不会有太大的差异，或者说不同的品种他自身这种差异到底有多大？

- 当然，我们预期和想要结果是，在用砖图本身这个问题存在的情况下，如果上述问题，无论用任何点作为起始点，在未来半年，一年或者一段相当长的时期内，各个起始点回测下来的资金曲线的形状（因为交易笔数不一样，所以可以只看本身的走势）还是在第一象限，或者所有的资金曲线，还都是往上走的。那么，策略和砖图本身因为选择起始点造成的资金曲线在短期内不太一样的情况，就可以相对忽略，因为如果能验证这个结论，那么我们心里有底的是，短期内的影响不一致本身就没有好坏之分，更何况未来一个更长的时间之后，行情本身会逐渐抹平这种效应，所有的资金曲线还是在第一象限而且走势都相对趋近于一致。

- 问题截图：
　　　例如，下图1是：J 2018-9-16日 / 2019-1-11日资金曲线图/下图2是：J 2018-9-20日 / 2019-1-11日资金曲线图

- 我们会发现，即使剔除掉资金曲线前四天的绩效，后面的资金曲线在微观处也有一些差异，这个就是起始点造成的，甚至在信号上也有细微的差异。

 - 下图是18年9.16日，和9.20日作为起始点，在19年元月局部的信号差异。
  　　　　　　
 - 因为起始点不一样，所以信号会有些微小差异，并且这种差异在局部可能差异比较大，但是能想到的是，在一个相当长的时间之后，这种差异造成的资金曲线不同会被抹平。我们可以看到因为起始点不同，除了信号不一样，最末尾形成的砖即时行情也不一样。
   
- 所以，现在可以利用Multicharts的CommandLine搭配外部工具，可以不间断指定任意起始点和终点，进行100-1000次甚至更多次的回测，最后绘制成曲线族，看是否所有区间段或者任意移动区间的资金曲线都在第一象限或者往上走的资金曲线的形态。

* * *

### 解决方案

- .Multi charts-CommandLine命令集合链接：
     https://www.multicharts.com/trading-software/index.php/CommandLine


- .比如需要调用出IF的指定区间段的Renko图，周期可以默认为Tick（设置一次即可），在CommandLine旁边，策略加载一次就可以了，之后可以只用ComandLine选择起始和终点即可，加载的策略可以直接在公式编辑器中打印出每笔盈亏，外部工具获取，绘制出曲线，这样利用工具，可以同时绘制出成千上万了同品种同策略不同区间段的策略资金曲线，用于看普适性和上述出现的起始点问题，Ｋ线图表也是同样的道理。
　　　
- Multicharts CommandLine指令实例　.csy dnum=1, name=CFFEX.IF HOT, df=MCTrader, res=1 min,from=12/31/2018, to=1/5/2019

## 其他列表（Other Lists）

