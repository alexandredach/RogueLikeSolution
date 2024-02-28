using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace RogueLikeProject
{
    internal class RemoveAttack : ITriggerable
    {
        public void Trigger(Characteristics playerSpecs)
        {
            Monster facingMonster = null;

            foreach (Monster monster in Dungeon.MonstersList)
            {
                if (monster.Specs.CurrentRoom.RoomIndex == playerSpecs.CurrentRoom.RoomIndex)
                {
                    facingMonster = monster;
                }
            }

            ClearScreen(playerSpecs, facingMonster);
            Console.WriteLine($"You are facing a {facingMonster.Name} !");

            if (playerSpecs.Speed >= facingMonster.Specs.Speed)
            {
                Console.WriteLine("You are the first to fight !");
            } else
            {
                Console.WriteLine($"{facingMonster.Name} is the first to attack !");
            }

            while (facingMonster.Specs.Health > 0 && playerSpecs.Health > 0)
            {
                if(playerSpecs.Speed >= facingMonster.Specs.Speed)
                {
                    PlayerAttack(playerSpecs, facingMonster);
                    if (facingMonster.Specs.Health <= 0)
                        break;
                    MonsterAttack(playerSpecs, facingMonster);
                } else
                {
                    MonsterAttack(playerSpecs, facingMonster);
                    if (playerSpecs.Health <= 0)
                        break;
                    PlayerAttack(playerSpecs, facingMonster);
                }
            }

            if(facingMonster.Specs.Health <= 0)
            {
                playerSpecs.Attack++;
                playerSpecs.Speed++;
                ClearScreen(playerSpecs, facingMonster);
                Console.WriteLine($"You defeat the {facingMonster.Name} ! Rewards : attack+1 speed+1");
            }
        }

        public void PlayerAttack(Characteristics playerSpecs, Monster facingMonster)
        {
            Random random = new Random();
            int attackValue = random.Next(playerSpecs.Attack * 2, playerSpecs.Attack * 5);
            Console.WriteLine("Press ENTER to attack");
            Console.ReadLine();
            facingMonster.Specs.Health -= attackValue;
            ClearScreen(playerSpecs, facingMonster);
            Console.WriteLine($"You give {playerSpecs.Attack * 4} damage to {facingMonster.Name}");
        }
        public void MonsterAttack(Characteristics playerSpecs, Monster facingMonster)
        {
            Random random = new Random();
            int attackValue = random.Next(facingMonster.Specs.Attack * 2, facingMonster.Specs.Attack * 5);
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            playerSpecs.Health -= attackValue;
            ClearScreen(playerSpecs, facingMonster);
            Console.WriteLine($"{facingMonster.Name} gives you {facingMonster.Specs.Attack * 4} damages");
        }

        public void ClearScreen(Characteristics playerSpecs, Monster facingMonster)
        {
            Console.Clear();
            Console.WriteLine($"[{playerSpecs.Name} | HP {playerSpecs.Health}] [{facingMonster.Name} | HP {facingMonster.Specs.Health}]\n");
        }
    }
}
