namespace LaFamiliaCasino.Classes
{
    public class Player : BaseEntity
    {
        public Player(int money, string name) : base(money, name) { }

        public override string Stats()
        {
            return $"Player name: {Name}\nBalance: {Money}$";
        }
    }
}
