namespace LaFamiliaCasino.Classes
{
    public class Games
    {
        private static Random random = new Random();
        public static void Roulette(out string ball)
        {
            int nr = random.Next(1, 40);
            string green; string black; string red;
            black = "black";
            red = "red";
            green = "green";

            if (nr % 2 == 0) 
            {
                ball = black;
                Console.WriteLine($"The ball was {ball}, nr was {nr}");
            }
            else if (nr == 1)
            {
                ball = green;
                Console.WriteLine($"The ball was {ball}, nr was {nr}");
            }
            else
            {
                ball = red;
                Console.WriteLine($"The ball was {ball}, nr was {nr}");
            }

        }
    }
}

