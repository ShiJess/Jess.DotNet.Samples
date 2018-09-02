using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWangyexx
{
    /// <summary>
    /// 此示例演示 String 类的 Format 方法
    /// 输出一段个人信息
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string name;  // 姓名            
            string birthday;  // 出生年月
            int height;  // 身高
            string bloodType;  // 血型
            string planet;  // 星座
            string favourFood;  // 最喜欢的食物
            string record;  // 个人档案

            Console.WriteLine("你好，欢迎来到 C# 世界！");
            Console.WriteLine("请输入你的个人信息，我将为你建立个人档案！");
            Console.Write("姓名：");
            name = Console.ReadLine();
            Console.Write("出生年月（*年*月格式）：");
            birthday = Console.ReadLine();
            Console.Write("身高(cm)：");
            height = int.Parse(Console.ReadLine());
            Console.Write("血型：");
            bloodType = Console.ReadLine();
            Console.Write("星座：");
            planet = Console.ReadLine();
            Console.Write("最喜欢的食物：");
            favourFood = Console.ReadLine();

            record = string.Format(
                "姓名：{0}\n出生年月：{1}\n身高：{2}\n血型：{3}\n星座：{4}\n最喜欢的食物：{5}",
                name, birthday, height, bloodType, planet, favourFood);

            Console.WriteLine("\n这是你的个人档案：");
            Console.WriteLine(record);

            Console.ReadLine();
        }
    }
}