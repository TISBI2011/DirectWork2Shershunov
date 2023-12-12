using DirectorWorkShershunovNoGit2.Pages;
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

namespace DirectorWorkShershunovNoGit2
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        private void TBLogin_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void TBVxod_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
            var user = App.DB.User.FirstOrDefault(x => x.Login == TBLogin.Text && x.Password == TBPassword.Text);

            if (user != null)
                NavigationService.Navigate(new MainPage());
            else
                MessageBox.Show("Введены неверные данные");
        }

        private void BReg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
