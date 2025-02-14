using HomelessDogs.Models;
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
    /// Логика взаимодействия для AviaryPage.xaml
    /// </summary>
    public partial class AviaryPage : Page
    {
        public static List<Dog> aviaries = new List<Dog>();
        public AviaryPage()
        {
            InitializeComponent();

            aviaries = App.db.Dog.Where(i=>i.Id_aviary != null).ToList();
            AllAviariesLV.ItemsSource = aviaries;
        }


        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainAdminPage());
        }        
    }
}
