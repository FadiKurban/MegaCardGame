using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGv4.Classes.Attack.Special
{
    public class Berserk : SpecialAttack
    {
        public override int RollOutcome(int damage)
        {

            var vRandom = new Random();
            int A = vRandom.Next(0, 3);
            if (A == 1)
            {
                return damage * 3;
            }
            else
            {
                return 0;
            }
        }
    }
}
