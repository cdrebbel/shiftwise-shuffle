using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftwiseShuffle
{
    public class Card : IComparable
    {
        public int FaceValue { get; set; }

        public int CompareTo(object obj)
        {
            var card = (Card)obj;
            return FaceValue >= card.FaceValue ? 1 : -1;
        }
    }
}
