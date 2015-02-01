using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hand: ");
            foreach (var card in this.Cards)
            {
                sb.AppendLine("Face: " + card.Face + ", Suit: " + card.Suit);
            }

            return sb.ToString();
        }


    }
}
