using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApplication2
{
    public class Contender
    {
        public List<Jump> ListJumps = new List<Jump>();//lista på hoppens poäng, summerad av tre domare (helst 7)

        public Contender()
        {

        }
        public void AddContender(int id, string name, string nationality)  // Kanske bör läggas i Admin??
        {
            this.Id = id;
            this.Name = name;
            this.Nationality = nationality;
        }

        //MedlemsVariabler
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public double totalPoints { get; set; } = 0; //Håller totalpoängen för alla hopp som deltagaren har gjort.
        public void summeraPoints()  //ej testad
        {    // ska summera deltagarens alla 7 hopp till en variabel, totalPoints (för att sedan bestämma en vinnare av alla deltagare i tävling)
        
            foreach (var x in ListJumps) //loopar igenom alla hopp i varje deltagare
            {
                totalPoints += x.Point; //lägger in alla poäng till en totalsumma
            }
        }

        public void add_jump(Jump jump)     //ej testad
        {                                   //ska lägga till Jumpobjekt i en lista
            ListJumps.Add(jump);
        }

        public bool IsJumpListEmpty()
        {
            if (ListJumps.Count == 0)
                return true;
            else
                return false;
        }

    }
}