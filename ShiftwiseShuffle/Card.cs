using System;

namespace ShiftwiseShuffle
{
    public class Card : IComparable
    {
        public int FaceValue { get; set; }
        public Suit Suit { get; set; }

        public int CompareTo(object obj)
        {
            var compareCard = (Card)obj;

            var thisCardFullValue = FaceValue + (int)Suit;
            var compareCardFullValue = compareCard.FaceValue + (int)compareCard.Suit;

            return  thisCardFullValue >= compareCardFullValue? 1 : -1;
        }
    }

    public enum Suit
    {
        SPADES = 100,
        HEARTS = 200,
        CLUBS = 300,
        DIAMONDS = 400
    }
}
