using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Text;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        private Card testCard;

        [TestInitialize]
        public void InitializeVariables()
        {
            testCard = new Card(CardFace.Two, CardSuit.Hearts);
        }

        [TestMethod]
        public void TestCardConstructor()
        {
            Card card = new Card(CardFace.King, CardSuit.Diamonds);
        }

        [TestMethod]
        public void TestCardFaceGetter()
        {
            var testCardFace = testCard.Face;
            Assert.AreEqual(testCardFace, testCard.Face);
        }

        [TestMethod]
        public void TestCardSuitGetter()
        {
            var testSuit = testCard.Suit;
            Assert.AreEqual(testSuit, testCard.Suit);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            StringBuilder testContainer = new StringBuilder();
            testContainer.AppendLine("Card: ");
            testContainer.AppendFormat("Face: {0}, Suit: {1}", testCard.Face, testCard.Suit);
            Assert.AreEqual(testCard.ToString(), testContainer.ToString());
        }

    }
}
        
