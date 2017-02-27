using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Console;

namespace WindowsFormsApplication2
{
    public class Contest
    {
        public List<Contender> ContenderList = new List<Contender>(); //Skapar en lista av contenderobjekt
      
        public List<Judge> JudgeList = new List<Judge>(3); //Skapar en lista med 3 domare
        Judge judge = new Judge();
        Jump jump = new Jump();
        
        //MedlemsVariabler
        public int Id { get; set; } = 0;
        public string Date { get; set; } = "";
        public string Name { get; set; } = "";
        public int Jumpheight { get; set; } = 0;
        public int TotJ { get; set; } = 0;
        public string GenderContest { get; set; } = ""; //La till en gender attribut så tävlingar kan delas in i kön-tävlingar / tomas
        public string Winner { get; set; } = "";
        public bool ContestFinished = false;        //tävlingen är aktiv tills den ställs som true

        //MedlemsFunktioner
        public void add_contender(Contender con)    //ej klarat test
        {                                           //Adderar en deltagare i en lista fylld med andra deltagare-objekt
            ContenderList.Add(con);
        }

        public void add_judge(Judge judge)  //ej klarat test
        {                                   // Lägga till en domare 
            JudgeList.Add(judge);
        }

        public void judge_gives_jumpPoints_to_contender_in_contest(Judge judge1, Judge judge2, Judge judge3) //ej klarat test
        {
            int j = 0;
                    //ska loopa igenom varje deltagare i tävlingen
            foreach (var x in ContenderList)
            {
                for (int i = 0; i < ContenderList.Count; i++)  
                {
                    ContenderList[i].ListJumps[j].Point = JudgeSum(judge1, judge2, judge3, ContenderList[i].ListJumps[j].jumpDifficulty); 
                }
                j++;
            }
        }

        public int JudgeSum(Judge judge1, Judge judge2, Judge judge3, int difficulty) //ej testad
        {
            TotJ = (judge1.SetPoints(1) + judge2.SetPoints(1) + judge3.SetPoints(1)) * difficulty; //summerar domarpoäng och multiplicerar med hoppets svårighet
            return TotJ;
        }

        public string find_winner()     //klarat test
        {                               //går igenom deltagarlistan för att hitta deltagaren med högst totalpoäng
            int tempValue = 0;
            string winner = "";
            foreach (var x in ContenderList)
            {
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
    }
}


