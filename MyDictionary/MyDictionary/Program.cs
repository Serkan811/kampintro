using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> games = new Dictionary<int, string>();

            games.Add(01, "Counter-Strike: Global Offensive");
            games.Add(02, "League of Legends");
            games.Add(03, "PlayerUnkown’s Battlegrounds");
            games.Add(04, "Grand Theft Auto V");
            games.Add(05, "Among Us");
            games.Add(06, "Apex Legends");
            games.Add(07, "Tom Clancy’s Rainbow Six: Siege");
            games.Add(08, "Call of Duty: Modern Warfare");
            games.Add(09, "Assassin’s Creed: Odyssey");
            games.Add(10, "FIFA 2020");


            Console.WriteLine("Dictionary Size: " + games.Count);

            for (int i = 0; i < games.Count; i++)
            {
                Console.WriteLine(games.Keys[i] + " - " + games.Values[i]);
            }
        }
    }
}
    
