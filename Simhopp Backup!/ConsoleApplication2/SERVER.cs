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
using WindowsFormsApplication2;


namespace ServerApp
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
            String message = "";
            try
            {
                NetworkStream = TcpClient.GetStream();
                StreamReader = new StreamReader(NetworkStream);
                StreamWriter = new StreamWriter(NetworkStream);

                int i;
                bool quit = false;

                while (!quit)
                {

                }
            }
            catch (IOException ioe)
            { }
            finally
            {
                TcpClient.Close(); // Shutdown and end connection
                ThreadClient.IsBackground = true;
                ThreadClient.Abort();
            }


        }

        class TcpServer
        {
            private static TcpServer tcpServer = null;
            public static TcpServer Instance()
            {
                if (tcpServer == null)
                    tcpServer = new TcpServer();
                return tcpServer;
            }

            private Int32 port = 9058;
            private IPAddress localAddr = IPAddress.Parse("10.22.20.187");
            private TcpListener server = null;
            private Thread threadServer = null;

            private TcpServer()
            {
                tcpServer = this;
                threadServer = new Thread(tcpServer.ThreadListener);
                threadServer.Start();
            }

            public ConcurrentQueue<String> ConcurrentQueue { get; set; } = new ConcurrentQueue<string>();
            public List<HandleTcpClient> ListHandleTcpClients { get; set; } = new List<HandleTcpClient>();
            private void ThreadListener()
            {
                try
                {
                    server = new TcpListener(localAddr, port);
                    server.Start(); // Start listening for client requests.

                    while (ListHandleTcpClients.Count < 3) //ListHandleTcpClients.Count < 3
                    {
                        Console.WriteLine("Waiting for a  judge to connect... ");

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
                    ;
                }


                Console.WriteLine("\nHit enter to continue...");
                Console.Read();
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
                threadServer.IsBackground = true;
                foreach (var client in ListHandleTcpClients)
                {
                    client.ThreadClient.IsBackground = true;
                }
            }
        }

        class Program
        {
            //public static List<TcpClient> connections = new List<TcpClient>();
            public static void Main(string[] args)
            {
                Contender contender = new Contender();
                Contender contender1 = new Contender();

                Jump jump1 = new Jump();
                Jump jump2 = new Jump();
                Jump jump3 = new Jump();
                Jump jump4 = new Jump();
                jump1.Jumpstyle = "301A";
                jump2.Jumpstyle = "31A";
                jump3.Jumpstyle = "3901A";
                jump4.Jumpstyle = "3081A";
                contender.Name = "Viktor Lundin";
                contender1.Name = "Carlos Mantero";
                contender.Gender = "Male";
                contender1.Gender = "Male";
                contender.Nationality = "Sweden";
                contender1.Nationality = "Sweden";

                contender.add_jump(jump4);
                contender.add_jump(jump3);
                contender1.add_jump(jump1);
                contender1.add_jump(jump2);

                Contest contest = new Contest();

                contest.add_contender(contender);
                contest.add_contender(contender1);

                TcpServer server = TcpServer.Instance();
                String infoStringforJudges = String.Empty, str, PointString;
                int j = 0;
                double point = 0;
                try
                {
                    str = ReadLine();
                    foreach (var x in contest.ContenderList)
                    {
                        for (int i = 0; i < contest.ContenderList.Count; i++)
                        {
                            infoStringforJudges = (contest.ContenderList[i].Name + " " + contest.ContenderList[i].Nationality + " " + contest.ContenderList[i].Gender + " " + contest.ContenderList[i].ListJumps[j].Jumpstyle);
                            server.SendToAllClients(infoStringforJudges);
                            lock(server.ListHandleTcpClients){
                                foreach (var judge in server.ListHandleTcpClients)
                                {
                                    PointString = String.Empty;
                                    PointString = judge.StreamReader.ReadLine();
                                    contest.ContenderList[i].ListJumps[j].Point += double.Parse(PointString, System.Globalization.NumberStyles.AllowDecimalPoint);
                                }
                            }
                           
                        }
                        j++;
                    }
                    foreach (var item in contest.ContenderList)
                    {
                        item.summeraPoints();
                    }
                    foreach (var item in contest.ContenderList)
                    {
                        Console.WriteLine(item.Name + " " + item.TotalPoints);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                    
            }
        }
    }
}
        
         
    
