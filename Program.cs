using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Werewolf.Adventures;
using Werewolf.Engine;
using Werewolf.Entities;

namespace Werewolf
{
    internal class Program
    {
        private static AdventureService adventureService = new AdventureService();
        private static CharacterService characterService = new CharacterService();
        private static GameService gameService = new GameService(adventureService, characterService);

        static void Main(string[] args)
        {
            MakeTitle();
            MakeMainMenu();

        }

        private static void MakeTitle()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" _ _ _                       _ ___ ");
            Console.WriteLine("| | | |___ ___ ___ _ _ _ ___| |  _|");
            Console.WriteLine("| | | | -_|  _| -_| | | | . | |  _|");
            Console.WriteLine("|_____|___|_| |___|_____|___|_|_|\n\n");
        }
        private static void MakeMainMenu()
        {
            bool inputValid = false;
            MakeMenuOptions();
            
            
            while (!inputValid)
            {
                
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        gameService.StartGame();
                        inputValid = true;
                        break;
                    case "C":
                        CreateCharacter();
                        inputValid = true;
                        break;
                    case "L":
                        LoadGame();
                        inputValid = true;
                        break;
                    default:
                        Console.WriteLine("Input is invalid. Please try again.");
                        MakeMenuOptions();
                        inputValid = false;
                        break;
                }
            }
        }
        private static void MakeMenuOptions()
        {
            Console.WriteLine("(S)tart a New Game");
            Console.WriteLine("(L)oad a Game");
            Console.WriteLine("(C)reate New Character");
        }

        private static void CreateCharacter()
        {
            Console.WriteLine("Who are you?");
            Console.ReadKey();
        }
        private static void LoadGame()
        {
            Console.WriteLine("Back for more, I see...");
            Console.ReadKey();
        }
    }
}