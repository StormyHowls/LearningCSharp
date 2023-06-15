using Werewolf.Adventure;
using Werewolf.Adventures.Interfaces;
using Werewolf.Engine.Interfaces;
using Werewolf.Entities.Interfaces;
using Werewolf.Entities.Models;

namespace Werewolf.Engine
{
    public class GameService : IGameService
    {
        private IAdventureService adventureService;
        private ICharacterService characterService;

        private Character character;
        public GameService(IAdventureService AdventureService, ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }
        public bool StartGame(Game adventure = null)
        {
            try
            {
                if (adventure == null)
                {
                    Console.WriteLine("Welcome to your new life, cub...");
                    adventure = adventureService.GetInitialAdventure();
                }



                Console.Clear();
                Console.WriteLine();

                //Create Title Banner
                for (int i = 0; i <= adventure.Title.Length + 3; i++)
                {
                    Console.Write("*");
                    if (i == adventure.Title.Length + 3)
                    {
                        Console.Write("\n");
                    }
                }
                Console.WriteLine($"| {adventure.Title} |");
                for (int i = 0; i <= adventure.Title.Length + 3; i++)
                {
                    Console.Write("*");
                    if (i == adventure.Title.Length + 3)
                    {
                        Console.Write("\n");
                    }
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{adventure.Description.ToUpper()}");


                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;

                var charactersInRange = characterService.GetCharactersInRange(adventure.MinimumLevel, adventure.MaxLevel);

                if (charactersInRange.Count == 0)
                {
                    Console.WriteLine("Sorry, you do not have any characters in the range level of the adventure you are trying to play");
                    return false;
                }
                else
                {
                    Console.WriteLine("Who doth wish to chance death?!");
                    var characterCount = 0;
                    foreach (var character in charactersInRange)
                    {
                        Console.WriteLine($"#{characterCount} {character.Name} Level - {character.Level} {character.Class}");
                        characterCount++;
                    }

                }
                character = characterService.LoadCharacter(charactersInRange[Convert.ToInt32(Console.ReadLine())].Name);

                //Console.WriteLine($"Adventure : {initialAdventure.Title}");
                //Console.WriteLine($"Description : {initialAdventure.Description}");
                Console.WriteLine($"Character Name : {character.Name}");
                Console.WriteLine($"Level : {character.Level}");

                Monster myMonster = new Monster();// DOn't need - kill line

            }
            catch (Exception ex)
            {
                Console.WriteLine($"KaBOOM! Orcs did it again! Something went wrong! {ex.Message}");
            }

            return true;


        }
    }
}
