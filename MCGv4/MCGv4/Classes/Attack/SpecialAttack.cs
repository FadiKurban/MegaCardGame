using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCGv4.Classes;
using MCGv4.Classes.Frigther;
using MCGv4.Classes.Attack;

namespace MCGv4.Classes
{
    public class SpecialAttack : Attack1
    {
        

        public virtual int RollOutcome(int Damage)
        {
            throw new Exception();
        }

        internal void DealDamage(int damageReturn, Character target)
        {
            throw new NotImplementedException();
        }
    }
}
