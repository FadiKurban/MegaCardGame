using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGv4.Classes.Attack.Special
{
    public class Back_Stab : SpecialAttack
    {
        public override int RollOutcome(int damage)
        {
            var vRandom = new Random();
            int A = vRandom.Next(0, 3);
            if (A == 1)
            {
                return damage * 2;
            }
            else
            {
                return damage / 2;
            }
        }
    }
}
