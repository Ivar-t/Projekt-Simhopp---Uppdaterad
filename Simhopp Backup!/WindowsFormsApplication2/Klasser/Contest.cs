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
                jj++;
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

        public double find_winners_score()     //klarat test
        {                               //går igenom deltagarlistan för att hitta deltagaren med högst totalpoäng
            double HighestValue = 0;
            
            foreach (var x in ContenderList)
            {
                x.summeraPoints();
                if (HighestValue < x.totalPoints)      //jämnför om den nya deltagarens totalPointes är bättre än den förras
                {
                    HighestValue = x.totalPoints;
                }
            }
            return HighestValue;                          // returnerar vinnarens namn
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
        public void printShit() //testfunktion för att se vad deltagarna har fått för poäng för sina hopp
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
        public void printContest()  //testfunktion för att se vad som vad en contest från fil innehåller
        {

            Console.WriteLine("Tävling: {0} | {1} | {2} | {3}", this.Name, this.Date, this.GenderContest, this.Jumpheight);
            Console.WriteLine();
            Console.WriteLine("Deltagare");
            int u = 0;
            foreach (var x in ContenderList)
            {
                Console.Write("{0} | {1} | {2}", this.ContenderList[u].Name, this.ContenderList[u].Id, this.ContenderList[u].Nationality);
                for (int t = 0; t < 7; t++)
                {
                    Console.Write(" | {0} | {1}",ContenderList[u].ListJumps[t].Jumpstyle, ContenderList[u].ListJumps[t].jumpDifficulty);
                }
                Console.WriteLine();
                u++;
            }
        }
    }
}


