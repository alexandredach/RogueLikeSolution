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
        public static List<Monster> MonstersList { get; set; }
        public static int MonsterIndex { get; set; }

        // il faudra veiller à ce qu'il y ait autant de Room de type Monster que de Monster dans MonstersList

        public static void InitRooms()
        {
            RoomList = new List<Room>();
            RoomList.Add(new Room(RoomType.Trap, 10));
            RoomList.Add(new Room(RoomType.Item, 15));
            RoomList.Add(new Room(RoomType.Trap, 20));
            RoomList.Add(new Room(RoomType.Item, 40));
            RoomList.Add(new Room(RoomType.Monster, 3));
            RoomList.Add(new Room(RoomType.Item, 30));
            RoomList.Add(new Room(RoomType.Monster, 3));
            RoomList.Add(new Room(RoomType.Item, 60));
            RoomList.Add(new Room(RoomType.Monster, 7));
        }

        public static void InitMonsters()
        {
            MonsterIndex = 0;
            MonstersList = new List<Monster>();
            MonstersList.Add(new Monster("Giant Spider", 100, 1));
            MonstersList.Add(new Monster("Skeleton", 100, 2));
            MonstersList.Add(new Monster("Dragon", 100, 5));
        }
    }

}
