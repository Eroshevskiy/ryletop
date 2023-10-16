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

namespace ryle.Pages
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void autorClick(object sender, RoutedEventArgs e)
        {
            Autor autor = new Autor();
            this.Visibility = Visibility.Hidden;
            autor.Show();
        }

        private void merchesClick(object sender, RoutedEventArgs e)
        {
            merches merch = new merches();
            this.Visibility = Visibility.Hidden;
            merch.Show();
        }
    }
}
