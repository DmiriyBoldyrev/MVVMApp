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
    /// Логика взаимодействия для ChangePage.xaml
    /// </summary>
    public partial class ChangePage : Page
    {
        public ChangePage()
        {
            InitializeComponent();
        }

        private void EmployerButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployerPage());
        }

        private void WorkerButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WorkerPage());
        }
    }
}
