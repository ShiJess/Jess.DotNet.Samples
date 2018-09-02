using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此程序演示如何使用foreach循环
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 输入提示            
            Console.WriteLine("请输入一个字符串：");

            // 从控制台读入字符串
            string line = Console.ReadLine();

            // 循环输出字符串中的字符
            foreach (char c in line)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}