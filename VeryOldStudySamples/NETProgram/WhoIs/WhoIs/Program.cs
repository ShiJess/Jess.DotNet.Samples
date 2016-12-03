using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WhoIs
{
    class Whois
    {
        private static int portNumber = 43;
        private string hostName;
        public Whois(string hostName)
        {
            this.hostName = hostName;
        }

        public void lookUp(string searchText)
        {
            TcpClient theConnection = null;
            NetworkStream networkStream = null;
            BufferedStream baseStream = null;
            StreamReader inputStream = null;
            StreamWriter outputStream = null;

            try
            {
                theConnection = new TcpClient(hostName,portNumber);
                networkStream = theConnection.GetStream();
                baseStream = new BufferedStream(networkStream);
            }

            catch(SocketException se)
            {
                Console.WriteLine("Exception caught attempting to open connection to {0}.",hostName);
                Console.WriteLine("\nException details: {0}",se.ToString());
                return;
            }

            try
            {
                outputStream = new StreamWriter(baseStream);
                outputStream.WriteLine(searchText);
                outputStream.Flush();
            }

            catch(Exception e)
            {
                Console.WriteLine("Exception caught attempting to send data to host:{0}.",hostName);
                Console.WriteLine("\nException details:{0}",e.ToString());

                theConnection.Close();

                return;
            }

            try
            {
                inputStream = new StreamReader(baseStream);
                string intermediateOutput;

                while(null!=(intermediateOutput=inputStream.ReadLine()))
                {
                    Console.WriteLine(intermediateOutput);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception caught attempting to read data from host:{0}.",hostName);
                Console.WriteLine("\nException details:{0}",e.ToString());

                theConnection.Close();

                return;
            }

            theConnection.Close();
        }

        static void Main(string[] args)
        {

            string host;
            string search;
            if(0==args.Length)
            {
                Console.WriteLine("usage:whois<lookup host>hostname");
                return;
            }
            else if (2 == args.Length)
            {
                host = args[0];
                search = args[1];
            }
            else
            {
                host = "whois.internic.net";
                search=args[0];
            }

            Whois whoisInstance = new Whois(host);
            whoisInstance.lookUp(search);
            //Console.ReadKey();
        }
    }
}
