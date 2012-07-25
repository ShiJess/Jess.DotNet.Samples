using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    /// <summary>
    /// C#和winform开发 C#时尚编程——第一章 编程初步
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            BasicOutput();
            FormatOutput();
            CommandLineParameter(args);
           
            Console.ReadKey();
        }

        //Console.WriteLine();基本输出
        static void BasicOutput()
        {
            Console.WriteLine("Hello,the World!");
        }

        //Console.WriteLine();格式化输出
        static void FormatOutput()
        {
            string strName;
            Console.Write("please input your name:");
            strName = Console.ReadLine();
            Console.WriteLine("hello,{0}!", strName);
        }

        //命令行参数
        static void CommandLineParameter(string[] args)
        {
            args=new string[1];
            string strName;
            strName = args[0];
            Console.WriteLine("This is the first argument:{0}!",strName);
        }
    }
}
