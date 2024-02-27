using System;

namespace RogueLikeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dungeon.InitRooms();

            Adventurer player = new Adventurer("Sora");

            Console.WriteLine(player);

            player.GetInRoom(0);

            Console.WriteLine(player);

            player.GetInRoom(1);

            Console.WriteLine(player);

            player.GetInRoom(2);

            Console.WriteLine(player);

        }
    }
}