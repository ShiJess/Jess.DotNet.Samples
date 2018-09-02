using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 本程序演示使用二重循环实现数组的冒泡排序算法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            int i, j;  // 循环变量
            int temp;  // 临时变量

            // 读入成绩
            Console.WriteLine("请输入5个学员的成绩：");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第{0}个学员的成绩：", i + 1);
                scores[i] = int.Parse(Console.ReadLine());//类型转换  
            }

            // 开始排序
            for (i = 0; i < scores.Length - 1; i++)
            {
                for (j = 0; j < scores.Length - 1 - i; j++)
                {
                    if (scores[j] > scores[j + 1])
                    {
                        // 交换元素
                        temp = scores[j];
                        scores[j] = scores[j + 1];
                        scores[j + 1] = temp;
                    }
                }
            }

            // 排序后输出
            Console.WriteLine("排序后的成绩为：");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}\t", scores[i]);
            }

            Console.ReadLine();
        }
    }
}