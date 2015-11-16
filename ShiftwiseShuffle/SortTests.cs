using NUnit.Framework;
using FluentAssertions;

namespace ShiftwiseShuffle
{
    [TestFixture]
    public class SortTests
    {
        private Card _card1;
        private Card _card2;
        private int _result;

        [Test]
        public void TwoIsGreaterThanOne()
        {
            GivenCardsWithFaceValue();
            WhenCardsAreCompared();
            ThenFirstCardIsLarger();
        }

        [Test]
        public void DiamondsAreGreaterThanSpades()
        {
            GivenCardsWithSuits();
            WhenCardsAreCompared();
            ThenFirstCardIsLarger();
        }

        private void GivenCardsWithFaceValue()
        {
            _card1 = new Card() { FaceValue = 13 };
            _card2 = new Card() { FaceValue = 1 };
        }

        private void GivenCardsWithSuits()
        {
            _card1 = new Card() { Suit = Suit.DIAMONDS , FaceValue = 1};
            _card2 = new Card() { Suit = Suit.SPADES, FaceValue = 13 };
        }

        public void WhenCardsAreCompared()
        {
            _result = _card1.CompareTo(_card2);
        }

        private void ThenFirstCardIsLarger()
        {
            _result.Should().Be(1);
        }
    }
}