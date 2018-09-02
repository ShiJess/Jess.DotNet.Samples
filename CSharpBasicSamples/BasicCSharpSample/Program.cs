using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此示例演示使用 Convert 进行不同类型之间的转换
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 85.63; // 原始数值
            int myInt;  // 转换后的整型
            float myFloat;  // 转换后的浮点型            
            string myString;  // 转换后的字符串

            Console.WriteLine("原始数值为 double 类型：{0}", myDouble);
            // 开始转换
            myInt = Convert.ToInt32(myDouble); // 转换为整型
            myFloat = Convert.ToSingle(myDouble);  // 转换为浮点型            
            myString = Convert.ToString(myDouble); // 转换为字符串

            // 输出
            Console.WriteLine("转换后：");
            Console.WriteLine("int\tfloat\tstring");
            Console.WriteLine("{0}\t{1}\t{2}", myInt, myFloat, myString);
            Console.ReadLine();
        }
    }
}