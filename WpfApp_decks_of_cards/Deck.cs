using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfApp_decks_of_cards
{
    class Deck : ObservableCollection<Card>
    {
        private static Random random = new Random();

        public Deck()
        {
            Reset();
        }

        public Card Deal(int index)
        {
            // Use base[index] to pull out the specific card and RemoveAt(index) to remove it
            // "The Deal method will deal a card from the deck"
            Card cardToDeal = base[index];
            RemoveAt(index);
            return cardToDeal;
        }

        public void Reset()
        {
            /* Call Clear() to remove all cards from the deck, then use two for loops to add
            * all combinations of suit and value, calling Add(new Card(...)) to add each card */
            // "The Reset method reset the 52-card deck"
            Clear();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    Add(new Card((Values)value, (Suits)suit));
        }

        public void Shuffle()
        {
            /* Use new List<Card>(this) to create a copy of the deck, then pick a random card
            * from copy, call copy.RemoveAt to remove it, and Add(card) to add it */
            // "The Shuffle method will randomize the cards"
            List<Card> copy = new List<Card>(this);
            Clear();
            while (copy.Count > 0)
            {
                int index = random.Next(copy.Count);
                Card card = copy[index];
                copy.RemoveAt(index);
                Add(card);
            }
        }
        public void Sort()
        {
            // Use a foreach loop to call Add for each card in sortedCards
            //The Sort method sorts the cards.
            List<Card> sortedCards = new List<Card>(this);
            sortedCards.Sort(new CardComparedByValues());
            Clear();
            foreach (Card card in sortedCards)
            {
                Add(card);
            }
        }
    }
}
