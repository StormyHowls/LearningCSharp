using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Werewolf.Adventure;
using Werewolf.Adventures.Interfaces;

namespace Werewolf.Engine
{
    public class GameService
    {
        private IAdventureService adventureService;
        public GameService(IAdventureService AdventureService)
        {
            adventureService = AdventureService;
        }
        public void StartGame()
        {
            Console.WriteLine("Welcome to your new life, cub...");
            Game initialAdventure = adventureService.GetInitialAdventure();
            Console.WriteLine($"Adventure : {initialAdventure.Title}");
            Console.WriteLine($"Description : {initialAdventure.Description}");
            Console.ReadKey();
        }
    }
}
