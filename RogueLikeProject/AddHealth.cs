using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class AddHealth : ITriggerable
    {
        public void Trigger(Characteristics specs)
        {
            if (specs.IsInRoom == RoomType.Item)
            {
                int addHealth = Item.Heal;
                Console.WriteLine($"You get a {Item.ItemType} ! {addHealth} HP\n");
                specs.Health += addHealth;
            }
        }
    }
}
