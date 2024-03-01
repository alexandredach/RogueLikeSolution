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
            Specs = new Characteristics(name, 100, 5, 3);
            Triggerables = new List<ITriggerable>();
            Triggerables.Add(new RemoveHealth());
            Triggerables.Add(new AddHealth());
            Triggerables.Add(new RemoveAttack());
        }

        public void GetInRoom(int roomNumber)
        {
            Room currentRoom = null;
            foreach(Room room in Dungeon.RoomList)
            {
                if (room.RoomIndex == roomNumber)
                {
                    currentRoom = room;
                }
            }
            this.Specs.CurrentRoom = currentRoom;

            if (currentRoom.RoomType == RoomType.Trap)
            {
                Triggerables[0].Trigger(this.Specs);
            } 
            else if (currentRoom.RoomType == RoomType.Item)
            {
                Triggerables[1].Trigger(this.Specs);
            } 
            else if (currentRoom.RoomType == RoomType.Monster)
            {
                Triggerables[2].Trigger(this.Specs);
            }
        }

        public void EnterDungeon()
        {
            int currentRoom = 1;
            ClearScreen();
            Screens.DunjeonScreen();
            Console.WriteLine("You are face to the dungeon");

            while (currentRoom <= Dungeon.RoomList.Count && Specs.Health > 0)
            {
                Console.WriteLine("To enter the next room, press ENTER");
                Console.ReadLine();
                this.GetInRoom(currentRoom); // actionne le déroulement d'une room
                currentRoom++;
            }
            if(Specs.Health <= 0)
            {
                ClearScreen();
                Screens.DeathScreen();
                Console.WriteLine($"You are dead... \nGAME OVER");
            } else
            {
                ClearScreen();
                Screens.TriforceScreen();
                Console.WriteLine($"You got the Triforce and found the exit !\nDUNGEON FINISHED");
            }
        }

        public void ClearScreen()
        {
            Console.Clear();
            Console.WriteLine($"[{Name} | HP {Specs.Health}]\n");
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
