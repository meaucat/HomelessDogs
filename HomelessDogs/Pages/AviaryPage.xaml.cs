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

            AviaryTypeCb.ItemsSource = App.db.AviaryType.ToList();
            aviaries = App.db.Dog.Where(i=>i.Id_aviary != null).ToList();
            AllAviariesLV.ItemsSource = aviaries;
        }

        private void AllAnimalsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ClearBTN_Click(object sender, RoutedEventArgs e)
        {
            AviaryTypeCb.SelectedItem = null;
        }

        private void AddAviaryBTN_Click(object sender, RoutedEventArgs e)
        {
            if (AviaryTypeCb.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать тип вольера.");
            }
            else
            {
                Aviary aviary = new Aviary()
                {
                    Id_aviary_type = (AviaryTypeCb.SelectedItem as AviaryType).Id_aviary_type,
                };
                App.db.Aviary.Add(aviary);
                App.db.SaveChanges();

                aviaries = App.db.Dog.ToList();
                AllAviariesLV.ItemsSource = aviaries;

                MessageBox.Show("Вольер успешно добавлен.");
            }
        }
        
        private void EditAviaryBTN_Click(object sender, RoutedEventArgs e)
        {
            if (AllAviariesLV.SelectedItem ==  null)
            {
                MessageBox.Show("Необходимо выбрать вольер для изменения.");
            }
            else
            {
                App.selectedAviary = AllAviariesLV.SelectedItem as Aviary;
                //Переход на окно или страницу
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainAdminPage());
        }        
    }
}
