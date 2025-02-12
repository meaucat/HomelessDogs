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
    /// Логика взаимодействия для InfoAboutAnimalPage.xaml
    /// </summary>
    public partial class InfoAboutAnimalPage : Page
    {
        
        public InfoAboutAnimalPage()
        {
            InitializeComponent();

            SerialNumberTB.Text = App.selectedDog.SerialNumber;
            PointLifeTB.Text = $"Вольер №{App.selectedDog.Id_aviary}";
            TypeTB.Text = App.selectedDog.SerialNumber;
            AgeTB.Text = App.selectedDog.AgeText;
            HeightTB.Text = $"{App.selectedDog.Height}см.";
            WeightTB.Text = $"{App.selectedDog.Weight}кг.";
            GenderTB.Text = (App.selectedDog.Gender as Gender).Name;
            DescriptionTB.Text = App.selectedDog.Description;
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
                NavigationService.Navigate(new MainGuestPage(new Employee()));
        }
    }
}