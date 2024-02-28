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
        // contentPower définira soit les dommages des pièges, soit la taille d'une potion, soit la force d'un monstre
        {
            NumberOfRooms++;
            // le RoomIndex commencera à 1 pour éviter les confusions
            RoomIndex = NumberOfRooms;

            if (roomContent == RoomType.Trap)
            {
                RoomType = RoomType.Trap;
                RoomContent = new Trap(contentPower);
            } else if(roomContent == RoomType.Item)
            {
                RoomType = RoomType.Item;
                RoomContent = new Item(contentPower);
            } else if(roomContent == RoomType.Monster)
            {
                RoomType = RoomType.Monster;
                int currentIndex = Dungeon.MonsterIndex;
                RoomContent = Dungeon.MonstersList[currentIndex];
                // ici, contentPower va définir la puissance d'attaque du monstre
                Dungeon.MonstersList[currentIndex].Specs.Attack = contentPower;
                // et lui attribuer cette Room dans ses attributs
                Dungeon.MonstersList[currentIndex].Specs.CurrentRoom = this;
                Dungeon.MonsterIndex++; 
                // la prochaine Room ajoutera le monstre de la liste MonsterList suivant
            }
        }

        public override string ToString()
        {
            return $"Room number {RoomIndex} ({RoomType} room)";
        }
    }
}
