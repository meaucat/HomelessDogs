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
using System.Windows.Shapes;

namespace HomelessDogs.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainGuestPage.xaml
    /// </summary>
    public partial class MainGuestPage : Page
    {
        public Employee currentEmployee;
        public static List<Dog> dogs = new List<Dog>();
        public MainGuestPage(Employee employee)
        {
            InitializeComponent();
            currentEmployee = employee;

            if (currentEmployee.Id_employee != 0)
            {
                dogs = App.db.Dog.ToList();
                AllAnimalsLV.ItemsSource = dogs;
                AddPetBTN.Visibility = Visibility.Visible;
            }
            else
            {
                dogs = App.db.Dog.Where(x => x.IsDie == false && x.IsGive == false).ToList();
                AllAnimalsLV.ItemsSource = dogs;
                AddPetBTN.Visibility = Visibility.Hidden;
            }
        }

        private void AllAnimalsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.selectedDog = AllAnimalsLV.SelectedItem as Dog;
            if (currentEmployee.Id_employee == 0)
            {
                NavigationService.Navigate(new InfoAboutAnimalPage());
            }
            else
            {
                NavigationService.Navigate(new EditPetsPage());
            }
                
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            if (currentEmployee.Id_employee == 0)
            {
                NavigationService.Navigate(new AuthorizationPage());
                return;
            }
            NavigationService.Navigate(new MainAdminPage());
        }

        private void AddPetBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPetsPage());
        }
    }
}
