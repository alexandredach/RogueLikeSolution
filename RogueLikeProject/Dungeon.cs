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
            RoomList.Add(new Room(RoomType.Trap, 10));
            RoomList.Add(new Room(RoomType.Trap, 20));
            RoomList.Add(new Room(RoomType.Item, 40));
            RoomList.Add(new Room(RoomType.Item, 10));
        }

        //public override string ToString()
        //{
        //    foreach(Room room in RoomList)
        //    {
        //        return $"Room number : {room.RoomIndex} \n" +
        //            $"Room type : {room.RoomType} - {room.RoomContent}";
        //    }
        //    return "";
        //}
    }
}
