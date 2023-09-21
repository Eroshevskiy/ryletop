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
    /// Логика взаимодействия для Autor.xaml
    /// </summary>
    public partial class Autor : Window
    {
        public Autor()
        {
            InitializeComponent();

            Classes.dbconnect.modeldb = new Models.ryleEntities1();
        }

        private void Enter(object sender, RoutedEventArgs e)
        {


            var userobj = Classes.dbconnect.modeldb.users.FirstOrDefault(x =>
            login.Text == x.login && pass.Password == x.pasword);

            

            Admin objAdmin = new Admin();
            this.Visibility = Visibility.Hidden;
            objAdmin.Show();
            

            
        }
    }
}
