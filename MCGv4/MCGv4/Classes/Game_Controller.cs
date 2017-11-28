using MCGv4.Classes.Frigther;
using MCGv4.Classes.Frigther.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MCGv4.Classes
{
    public class Game_Controller
    {
        public Player player;
        public Character enemy;

        internal Player Player { get => player; set => player = value; }

        public Game_Controller()
        {
            enemy = new NPC(40, 10);
        }

        public void ClassChoice(char p)
        {
            if (p == 'M')
            {
                Player = new Mage(40, 10);
            }
            else if (p == 'W')
            {
                Player = new Warrior(40, 10);

            }
            else if (p == 'T')

                Player = new Thief(40, 10);
        }

        internal void ClassChoice(object p)
        {
            throw new NotImplementedException();
        }

        public void AttackCall(char p)
        {
            if (p == 'N')
            {
                Player.AttackChar(enemy);
            }
            else
            {
                Player.IniateSpecial(enemy);
            }


            if (enemy.Hp <= 0)
            {
                MessageBox.Show("Game will exit", "You win", MessageBoxButton.OK, MessageBoxImage.Information);
                Environment.Exit(0);
            }
            else
            {
                enemy.AttackChar(Player);
            }

            if (Player.Hp <= 0)
            {
                MessageBox.Show("Game will exit", "You Lost", MessageBoxButton.OK, MessageBoxImage.Information);
                Environment.Exit(0);
            }


        }


    }




}