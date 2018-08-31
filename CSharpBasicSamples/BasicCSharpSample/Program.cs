using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11
{
    public class GetAllZu            //创建类
    {
        static int l = 1;                    //用于记录第几组数据
        private int sum;
        public int Sum                  //属性，设置和的值
        {
            get                                //get此处可以省去
            {
                return sum;
            }
            set
            {
                sum = value;
            }
        }
        public void PrintAllZu()    //获得所有的组函数
        {
            for (int i = 1; i <= sum; i++)
            {
                int s = 0, j = i;          //注意s和j用到的范围
                for (; s < sum; j++)
                {
                    s = s + j;
                }
                if (s == sum)
                {
                    Console.WriteLine("第{0}组的数据为：", l);
                    for (int k = i; k < j; k++)
                    {
                        Console.Write("{0}  ", k);
                    }
                    Console.Write("\n");
                    l++;                             //组数加1
                }
                else
                    continue;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GetAllZu s1 = new GetAllZu();
            Console.WriteLine("请输入若干数整数和的值为（以500为例）：");
            s1.Sum = Convert.ToInt32(Console.ReadLine());
            s1.PrintAllZu();
        }
    }
}
