using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadStudyFifth
{
    class TimerExampleState
    {
        public int counter = 0;
        public Timer tmr;
    }

    class Program
    {
        static void Main(string[] args)
        {
            TimerExampleState s = new TimerExampleState();

　　        //创建代理对象TimerCallback，该代理将被定时调用
　　        TimerCallback timerDelegate = new TimerCallback(CheckStatus);

            //创建一个时间间隔为1s的定时器
            Timer timer = new Timer(timerDelegate, s,1000, 1000);
            s.tmr = timer;

            //主线程停下来等待Timer对象的终止
            while(s.tmr != null)
            Thread.Sleep(0);
            Console.WriteLine("Timer example done.");
            Console.ReadLine();
　　    }

　　    //下面是被定时调用的方法
　　    static void CheckStatus(Object state)
　　    {
            TimerExampleState s =(TimerExampleState)state;
            s.counter++;
            Console.WriteLine("{0} Checking Status {1}.",DateTime.Now.TimeOfDay, s.counter);

            if(s.counter == 5)
            {
                //使用Change方法改变了时间间隔
                (s.tmr).Change(10000,2000);
                Console.WriteLine("changed");
            }

            if(s.counter == 10)
            {
                Console.WriteLine("disposing of timer");
                s.tmr.Dispose();
                s.tmr = null;
            }
　　    }
        
    }
}
