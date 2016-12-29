namespace Engine.Model
{
    public class Character
    {
        private string _name;
        private string _playerName;
        private double _scrip;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public double Scrip
        {
            get { return _scrip; }
            set { _scrip = value; }
        }
    }
}