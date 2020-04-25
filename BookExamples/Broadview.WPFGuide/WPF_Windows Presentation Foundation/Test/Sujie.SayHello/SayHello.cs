//*************************************************
//Copyright (C):	Sujie
//文件名（File Name）：	SayHello.cs
//作者（Author）：	Sujie
//版本（Version）：	1.0
//创建日期（Create Date）：	2013.07.05
//功能描述（Description）：
//主要函数列表（Function List）：
//修改记录（Revision History）：
//*************************************************

using System;
using System.Windows;

namespace Sujie.SayHello
{
    class SayHello
    {
        [STAThread]
        public static void Main()
        {
            Window win = new Window();
            win.Title = "Say Hello";
            win.Show();

            Application app = new Application();
            app.Run();
        }
    }
}