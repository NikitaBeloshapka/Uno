using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сards
{
    public class CardSet
    {
        public List<Card> Cards { get; set; }

        protected int Count
        {
            get { return Cards.Count; }
        }

        public CardSet(List<Card> cards)
        {
            this.Cards = cards;
        }

        public CardSet() : this(new List<Card>())
        { }

        public CardSet(int count) : this()
        {
            foreach (var colour in Enum.GetValues(typeof(CardColour)))
            {
                foreach (var kind in Enum.GetValues(typeof(KindsOfCards)))
                {
                    Cards.Add(new Card((CardColour)colour, (KindsOfCards)kind));
                }
            }
            if (count < Count)
                Cards.RemoveRange(0, Count - count);
        }


        public void Mix()
        {
            Random rnd = new Random();
            List<Card> newCards = new List<Card>();

            for (int i = Cards.Count; i > 0; i--)
            {
                Card a = Cards[rnd.Next(0, Cards.Count)];
                newCards.Add(a);
                Cards.Remove(a);
            }

            Cards = newCards;
        }

        public Card Pull()
        {
            return Pull(0);
        }

        public Card Pull(int number)
        {
            if (number > Count - 1) return null;

            Card a = Cards[number];
            Cards.RemoveAt(number);
            return a;
        }

        public virtual void Show()
        {
            foreach (var item in Cards)
            {
                item.Show();
            }

        }

        public void Sort()
        {
            Cards.Sort((card1, card2) =>
            card1.Colour.CompareTo(card2.Colour) == 0 ?
            card1.Kinds.CompareTo(card2.Kinds) :
            card1.Colour.CompareTo(card2.Colour));
        }

        public CardSet Deal(int amount)
        {
            CardSet c = new CardSet();
            if (amount > Cards.Count) amount = Cards.Count;

            for (int i = 0; i < amount; i++)
            {
                c.Add(Cards[i]);
                Cards.RemoveAt(i);
            }

            return c;
        }

        public void Add(params Card[] card)
        {
            foreach (var item in card)
            {
                Cards.Add(item);
            }
        }

        public void Add(CardSet cards)
        {
            Add(cards.Cards.ToArray());
        }
    }
}
