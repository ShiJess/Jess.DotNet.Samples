using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此示例演示向控制台输出学员信息，在一行当中使用多个{0}、{1}...
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string name1;  // 第一个学员姓名
            string name2;  // 第二个学员姓名
            int age1;      // 第一个学员年龄
            int age2;      // 第二个学员年龄            

            // 输入第一个学员提示
            Console.WriteLine("请输入第一个学员的姓名：");
            name1 = Console.ReadLine();
            Console.WriteLine("请输入第一个学员的年龄：");
            age1 = int.Parse(Console.ReadLine());

            // 输入第二个学员提示
            Console.WriteLine("请输入第二个学员的姓名：");
            name2 = Console.ReadLine();
            Console.WriteLine("请输入第二个学员的年龄：");
            age2 = int.Parse(Console.ReadLine());

            // 输出学员信息
            Console.WriteLine("第一个学员的姓名" + name1 + ",年龄" + age1 + "岁");
            Console.WriteLine("第二个学员的姓名{0},年龄{1}岁", name2, age2);

            Console.ReadLine();
        }
    }
}