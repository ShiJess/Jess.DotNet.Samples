using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此程序演示如何使用嵌套 if 结构
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int price = 4000;  // 机票的原价
            int month;         // 出行的月份
            int type;          // 头等舱为1,经济舱为2

            Console.WriteLine("请输入您出行的月份：1-12");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("请问您选择头等舱还是经济舱？头等舱输入1，经济舱输入2");
            type = int.Parse(Console.ReadLine());

            if (month >= 5 && month <= 10)  // 旺季
            {
                if (type == 1)        // 头等舱
                {
                    Console.WriteLine("您的机票价格为：{0}", price * 0.9);
                }
                else if (type == 2)  // 经济舱
                {
                    Console.WriteLine("您的机票价格为：{0}", price * 0.75);
                }
            }
            else  // 淡季
            {
                if (type == 1)       // 头等舱
                {
                    Console.WriteLine("您的机票价格为：{0}", price * 0.6);
                }
                else if (type == 2)  // 经济舱
                {
                    Console.WriteLine("您的机票价格为：{0}", price * 0.3);
                }
            }

            Console.ReadLine();
        }
    }
}