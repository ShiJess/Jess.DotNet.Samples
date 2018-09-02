using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此程序演示内层循环continue应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;       // 循环变量
            int sum = 0;    // 总分
            int average;    // 平均分
            int score;      // 输入的分数
            int count = 0;  // 分数在85分以上的学员数目

            // 外层循环控制逐个计算每个班级
            for (i = 0; i < 3; i++)
            {
                sum = 0;   // 总分清0，重新计算
                Console.WriteLine("\n请输入第{0}个班的成绩", i + 1);
                // 内层循环计算每个班级的总分
                for (j = 0; j < 4; j++)
                {
                    Console.Write("第{0}个学员的成绩：", j + 1);
                    score = int.Parse(Console.ReadLine());
                    sum = sum + score;

                    // 如果成绩不高于85分，继续执行，跳过计数
                    if (score < 85)
                    {
                        continue;
                    }
                    count++;
                }
                average = sum / 4;
                Console.WriteLine("第{0}个班的平均分为：{1}分", i + 1, average);
            }
            Console.WriteLine("成绩在85分以上的学员有{0}人", count);

            Console.ReadLine();
        }
    }
}