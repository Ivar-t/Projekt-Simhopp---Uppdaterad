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
        public void TestSimulationOfContest()
        {
            //Skapar tävling och slänger in all information för att kunna vara en fungerande tävling
            Contest SimOS2017 = new Contest();
            SimOS2017.Name = "SimOS2017";
            SimOS2017.Date = "21/02-2017";
            SimOS2017.GenderContest = "Male";
            SimOS2017.Jumpheight = 7;

            Contender contender1 = new Contender();
            Contender contender2 = new Contender();
            Contender contender3 = new Contender();


            Jump c0jump0 = new Jump();
            c0jump0.Jumpstyle = "302A";
            c0jump0.jumpDifficulty = 0.6;
            Jump c0jump1 = new Jump();
            c0jump1.Jumpstyle = "355B";
            c0jump1.jumpDifficulty = 0.1;
            Jump c0jump2 = new Jump();
            c0jump2.Jumpstyle = "222B";
            c0jump2.jumpDifficulty = 0.4;
            Jump c0jump3 = new Jump();
            c0jump3.Jumpstyle = "288B";
            c0jump3.jumpDifficulty = 0.8;
            Jump c0jump4 = new Jump();
            c0jump4.Jumpstyle = "128B";
            c0jump4.jumpDifficulty = 0.9;
            Jump c0jump5 = new Jump();
            c0jump5.Jumpstyle = "488B";
            c0jump5.jumpDifficulty = 0.8;
            Jump c0jump6 = new Jump();
            c0jump6.Jumpstyle = "138B";
            c0jump6.jumpDifficulty = 0.9;

            Jump c1jump0 = new Jump();
            c1jump0.Jumpstyle = "303A";
            c1jump0.jumpDifficulty = 0.8;
            Jump c1jump1 = new Jump();
            c1jump1.Jumpstyle = "352B";
            c1jump1.jumpDifficulty = 0.5;
            Jump c1jump2 = new Jump();
            c1jump2.Jumpstyle = "222A";
            c1jump2.jumpDifficulty = 0.4;
            Jump c1jump3 = new Jump();
            c1jump3.Jumpstyle = "289B";
            c1jump3.jumpDifficulty = 0.2;
            Jump c1jump4 = new Jump();
            c1jump4.Jumpstyle = "128B";
            c1jump4.jumpDifficulty = 0.9;
            Jump c1jump5 = new Jump();
            c1jump5.Jumpstyle = "280B";
            c1jump5.jumpDifficulty = 0.2;
            Jump c1jump6 = new Jump();
            c1jump6.Jumpstyle = "100B";
            c1jump6.jumpDifficulty = 0.9;

            Jump c2jump0 = new Jump();
            c2jump0.Jumpstyle = "300A";
            c2jump0.jumpDifficulty = 0.6;
            Jump c2jump1 = new Jump();
            c2jump1.Jumpstyle = "351B";
            c2jump1.jumpDifficulty = 0.4;
            Jump c2jump2 = new Jump();
            c2jump2.Jumpstyle = "222A";
            c2jump2.jumpDifficulty = 0.4;
            Jump c2jump3 = new Jump();
            c2jump3.Jumpstyle = "289B";
            c2jump3.jumpDifficulty = 0.2;
            Jump c2jump4 = new Jump();
            c2jump4.Jumpstyle = "129B";
            c2jump4.jumpDifficulty = 0.8;
            Jump c2jump5 = new Jump();
            c2jump5.Jumpstyle = "289B";
            c2jump5.jumpDifficulty = 0.2;
            Jump c2jump6 = new Jump();
            c2jump6.Jumpstyle = "129B";
            c2jump6.jumpDifficulty = 0.5;



            Assert.AreEqual(true, contender1.IsJumpListEmpty());
            Assert.AreEqual(true, contender2.IsJumpListEmpty());
            Assert.AreEqual(true, contender3.IsJumpListEmpty());

            contender1.Id = 1;
            contender1.Name = "Alfred Fjällvard";
            contender1.Nationality = "Norway";
            contender1.add_jump(c0jump0);
            contender1.add_jump(c0jump1);
            contender1.add_jump(c0jump2);
            contender1.add_jump(c0jump3);
            contender1.add_jump(c0jump4);
            contender1.add_jump(c0jump5);
            contender1.add_jump(c0jump6);

            contender2.Id = 2;
            contender2.Name = "Dicken Larsen";
            contender2.Nationality = "Denmark";
            contender2.add_jump(c1jump0);
            contender2.add_jump(c1jump1);
            contender2.add_jump(c1jump2);
            contender2.add_jump(c1jump3);
            contender2.add_jump(c1jump4);
            contender2.add_jump(c1jump5);
            contender2.add_jump(c1jump6);

            contender3.Id = 3;
            contender3.Name = "Stefan Lundmark";
            contender3.Nationality = "Sweden";
            contender3.add_jump(c2jump0);
            contender3.add_jump(c2jump1);
            contender3.add_jump(c2jump2);
            contender3.add_jump(c2jump3);
            contender3.add_jump(c2jump4);
            contender3.add_jump(c2jump5);
            contender3.add_jump(c2jump6);

            Assert.AreEqual(false, contender1.IsJumpListEmpty());
            Assert.AreEqual(false, contender2.IsJumpListEmpty());
            Assert.AreEqual(false, contender3.IsJumpListEmpty());

            Assert.AreEqual(true, SimOS2017.IsContenderListEmpty());
            SimOS2017.add_contender(contender1);
            SimOS2017.add_contender(contender2);
            SimOS2017.add_contender(contender3);
            Assert.AreEqual(false, SimOS2017.IsContenderListEmpty());

            //tävling skapad och ska nu öppnas för att bli dömd av domare
            Judge judge1 = new Judge();
            Judge judge2 = new Judge();
            Judge judge3 = new Judge();

            SimOS2017.add_judge(judge1);
            SimOS2017.add_judge(judge2);
            SimOS2017.add_judge(judge3);



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Assert.AreEqual(0, SimOS2017.ii);
            Assert.AreEqual(0, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(4, 2, 2);    //hoppnr1
            Assert.AreEqual(1, SimOS2017.ii);
            Assert.AreEqual(0, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(2, 6, 4);
            Assert.AreEqual(2, SimOS2017.ii);
            Assert.AreEqual(0, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(8, 8, 7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Assert.AreEqual(3, SimOS2017.ii);
            Assert.AreEqual(0, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(5, 5, 5);    //hoppnr2
            Assert.AreEqual(1, SimOS2017.ii);
            Assert.AreEqual(1, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(4, 4, 4);
            Assert.AreEqual(2, SimOS2017.ii);
            Assert.AreEqual(1, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(8, 8, 8);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Assert.AreEqual(3, SimOS2017.ii);
            Assert.AreEqual(1, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(10, 9, 9);    //hoppnr3
            Assert.AreEqual(1, SimOS2017.ii);
            Assert.AreEqual(2, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(8, 7, 8);
            Assert.AreEqual(2, SimOS2017.ii);
            Assert.AreEqual(2, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(6, 6, 6);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Assert.AreEqual(3, SimOS2017.ii);
            Assert.AreEqual(2, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(7, 6, 6);    //hoppnr4
            Assert.AreEqual(1, SimOS2017.ii);
            Assert.AreEqual(3, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(8, 7, 8);
            Assert.AreEqual(2, SimOS2017.ii);
            Assert.AreEqual(3, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(7, 9, 6);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Assert.AreEqual(3, SimOS2017.ii);
            Assert.AreEqual(3, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(5, 5, 4);    //hoppnr5
            Assert.AreEqual(1, SimOS2017.ii);
            Assert.AreEqual(4, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(3, 3, 2);
            Assert.AreEqual(2, SimOS2017.ii);
            Assert.AreEqual(4, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(7, 5, 5);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Assert.AreEqual(3, SimOS2017.ii);
            Assert.AreEqual(4, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(5, 5, 5);    //hoppnr6
            Assert.AreEqual(1, SimOS2017.ii);
            Assert.AreEqual(5, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(4, 6, 4);
            Assert.AreEqual(2, SimOS2017.ii);
            Assert.AreEqual(5, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(7, 6, 8);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Assert.AreEqual(3, SimOS2017.ii);
            Assert.AreEqual(5, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(6, 3, 4);    //hoppnr7
            Assert.AreEqual(1, SimOS2017.ii);
            Assert.AreEqual(6, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(5, 6, 7);
            Assert.AreEqual(3, SimOS2017.ContenderList.Count);
            Assert.AreEqual(2, SimOS2017.ii);
            Assert.AreEqual(6, SimOS2017.jj);
            SimOS2017.judge_gives_jumpPoints_to_contender_in_contest(9, 9, 6);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            SimOS2017.printShit();



            Assert.AreEqual(48, (int)(SimOS2017.ContenderList[0].ListJumps[0].Point * 10));
            Assert.AreEqual(96, (int)(SimOS2017.ContenderList[1].ListJumps[0].Point * 10));
            Assert.AreEqual(138, (int)(SimOS2017.ContenderList[2].ListJumps[0].Point * 10));

            Assert.AreEqual(15, (int)(SimOS2017.ContenderList[0].ListJumps[1].Point * 10));
            Assert.AreEqual(60, (int)(SimOS2017.ContenderList[1].ListJumps[1].Point * 10));
            Assert.AreEqual(96, (int)(SimOS2017.ContenderList[2].ListJumps[1].Point * 10));

            Assert.AreEqual(112, (int)(SimOS2017.ContenderList[0].ListJumps[2].Point * 10));
            Assert.AreEqual(92, (int)(SimOS2017.ContenderList[1].ListJumps[2].Point * 10));
            Assert.AreEqual(72, (int)(SimOS2017.ContenderList[2].ListJumps[2].Point * 10));

            Assert.AreEqual(152, (int)(SimOS2017.ContenderList[0].ListJumps[3].Point * 10));
            Assert.AreEqual(46, (int)(SimOS2017.ContenderList[1].ListJumps[3].Point * 10));
            Assert.AreEqual(44, (int)(SimOS2017.ContenderList[2].ListJumps[3].Point * 10));

            Assert.AreEqual(126, (int)(SimOS2017.ContenderList[0].ListJumps[4].Point * 10));
            Assert.AreEqual(72, (int)(SimOS2017.ContenderList[1].ListJumps[4].Point * 10));
            Assert.AreEqual(136, (int)(SimOS2017.ContenderList[2].ListJumps[4].Point * 10));

            Assert.AreEqual(120, (int)(SimOS2017.ContenderList[0].ListJumps[5].Point * 10));
            Assert.AreEqual(28, (int)(SimOS2017.ContenderList[1].ListJumps[5].Point * 10));
            Assert.AreEqual(42, (int)(SimOS2017.ContenderList[2].ListJumps[5].Point * 10));

            Assert.AreEqual(117, (int)(SimOS2017.ContenderList[0].ListJumps[6].Point * 10));
            Assert.AreEqual(162, (int)(SimOS2017.ContenderList[1].ListJumps[6].Point * 10));
            Assert.AreEqual(120, (int)(SimOS2017.ContenderList[2].ListJumps[6].Point * 10));

            Assert.AreEqual("Alfred Fjällvard", SimOS2017.find_winner());

            Assert.AreEqual(false, SimOS2017.ContestFinished);
            SimOS2017.EndContest();
            Assert.AreEqual(true, SimOS2017.ContestFinished);

        }
    }
}
