# Bottom_Control 
                                                           关于说明  
无代码访问PLC的控件 通过Visual Studio 拖拽控件设置相应的参数就可以访问PLC简单易用 适用于工业开发作为底层减少项目代码量提高稳定性 目前支持6款控件 正在全力开发  

                                                           使用步骤 
1：先拖拽plC_Open_Time1控件   
2：设置好相应的PLC参数  
3：然后拖拽出DAButton1控件  
4：设置好PLC类型参数  
5：在FORM窗口的Load 事件添加上plC_Open_Time1.Enabled = true;  
6：plC_Open_Time1.Start(); 以上代码   

                                                           注意  
 1：plC_Open_Time1控件只能使用一次  否则报错    
 2: 清理解决方案会导致plC_Open_Time1控件出现错误（删除重写添加即可）  
 
