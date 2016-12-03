using System;
using System.Data;
using System.Data.SqlClient;

class Sample
{
    public static void Main()
    {
        SqlConnection nwindConn = new SqlConnection("DataBase=viot;server=192.168.12.204;user id=viot;password=viot;connect Timeout=30");
        SqlCommand catCMD = nwindConn.CreateCommand();
        catCMD.CommandText = "select ZPBH from zhxt_tx_ry_rxzp";

        nwindConn.Open();

        SqlDataReader myReader = catCMD.ExecuteReader();
        while (myReader.Read())
        {
            Console.WriteLine("{0}", myReader.GetString(0));
        }
        myReader.Close();
        nwindConn.Close();
        Console.ReadKey();
    }
}