using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadStudyFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "System Thread";//给当前线程起名
            Console.WriteLine(Thread.CurrentThread.Name+"'s Status:"+Thread.CurrentThread.ThreadState);
            Console.ReadLine();
        }
    }
}
