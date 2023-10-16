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
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void autorClick(object sender, RoutedEventArgs e)
        {
            Autor autor = new Autor();
            this.Visibility = Visibility.Hidden;
            autor.Show();
        }

        private void listmerchesClick(object sender, RoutedEventArgs e)
        {
            listviewmerch list = new listviewmerch();
            this.Visibility = Visibility.Hidden;
            list.Show();

        }
    }
}
