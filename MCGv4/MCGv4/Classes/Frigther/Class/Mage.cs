using MCGv4.Classes.Attack.Special;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGv4.Classes.Frigther.Class
{
   public class Mage : Player
    {
        public Mage(int p, int p_2) : base(p, p_2)
        {
            vSpecialAttack = new Fireball();
        }

        public override void IniateSpecial(Character Target)
        {
            var DamageReturn = vSpecialAttack.RollOutcome(BaseDamage);

            if (DamageReturn > 0)
            {
                vSpecialAttack.DealDamage(DamageReturn, Target);
            }
            else
            {
                Hp += DamageReturn;
            }

        }
    }
}
