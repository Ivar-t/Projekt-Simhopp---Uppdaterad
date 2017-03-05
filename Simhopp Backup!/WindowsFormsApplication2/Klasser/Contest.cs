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

namespace WindowsFormsApplication2
{
    public class Contest
    {
        public List<Contender> ContenderList = new List<Contender>(); //Skapar en lista av contenderobjekt
      
        public List<Judge> JudgeList = new List<Judge>(3); //Skapar en lista med 3 domare

        //MedlemsVariabler
        public string Name { get; set; } = "";
        public string Date { get; set; } = "";
        public string GenderContest { get; set; } = ""; //La till en gender attribut så tävlingar kan delas in i kön-tävlingar / tomas
        public int Jumpheight { get; set; } = 0;
        public string Winner { get; set; } = "";
        public bool ContestFinished = false;        //tävlingen är aktiv tills den ställs som true
        public bool AreUnderJudging = false; // När domarna har röstat klart -> ändra till true

        //MedlemsFunktioner
        public void add_contender(Contender con)    //ej klarat test
        {                                           //Adderar en deltagare i en lista fylld med andra deltagare-objekt
            ContenderList.Add(con);
        }

        public void add_judge(Judge judge)  //ej klarat test
        {                                   // Lägga till en domare 
            JudgeList.Add(judge);
        }

        public int ii = 0;  //contender counter
        public int jj = 0;  //jump counter
        public void judge_gives_jumpPoints_to_contender_in_contest(double score1, double score2, double score3)
        {
            if (ii == this.ContenderList.Count) //nollställer ii varje gång ii gått igeonom varje contender
            {
                ii = 0;
                jj++;   //får inte gå över 7 | går till contenders nästa hopp
            }
            ContenderList[ii].ListJumps[jj].Point = (score1 + score2 + score3) * ContenderList[ii].ListJumps[jj].jumpDifficulty;

            ii++;
        }

   

        public string find_winner()     //klarat test
        {                               //går igenom deltagarlistan för att hitta deltagaren med högst totalpoäng
            double tempValue = 0;
            string winner = "";
            foreach (var x in ContenderList)
            {
                x.summeraPoints();
                if (tempValue < x.totalPoints)      //jämnför om den nya deltagarens totalPointes är bättre än den förras
                {
                    tempValue = x.totalPoints;
                    winner = x.Name;
                }
            }
            return winner;                          // returnerar vinnarens namn
        }

        public void EndContest()        //ej klarat test
        {
            this.ContestFinished = true;    //sätter att tävlingen är avslutad
        }

        public bool IsContenderListEmpty()      //klarat test
        {                                       // Kolla om listan är fylld eller ej! 
            if (ContenderList.Count == 0)
                return true;
            else
                return false;
        }

        public void printShit()
        {
            int u = 0;
            foreach (var x in ContenderList)
            {

                Console.WriteLine("Deltagare: {0}", u);
                for (int t = 0; t < 7; t++)
                {
                    Console.WriteLine(ContenderList[u].ListJumps[t].Point);
                }
                Console.WriteLine();
                u++;
            }
        }

        public void Lets_get_this_party_started() //TESTFUNKTION FÖR SERVER
        {
            TcpServer server = TcpServer.Instance(); //Startar servern och börjar lyssna efter domarklienter
            String infoStringforJudges = String.Empty, str, PointString;
            int j = 0;
            try
            {
                str = Console.ReadLine();
                foreach (var x in ContenderList)
                {
                    for (int i = 0; i < ContenderList.Count; i++)
                    {
                        infoStringforJudges = (ContenderList[i].Name + " " + ContenderList[i].Nationality + " " + ContenderList[i].ListJumps[j].Jumpstyle);
                        server.SendToAllClients(infoStringforJudges);
                        lock (server.ListHandleTcpClients)
                        {
                            foreach (var judge in server.ListHandleTcpClients)
                            {
                                PointString = String.Empty;
                                PointString = judge.StreamReader.ReadLine();
                                ContenderList[i].ListJumps[j].Point += double.Parse(PointString, System.Globalization.NumberStyles.AllowDecimalPoint);
                            } //För att få in jumpdifficulty gör en till foreach loop som går igenom alla hopp och gångrar med dess svårighetsgrad.
                        }
                    }
                    j++;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Thread.Sleep(5000);
                server.KillThreads();
            }

        }
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
            public HandleTcpClient(TcpServer tcpServer, TcpClient tcpClient)
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
                { }
                finally
                {
                    TcpClient.Close(); // Shutdown and end connection
                    ThreadClient.IsBackground = true;
                    ThreadClient.Abort();
                }
            }
        }
        public class TcpServer
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


