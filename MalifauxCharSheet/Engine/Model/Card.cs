namespace Engine.Model
{
    public class Card
    {
        private readonly string _suit;
        private readonly int _value;

        public string Suit => _suit;
        public int Value => _value;

        public Card(string suit, int value)
        {
            _suit = suit;
            _value = value;
        }
    }
}