using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 5;
            if (object.ReferenceEquals(i, j))
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
            i = j;
            Console.WriteLine(object.ReferenceEquals(i, j));
        }
    }
}
