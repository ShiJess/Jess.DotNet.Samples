using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

public class server
{
	public static void Main()
	{
		try
		{
			IPAddress ipAd=IPAddress.Parse("127.0.0.1");
			
			TcpListener myList=new TcpListener(ipAd,8001);
			
			myList.Start();
			
			Console.WriteLine("在8001端口启动服务...");
			Console.WriteLine("本地节点为："+myList.LocalEndpoint);
			Console.WriteLine("等待连接...");
			
			Socket s=myList.AcceptSocket();
			Console.WriteLine("连接来自 "+s.RemoteEndPoint);
			
			byte[] b=new byte[100];
			int k=s.Receive(b);
			Console.WriteLine("已接收...");
			for(int i=0;i<k;i++)
			{
				Console.Write(Convert.ToChar(b[i]));
			}
			
			ASCIIEncoding asen=new ASCIIEncoding();
			s.Send(asen.GetBytes("The string was recieved by the server."));
			Console.WriteLine("\n 已发送回应信息");
			
			
			s.Close();
            myList.Stop();
		}
		catch (Exception e)
        {
            Console.WriteLine("Error..... " + e.StackTrace);
        }

		Console.ReadKey();
	}
}