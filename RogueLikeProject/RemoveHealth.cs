using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class RemoveHealth : ITriggerable
    {
        public void Trigger(Characteristics specs)
        {
            if(specs.CurrentRoom.RoomType == RoomType.Trap)
            {
                int removeHealth = ((Trap)specs.CurrentRoom.RoomContent).Damage;
                Console.WriteLine($"You fall on a trap and lose {removeHealth} HP !\n");
                specs.Health -= removeHealth;
            }
        }
    }
}
