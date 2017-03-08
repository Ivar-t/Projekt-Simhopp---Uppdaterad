using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;



namespace ClassLibrary1
{
    public class ClassClient
    {
        public TcpClient socketForServer;
        public NetworkStream networkStream { get; set; } = null;
        public StreamReader streamReader { get; set; } = null;
        public StreamWriter streamWriter { get; set; } = null;
        public void connectToServerfunc()
        {
            try
            {
                socketForServer = new TcpClient("10.22.21.196", 9058);
                networkStream = socketForServer.GetStream();
                streamReader = new StreamReader(networkStream);
                streamWriter = new StreamWriter(networkStream);
            }
            catch
            {
                Console.WriteLine("Failed to connect");
                return;
            }
        }
        public void comp()
        {
            networkStream = socketForServer.GetStream();
            streamReader = new StreamReader(networkStream);
            streamWriter = new StreamWriter(networkStream);

            try
            {
                String outputString = " ", str = " ";
                while (true)
                {
                    //outputString = streamReader.ReadLine();
                    //Console.WriteLine(outputString);
                    //Console.WriteLine("Give score: ");
                    //streamWriter.WriteLine(str);
                    //streamWriter.Flush();

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
