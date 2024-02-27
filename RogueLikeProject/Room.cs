using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class Room
    {
        public static int NumberOfRooms { get; set; }
        public int RoomIndex { get; set; }
        public RoomType RoomType { get; set; }
        public Encounter RoomContent { get; set; }

        public Room(RoomType roomContent, int contentPower)
        {
            NumberOfRooms++;
            RoomIndex = NumberOfRooms;

            if (roomContent == RoomType.Trap)
            {
                RoomType = RoomType.Trap;
                RoomContent = new Trap(contentPower);
            } else if(roomContent == RoomType.Item)
            {
                RoomType = RoomType.Item;
                RoomContent = new Item(contentPower);
            }
        }
    }
}
