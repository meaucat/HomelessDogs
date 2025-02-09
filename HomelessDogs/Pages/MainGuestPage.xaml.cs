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
    /// Логика взаимодействия для MainGuestPage.xaml
    /// </summary>
    public partial class MainGuestPage : Page
    {
        public static List<Dog> dogs = new List<Dog>();
        public MainGuestPage()
        {
            InitializeComponent();

            dogs = App.db.Dog.Where(x => x.IsDie == false && x.IsGive == false).ToList();
            AllAnimalsLV.ItemsSource = dogs;
        }

        private void AllAnimalsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.selectedDog = AllAnimalsLV.SelectedItem as Dog;
            NavigationService.Navigate(new InfoAboutAnimalPage());
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
