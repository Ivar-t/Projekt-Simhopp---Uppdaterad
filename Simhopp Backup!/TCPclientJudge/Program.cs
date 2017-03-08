using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient socketForServer;
            try
            {
                socketForServer = new TcpClient("10.22.21.196", 9058);
            }
            catch
            {
                Console.WriteLine("Failed to connect");
                return;
            }
            NetworkStream networkStream = socketForServer.GetStream();
            StreamReader streamReader = new StreamReader(networkStream);
            StreamWriter streamWriter = new StreamWriter(networkStream);

            try
            {
                String outputString = " ", str = " ";
                while (true)
                {
                    outputString = streamReader.ReadLine();
                    Console.WriteLine(outputString);
                    Console.WriteLine("Give score: ");
                    str = Console.ReadLine();
                    streamWriter.WriteLine(str);
                    streamWriter.Flush();

                }
                if (str.StartsWith("Exit"))
                {
                    streamWriter.WriteLine(str);
                    streamWriter.Flush();
                }
            }
            catch
            {

                Console.WriteLine("Exception reading from server");
            }
            networkStream.Close();
            socketForServer.Close();
        }
    }
}