using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Werewolf.Adventure;

namespace Werewolf.Adventures.Interfaces
{
    public interface IAdventureService
    {
        Game GetInitialAdventure();
    }
}
