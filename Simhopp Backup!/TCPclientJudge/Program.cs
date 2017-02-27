using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2;
using static System.Console;

namespace TCPclientJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient tcpClient = null; //Vår domare
            try
            {
                Int32 port = 9058; //VIlken port som ska kommuniceras med hos servern
                tcpClient = new TcpClient("10.22.25.228", port); //Din IP-adress + port att kommunicera med

                StreamReader sr = new StreamReader(tcpClient.GetStream()); //Läs från ström
                StreamWriter sw = new StreamWriter(tcpClient.GetStream()); //Skriv till ström

                Judge judge = new Judge(); //kommer behövas senare för att ge poäng
                Int32 Point = 0; //poäng från domare
                string str = "";

                while (!str.StartsWith("quit")) //Sålänge man inte skriver in quit så fortsätter den gå i snurran
                {
                    str = sr.ReadLine(); //Läs in från ström till din string
                    WriteLine(str);
                    sw.WriteLine("Svar: " + str);
                    sw.Flush(); //Rensar det man skrivit?
                }

            }
            catch (IOException ioe)
            {
                tcpClient?.Close(); //stäng ner anslutning/kommunikation
            }
            finally
            {
                tcpClient?.Close();
            }
        }
    }
}
