namespace CardGame
{
    /// <summary>
    /// Interface for an operation on a deck of cards
    /// </summary>
    public interface IGameOperation
    {
        public Deck Deck { get; }
        void ExecuteOperation();
    }
}
