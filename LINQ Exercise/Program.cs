using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;//This doesn't seem to work for some reason....
using System.Text;

namespace LINQ_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Diablo II", "Diablo II Expansion: Lord of Destruction", "Counterstrike", "Mario Kart 64", "Golden Eye 007", "Perfect Dark", "Mortal Kombat 3", "Mortal Kombat Trilogy", "Duke Nukem 3D", "Diddy Kong Racing", "Super Smash Bros", "Super Smash Bros Melee", "Soul Calibur", "Quake III Arena", "Doom II", "Jet Grind Radio", "Tekken Tag", "Bomberman 64", "Heretic", "Hexen", "Twisted Metal 2", "Lords of Magic: Special Edition", "Riven", "League of Legends", "Zelda: Ocarina of Time", "Donkey Kong 64" };

            videoGames.Add("Dance Dance Revolution");
            videoGames.Add("Gauntlet Legends");
            videoGames.Add("F.E.A.R");
            videoGames.Add("Crysis");
            videoGames.Add("Elder Scrolls IV: Oblivion");
            videoGames.Add("Elder Scrolls V: Skyrim");
            videoGames.Add("Quake");
            videoGames.Add("Quake II");

            var orderedVideoGamesbyLength = videoGames.OrderBy(name => name.Length);//Lists the indexes by their length of characters (since each is a string type)
            var orderedVideoGamesbyAlphabet = videoGames.OrderBy(name => name);//Lists the indexes alphabetically.
            var orderedVideoGamesbyDescending = videoGames.OrderByDescending(name => name.Length);//variable orderedVideoGamebyDescending equals variable videoGames dot OrderByDescending method extension, variable name lambda length of variable name.
            //var orderedVideoGamesby = videoGames.Contains(letter => letter);
            Console.WriteLine("Utilizing C#'s LINQ system syntax, we can quickly organize lists of indexes. In this case; video game titles.");
            Console.WriteLine();

            Console.WriteLine("By Title Length.");
            Console.WriteLine();
            foreach (var game in orderedVideoGamesbyLength)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine();
            //Thread.Sleep(1222);//Couldn't figure out why this wasn't functioning at all.... thought I included the system directive that it needed in order to work.

            Console.WriteLine("By Title Alphabet");
            Console.WriteLine();
            foreach (var game in orderedVideoGamesbyAlphabet)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine();

            Console.WriteLine("By Title Length -- Descending.");
            Console.WriteLine();
            foreach (var game in orderedVideoGamesbyDescending)
            {
                Console.WriteLine($"{game}");
            }
            Console.WriteLine();
        }
    }
}