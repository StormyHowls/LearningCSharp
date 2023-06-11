using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werewolf.Adventure
{
    public class Game
    {
        public string GUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CompletionXPReward { get; set; }
        public int CompletionGoldReward { get; set; }
        public int MaxLevel { get; set; }
        public int MinimumLevel { get; set; }

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
