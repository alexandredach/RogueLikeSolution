using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class Monster : Encounter
    {
        public string Name { get; set; }
        public Characteristics Specs { get; set; }
        public Monster(string name, int health, int speed)
        {
            Name = name;
            Specs = new Characteristics(name, health, 0, speed);
        }

        //public void PlaceInRoom(int roomNumber)
        //{
        //    Room currentRoom = null;

        //    foreach (Room room in Dungeon.RoomList)
        //        if (room.RoomIndex == roomNumber)
        //            currentRoom = room;

        //    this.Specs.CurrentRoom = currentRoom;
        //}

        public override string ToString()
        {
            return $"--- {Name} specs ---\n" +
                $"HP : {Specs.Health} \n" +
                $"Attack : {Specs.Attack} \n" +
                $"Speed : {Specs.Speed}\n" +
                $"Placement : {Specs.CurrentRoom}";
        }
    }
}
