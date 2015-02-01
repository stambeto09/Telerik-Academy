using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker;

namespace Poker.Tests.PockerHandsCheckerTests
{
    [TestClass]
    public class PockerHandsCheckerTests
    {
        private PokerHandsChecker checker;
        private List<ICard> cards;
        private Card firstCard;
        private Card secondCard;

        [TestInitialize]
        public void InitializeVariables()
        {
            checker = new PokerHandsChecker();
            cards = new List<ICard>();
            firstCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            secondCard = new Card(CardFace.Ace, CardSuit.Clubs);
            
        }

        [TestMethod]
        public void IsHandValidWithTrueValue()
        {
            cards.Add(firstCard);
            cards.Add(secondCard);

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsValidHand(testHand));

        }

        [TestMethod]
        public void IsHandValidWithFalseValueLowerBoundary()
        {
            cards.Add(firstCard);

            Hand testHand = new Hand(cards);

            Assert.IsFalse(checker.IsValidHand(testHand));

        }

        [TestMethod]
        public void IsHandValidWithFalseValueHigherBoundary()
        {
            cards.Add(firstCard);
            cards.Add(secondCard);
            // Adding 4 more cards to check if the top boundary is working correctly
            for (int card = 0; card < 4; card++)
            {
                cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            }

            Hand testHand = new Hand(cards);

            Assert.IsFalse(checker.IsValidHand(testHand));

        }

        [TestMethod]
        public void TestIsStraightFlushMethodPositiveCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Three, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Four, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Five, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Six, CardSuit.Diamonds));
            
            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsStraightFlush(testHand));
        }

        [TestMethod]
        public void TestIsStraightFlushMethodNegativeCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Three, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Four, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Queen, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsFalse(checker.IsStraightFlush(testHand));
        }

        [TestMethod]
        public void TestIsFourOfAKindMethodPositiveCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Two, CardSuit.Spades));
            cards.Add(new Card(CardFace.Two, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Two, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Queen, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsFourOfAKind(testHand));
        }

        [TestMethod]
        public void TestIsFourOfAKindMethodNegativeCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Two, CardSuit.Spades));
            cards.Add(new Card(CardFace.Three, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Two, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Queen, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsFalse(checker.IsFourOfAKind(testHand));
        }

        [TestMethod]
        public void TestIsFullHouseMethodPositiveCaseFirst()
        {
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cards.Add(new Card(CardFace.King, CardSuit.Hearts));
            cards.Add(new Card(CardFace.King, CardSuit.Clubs));
            cards.Add(new Card(CardFace.King, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsFullHouse(testHand));
        }

        [TestMethod]
        public void TestIsFullHouseMethodPositiveCaseSecond()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Two, CardSuit.Spades));
            cards.Add(new Card(CardFace.King, CardSuit.Hearts));
            cards.Add(new Card(CardFace.King, CardSuit.Clubs));
            cards.Add(new Card(CardFace.King, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsFullHouse(testHand));
        }
        
        [TestMethod]
        public void TestIsFullHouseMethodNegativeCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.King, CardSuit.Spades));
            cards.Add(new Card(CardFace.King, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Queen, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Queen, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsFalse(checker.IsFullHouse(testHand));
        }

        [TestMethod]
        public void TestIsFlushPositiveCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Four, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.King, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Queen, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsFlush(testHand));
        }

        [TestMethod]
        public void TestIsFlushNegativeCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Four, CardSuit.Spades));
            cards.Add(new Card(CardFace.King, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Queen, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsFalse(checker.IsFlush(testHand));
        }

        [TestMethod]
        public void TestisStraightPositiveCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Three, CardSuit.Spades));
            cards.Add(new Card(CardFace.Four, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Six, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsStraight(testHand));
        }

        [TestMethod]
        public void TestIsStraightNegativeCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cards.Add(new Card(CardFace.Four, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Six, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsFalse(checker.IsStraight(testHand));
        }

        [TestMethod]
        public void TestIsThreeOfAKindPositiveCaseFirst()
        {
            cards.Add(new Card(CardFace.Queen, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Queen, CardSuit.Spades));
            cards.Add(new Card(CardFace.Queen, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Six, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsThreeOfAKind(testHand));
        }

        [TestMethod]
        public void TestIsThreeOfAKindPositiveCaseSecond()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Two, CardSuit.Spades));
            cards.Add(new Card(CardFace.Two, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Six, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsThreeOfAKind(testHand));
        }

        [TestMethod]
        public void TestIsThreeOfAKindNegativeCaseFirst()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cards.Add(new Card(CardFace.Four, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Six, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsFalse(checker.IsThreeOfAKind(testHand));
        }

        [TestMethod]
        public void TestIsTwoPairPositiveCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cards.Add(new Card(CardFace.Four, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Two, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsTwoPair(testHand));
        }

        [TestMethod]
        public void TestIsOnePairPositiveCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Three, CardSuit.Spades));
            cards.Add(new Card(CardFace.Four, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Two, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsOnePair(testHand));
        }

        [TestMethod]
        public void TestIsOnePairNegativeCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Three, CardSuit.Spades));
            cards.Add(new Card(CardFace.Four, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsFalse(checker.IsOnePair(testHand));
        }

        [TestMethod]
        public void TestIsHighCardPositiveCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Four, CardSuit.Spades));
            cards.Add(new Card(CardFace.Six, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Eight, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ten, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsTrue(checker.IsHighCard(testHand));
        }

        [TestMethod]
        public void TestIsHighCardNegativeCase()
        {
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Five, CardSuit.Spades));
            cards.Add(new Card(CardFace.Six, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ten, CardSuit.Diamonds));

            Hand testHand = new Hand(cards);

            Assert.IsFalse(checker.IsHighCard(testHand));
        }
    }
}
