using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习4_1
{
    class A
    {
        public A()
        {
            PrintFields();
        }
        public virtual void PrintFields() { }
    }
    class B : A
    {
        int x = 1;
        int y;
        public B()
        {
            y = -1;
        }
        public override void PrintFields()
        {
            Console.WriteLine("x={0},y={1}", x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
        }
    }
}
