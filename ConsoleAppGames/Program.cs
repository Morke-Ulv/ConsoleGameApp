using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Program newGame = new Program();
            newGame.Run();

        }

        public void Run()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            introQuote();
        }
        public void introQuote()
        {
            Console.Clear();
            Console.WriteLine("In a galixy far far away....");
            Console.WriteLine("Galaga hears rumor that Earth is under attack and must make haste to save the world");
            Console.WriteLine("This is where your journey begins...");
            Console.ReadKey(true);
            room1();
        }

        public void room1()
        {
            Randy room = new Randy();
            bool inRoom = true;
            while (inRoom)
            {
            Console.Clear();
            Console.WriteLine("Current position is in Galaxy 778, nearest points of jump is....");
            Console.WriteLine("galaxy 334, galaxy 938, galaxy 492.");
            Console.WriteLine("where would you like to jump to?");
            string nextRoom = Console.ReadLine();
            Console.Clear();
                switch (nextRoom)
                {
                    case "galaxy 334":
                        room.Randomizer();
                        inRoom = false;
                        break;
                    case "galaxy 938":
                        room.Randomizer();
                        inRoom = false;
                        break;
                    case "galaxy 492":
                        room.Randomizer();
                        inRoom = false;
                        break;
                    default:
                        Console.WriteLine("I did not copy that Captain");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
