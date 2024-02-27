using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class Item : Encounter
    {
        public static int Heal { get; set; }
        public static string ItemType { get; set; }

        public Item(int heal, string typeName)
        {
            Heal = heal;
            ItemType = typeName;
        }
    }
}
