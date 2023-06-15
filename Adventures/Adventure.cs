using Werewolf.Adventures.Models;

namespace Werewolf.Adventure
{
    public class Game
    {
        public string GUID;
        public string Title;
        public string Description;
        public int CompletionXPReward;
        public int CompletionGoldReward;
        public int MaxLevel;
        public int MinimumLevel;
        public List<Room> Rooms;

        public Game()
        {

        }

    }
}
