using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        /// <summary>
        /// This class does this and that, but don't do this.
        /// </summary>

        public void myMethod()
        {

        }
    }
}
