using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Collections.Generic;

namespace Poker.Tests.HandTests
{
    [TestClass]
    public class HandTests
    {
        private List<ICard> cards;
        private const int InitialNumberOfCards = 2;
        [TestInitialize]
        public void InitializeVariables()
        {
            cards = new List<ICard>();

            // Intializing three new cards by generating random suits and
            Array cardSuits = Enum.GetValues(typeof(CardSuit));
            Random randomCardSuits = new Random();

            Array cardFace = Enum.GetValues(typeof(CardFace));
            Random randomCardFace = new Random();

            for (int card = 0; card < InitialNumberOfCards; card++)
            {
                CardSuit randomSuit = (CardSuit)cardSuits.GetValue(randomCardSuits.Next(cardSuits.Length));
                CardFace randomFace = (CardFace)cardFace.GetValue(randomCardFace.Next(cardFace.Length));

                cards.Add(new Card(randomFace, randomSuit));
            }
        }

        [TestMethod]
        public void TestHandConstructor()
        {
            Hand testHand = new Hand(cards);
        }

        [TestMethod]
        public void TestHandToStringMethod()
        {
            Hand testHand = new Hand(cards);
            StringBuilder testContainer = new StringBuilder();
            testContainer.AppendLine("Hand: ");
            foreach (var card in cards)
            {
                testContainer.AppendLine("Face: " + card.Face + ", Suit: " + card.Suit);
            }
            Assert.AreEqual(testContainer.ToString(), testHand.ToString());
        }
    }
}
