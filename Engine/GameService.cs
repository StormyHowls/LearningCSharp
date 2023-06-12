using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Werewolf.Adventure;
using Werewolf.Adventures.Interfaces;
using Werewolf.Entities.Interfaces;

namespace Werewolf.Engine
{
    public class GameService
    {
        private IAdventureService adventureService;
        private ICharacterService characterService;
        public GameService(IAdventureService AdventureService, ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }
        public void StartGame()
        {
            Console.WriteLine("Welcome to your new life, cub...");
            Game initialAdventure = adventureService.GetInitialAdventure();
            var initialCharacter = characterService.LoadInitialCharacter();
            Console.WriteLine($"Adventure : {initialAdventure.Title}");
            Console.WriteLine($"Description : {initialAdventure.Description}");
            Console.WriteLine($"Character Name : {initialCharacter.Name}");
            Console.WriteLine($"Level : {initialCharacter.Level}");
            
        }
    }
}
