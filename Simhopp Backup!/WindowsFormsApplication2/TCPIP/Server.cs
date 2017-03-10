using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


using static System.Console;

namespace ClassLibrary1
{
    public class HandleTcpClient
    {
        public IPEndPoint EndPoint { get; set; } = null;
        public NetworkStream NetworkStream { get; set; } = null;
        public StreamReader StreamReader { get; set; } = null;
        public StreamWriter StreamWriter { get; set; } = null;
        public TcpClient TcpClient { get; set; } = null;
        public Thread ThreadClient { get; set; } = null;
        TcpServer tcpServer { get; set; } = null;
        public bool quit = false;
        HandleTcpClient(TcpServer tcpServer, TcpClient tcpClient)
        {
            this.tcpServer = tcpServer;
            this.TcpClient = tcpClient;
            this.EndPoint = TcpClient.Client.RemoteEndPoint as IPEndPoint;
            ThreadClient = new Thread(Client);
            ThreadClient.Start();
        }
        public void Client()
        {
            try
            {
                NetworkStream = TcpClient.GetStream();
                StreamReader = new StreamReader(NetworkStream);
                StreamWriter = new StreamWriter(NetworkStream);
                while (!quit)
                {
                    ;
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe);
            }
            finally
            {
                TcpClient.Close(); // Shutdown and end connection
                ThreadClient.IsBackground = true;
                ThreadClient.Abort();
            }
        }
        public class TcpServer //mio lo hice public
        {
            private static TcpServer tcpServer = null;
            public static TcpServer Instance()
            {
                if (tcpServer == null)
                    tcpServer = new TcpServer();
                return tcpServer;
            }
            private Int32 port = 9058;
            private IPAddress localAddr = IPAddress.Parse("10.22.21.196");
            private TcpListener server = null;
            private Thread threadServer = null;
            private TcpServer()
            {
                tcpServer = this;
                threadServer = new Thread(tcpServer.ThreadListener);
                threadServer.Start();
            }
            public List<HandleTcpClient> ListHandleTcpClients { get; set; } = new List<HandleTcpClient>();
            private void ThreadListener()
            {
                try
                {
                    server = new TcpListener(localAddr, port);
                    server.Start(); // Start listening for client requests.

                    while (ListHandleTcpClients.Count < 3) 
                    {

                        TcpClient client = server.AcceptTcpClient();
                        lock (ListHandleTcpClients)
                        {
                            ListHandleTcpClients.Add(new HandleTcpClient(this, client));
                        }
                        Console.WriteLine("A judge connected to the server!");
                    }
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                }
                finally
                {
                    Thread.Sleep(10000);
                    server.Stop();
                }
            }
            public void SendToAllClients(String message)
            {
                lock (ListHandleTcpClients)
                {
                    foreach (var client in ListHandleTcpClients)
                    {
                        client.StreamWriter.WriteLine(message);
                        client.StreamWriter.Flush();
                    }
                }
            }
            public void KillThreads()
            {
                foreach (var client in ListHandleTcpClients)
                {
                    client.ThreadClient.IsBackground = true;
                }
            }

          
        }
    }
}




