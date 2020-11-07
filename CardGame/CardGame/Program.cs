using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        /// <summary>
        /// Entry point to the game.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                var deck = new Deck();
                //Factory for all possible operations on the deck.
                var options = new Dictionary<GameOperation, IGameOperation>
            {
                { GameOperation.Shuffle, new Shuffle(deck) },
                { GameOperation.DrawTop, new DrawTop(deck) },
                { GameOperation.ResetDeck, new ResetDeck(deck) }
            };
                Console.WriteLine("Ready to play!");
                //Game loop.
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Choose from following operations:");
                    int opearationIndex = 0;
                    //print all the options in the game.
                    foreach (var option in options)
                    {

                        Console.WriteLine("For " + option.Key + " Press: " + opearationIndex);
                        opearationIndex += 1;
                    }
                    //get and validate user input.
                    Console.WriteLine();
                    var userInput = Console.ReadLine();
                    if (!int.TryParse(userInput, out int selectedOption))
                    {
                        Console.WriteLine("Invalid input. Please try again!");
                        continue;
                    }

                    bool validInput = Enum.IsDefined(typeof(GameOperation), selectedOption);
                    if (validInput)
                    {
                        var selectedOperation = (GameOperation)Enum.Parse(typeof(GameOperation), userInput);
                        options[selectedOperation].ExecuteOperation();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again!");
                    }
                }
            }
            catch (Exception anyException)
            {
                GameException.Throw(anyException);
            }
            
        }        
    }
    /// <summary>
    /// All the possible operations on the deck of cards.
    /// </summary>
    public enum GameOperation
    {
        Shuffle,
        DrawTop,
        ResetDeck
    }
}
