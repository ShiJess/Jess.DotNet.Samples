using System;
public class ChengEr
{
    public static void Main()
    {
        int x;
        //x = Console.Read()-48;//输入的为一位数
        string z = Console.ReadLine();
        x = Int32.Parse(z);
        int y = x * 2;
        Console.WriteLine("{0}乘以2后的结果为{1}", x, y);
    }
}