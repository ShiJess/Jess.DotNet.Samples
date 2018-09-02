using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此代码演示向控制台输出
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string course = "C#";  //课程名称

            // 向控制台输出信息
            Console.WriteLine("Hello Wangyexx .NET");

            // 向控制台输出单个变量
            Console.WriteLine(course);

            // + 连接输出字符串
            Console.WriteLine("我的课程名称是：" + course);

            // 使用格式字符串
            Console.WriteLine("我的课程名称是：{0}", course);

            Console.ReadLine();
        }
    }
}