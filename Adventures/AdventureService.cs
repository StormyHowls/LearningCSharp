using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Werewolf.Adventure;
using Werewolf.Adventures.Interfaces;

namespace Werewolf.Adventures
{
    public class AdventureService : IAdventureService
    {
        public Game GetInitialAdventure()
        {
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
               
            }
            return initialAdventure;
        }
    }
}
