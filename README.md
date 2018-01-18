# KiwiSurfaceDefectInspection 猕猴桃表面缺陷检测

## what project does

>国外水果检测方面的研究起步较早，已经做了很多工作。基于机器视觉和机电一体化技术的水果尺寸、形状和颜色分级技术已经成熟，基于实现自动化检测，给我们提供了许多宝贵的学习经验。
而目前国内对于水果颜色、纹理等检测研究上取得了很大的进展，有些技术也已经用于实际生产中。但运用机器视觉技术检测水果的外观缺陷依旧是一个研究难题。

## 图像采集

>在白光照射下用工业相机对猕猴果实进行图像采集。

<img src="http://ovzxu2ccl.bkt.clouddn.com/frame.png" style="width=50%;height=50%" />

## 图像处理

>主要是基于Microsoft Visual Studio2013设计的软件界面，运用相关的C#中图像处理和检测的算法，对猕猴桃果实图像进行去燥灰度化二值化处理图像并获取最佳阈值，最后图像分割得到猕猴桃果实表面的黑色斑点区域，包括真正的缺陷区域和梗萼区域。

**原始图像**
<img src = "http://ovzxu2ccl.bkt.clouddn.com/mihoutao.png" style="width=50%;height=50%" />

**处理后图像**
<img src = "http://ovzxu2ccl.bkt.clouddn.com/result.png" style="width=50%;height=50%"/>

## 模块通信

>相机自动采集图像并存至预先设定的盘内，计算机自动处理图像并将处理水果的结果通过串口通信传给单片机，处理结果分五个等级，单片机接受这个五个等级所携带的信息作出相应动作指令，实现自动化剔除缺陷水果果实和保留无缺陷水果果实的功能。

**软件截图**
<img src="http://ovzxu2ccl.bkt.clouddn.com/processpic.png" style="width=50%;height=50%"/>

## installation & Dependency

>1.install visual studio 2013 via download from official website

## Example usage

>just compile sln and run it,before that you should have some example pictrues in the folder

## Meta

Allen Zhou – [@Weibo](http://weibo.com/zhouyuangan) – 1401499346@qq.com

Distributed under the MIT license. See ``LICENSE`` for more information.

[https://github.com/AllenZhou1996/KiwiSurfaceDefectInspection](https://github.com/AllenZhou1996/)
