namespace LaFamiliaCasino
{
    class Program
    {
        static void Main()
        {
            Player player = new Player(1000, "Daniel");
            player.Stats();
            Games newgame = new Games();
            newgame.Roulette(ball);
        }
    }
}