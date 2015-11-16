using System;
using System.Collections.Generic;

namespace ShiftwiseShuffle
{
    public class CardShuffler
    {
        private List<Card> _deck;

        public CardShuffler(List<Card> deck)
        {
            _deck = deck;
        }

        public List<Card> Shuffle()
        {
            var rand = new Random();
            for (int i = 0; i < _deck.Count; i++)
            {
                var moveMe = _deck[i];
                var fromHere = rand.Next() % _deck.Count;

                _deck[i] = _deck[fromHere];
                _deck[fromHere] = moveMe;
            }

            return _deck;
        }
    }
}