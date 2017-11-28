using MCGv4.Classes.Attack.Special;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGv4.Classes.Frigther.Class
{
  public  class Thief : Player
    {
        public Thief(int p, int p_2) : base(p, p_2)
        {
            vSpecialAttack = new Back_Stab();
        }
    }
}
