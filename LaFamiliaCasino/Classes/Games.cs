namespace LaFamiliaCasino.Classes
{
    public class Games
    {
        private static Random random = new Random();
        public static void Roulette(out string ball)
        {
            int nr;
            string green; string black; string red;
            black = "black";
            red = "red";
            green = "green";

            nr = random.Next(1, 60);
            if (nr % 2 == 0) 
            {
                ball = black;
                Console.WriteLine(ball);
            }
            else if (nr % 3 == 0)
            {
                ball = red;
                Console.WriteLine(ball);
            }
            else if (nr == 1)
            {
                ball = green;
                Console.WriteLine(ball);
            }
            else
            {
                ball = "None";
            }

        }
    }
}

