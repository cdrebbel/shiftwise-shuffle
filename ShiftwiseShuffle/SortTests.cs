using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace ShiftwiseShuffle
{
    [TestFixture]
    public class SortTests
    {
        [Test]
        public void TwoIsGreaterThanOne()
        {
            GivenDeck();
            WhenDeckIsSorted();
            ThenCardsAreInOrder();

        }

        private List<Card> _deck; 

        private void GivenDeck()
        {
            _deck = new List<Card>();
            _deck.Add(new Card() { FaceValue = 13 });
            _deck.Add(new Card() { FaceValue = 1 });
            _deck.Add(new Card() { FaceValue = 7 });
        }

        public void WhenDeckIsSorted()
        {
            _deck.Sort();
        }

        private void ThenCardsAreInOrder()
        {
            var prevCard= _deck.First();
            _deck.Remove(prevCard);
            foreach(var card in _deck)
            {
                prevCard.FaceValue.Should().BeLessOrEqualTo(card.FaceValue);
            }
        }
    }
}
