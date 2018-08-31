using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习4_11
{
    public interface MyInterface
    {
        string Name { get; }
    }
    class MyClass : MyInterface
    {
        public string Name { get { return "only a test!"; } }
    }
    class Program
    {

        static void Main(string[] args)
        {
            MyInterface x = new MyClass();
            Console.WriteLine(x.Name);
        }
    }
}
