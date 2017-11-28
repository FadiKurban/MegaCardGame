using MCGv4.Classes.Frigther;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGv4.Classes.Attack
{
   public class Attack1
    {
        public virtual void DealDamage(int Damage, Character Target)
        {
            Target.Hp -= Damage;
        }

    }
}
