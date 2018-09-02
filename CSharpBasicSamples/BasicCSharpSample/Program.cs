using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此示例演示使用方法交换两个数
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("请输入两个数字：");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("交换前两个数的分别为：{0}和{1}", num1, num2);

            // 交换两个数的值
            Swap(ref num1, ref num2);

            Console.WriteLine("交换后两个数的分别为：{0}和{1}", num1, num2);
            Console.ReadLine();
        }

        private static void Swap(ref int num1, ref int num2)
        {
            int temp;      // 中间变量
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}