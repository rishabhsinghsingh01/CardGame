using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    /// <summary>
    /// Class representing a single card from the deck.
    /// Initialize with a card suit and card face.
    /// </summary>
    public class Card
    {
        private readonly Suit suit;
        private readonly CardFace cardFace;

        public Card(Suit suit, CardFace cardFace)
        {
            this.suit = suit;
            this.cardFace = cardFace;
        }

        /// <summary>
        /// to string override to represent a card on console.
        /// </summary>
        /// <returns>cardface of suit</returns>
        public override string ToString()
        {
            return cardFace.ToString() + " of " + suit.ToString();
        }
    }
}
