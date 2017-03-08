using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication2;

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for UnitTestContender
    /// </summary>
    [TestClass]
    public class UnitTestContender
    {
        public UnitTestContender()
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
        public void TestContenderClass()
        {


            Contender contender1 = new Contender();
            Contender contender2 = new Contender();
            Contender contender3 = new Contender();
            Contender contender4 = new Contender();



            contender1.Id = 1;
            contender2.Id = 2;
            contender3.Id = 3;
            contender4.Id = 4;

            Assert.AreEqual(1, contender1.Id);
            Assert.AreEqual(2, contender2.Id);
            Assert.AreEqual(3, contender3.Id);
            Assert.AreEqual(4, contender4.Id);

            contender1.Name = "Ivar";
            contender2.Name = "Carlos";
            contender3.Name = "Tomas";
            contender4.Name = "Viktor";

            Assert.AreEqual("Ivar", contender1.Name);
            Assert.AreEqual("Carlos", contender2.Name);
            Assert.AreEqual("Tomas", contender3.Name);
            Assert.AreEqual("Viktor", contender4.Name);


            contender1.Nationality = "Swe";
            contender2.Nationality = "Swe";
            contender3.Nationality = "Swe";
            contender4.Nationality = "Swe";

            Assert.AreEqual("Swe", contender1.Nationality);
            Assert.AreEqual("Swe", contender2.Nationality);
            Assert.AreEqual("Swe", contender3.Nationality);
            Assert.AreEqual("Swe", contender4.Nationality);


            //Test av konstruktor
            Contender contender = new Contender();
            contender.AddContender(5, "Kjell", "Swe");
            Assert.AreEqual("Kjell", contender.Name);
            Assert.AreEqual("Swe", contender.Nationality);
            Assert.AreEqual(5, contender.Id);

            Jump jump1 = new Jump();
            Jump jump2 = new Jump();
            Jump jump3 = new Jump();
            Jump jump4 = new Jump();

            jump1.Point = 5;
            jump2.Point = 10;
            jump4.Point = 15;
            jump3.Point = 1;

            Assert.AreEqual(true, contender1.IsJumpListEmpty());

            contender1.add_jump(jump1);
            contender1.add_jump(jump2);
            contender2.add_jump(jump3);
            contender2.add_jump(jump4);
            contender3.add_jump(jump1);
            contender3.add_jump(jump4);
            contender4.add_jump(jump2);
            contender4.add_jump(jump3);

            Assert.AreEqual(false, contender1.IsJumpListEmpty());

            contender1.summeraPoints();
            contender2.summeraPoints();
            contender3.summeraPoints();
            contender4.summeraPoints();

            Assert.AreEqual(15, contender1.totalPoints);
            Assert.AreEqual(16, contender2.totalPoints);
            Assert.AreEqual(20, contender3.totalPoints);
            Assert.AreEqual(11, contender4.totalPoints);

        }
    }
}
