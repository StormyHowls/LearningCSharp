using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Werewolf.Entities.Models;

namespace Werewolf.Entities.Interfaces
{
    public interface ICharacterService
    {
        public Character LoadInitialCharacter();
    }
}
