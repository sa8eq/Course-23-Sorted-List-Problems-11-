using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public class Game
    {
        private SortedList<string, int> Players { set; get; }
        public Game()
        {
            Players = new SortedList<string, int>();
        }
        public void PrintBoard()
        {
            Console.WriteLine(string.Join("\n", Players.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value} Points")));
            Console.WriteLine("-----------------------------------------"); Console.WriteLine("-----------------------------------------");
        }
        public void AddPlayer(string name)
        {
            Players.Add(name, 0);
        }
        public void UpdateScore(string name,int score)
        {
            Players[name] = score;
            
            PrintBoard();
        }
    }
    static void Main(string[] args)
    {
        Game game = new Game();

        game.AddPlayer("Sadeq");
        game.AddPlayer("Ahmed");
        game.AddPlayer("Lenah");

        game.UpdateScore("Sadeq", 100);
        game.UpdateScore("Lenah", 101);
        game.UpdateScore("Ahmed", 105);




    }
}

