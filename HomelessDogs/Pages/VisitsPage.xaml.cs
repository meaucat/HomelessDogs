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

namespace HomelessDogs.Pages
{
    /// <summary>
    /// Логика взаимодействия для VisitsPage.xaml
    /// </summary>
    public partial class VisitsPage : Page
    {
        public VisitsPage()
        {
            InitializeComponent();

            if (App.employee.Id_post != 1)
            {
                EditInformationBTN.Visibility = Visibility.Visible;
            }
            else
            {
                EditInformationBTN.Visibility = Visibility.Hidden;
            }
        }

        private void EditInformationBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditVisitPage());
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisitsPage());
        }
    }
}
