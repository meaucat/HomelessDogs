using HomelessDogs.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
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
using System.Windows.Media.Media3D;
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
            AviariesLv.ItemsSource = App.db.Aviary.ToList();
            AviaryTypeCb.ItemsSource = App.db.AviaryType.ToList();
            DescriptionTB.Text = App.selectedDog.Description;
            WeightTB.Text = App.selectedDog.Weight.ToString();
            HeightTB.Text = App.selectedDog.Height.ToString();
            AgeTB.Text = App.selectedDog.Age.ToString();
            NameTB.Text = App.selectedDog.SerialNumber;
            StatusCB.IsChecked = App.selectedDog.IsGive;
            DieCB.IsChecked = App.selectedDog.IsDie;
            GenderCB.ItemsSource = App.db.Gender.ToList();
            GenderCB.SelectedItem = App.selectedDog.Gender;
            PetImg.Source = ToImage(App.selectedDog.Photo);
            AviariesLv.SelectedItem = App.selectedDog.Aviary;
        }

        public BitmapImage ToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainGuestPage(App.employee));
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

                MessageBox.Show("Вольер успешно добавлен.");
                AviariesLv.ItemsSource = App.db.Aviary.ToList();
            }
        }

        private void EditPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                App.selectedDog.Photo = File.ReadAllBytes(openFileDialog.FileName);
                PetImg.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
            else
            {
                MessageBox.Show("Изменений не происходило.");
                return;
            }

            App.db.Dog.AddOrUpdate(App.selectedDog);
            App.db.SaveChanges();

            MessageBox.Show("Фотография питомца выбрана.");
        }

        private void EditInformationBTN_Click(object sender, RoutedEventArgs e)
        {
            var fieldsToCheck = new[] { NameTB.Text, AgeTB.Text, HeightTB.Text, WeightTB.Text, DescriptionTB.Text };
            if (fieldsToCheck.Any(string.IsNullOrWhiteSpace) || GenderCB.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля.");
            }
            else if (NameTB.Text == App.selectedDog.SerialNumber && AgeTB.Text == App.selectedDog.Age.ToString() && HeightTB.Text == App.selectedDog.Height.ToString() && WeightTB.Text == App.selectedDog.Weight.ToString() && DescriptionTB.Text == App.selectedDog.Description && StatusCB.IsChecked == App.selectedDog.IsGive && App.selectedDog.IsDie
                == DieCB.IsChecked && AviariesLv.SelectedIndex == App.selectedDog.Id_aviary)
            {
                MessageBox.Show("Изменений не происходило.");
                return;
            }
            else
            {
                App.selectedDog.SerialNumber = NameTB.Text;
                App.selectedDog.Height = int.Parse(HeightTB.Text);
                App.selectedDog.Weight = int.Parse(WeightTB.Text);
                App.selectedDog.Description = DescriptionTB.Text;
                App.selectedDog.Age = int.Parse(AgeTB.Text);
                App.selectedDog.IsDie = DieCB.IsChecked;
                App.selectedDog.IsGive = StatusCB.IsChecked;
                App.selectedDog.Id_gender = GenderCB.SelectedIndex + 1;
                App.selectedDog.Id_aviary = (AviariesLv.SelectedItem as Aviary).Id_aviary;

                App.db.SaveChanges();

                MessageBox.Show("Данные изменены.");
                NavigationService.Navigate(new MainGuestPage(App.employee));
            }
        }
    }
}
