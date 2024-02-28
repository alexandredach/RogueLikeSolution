using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RogueLikeProject
{
    internal class RemoveHealth : ITriggerable
    {
        public void Trigger(Characteristics playerSpecs)
        {
            int damage = ((Trap)playerSpecs.CurrentRoom.RoomContent).Damage;
            playerSpecs.Health -= damage;
            Console.Clear();
            Console.WriteLine($"[{playerSpecs.Name} | HP {playerSpecs.Health}]\n");
            Console.WriteLine($"You get in room {playerSpecs.CurrentRoom.RoomIndex}");
            Console.WriteLine($"You fall on a trap and lose {damage} HP !\n");
            
        }
    }
}
