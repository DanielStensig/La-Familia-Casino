namespace LaFamiliaCasino.Classes
{
    public class Player : BaseEntity
    {
        public Player(int money, string name) : base(money, name) { }
        
        public override void Stats()
        {
            Console.WriteLine($"{Name} has {Money} dollars to spend!");
            Console.ReadKey();
        }
    }
}

