using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此示例演示使用Split()和Join()方法分割和连接字符串
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;  // 输入的字符串
            string[] splitStrings; // 分割后的字符串数组
            string joinString;  // 连接后的新字符串

            // 输入提示
            Console.WriteLine("请输入一串字符串，用空格分隔单词：");
            inputString = Console.ReadLine();//  接收输入

            splitStrings = inputString.Split(' ');  // 以空格作为分隔符分割字符串

            // 将分割后的字符串输出
            Console.WriteLine("\n分割后的字符串为：");
            foreach (string s in splitStrings)
            {
                Console.WriteLine(s);
            }

            // 将分割后的字符串使用下划线连接在一起
            joinString = string.Join("_", splitStrings);

            // 将连接后的字符串输出
            Console.WriteLine("\n连接后的新字符串为：{0}", joinString);

            Console.ReadLine();
        }
    }
}