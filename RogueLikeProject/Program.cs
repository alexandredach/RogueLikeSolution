using System;

namespace RogueLikeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dungeon.InitRooms();

            Adventurer player = new Adventurer("Sora");

            player.GetInRoom(1);

            Console.WriteLine(player);

            player.GetInRoom(2);

            Console.WriteLine(player);

            player.GetInRoom(3);

            Console.WriteLine(player);

            player.GetInRoom(4);

            Console.WriteLine(player);

            //Console.WriteLine(Room.NumberOfRooms + " " +
            //     Dungeon.RoomList[0].RoomIndex + " " + Dungeon.RoomList[0].RoomType);

            //Console.WriteLine(Room.NumberOfRooms + " " + Dungeon.RoomList[1].RoomIndex + " " + Dungeon.RoomList[1].RoomType);

            //Console.WriteLine(Room.NumberOfRooms + " " + Dungeon.RoomList[2].RoomIndex + " " + Dungeon.RoomList[2].RoomType);



            //Console.WriteLine(player);

            //player.GetInRoom(0);

            //Console.WriteLine(player);



        }
    }
}