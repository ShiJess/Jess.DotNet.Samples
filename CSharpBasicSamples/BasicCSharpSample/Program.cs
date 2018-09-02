using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此程序演示字符串的常用处理方法，从邮箱地址中提取用户名
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string email;  // 邮箱地址
            string choice; // 用户的选择
            string name;   // 邮箱用户名

            do
            {
                Console.WriteLine("请输入你的邮箱地址：");
                email = Console.ReadLine();

                Console.WriteLine("你的邮箱地址是:{0}", email); //前两步中使用                

                // 抽取邮箱用户名
                int position = email.IndexOf("@");    // 完善的第三步：使用IndexOf
                if (position > 0)
                {
                    name = email.Substring(0, position);  // 完善的第三步：使用Substring

                    // 输出邮箱用户名
                    Console.WriteLine("你的邮箱用户名是：{0}", name);
                }
                else
                {
                    Console.WriteLine("你的邮箱格式错误！");
                }

                Console.WriteLine("是否要继续？yes/no");           // 第一步
                choice = Console.ReadLine();

                choice = choice.Trim().ToLower(); //完善的第二步：使用Trim 、ToLower方法
            } while (choice.Equals("yes"));  // 完善的第一步：使用Equals判断

            Console.ReadLine();
        }
    }
}