namespace Engine.Model
{
    public class Item
    {
        private readonly string _name;
        private readonly double _cost;
        private int _quantity;

        public string Name => _name;

        public double Cost => _cost;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public Item(string name, double cost, int quantity = 1)
        {
            _name = name;
            _cost = cost;
            _quantity = quantity;
        }
    }
}