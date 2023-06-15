using Werewolf.Items.Models;

namespace Werewolf.Adventures.Models
{
    public class Chest
    {
        public bool Locked = false;
        public Trap Trap;
        public List<Item> Treasure;
        public int Gold;

    }
}
