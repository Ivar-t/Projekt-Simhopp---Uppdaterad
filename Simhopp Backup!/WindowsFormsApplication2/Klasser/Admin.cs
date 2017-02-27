using System;
using System.IO;  //För att läsa och skriva till fil//
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Admin //Kanske kan lägga ihop admin + contest = win?
    {
        //MedlemsVariabler
        public List<Contest> Contestlist = new List<Contest>();
            //Lista för tävlingar. Om vi har flera tävlingar igång samtidigt?

        private int Id { get; set; }

        //MedlemsFunktioner
        void CreateContest()
        {
        } //öppnar fönstret där man skriver in ett namn till filen

        void add_contest(Contest contest)
        {
        } //lägger till en tävling i en lista

        void WriteContest2File()
        {
        } //skapar filen 

        void ReadContestFromFile()
        {
        } //läser filen (för att sedan kunna söka)

        void WriteContender2File()
        {
        } //skriver enskild deltagare till specifik tävlingsfil

        void EditContest()
        {
        } //deltagare läggs till i specifik tävlingsfil

        //static void Main(string[] args)
        //{
           
        //}
    }
}
