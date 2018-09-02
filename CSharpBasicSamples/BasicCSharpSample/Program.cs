using System;
using System.Collections.Generic;
using System.Text;

namespace HelloACCP
{
    /// <summary>
    /// 本示例演示如何在内层循环使用break
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;  // 计算共卖了多少件衣服
            int i, j;       // 循环变量
            string choice;  // 顾客的选择是否离开

            //外层循环控制依次进入下一个专卖店
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\n欢迎光临第{0}家专卖店", i + 1);
                for (j = 0; j < 3; j++)
                {
                    Console.Write("要离开吗(y/n)？");
                    choice = Console.ReadLine();
                    // 如果离开，就跳出，结账，进入下一个店
                    if (choice == "y")
                        break;
                    Console.WriteLine("买了一件衣服");
                    count++;  // 买一件衣服
                }
                Console.WriteLine("离店结账");
            }
            Console.WriteLine("\n共买了{0}件衣服", count);
            Console.ReadLine();
        }
    }
}