using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此示例演示贯穿 case 的break
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入当前的时间：");
            string time = Console.ReadLine(); // 接受输入

            switch (time)　　// 根据时间输出
            {
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    Console.WriteLine("上午好");
                    break;
                case "11":
                case "12":
                case "13":
                    Console.WriteLine("中午好");
                    break;
                case "14":
                case "15":
                case "16":
                case "17":
                case "18":
                    Console.WriteLine("下午好");
                    break;
                default:
                    Console.WriteLine("休息时间");
                    break;
            }

            Console.ReadLine();
        }
    }
}