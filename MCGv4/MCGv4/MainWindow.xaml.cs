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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MCGv4.Classes;

namespace MCGv4
{
    public partial class MainWindow : Window
    {
        Battle start;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Mage_Click(object sender, RoutedEventArgs e)
        {
            start = new Battle('M');
            start.PlayerImage.Source = new BitmapImage(new Uri(@"C:\Users\fadi\Desktop\More Files\Uni\Code\Verison 3\MCG\MCG\Images\Character\wizard.png"));
            this.Hide();
            start.Show();
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            start = new Battle('W');
            start.PlayerImage.Source = new BitmapImage(new Uri(@"C:\Users\fadi\Desktop\More Files\Uni\Code\Verison 3\MCG\MCG\Images\Character\Knight.jpg"));
            this.Hide();
            start.Show();
        }
        private void Thief_Click(object sender, RoutedEventArgs e)
        {
            start = new Battle('T');
            start.PlayerImage.Source = new BitmapImage(new Uri(@"C:\Users\fadi\Desktop\More Files\Uni\Code\Verison 3\MCG\MCG\Images\Character\Robber.jpg"));
            this.Hide();
            start.Show();
        }
    }
}
