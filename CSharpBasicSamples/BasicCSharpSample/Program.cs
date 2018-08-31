using System;
public class format
{
    public static void Main()
    {
        decimal x = 11111111.976M;
        decimal y = 123456789123456789m;
        Console.Write("结果是：");
        Console.WriteLine("{0:C}", x);
        Console.Write("结果是：");
        Console.WriteLine("{0:C}", y);

    }
}