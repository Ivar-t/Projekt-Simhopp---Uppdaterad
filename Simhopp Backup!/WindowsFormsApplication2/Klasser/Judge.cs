using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication2
{
    public class Judge
    {
        public List<Jump> JudgeIndividualScore = new List<Jump>(); //Ändrar sen "Jump" till "points"

        //MedlemsVariabler
        private int Id { get; set; } = 0;
        public int TotJ { get; set; } = 0; //håller i alla 3 domares poäng

        //MedlemsFunktioner
        public int SetPoints(int score) //domare sätter poäng för en contender och deras hopp
        {
            return score;
        }

        void judge_contest()
        {
            TcpClient socketForServer;
            try
            {
                socketForServer = new TcpClient("10.22.20.187", 9058);
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


        void WriteScore2File() { }  //skriver ner poängen för varje deltagare till en fil, samma fil som skapades av ADMIN
        void ReadContenderFromFile() { }    //läser in tävlande från till programmet
        void WriteWinner2File() { }         //skriver vinnare till filen
        void ReadWinnerFromFile() { }       //läser vinnare från fil till ett fönster

    }
}
