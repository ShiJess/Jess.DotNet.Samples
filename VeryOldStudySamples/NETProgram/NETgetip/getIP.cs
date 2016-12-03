using System;
using System.Net;
using System.Net.Sockets;

class GetIP
{
	public static void Main(string[] args)
	{
		if(args.Length!=1)
		{
			usage();
			return;
		}
		try
		{
			
			IPHostEntry IPHost=Dns.Resolve(args[0]);
			Console.WriteLine("HostName:"+IPHost.HostName);
			
			string [] aliases=IPHost.Aliases;
			Console.WriteLine("Count of host aliases:"+aliases.Length);
			for(int i=0;i<aliases.Length;i++)
			{
				Console.WriteLine(aliases[i]);
			}
			
			IPAddress[] addr=IPHost.AddressList;
			Console.WriteLine("Count of host addresser:"+addr.Length);
			Console.WriteLine("Host IP list:");
			for(int i=0;i<addr.Length;i++)
			{
				Console.WriteLine(addr[i]);
			}
		}
		catch(Exception e)
		{
			Console.WriteLine(e.ToString());		
		}
	}
	private static void usage()
	{
		Console.WriteLine("Usage:getIP hostname");
	}
}