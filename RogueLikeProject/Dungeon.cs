using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class Dungeon
    {
        public static List<Room> RoomList { get; set; }

        public static void InitRooms()
        {
            RoomList = new List<Room>();
            RoomList.Add(new Room());
            RoomList.Add(new Item(10, "small potion"));
            RoomList.Add(new Item(30, "big potion"));
        }
    }
}
