using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 本示例演示利用二重循环打印直角三角形
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;  // 打印的行数
            int i, j;      // 循环变量

            // 外层循环控制打印的行数
            for (i = 1; i <= rows; i++)
            {
                // 内层循环控制每行打印*的个数
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");  // 打印一个 *
                }
                Console.WriteLine();     // 打印完一行之后换行
            }
            Console.ReadLine();
        }
    }
}