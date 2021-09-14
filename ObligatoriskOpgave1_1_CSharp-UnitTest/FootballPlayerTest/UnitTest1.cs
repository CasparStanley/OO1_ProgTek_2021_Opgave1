using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave1_1_CSharp_UnitTest;
using System;

namespace FootballPlayerTest
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
    }
}
