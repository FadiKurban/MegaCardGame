using MCGv4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MCGv4
{
    /// <summary>
    /// Interaction logic for Battle.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for Battle.xaml
    /// </summary>
    public partial class Battle : Window
    {
        Game_Controller GameController;
        private char v;
        
        public Battle(char p)
        {
            GameController = new Game_Controller();
            GameController.ClassChoice(p);
            InitializeComponent();
            lblNPCHp.Content = GameController.enemy.Hp.ToString();
            lblPlayerHp.Content = GameController.Player.Hp.ToString();
            lblPlayerDam.Content = GameController.Player.BaseDamage.ToString();
        }

        

        private void Special_Click(object sender, RoutedEventArgs e)
        {
            GameController.AttackCall('N');
            lblNPCHp.Content = (GameController.enemy.Hp).ToString();
            lblPlayerHp.Content = (GameController.Player.Hp).ToString();
        }

        private void Normal_Click(object sender, RoutedEventArgs e)
        {
            GameController.AttackCall('S');
            lblNPCHp.Content = (GameController.enemy.Hp).ToString();
            lblPlayerHp.Content = (GameController.Player.Hp).ToString();
        }
    }
}

