using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            int minimalNumberOfCards = 2;
            int maximalNumberOfCards = 5;

            if (hand.Cards.Count >= minimalNumberOfCards && hand.Cards.Count <= maximalNumberOfCards)
            {
                return true;
            }

            return false;
        }

        public bool IsStraightFlush(IHand hand)
        {
            var sortedCards = hand.Cards.OrderBy(card => card.Face).ThenBy(card => card.Suit).ToList();
            bool hasStraightFlush = true;
            for (int i = 1; i < sortedCards.Count(); i++)
            {
                if ((int)sortedCards[i].Face != (int)sortedCards[i - 1].Face + 1 || sortedCards[i].Suit != sortedCards[i - 1].Suit)
                {
                    hasStraightFlush = false;
                    break;
                }
            }

            return hasStraightFlush;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var sortedCards = hand.Cards.OrderBy(card => card.Face).ThenBy(card => card.Suit).ToList();

            if (sortedCards[sortedCards.Count() - 2].Face == sortedCards[0].Face)
            {
                return true;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            var sortedCards = hand.Cards.OrderBy(card => card.Face).ThenBy(card => card.Suit).ToList();
            int numberOfCards = sortedCards.Count();

            if ((sortedCards[0].Face == sortedCards[2].Face) && (sortedCards[numberOfCards - 2].Face == sortedCards[numberOfCards - 1].Face))
            {
                return true;
            }
            else if ((sortedCards[0].Face == sortedCards[1].Face) && (sortedCards[2].Face == sortedCards[numberOfCards - 1].Face))
            {
                return true;
            }

            return false;
        }

        public bool IsFlush(IHand hand)
        {
            var currentSuit = hand.Cards[0].Suit;
            foreach (var card in hand.Cards)
            {
                if (card.Suit != currentSuit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            var sortedCards = hand.Cards.OrderBy(card => card.Face).ThenBy(card => card.Suit).ToList();
            for (int i = 1; i < sortedCards.Count(); i++)
            {
                if ((int)sortedCards[i].Face != (int)sortedCards[i - 1].Face + 1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            var sortedCards = hand.Cards.OrderBy(card => card.Face).ThenBy(card => card.Suit).ToList();
            if (sortedCards[0].Face == sortedCards[2].Face || sortedCards[sortedCards.Count - 1].Face == sortedCards[2].Face)
            {
                return true;
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            var sortedCards = hand.Cards.OrderBy(card => card.Face).ThenBy(card => card.Suit).ToList();

            if ((sortedCards[0].Face == sortedCards[1].Face) && (sortedCards[2].Face == sortedCards[3].Face))
            {
                return true;
            }
            else if ((sortedCards[1].Face == sortedCards[2].Face) && (sortedCards[3].Face == sortedCards[4].Face))
            {
                return true;
            }
            else if ((sortedCards[0].Face == sortedCards[1].Face) && (sortedCards[3].Face == sortedCards[4].Face))
            {
                return true;   
            }

            return false; 
        }

        public bool IsOnePair(IHand hand)
        {
            var sortedCards = hand.Cards.OrderBy(card => card.Face).ThenBy(card => card.Suit).ToList();
            for (int i = 1; i < sortedCards.Count(); i++)
            {
                if ((int)sortedCards[i].Face == (int)sortedCards[i - 1].Face)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            var sortedCards = hand.Cards.OrderBy(card => card.Face).ThenBy(card => card.Suit).ToList();
            for (int i = 1; i < sortedCards.Count(); i++)
            {
                if ((int)sortedCards[i].Face != (int)sortedCards[i - 1].Face + 2)
                {
                    return false;
                }
            }

            return true;
            
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            // I have no idea how to compare 2 hands. If you know - please leave me a message in homework comment.
            throw new NotImplementedException();
        }
    }
}
