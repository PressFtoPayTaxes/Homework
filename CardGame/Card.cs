using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card : IComparable<Card>
    {
        public Suit Suit { get; set; }
        public CardType Type { get; set; }

        public int CompareTo(Card obj)
        {
            return Type.CompareTo(obj.Type);
        }
    }
}
