using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werewolf.Adventures.Models
{
    public class Trap
    {
        public TrapType trapType;
    }
    public enum TrapType
    {
        Pit,
        Poison,
        Spike
    }
}
