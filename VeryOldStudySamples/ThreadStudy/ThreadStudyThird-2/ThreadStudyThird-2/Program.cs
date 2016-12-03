using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadStudyThird_2
{
    class Program
    {
        static void Main(string[] args)
        {
             int result = 0; //一个标志位，如果是0表示程序没有出错，如果是1表明有错误发生
        Cell cell = new Cell( ); 

        //下面使用cell初始化CellProd和CellCons两个类，生产和消费次数均为20次
        CellProd prod = new CellProd(cell, 20); 
        CellCons cons = new CellCons(cell, 20); 

        Thread producer = new Thread(new ThreadStart(prod.ThreadRun));
        Thread consumer = new Thread(new ThreadStart(cons.ThreadRun));
        //生产者线程和消费者线程都已经被创建，但是没有开始执行 
        try
        {
　　　　    producer.Start( );
　　　　    consumer.Start( ); 

　　　　    producer.Join( ); 
　　　　    consumer.Join( );
　　　　    Console.ReadLine();
        }
        catch (ThreadStateException e)
        {
　　　　    //当线程因为所处状态的原因而不能执行被请求的操作
　　　　    Console.WriteLine(e); 
　　　　    result = 1; 
        }
        catch (ThreadInterruptedException e)
        {
　　　　    //当线程在等待状态的时候中止
　　　　    Console.WriteLine(e); 
　　　　    result = 1; 
        }
        //尽管Main()函数没有返回值，但下面这条语句可以向父进程返回执行结果
        Environment.ExitCode = result;
　　    
        }
    }
}
