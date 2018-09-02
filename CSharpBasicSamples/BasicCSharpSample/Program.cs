using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此代码演示如何使用switch语句
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "张三";    // 第一个学员姓名
            string name2 = "李四";    // 第二个学员姓名
            string subject1 = "C#";   // 第一个学员考试科目
            string subject2 = "Java"; // 第二个学员考试科目
            int score1 = 91;          // 第一个学员考试分数
            int score2 = 89;          // 第二个学员考试分数

            // 输入提示
            Console.WriteLine("请选择输出哪个学员的信息：张三 / 李四");

            string choice = Console.ReadLine();  // 接收输入

            // 判断输入，选择输出
            Console.WriteLine("姓名\t科目\t成绩");
            switch (choice)
            {
                case "张三":
                    Console.WriteLine("{0}\t{1}\t{2}", name1, subject1, score1);
                    break;
                case "李四":
                    Console.WriteLine("{0}\t{1}\t{2}", name2, subject2, score2);
                    break;
                default:
                    Console.WriteLine("抱歉！没有你要找的学员！");
                    break;
            }

            Console.ReadLine();
        }
    }
}