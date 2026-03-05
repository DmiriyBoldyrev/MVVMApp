using MVVMApp.View;
using MVVMApp.View.WorkerUI;
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
    /// Логика взаимодействия для AuthorisationEmployerPage.xaml
    /// </summary>
    public partial class AuthorisationEmployerPage : Page
    {
        public AuthorisationEmployerPage()
        {
            InitializeComponent();
        }

        private void AuthClickEmp(object sender, RoutedEventArgs e)
        {
            WindowEmployer windowEmployer = new WindowEmployer();
            windowEmployer.Show();
        }
    }
}
