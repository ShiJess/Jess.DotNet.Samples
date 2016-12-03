using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            string s="";
            int iterations;
            for (imagCoord = 1.2; imagCoord >= -1.2;imagCoord-=0.1 )
            {
                string s1="";
                for (realCoord = -0.6; realCoord <= 1.77;realCoord+=0.03 )
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg=(realCoord*realCoord)+(imagCoord*imagCoord);
                    while((arg<4)&&(iterations<40))
                    {
                        realTemp2=(realTemp*realTemp)-(imagTemp*imagTemp)-realCoord;
                        imagTemp=(2*realTemp*imagTemp)-imagCoord;
                        realTemp = realTemp2;
                        arg=(realTemp*realTemp)+imagTemp*imagTemp;
                        iterations += 1;
                    }
                    switch(iterations%4)
                    {
                        case 0:
                            //Console.Write(".");
                            s1 =s1+ ".";
                            break;
                        case 1:
                            //Console.Write("o");
                            s1 = s1 + "o";
                            break;
                        case 2:
                            //Console.Write("O");
                            s1 = s1 + "O";
                            break;
                        case 3:
                            //Console.Write("0");
                            s1 = s1 + "0";
                            break;
                    }
                }
                //Console.Write("\n");
                s = s1 + s;
                Console.Clear();
                Console.Write(s);
                s = "\n" + s;
                //Thread.Sleep(1000);
                //s = s + "\n";
            }
            Console.ReadKey();
        }
    }
}
