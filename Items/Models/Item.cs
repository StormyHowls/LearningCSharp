using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Werewolf.Items.Interfaces;

namespace Werewolf.Items.Models
{
    public class Item : IItem
    {
        public int Id;
        public string Name;
        public string Description;
        public int ObjectiveNumber;
        public int Weight;
        public int GoldValue;
    }

    public enum ItemType
    {
        Rope,
        Torch,
        HolySymbol,
        Water,
        Food,
        Tinderbox
    }
}
