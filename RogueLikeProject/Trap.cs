using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeProject
{
    internal class Trap : Encounter
    {
        public static int Damage { get; set; }

        public Trap(int damage)
        {
            Damage = damage;
        }
    }
}
