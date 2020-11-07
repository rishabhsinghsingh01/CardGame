using System;

namespace CardGame
{
    /// <summary>
    /// Operation to shuffle the deck of cards.
    /// </summary>
    public class Shuffle : IGameOperation
    {
        private static readonly Random random = new Random();
        public Deck Deck { get; }
        public Shuffle(Deck deck)
        {
            this.Deck = deck;
        }

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void ExecuteOperation()
        {
            var cards = Deck.Cards;
            int noOfCards = cards.Count;
            while (noOfCards > 1)
            {
                noOfCards--;
                int randomIndex = random.Next(noOfCards + 1);
                var randomCard = cards[randomIndex];
                cards[randomIndex] = cards[noOfCards];
                cards[noOfCards] = randomCard;
            }
            Console.WriteLine("Suffled your deck.");
        }
    }
}
