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
    /// Логика взаимодействия для tovari.xaml
    /// </summary>
    public partial class tovari : Window
    {
        public tovari()
        {
            InitializeComponent();
            var merches = Models.ryleEntities1.GetContext().merch.ToList();
            tovariBD.ItemsSource = merches;
        }

        private void mainClick(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
        }
    }
}
