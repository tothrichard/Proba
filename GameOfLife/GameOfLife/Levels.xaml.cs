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

namespace GameOfLife
{
    /// <summary>
    /// Interaction logic for Levels.xaml
    /// </summary>
    public partial class Levels : Window
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void E_Click(object sender, RoutedEventArgs e)
        {
           Easy game = new Easy();
            game.Show();
            Hide();
        }

        private void Z_Click(object sender, RoutedEventArgs e)
        {
            Medium game = new Medium();
            game.Show();
            Hide();
        }

        private void J_Click(object sender, RoutedEventArgs e)
        {
           Hard game = new Hard();
            game.Show();
            Hide();
        }

        private void U_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
