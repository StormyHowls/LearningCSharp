using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Werewolf.Adventure;

namespace Werewolf.Engine
{
    public class GameService
    {
        public void StartGame()
        {
            Console.WriteLine("Welcome to your new life, cub...");
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Adventures";
            Game initialAdventure = new Game();

            if (File.Exists($"{basePath}\\initial.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("initial.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialAdventure = JsonConvert.DeserializeObject<Game>(fi.ReadToEnd());
                }
                Console.WriteLine($"Adventure : {initialAdventure.Title}");
                Console.WriteLine($"Description : {initialAdventure.Description}");
            }
            Console.ReadKey();
        }
    }
}
