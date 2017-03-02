using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Jump //Håller reda på poängen för ett hopp. Samt har varje hopp en hoppkod(jumpstyle).
    {
        public double Point { get; set; } = 0;
        public string Jumpstyle { get; set; } = "";
        public double jumpDifficulty { get; set; } = 0;

        public void setPoint(int x) //ej testad
        {                           //sätter ett poäng i ett jumpobjekt
            Point = x;
        }
        public void setJumpstyle(string y)  //ej testad
        {                                   //sätter ett hoppstil i ett jumpobjekt
            Jumpstyle = y;
        }
        public void setJumpDifficulty(double z)  //ej testad
        {                                   //sätter hoppsvårigheten i ett jumpobjekt
            jumpDifficulty = z;
        }

    }
}
