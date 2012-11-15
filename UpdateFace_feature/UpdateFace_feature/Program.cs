using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace UpdateFace_feature
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数据库连接
            string ConnectionString = "Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST =192.168.12.205)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = face)));Persist Security Info=True;User ID=system;Password=123"; 
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand comm = conn.CreateCommand();
            try
            {
                conn.Open();
                Console.WriteLine("连接成功");
                conn.Close();
            }
            catch
            {
                Console.WriteLine("连接失败\n按键结束");
                Console.ReadKey();
                return;
            }
            #endregion

            //身份证设置信息
            int first = 320481;
            int second =0 ;     //年
            int third =0 ;      //月
            string third0 = "";
            int fourth =0 ;     //日
            string fourth0 = "";
            int fifth =0 ;
            string fifth0 = "";

            //姓名设置
            string name="";
            int name0 = 0;
            int namelength = 0;

            Random rand = new Random();
            conn.Open();
            for (int i = 450286; i < 450293; )
                {

                    #region 身份证设置
                    second = rand.Next(1912, 2012);
                    third = rand.Next(1, 13);
                    if (third == 2) //二月
                    {
                        if (second % 4 == 0)    //闰年
                        {
                            fourth = rand.Next(1, 29);
                            if (fourth < 10)
                            {
                                fourth0 = "0" + fourth.ToString();
                            }
                            else
                            {
                                fourth0 = fourth.ToString();
                            }
                        }
                        else
                        {
                            fourth = rand.Next(1, 30);
                            if (fourth < 10)
                            {
                                fourth0 = "0" + fourth.ToString();
                            }
                            else
                            {
                                fourth0 = fourth.ToString();
                            }
                        }
                        third0 = "0" + third.ToString();
                    }
                    else
                    {
                        if (third == 4 || third == 6 || third == 9 || third == 11)
                        {
                            fourth = rand.Next(1, 31);
                            if (fourth < 10)
                            {
                                fourth0 = "0" + fourth.ToString();
                            }
                            else
                            {
                                fourth0 = fourth.ToString();
                            }
                        }
                        else
                        {
                            fourth = rand.Next(1, 32);
                            if (fourth < 10)
                            {
                                fourth0 = "0" + fourth.ToString();
                            }
                            else
                            {
                                fourth0 = fourth.ToString();
                            }
                        }

                        if (third < 10)
                        {
                            third0 = "0" + third.ToString();
                        }
                        else
                        {
                            third0 = third.ToString();
                        }
                    }
                    fifth = rand.Next(0000, 9999);
                    if (fifth < 10)
                    {
                        fifth0 = "000" + fifth.ToString();
                    }
                    else if (fifth < 100)
                    {
                        fifth0 = "00" + fifth.ToString();
                    }
                    else if (fifth < 1000)
                    {
                        fifth0 = "0" + fifth.ToString();
                    }
                    else
                    {
                        fifth0 = fifth.ToString();
                    }
                    #endregion

                    #region 姓名设置
                    namelength = rand.Next(1, 5);
                    for (int j = 0; j < namelength; j++)
                    {
                        name0 = rand.Next(97, 123);
                        name = ((char)name0).ToString() + name;
                    }

                    #endregion

                    comm.CommandText = "update FACE_FEATURE_WW set XM='" + name + "',GMSFHM=" + first.ToString() + second.ToString() + third0 + fourth0 + fifth0 + "where FID=" + i;
                    OracleDataReader odr = comm.ExecuteReader();
                    try
                    {
                        odr.Read();
                        Console.WriteLine("修改第条{0}记录完成", i);
                        Console.WriteLine("修改后的名字为{0}", name);
                        name = "";
                        i++;
                        odr.Close();

                        continue;
                    }
                    catch
                    {
                        if (i == 450285)
                        {
                            Console.WriteLine("更新结束");
                            Console.ReadKey();
                            odr.Close();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("无此FID");
                            i++;
                            name = "";
                            odr.Close();
                            continue;
                        }
                    }
                }
            conn.Close();
            Console.WriteLine("按键结束");
            Console.ReadKey();

        }
    }
}
