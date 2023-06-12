using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Werewolf.Adventure;
using Werewolf.Entities.Models;
using Werewolf.Entities.Interfaces;

namespace Werewolf.Entities
{
    public class CharacterService : ICharacterService
    {
        public Character LoadInitialCharacter()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Characters";
            Character initialCharacter = new Character();

            if (File.Exists($"{basePath}\\Conan.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("Conan.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialCharacter = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                }

            }
            return initialCharacter;
        }
    }
}
