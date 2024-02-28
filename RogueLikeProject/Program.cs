using System;

namespace RogueLikeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Il faut impérativement appeler InitMonsters PUIS InitRooms de la class Dunjeon pour ne pas lever d'erreur

            Dungeon.InitMonsters();
            Dungeon.InitRooms();

            Adventurer player = new Adventurer("Sora");

            player.EnterDungeon();

            // vérification de la présence d'un monstre dans une room
            //Console.WriteLine(Dungeon.RoomList[4].RoomContent);

        }
    }
}