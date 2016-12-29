using System.CodeDom;
using System.Collections.Generic;

namespace Engine.Model
{
    public class Deck
    {
        private List<Card> _cards;

        private readonly List<string> _suits;
        private readonly int _cardsInSuit;

        public Deck()
        {
            _cards = new List<Card>();
        }

        public Card Draw()
        {
            Card card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            
        }
    }
}