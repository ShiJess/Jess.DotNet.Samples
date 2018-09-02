using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    // 此示例演示使用方法计算税后工资
    class Program
    {
        static void Main(string[] args)
        {
            int pay;      // 税前工资  
            float taxRate = 0.1f;  // 税率
            float afterTax;  // 税后工资
            Console.WriteLine("请输入税前工资：");
            pay = int.Parse(Console.ReadLine());

            // 调用方法计算税后工资
            afterTax = GetPay(pay, taxRate);
            Console.WriteLine("税前工资{0}，税后工资{1}", pay, afterTax);

            Console.ReadLine();
        }

        // 此方法根据税前工资计算税后工资
        private static float GetPay(int pay, float taxRate)
        {
            float afterTax;  // 计税后的工资
            if (pay <= 1600)  // 低于1600不缴税
            {
                afterTax = pay;
            }
            else   // 高于1600 部分按税率缴税
            {
                afterTax = pay - (pay - 1600) * taxRate;
            }
            return afterTax;
        }
    }
}