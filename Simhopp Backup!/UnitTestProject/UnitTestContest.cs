using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication2;

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for UnitTestContest
    /// </summary>
    [TestClass]
    public class UnitTestContest
    {
        public UnitTestContest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Testjudge_gives_jumpPoints_to_contender_in_contest()
        {
            Contest contest = new Contest();
            Judge judge1 = new Judge();
            Judge judge2 = new Judge();
            Judge judge3 = new Judge();

            Contender contender1 = new Contender();
            Contender contender2 = new Contender();

            Jump c1Jump1 = new Jump();
            c1Jump1.Jumpstyle = "100A";
            c1Jump1.jumpDifficulty = 0.5;
            Jump c1Jump2 = new Jump();
            c1Jump2.Jumpstyle = "101B";
            c1Jump2.jumpDifficulty = 0.6;
            Jump c1Jump3 = new Jump();
            c1Jump3.Jumpstyle = "123A";
            c1Jump3.jumpDifficulty = 0.1;
            Jump c1Jump4 = new Jump();
            c1Jump4.Jumpstyle = "203A";
            c1Jump4.jumpDifficulty = 0.3;
            Jump c1Jump5 = new Jump();
            c1Jump5.Jumpstyle = "431A";
            c1Jump5.jumpDifficulty = 0.8;
            Jump c1Jump6 = new Jump();
            c1Jump6.Jumpstyle = "303A";
            c1Jump6.jumpDifficulty = 0.5;
            Jump c1Jump7 = new Jump();
            c1Jump7.Jumpstyle = "309B";
            c1Jump7.jumpDifficulty = 0.4;

            contender1.add_jump(c1Jump1);
            contender1.add_jump(c1Jump2);
            contender1.add_jump(c1Jump3);
            contender1.add_jump(c1Jump4);
            contender1.add_jump(c1Jump5);
            contender1.add_jump(c1Jump6);
            contender1.add_jump(c1Jump7);

            Jump c2Jump1 = new Jump();
            c2Jump1.Jumpstyle = "234A";
            c2Jump1.jumpDifficulty = 0.6;
            Jump c2Jump2 = new Jump();
            c2Jump2.Jumpstyle = "300B";
            c2Jump2.jumpDifficulty = 0.4;
            Jump c2Jump3 = new Jump();
            c2Jump3.Jumpstyle = "108B";
            c2Jump3.jumpDifficulty = 0.4;
            Jump c2Jump4 = new Jump();
            c2Jump4.Jumpstyle = "103B";
            c2Jump4.jumpDifficulty = 0.7;
            Jump c2Jump5 = new Jump();
            c2Jump5.Jumpstyle = "101A";
            c2Jump5.jumpDifficulty = 0.5;
            Jump c2Jump6 = new Jump();
            c2Jump6.Jumpstyle = "100B";
            c2Jump6.jumpDifficulty = 0.5;
            Jump c2Jump7 = new Jump();
            c2Jump7.Jumpstyle = "252A";
            c2Jump7.jumpDifficulty = 0.6;

            contender2.add_jump(c2Jump1);
            contender2.add_jump(c2Jump2);
            contender2.add_jump(c2Jump3);
            contender2.add_jump(c2Jump4);
            contender2.add_jump(c2Jump5);
            contender2.add_jump(c2Jump6);
            contender2.add_jump(c2Jump7);

            contest.add_contender(contender1);
            contest.add_contender(contender2);

            contest.judge_gives_jumpPoints_to_contender_in_contest(4, 2, 2);    //hoppnr1
            //contest.judge_gives_jumpPoints_to_contender_in_contest(2, 6, 4);

            //contest.judge_gives_jumpPoints_to_contender_in_contest(6, 5, 5);    //hoppnr2
            //contest.judge_gives_jumpPoints_to_contender_in_contest(2, 3, 5);

            //contest.judge_gives_jumpPoints_to_contender_in_contest(4, 4, 2);    //hoppnr3
            //contest.judge_gives_jumpPoints_to_contender_in_contest(5, 6, 7);

            //contest.judge_gives_jumpPoints_to_contender_in_contest(8, 4, 3);    //hoppnr4
            //contest.judge_gives_jumpPoints_to_contender_in_contest(2, 8, 6);

            //contest.judge_gives_jumpPoints_to_contender_in_contest(2, 7, 4);    //hoppnr5
            //contest.judge_gives_jumpPoints_to_contender_in_contest(1, 6, 5);

            //contest.judge_gives_jumpPoints_to_contender_in_contest(6, 6, 6);    //hoppnr6
            //contest.judge_gives_jumpPoints_to_contender_in_contest(6, 3, 6);

            //contest.judge_gives_jumpPoints_to_contender_in_contest(9, 4, 5);    //hoppnr7
            //contest.judge_gives_jumpPoints_to_contender_in_contest(10, 5, 7);

            Assert.AreEqual(40, (int)(contest.ContenderList[0].ListJumps[0].Point * 10));
            //Assert.AreEqual(72, (int)(contest.ContenderList[1].ListJumps[0].Point * 10));

            //Assert.AreEqual(96, (int)(contest.ContenderList[0].ListJumps[1].Point * 10));
            //Assert.AreEqual(40, (int)(contest.ContenderList[1].ListJumps[1].Point * 10));

            //Assert.AreEqual(10, (int)(contest.ContenderList[0].ListJumps[2].Point * 10));
            //Assert.AreEqual(72, (int)(contest.ContenderList[1].ListJumps[2].Point * 10));

            //Assert.AreEqual(45, (int)(contest.ContenderList[0].ListJumps[3].Point * 10));
            //Assert.AreEqual(112, (int)(contest.ContenderList[1].ListJumps[3].Point * 10));

            //Assert.AreEqual(104, (int)(contest.ContenderList[0].ListJumps[4].Point * 10));
            //Assert.AreEqual(60, (int)(contest.ContenderList[1].ListJumps[4].Point * 10));

            //Assert.AreEqual(90, (int)(contest.ContenderList[0].ListJumps[5].Point * 10));
            //Assert.AreEqual(75, (int)(contest.ContenderList[1].ListJumps[5].Point * 10));

            //Assert.AreEqual(72, (int)(contest.ContenderList[0].ListJumps[6].Point * 10));
            //Assert.AreEqual(132, (int)(contest.ContenderList[1].ListJumps[6].Point * 10));
            contest.printShit();

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

            Assert.AreEqual(34, contest1.ContenderList[3].totalPoints);
            Assert.AreEqual("Jason", contest1.find_winner());
        }
    }
}
