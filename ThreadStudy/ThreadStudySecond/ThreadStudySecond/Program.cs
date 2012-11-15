using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadStudySecond
{
    public class Alpha
    {
        public void Beta()
        {
            while (true)
            {
                Console.WriteLine("Alpha.Beta is running in its own thread.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread Start/Stop/Join Sample");

            Alpha oAlpha = new Alpha();
        //这里创建一个线程，使之执行Alpha类的Beta()方法
            Thread oThread = new Thread(new ThreadStart(oAlpha.Beta));
            oThread.Start();
            while (!oThread.IsAlive)
                Thread.Sleep(1);
            oThread.Abort();
            oThread.Join();
            Console.WriteLine();
            Console.WriteLine("Alpha.Beta has finished");
            try
            {
                Console.WriteLine("Try to restart the Alpha.Beta thread");
                oThread.Start();
            }
            catch (ThreadStateException)
            {
                Console.Write("ThreadStateException trying to restart Alpha.Beta. ");
                Console.WriteLine("Expected since aborted threads cannot be restarted.");
                Console.ReadLine();
            }
            return;
        }
    }
}
