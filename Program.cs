using System;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string> { "Fortnite", "Pacman", "Tetris", "Super Mario", "The Sims", "Grand Theft Auto V", "Sonic The Hedgehog", "CounterStrike", "Minecraft", "Super Smash Brothers", "Solar Ash", "The Legend of Zelda", "Metal Gear Solid", "WoW", "Final Fantasy", "Pokemon"};
            videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }



}

