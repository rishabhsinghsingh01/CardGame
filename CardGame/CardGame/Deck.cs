using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    /// <summary>
    /// Class representing a deck of card.
    /// Initialized with collection of cards.
    /// </summary>
    public class Deck
    {
        public List<Card> Cards;// { get; }

        public Deck()
        {
            Cards = new List<Card>();
            Populate();
        }

        /// <summary>
        /// Method to Initialize the deck.
        /// </summary>
        private void Populate()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (CardFace cardFace in Enum.GetValues(typeof(CardFace)))
                {
                    var card = new Card(suit, cardFace);
                    Cards.Add(card);
                }
            }
        }
        /// <summary>
        /// Clearing the current set of cards and initializing with deck.
        /// </summary>
        public void Reset()
        {
            Cards.Clear();
            Populate();
        }
    }
}
