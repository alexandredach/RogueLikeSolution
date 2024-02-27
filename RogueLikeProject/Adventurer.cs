using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class Adventurer
    {
        public string Name { get; set; }
        // doit juste avoir les propriétés Characteristics > pas d'héritage
        public Characteristics Specs { get; set; }
        public List<ITriggerable> Triggerables { get; set; }
        

        public Adventurer(string name)
        {
            Name = name;
            Specs = new Characteristics(100, 5, 3);
            Triggerables = new List<ITriggerable>();
            Triggerables.Add(new RemoveHealth());
            Triggerables.Add(new AddHealth());
        }

        public void GetInRoom(int roomIndex)
        {
            Console.WriteLine($"You get in room {roomIndex}");
            Encounter currentRoom = Room.RoomList[roomIndex];
            if (Room.RoomList[roomIndex].RoomType == RoomType.Trap)
            {
                this.Specs.IsInRoom = RoomType.Trap;
                Triggerables[0].Trigger(this.Specs);
            } else if (Room.RoomList[roomIndex].RoomType == RoomType.Item)
            {
                this.Specs.IsInRoom = RoomType.Item;
                Triggerables[1].Trigger(this.Specs);
            }
        }

        public override string ToString()
        {
            return $"--- {Name} specs ---\n" +
                $"HP : {Specs.Health} \n" +
                $"Attack : {Specs.Attack} \n" +
                $"Speed : {Specs.Speed}\n";
        }
    }
}
