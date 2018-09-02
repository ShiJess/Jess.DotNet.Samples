using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此示例演示使用 C# 中的一维数组
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 0, 1, 2, 3, 4 };// 声明并初始化一维数组
            for (int i = 0; i < array.Length; i++)    // 输出数组中的所有元素
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}