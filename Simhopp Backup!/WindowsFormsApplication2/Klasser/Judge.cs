using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        void WriteScore2File() { }  //skriver ner poängen för varje deltagare till en fil, samma fil som skapades av ADMIN
        void ReadContenderFromFile() { }    //läser in tävlande från till programmet
        void WriteWinner2File() { }         //skriver vinnare till filen
        void ReadWinnerFromFile() { }       //läser vinnare från fil till ett fönster

    }
}
