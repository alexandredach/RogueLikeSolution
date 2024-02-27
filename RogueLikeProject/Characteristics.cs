using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class Characteristics
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public Room CurrentRoom { get; set; }

        public Characteristics(int health, int attack, int speed)
        {
            Health = health;
            Attack = attack;
            Speed = speed;
            CurrentRoom = null;
    }

        
    }
}
