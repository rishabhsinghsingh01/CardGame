using System;

namespace CardGame
{
    /// <summary>
    /// Operation to draw top card from the deck.
    /// </summary>
    public class DrawTop : IGameOperation
    {
        public Deck Deck { get; }
        public DrawTop(Deck deck)
        {
            this.Deck = deck;
        }

        /// <summary>
        /// Removes the first element of the deck and prints it.
        /// </summary>
        public void ExecuteOperation()
        {
            if(Deck.Cards.Count < 1)
            {
                Console.WriteLine("No more cards left!");
                return;
            }
            try
            {
                var card = Deck.Cards[0];
                Deck.Cards.RemoveAt(0);
                Console.WriteLine(card);
            }
            catch (ArgumentOutOfRangeException outOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Please ensure the values is in bound.",outOfRangeException.InnerException);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
