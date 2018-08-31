using System;
class Class1
{
    public int value = 0;
}
class Demo
{
    static void Main()
    {
        int x = 0;
        int y = x;
        y = 80;
        Class1 ref1 = new Class1();
        Class1 ref2 = ref1;
        ref2.value = 80;
        Console.WriteLine("Value:{0},{1}", x, y);
        Console.WriteLine("Refs:{0},{1}", ref1.value, ref2.value);
    }
}