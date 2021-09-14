using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO1_Opgave1;
using System;

namespace OO1_Opg1_Test
{
    [TestClass]
    public class UnitTest1
    {
        private FootballPlayer _footballPlayer;

        [TestInitialize]
        public void Init()
        {
            _footballPlayer = new FootballPlayer(0, "Michael Laudrup", 690000, 10);
        }

        // Testing Constructor -------------------------------------------------------------------- Testing Constructor
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorName1()
        {
            _ = new FootballPlayer(0, "", 10, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorName2()
        {
            _ = new FootballPlayer(0, "Na", 10, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorPrice()
        {
            _ = new FootballPlayer(0, "Name", -1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorShirtNo()
        {
            _ = new FootballPlayer(0, "Name", 10, 101);
        }

        // Testing ID ----------------------------------------------------------------------------- Testing ID
        [TestMethod]
        public void TestId()
        {
            Assert.AreEqual(0, _footballPlayer.Id);
            _footballPlayer.Id = 1;
            Assert.AreEqual(1, _footballPlayer.Id);
        }

        // Testing Name --------------------------------------------------------------------------- Testing Name
        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Michael Laudrup", _footballPlayer.Name);
            _footballPlayer.Name = "Lichael Maudrup";
            Assert.AreEqual("Lichael Maudrup", _footballPlayer.Name);

            try
            {
                _footballPlayer.Name = null;
                Assert.Fail();
            }
            catch (ArgumentException argExc)
            {
                Assert.AreEqual("Name is null or blank", argExc.Message);
            }
        }

        // Testing Price -------------------------------------------------------------------------- Testing Price
        [TestMethod]
        public void TestPrice()
        {
            Assert.AreEqual(690000, _footballPlayer.Price);
            _footballPlayer.Price = 420000;
            Assert.AreEqual(420000, _footballPlayer.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPriceException()
        {
            _footballPlayer.Price = -10;
        }

        // Testing Shirt Number ------------------------------------------------------------------- Testing Shirt Number
        [TestMethod]
        public void TestShirtNumber()
        {
            Assert.AreEqual(10, _footballPlayer.ShirtNumber);
            _footballPlayer.ShirtNumber = 9;
            Assert.AreEqual(9, _footballPlayer.ShirtNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestShirtNumberExceptionNegative()
        {
            _footballPlayer.ShirtNumber = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestShirtNumberExceptionAboveHundred()
        {
            _footballPlayer.ShirtNumber = 101;
        }

        // Testing ToString ----------------------------------------------------------------------- Testing ToString
        [TestMethod]
        public void TestToString()
        {
            Assert.AreEqual("Football Player\n ID: 0, Name: Michael Laudrup, Price: 690000, Shirt Number: 10", _footballPlayer.ToString());
        }

        // Code coverage = 100%!
    }
}
