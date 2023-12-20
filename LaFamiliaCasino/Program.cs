using System.Xml.Serialization;

namespace LaFamiliaCasino
{
    class Program
    {
        static void Main()
        {
            string? choice = "";
            Player player = new Player(1000, "Daniel");
            Console.WriteLine("Vil du åbne programmet?");
            choice = Console.ReadLine();

            if (choice == "y")
            {
                do
                {
                    Console.WriteLine("1: Play a game" +
                    "\n2: Check your stats" +
                    "\n3: Exit");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Choose a game: ");
                        if (true)
                        {
                            Games.Roulette(out string ball);
                            Console.WriteLine("The ball landed on {0}", ball);
                        }
                    }
                    else if (choice == "2")
                    {
                        string playerStats = player.Stats();
                        foreach (var letter in playerStats)
                        {
                            Console.Write(letter);
                            Thread.Sleep(75);
                        }
                    }
                    else if (choice == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Prøv igen");
                    }
                } while (choice == "3");
            }
            else
            {
                Console.WriteLine("Programmet slutter...");
            }
        }
    }
}