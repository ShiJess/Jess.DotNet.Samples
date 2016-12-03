using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

class IrcBot
{
	public static string SERVER="irc.mindforge.org";
	
	private static int PORT=6667;
	private static string USER="USER liping 8*:I'm a C# irc bot";
	
	private static string NICK="Rose";
	
	private static string CHANNEL="#my_channel";
	
	public static StreamWriter writer;
	
	static void Main(string[] args)
	{
		NetworkStream stream;
		TcpClient irc;
		string inputLine;
		StreamReader reader;
		string nickname;
		
		try
		{
			irc=new TcpClient(SERVER,PORT);
			stream=irc.GetStream();
			reader=new StreamReader(stream);
			writer=new StreamWriter(stream);
			
			PingSender ping=new PingSender();
			ping.Start();
			
			writer.WriteLine(USER);
			writer.Flush();
			writer.WriteLine("NICK"+NICK);
			writer.Flush();
			writer.WriteLine("JOIN"+CHANNEL);
			writer.Flush();
			
			while(true)
			{
				while((inputLine=reader.ReadLine())!=null)
				{
					if(inputLine.EndsWith("JOIN:"+CHANNEL))
					{
						nickname=inputLine.Substring(1,inputLine.IndexOf("!")-1);
						
						writer.WriteLine("NOTICE"+nickname+":Hi"+nickname+" and welcome to "+CHANNEL+" channel! ");
						writer.Flush();
						
						Thread.Sleep(2000);
					}
				}
				
				
				writer.Close();
				reader.Close();
				irc.Close();
			}
		}
		
		
		catch(Exception e)
		{
			Console.WriteLine(e.ToString());
			Thread.Sleep(5000);
			string[] argv={};
			Main(argv);
		}
	}
}


class PingSender
{
	static string PING="PING:";
	private Thread pingSender;
	
	public PingSender()
	{
		pingSender=new Thread(new ThreadStart(this.Run));
	}
	
	public void Start()
	{
		pingSender.Start();
	}
	
	public void Run()
	{
		while(true)
		{
			IrcBot.writer.WriteLine(PING+IrcBot.SERVER);
			IrcBot.writer.Flush();
			Thread.Sleep(15000);
		}
	}
}