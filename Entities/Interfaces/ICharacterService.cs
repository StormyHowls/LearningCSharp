using Werewolf.Entities.Models;

namespace Werewolf.Entities.Interfaces
{
    public interface ICharacterService
    {
        public Character LoadCharacter(string name);

        public List<Character> GetCharactersInRange(int minLevel =0, int maxLevel = 20);
    }

}
