using Newtonsoft.Json;
using Werewolf.Entities.Interfaces;
using Werewolf.Entities.Models;

namespace Werewolf.Entities
{
    public class CharacterService : ICharacterService
    {
        

        public Character LoadCharacter(string name)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Characters";
            Character character = new Character();

            if (File.Exists($"{basePath}\\{name}.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var characterJsonFile = directory.GetFiles($"{name}.json");

                using (StreamReader fi = File.OpenText(characterJsonFile[0].FullName))
                {
                    character = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                }

            }
            else
            {
                throw new Exception("Character not found");
            }
            return character;
        }

        public List<Character> GetCharactersInRange(int minLevel = 0, int maxLevel = 20)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            var charactersInRange = new List<Character>();

            try 
	        {
                var directory = new DirectoryInfo(basePath);
                foreach (var file in directory.GetFiles($"*.json"))
                {
                    using (StreamReader fi = File.OpenText(file.FullName))
                    {
                        var potentialCharacterInRange = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                        if (potentialCharacterInRange.IsAlive && (potentialCharacterInRange.Level >=minLevel && potentialCharacterInRange.Level <= maxLevel))
                        {
                            charactersInRange.Add(potentialCharacterInRange);
                        }
                    }
                    
                }
	        }
	        catch (global::System.Exception ex)
	        {

                Console.WriteLine($"Oh NOES! Goblins!!! {ex.Message}");
	        }
            return charactersInRange;
        }
    }
}
