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
using WindowsFormsApplication2;
using static System.Console;

namespace tcpServerAdmin
{

    /// <summary>
    /// Ett objekt av denna klass handhar en domarklient.
    /// Objektet har en tråd för att kommunicera med en klient.
    /// </summary>

    class HandleTcpClientJudge
    {
        //Medlemsvariabler
        public IPEndPoint EndPoint { get; set; } = null;
        public NetworkStream Networkstream { get; set; } = null;
        public StreamReader Streamreader { get; set; } = null; //ström som läser från en byteström
        public StreamWriter Streamwriter { get; set; } = null; //ström för att skriva till en byteström
        public TcpClient TcpClientJudge { get; set; } = null; //Bidrar med klientkopplingar för TCP
        public Thread ThreadClientJudge { get; set; } = null; //För att få en tråd för varje judge.
        public TcpServer TcpServerAdmin { get; set; } = null; //Bidrar med serveradmin för TCP
        public ConcurrentQueue<String> ConcurrentQueue { get; set; } = null; //Speciell kö-datastruktur för trådar

        //funktioner
        public HandleTcpClientJudge(TcpServer tcpserveradmin, TcpClient tcpclientjudge,
            ConcurrentQueue<String> concurrentQueue) //konstruktor för att få en till klient.
        {
            this.ConcurrentQueue = concurrentQueue;
            this.TcpServerAdmin = tcpserveradmin;
            this.TcpClientJudge = tcpclientjudge;
            this.EndPoint = TcpClientJudge.Client.RemoteEndPoint as IPEndPoint; //sätter socket

            ThreadClientJudge = new Thread(ClientJudge);
            ThreadClientJudge.Start();
        }

        public void ClientJudge()
        {
            String message = "";
            try
            {
                Networkstream = TcpClientJudge.GetStream();
                //Returnerar nätverkströmmen som används för att hämta och skicka data
                Streamreader = new StreamReader(Networkstream);
                Streamwriter = new StreamWriter(Networkstream);

                int i;
                bool quit = false;

                while (!quit)
                {
                    message = Streamreader.ReadLine(); //omvandlar bokstäverna  i en dataström till en sträng
                    if (message == null || message.StartsWith("quit"))
                        //kollar om strängen är tom eller om det står quit
                    {
                        quit = true;
                        Console.WriteLine($"Quit: {message} from {EndPoint}");
                        //skriver ut på konsolfönstret här borde vi få in en funktion som tillåter judge att ge poäng till ett hopp.
                    }
                    else if (message.StartsWith("points")) //om meddelandet börjar med "points"
                    {
                        //Dollartecknet representerar text som en serie av unicode chars. Utan den kan man inte skriva på {} sättet.
                        Console.WriteLine($"Queue message: {message} from {EndPoint}");
                        ConcurrentQueue.Enqueue(message + "," + EndPoint);
                        //lägger till en sträng i datastrukturen concurrentqueue
                    }
                    else
                    {
                        Console.WriteLine($"Message: {message} from {EndPoint}");
                    }

                }
            }
            catch (IOException ioe)
            {
            }
            finally //finally delen till för kod som måste köras även om det skapas ett exception
            {
                TcpClientJudge.Close(); //Stänger av och avslutar connection
                ThreadClientJudge.IsBackground = true;
                RemoveFromListHandleTCPclientsjudge();
                ThreadClientJudge.Abort();
            }
        }

        private void RemoveFromListHandleTCPclientsjudge()
        {
            for (int i = 0; i < TcpServerAdmin.ListHandleTcpClientsJudge.Count; i++)
            {
                if (this == TcpServerAdmin.ListHandleTcpClientsJudge[i])
                {
                    TcpServerAdmin.ListHandleTcpClientsJudge.Remove(this);
                    break;
                }
            }
        }
    }


    class TcpServer
    {
        private static TcpServer tcpServer = null; //Serverobjektet refererar ej till något.

        public static TcpServer Instance() //Till för att skapa en ny instans av en server
        {
            if (tcpServer == null)
                tcpServer = new TcpServer();
            return tcpServer;
        }

        private Int32 port = 9058; //Port för att kommunicera med
        private IPAddress localAddr = IPAddress.Parse("10.22.25.228"); //lokaladress där servern finns
        private TcpListener server = null; //avlyssning av klienter
        private Thread threadServer = null; //egen tråd för servern

        private TcpServer()
        {
            tcpServer = this;
            threadServer = new Thread(tcpServer.ThreadListener); //skapar en ny tråd för att lyssna av klienter.
            threadServer.Start();
        }

        public ConcurrentQueue<String> ConcurrentQueue { get; set; } = new ConcurrentQueue<string>();
        //en datastruktur som möjliggör att flera trådar kan skriva och läsa samtidigt.
        public List<HandleTcpClientJudge> ListHandleTcpClientsJudge { get; set; } = new List<HandleTcpClientJudge>();
        //Lista med domarklienter

        private void ThreadListener()
        {
            try
            {
                server = new TcpListener(localAddr, port);
                server.Start(); // Start listening for client requests.

                while (true)
                {
                    Console.WriteLine("Waiting for a connection... ");

                    TcpClient client = server.AcceptTcpClient();
                    lock (ListHandleTcpClientsJudge)
                    {
                        ListHandleTcpClientsJudge.Add(new HandleTcpClientJudge(this, client, ConcurrentQueue));
                    }
                    Console.WriteLine("Connected!");
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                server.Stop(); // Stop listening for new clients.
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }

        public void SendToAllJudgeclients(String message)
        {
            lock (ListHandleTcpClientsJudge)
                //lock används för att inte varje tråd ska kunna komma in i viktig koddel. tills det blir släppt.
            {
                foreach (var judge in ListHandleTcpClientsJudge)
                {
                    judge.Streamwriter.WriteLine(message);
                    judge.Streamwriter.Flush();
                }
            }
        }

        public void ListJudges()
        {
            foreach (var judge in ListHandleTcpClientsJudge)
            {
                WriteLine(judge.EndPoint); //Listar domarnas IP-adresser.
            }
        }

        public void KillThreads()
        {
            threadServer.IsBackground = true; //sätter en tråd till bakgrunden
            foreach (var judge in ListHandleTcpClientsJudge)
            {
                judge.ThreadClientJudge.IsBackground = true;
            }
        }
    }



    class Program
        {
            static void Main(string[] args)
            {
                TcpServer server = TcpServer.Instance();
                try
                {
                    String str;
                    do
                    {
                       
                        str = ReadLine() + '\n';
                        if (str.StartsWith("quit"))
                        {
                            ;
                        }
                        else if (str.StartsWith("queue"))
                        {
                            while (!server.ConcurrentQueue.IsEmpty)
                            {
                                String msg;
                                if (server.ConcurrentQueue.TryDequeue(out msg)) //out: objektet kommer initialiseras inuti funktionen
                                {
                                    WriteLine(msg);
                                }
                            }
                        }
                        else if (str.StartsWith("list")) //om strängen börjar med list så ska en lista med alla domare och dess IP addresser listas.
                        {
                            server.ListJudges();
                        }
                        else
                        {
                           server.SendToAllJudgeclients(str); //Tänker typ att här kommer info om deltagarna komma.

                    }
                } while (!str.StartsWith("quit"));
                }
                finally 
                {
                server.KillThreads();
                WriteLine("Quit Program");
                }
            }
        }
    }

