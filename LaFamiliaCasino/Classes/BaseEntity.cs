namespace LaFamiliaCasino.Classes
{
    public abstract class BaseEntity
    {
        private int _money;
        private string _name;

        public int Money
        {
            get { return _money;  }
            set { _money = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        protected BaseEntity(int money, string name)
        {
            this.Money = money;
            this.Name = name;
        }
        public abstract string Stats();
    }
}


