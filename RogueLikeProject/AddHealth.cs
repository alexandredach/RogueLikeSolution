using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class AddHealth : ITriggerable
    {
        public void Trigger(Characteristics playerSpecs)
        {
            int heal = ((Item)playerSpecs.CurrentRoom.RoomContent).Heal;
            playerSpecs.Health += heal;
            Console.Clear();
            Console.WriteLine($"[{playerSpecs.Name} | HP {playerSpecs.Health}]\n");
            Console.WriteLine($"You get in room {playerSpecs.CurrentRoom.RoomIndex}");
            Console.WriteLine($"You get a {((Item)playerSpecs.CurrentRoom.RoomContent).ItemType} ! +{heal} HP\n");
        }
    }
}
