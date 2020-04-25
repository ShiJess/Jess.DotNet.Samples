//*************************************************
//Copyright (C):	Sujie
//文件名（File Name）：	HandleAnEvent.cs
//作者（Author）：	Sujie
//版本（Version）：	1.0
//创建日期（Create Date）：	2013.07.05
//功能描述（Description）：
//主要函数列表（Function List）：
//修改记录（Revision History）：
//*************************************************

using System;
using System.Windows;
using System.Windows.Input;

namespace Sujie.HandleAnEvent
{
    class HandleAnEvent
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();

            Window win = new Window();
            win.Title = "Handle An Event";
            win.MouseDown += WindowOnMouseDown;

            app.Run(win);
        }
        static void WindowOnMouseDown(object sender,MouseButtonEventArgs args)
        {
            Window win = sender as Window;
            string strMessage = 
                string.Format("Window clicked with {0} button at point ({1})",
                            args.ChangedButton,args.GetPosition(win));
            MessageBox.Show(strMessage,win.Title);
        }
    }
}