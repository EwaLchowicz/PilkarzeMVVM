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

namespace PlayersMVVM.AddPlayer
{
    /// <summary>
    /// Logika interakcji dla klasy WindowAddPlayer.xaml
    /// </summary>
    public partial class WindowAddPlayer : Window
    {
        public WindowAddPlayer()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            addNewPlayerWindow.DialogResult = true;
            addNewPlayerWindow.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            addNewPlayerWindow.DialogResult = false;
            addNewPlayerWindow.Close();
        }
    }
}
