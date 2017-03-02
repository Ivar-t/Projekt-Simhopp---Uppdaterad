using System;
using System.Linq;
using WindowsFormsApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerApp;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Everything()
        {
           //Skapar objekt från klasserna
            Contender contender = new Contender();
            Contender contender1 = new Contender(); //En annan contender
            Judge judge = new Judge();
            Judge judge2 = new Judge();
            Judge judge3 = new Judge();
            Contest contest = new Contest();
            Jump jump = new Jump();


            contender.Name = "Viktor"; //Lägger till information om deltagare
            contender.Gender = "Male";
            contender.Id = 1;
            contender.Nationality = "Sweden";

            Assert.AreEqual("Viktor", contender.Name); //kollar om deltagarens namn stämmer

            //Ett hopp som en deltagare ska göra. Hoppstil och svårighetsgrad.
            jump.Jumpstyle = "303A";
            jump.jumpDifficulty = 5;

     

            contender.ListJumps.Add(jump); //Lägger till hoppet i deltagarens hopplista
            Assert.AreEqual("303A", contender.ListJumps[0].Jumpstyle); //Kollar om det stämmer 

            contender.ListJumps.Add(jump); //Ett hopp till contender
            contender1.ListJumps.Add(jump); //Ett hopp till contender

            Assert.AreEqual(0, contest.ContenderList.Count); //Kollar om listan är tom
            Assert.AreEqual(true, contest.IsContenderListEmpty());//Kollar om listan är tom, med insatt funktion
            contest.ContenderList.Add(contender);            //Lägger till tävlande i deltagarlistan
            Assert.AreEqual(false, contest.IsContenderListEmpty());
            contest.JudgeList.Add(judge);                    //Lägger till domare till tävlingen 

            

            //Låter alla domare ge poäng till alla hopp, 3 domarklienter. 
            contest.judge_gives_jumpPoints_to_contender_in_contest(judge, judge2, judge3);

            //Test av ett hopps poäng
            Assert.AreEqual(15, contender.ListJumps[0].Point);
            //test av summera points funktion
            Assert.AreEqual(30, contender.summeraPoints());
        }

        [TestMethod]
        public void TestFindWinner()
        {
            Contest contest1 = new Contest();

            Contender contender1 = new Contender();
            Contender contender2 = new Contender();
            Contender contender3 = new Contender();
            Contender contender4 = new Contender();
            Contender contender5 = new Contender();

            contest1.add_contender(contender1);
            contest1.add_contender(contender2);
            contest1.add_contender(contender3);
            contest1.add_contender(contender4);
            contest1.add_contender(contender5);


            contender1.Name = "Mike";
            contender2.Name = "Dredd";
            contender3.Name = "Dante";
            contender4.Name = "Jason";
            contender5.Name = "Trevor";

            contender1.totalPoints = 14;
            contender2.totalPoints = 16;
            contender3.totalPoints = 5;
            contender4.totalPoints = 34;
            contender5.totalPoints = 6;

            contest1.find_winner();

            Assert.AreEqual("Jason", contest1.find_winner());
        }

        [TestMethod]
        public void Test_contender_and_jump_classes()
        {
            Contender contender = new Contender();
            Contender contender1 = new Contender();

           

            Jump jump1 = new Jump();
            Jump jump2 = new Jump();
            Jump jump3 = new Jump();
            Jump jump4 = new Jump();
            jump1.Jumpstyle = "301A";
            jump2.Jumpstyle = "31A";
            jump3.Jumpstyle = "3901A";
            jump4.Jumpstyle = "3081A";
            jump1.Point = 30.5;
            jump2.Point = 31.5;
            jump3.Point = 39.5;
            jump4.Point = 81;

            Assert.AreEqual("301A", jump1.Jumpstyle);
            Assert.AreEqual("31A", jump2.Jumpstyle);
            Assert.AreEqual("3901A", jump3.Jumpstyle);
            Assert.AreEqual("3081A", jump4.Jumpstyle);


            contender.Name = "Viktor Lundin";
            contender1.Name = "Carlos Mantero";
            contender.Gender = "Male";
            contender1.Gender = "Male";
            contender.Nationality = "Sweden";
            contender1.Nationality = "Sweden";
            contender.add_jump(jump4);
            contender.add_jump(jump3);
            contender1.add_jump(jump1);
            contender1.add_jump(jump2);
            Contest contest = new Contest();

            contest.add_contender(contender);
            contest.add_contender(contender1);
            
            Assert.AreEqual(30.5, jump1.Point);
            Assert.AreEqual(31.5, jump2.Point);
            Assert.AreEqual(39.5, jump3.Point);
            Assert.AreEqual(81, jump4.Point);
        }
    }
}
