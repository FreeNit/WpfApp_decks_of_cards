using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_decks_of_cards
{
    class CardComparedByValues : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suit < y.Suit)
                return -1;
            if (x.Suit > y.Suit)
                return 1;
            if (x.Value < x.Value)
                return -1;
            if (x.Value > x.Value)
                return 1;
            return 0;
        }
    }
}
