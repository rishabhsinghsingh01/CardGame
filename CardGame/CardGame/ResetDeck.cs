namespace CardGame
{
    /// <summary>
    /// Operation to restart the deck of the card.
    /// </summary>
    public class ResetDeck : IGameOperation
    {
        public Deck Deck { get; }

        public ResetDeck(Deck deck)
        {
            this.Deck = deck;
        }

        /// <summary>
        /// Resets the deck.
        /// </summary>
        public void ExecuteOperation()
        {
            Deck.Reset();
            System.Console.WriteLine("Game restarted!");
        }
    }
}
