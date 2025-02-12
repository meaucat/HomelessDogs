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
    /// Логика взаимодействия для EditPetsPage.xaml
    /// </summary>
    public partial class EditPetsPage : Page
    {
        public EditPetsPage()
        {
            InitializeComponent();
            BylatEblanLV.ItemsSource = App.db.Aviary.ToList();
            DescriptionTB.Text = App.selectedDog.Description;
            WeightTB.Text = App.selectedDog.Weight.ToString();
            HeightTB.Text = App.selectedDog.Height.ToString();
            AgeTB.Text = App.selectedDog.Age.ToString();
            NameTB.Text = App.selectedDog.SerialNumber;
            StatusCB.IsChecked = App.selectedDog.IsGive;
            DieCB.IsChecked = App.selectedDog.IsDie;
            GenderCB.SelectedIndex = (int)App.selectedDog.Id_gender;
            GenderCB.ItemsSource = App.db.Gender.ToList();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainAdminPage());
        }

        private void AddAviaryBTN_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
