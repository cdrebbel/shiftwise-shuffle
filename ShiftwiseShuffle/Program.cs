using System;
using System.Collections.Generic;

namespace ShiftwiseShuffle
{
    class Program
    {
        public static void Main(string[] args)
        {
            var deck = new List<Card>();
            for (int i = 100; i <= 400; i = i + 100)
            {
                var suit = (Suit)i;

                for (int j = 1; j <= 13; j++)
                {
                    deck.Add(new Card() { FaceValue = j, Suit = suit });
                }
            }

            Console.WriteLine("New Deck\n--------");
            deck.ForEach(c => Console.WriteLine(c));
            Console.WriteLine();

            var shuffler = new CardShuffler(deck);
            var shuffledDeck = shuffler.Shuffle();
            
            Console.WriteLine("Shuffled Deck\n--------");
            shuffledDeck.ForEach(c => Console.WriteLine(c));
            Console.WriteLine();

            //This is why I chose to implement CompareTo().
            shuffledDeck.Sort();

            Console.WriteLine("Sorted Deck\n--------");
            shuffledDeck.ForEach(c => Console.WriteLine(c));
        }
    }
}