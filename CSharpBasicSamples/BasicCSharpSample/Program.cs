using System;
public class Demo
{
    public static void Main()
    {
        short x = 1;
        decimal y = 2.2m;
        double z = 3.3;
        Console.WriteLine("结果是：");
        //Console.WriteLine(x + y + z);   //错误，无法进行隐式类型转换
        Console.WriteLine(x + y);
        Console.WriteLine(x + z);
        //Console.WriteLine(y+z);   //错误，decimal类型无法隐式转换
    }
}