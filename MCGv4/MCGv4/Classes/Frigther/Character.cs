using MCGv4.Classes.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGv4.Classes.Frigther
{
    public class Character
    {
        public int Hp;
        public int BaseDamage;
        public NormalAttack vNormalAttack;

        public Character(int p, int p_2)
        {
            Hp = p;
            BaseDamage = p_2;
            vNormalAttack = new NormalAttack();
        }

        public void AttackChar(Character Target)
        {
            vNormalAttack.DealDamage(BaseDamage, Target);
        }
    }

}
