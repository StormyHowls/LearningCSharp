using Werewolf.Engine;

namespace Werewolf.Adventures.Models
{
    public class Trap
    {
        public TrapType trapType;
        public Die DamageDie = Die.D4;
    }
    public enum TrapType
    {
        Pit,
        Poison,
        Spike
    }
}
