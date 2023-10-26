using Animal_Info.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animal_Info.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public List<Master> Masters { get; set; }
        
        public AuthorizationPage()
        {
            InitializeComponent();
            //var masters1 = loginCb.SelectedItem as  Master;
            //Employee currentUser = employees.FirstOrDefault(i => i.Name == login && i.Password == password);
            //if (currentUser != null)
            //    NavigationService.Navigate(new MenuPage());
            //else
            //    MessageBox.Show("Такого сотрудника нет!!!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
