using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentAssertions;

namespace ShiftwiseShuffle
{
    [TestFixture]
    public class ShuffleTests
    {
        private CardShuffler _shuffler;
        private List<Card> _deck;
        private List<Card> _shuffledDeck;

        [Test]
        public void ShouldComeBackInDifferentOrder()
        {
            GivenDeck();
            GivenShuffler();
            WhenShuffled();
            ThenInDifferentOrder();
        }

        private void GivenDeck()
        {
            _deck = new List<Card>();

            //Adding lots of cards to reduce chance that test fails.
            for(int i = 1; i <= 100; i++){
                _deck.Add(new Card() { FaceValue = i });
            };
        }

        private void GivenShuffler()
        {
            _shuffler = new CardShuffler(_deck.Select(c=>c).ToList()); //Making a copy of the list, so we can do a comparison
        }

        private void WhenShuffled()
        {
            //Could be convinced to pass _deck in here rather than constructor. Didn't want to overthink it.
            _shuffledDeck = _shuffler.Shuffle();
        }

        private void ThenInDifferentOrder()
        {
            var diffCount = 0;
            for (int i = 0; i < _deck.Count; i++)
            {
                if(_deck[i] != _shuffledDeck[i])
                {
                    diffCount++;
                }
            }

            diffCount.Should().BeGreaterThan(0);
        }
    }
}
