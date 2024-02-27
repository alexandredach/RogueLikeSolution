using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class Item : Encounter
    {
        public int Heal { get; set; }
        public string ItemType { get; set; }

        public Item(int heal)
        {
            Heal = heal;
            if(heal < 30)
            {
                ItemType = "small potion";
            } else if (heal < 50)
            {
                ItemType = "medium potion";
            } else
            {
                ItemType = "big potion";
            }
        }
    }
}
