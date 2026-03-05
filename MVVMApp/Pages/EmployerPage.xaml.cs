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

namespace MVVMApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployerPage.xaml
    /// </summary>
    public partial class EmployerPage : Page
    {
        public EmployerPage()
        {
            InitializeComponent();
        }

        private void EmployerButtonLog_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorisationEmployerPage());
        }

        private void EmployerButtonReg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationEmployerPage());
        }
    }
}
