# Bottom_Control 
                                                           关于说明  
1: 无代码访问PLC的控件 通过Visual Studio 拖拽控件设置相应的参数就可以访问PLC简单易用 适用于工业开发作为底层减少项目代码量提高稳定性  正在全力开发  
2:视频展示链接：https://pan.baidu.com/s/12TFRdkp64Kqo6_oK1gdbNw 提取码: lo33  
3:项目控件使用视频展示 https://pan.baidu.com/s/1Sd7JBtRMBqxguB0ZFbR3Zg 提取码： pkve   
![image](https://user-images.githubusercontent.com/60955669/109391193-d1d9f980-7950-11eb-9e46-09c125089a27.png)

                                                           使用步骤 
1：先拖拽plC_Open_Time1控件   
2：设置好相应的PLC参数  
3：然后拖拽出DAButton1控件  
4：设置好PLC类型参数  
5：在FORM窗口的Load 事件添加上plC_Open_Time1.Enabled = true;  
6：plC_Open_Time1.Start(); 以上代码   

                                                           注意  
 1：plC_Open_Time1控件只能使用一次  否则报错    
 2: 清理解决方案会导致plC_Open_Time1控件出现错误（已修复）   
 3:有些控件需要配合SQL 数据库使用前要熟知 否则出现报错导致项目崩溃不负责  
 
                                                   关于用户自定义控件   
 1:控件类型分为Bit位线圈操作类型与字双字操作类型   
 2:分别继承类基Button_base TextBox_base实现了就可以设置相应的参数  
 3:控件操作PLC--Bit位 通过实例化Button_PLC类 调用plc(this)方法 方可 反之字操作类型实例化TextBox_PLC类型  
 4:每个控件都自带 System.Windows.Forms.Timer类型的定时器作为刷新UI  
 5:西门子S200 smart 访问V区 输入方式为DB 1.0 这样就是访问VB0
 
 
关于转换成Dll引用到其他项目的方法：
1.先把项目转换成类库然后编译 
2.编译成功后去项目的DEbug文件夹把全部dll引导到你的项目
3.然后找到Bottom_Control.dll拖拽到IDE拖拽控件处更待IDE更新就可以拖拽控件方式。
4.可以引用完成后直接清理解决方案然后重新生产的方法。
