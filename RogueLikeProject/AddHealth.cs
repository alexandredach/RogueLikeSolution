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
            if (specs.CurrentRoom.RoomType == RoomType.Item)
            {
                int addHealth = ((Item)specs.CurrentRoom.RoomContent).Heal;
                Console.WriteLine($"You get a {((Item)specs.CurrentRoom.RoomContent).ItemType} ! +{addHealth} HP\n");
                specs.Health += addHealth;
            }
        }
    }
}
