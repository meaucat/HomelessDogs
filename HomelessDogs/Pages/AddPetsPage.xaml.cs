using HomelessDogs.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomelessDogs.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddPetsPage.xaml
    /// </summary>
    public partial class AddPetsPage : Page
    {
        public AddPetsPage()
        {
            InitializeComponent();
            AviariesLv.ItemsSource = App.db.Aviary.ToList();
            AviaryTypeCb.ItemsSource = App.db.AviaryType.ToList();
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
            }
        }

        private void AddPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                PetImg.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        private void AddInformationBTN_Click(object sender, RoutedEventArgs e)
        {
            var fieldsToCheck = new[] { NameTB.Text, AgeTB.Text, HeightTB.Text, WeightTB.Text, DescriptionTB.Text, };
            if (fieldsToCheck.Any(string.IsNullOrWhiteSpace) || GenderCB.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля.");
            }
            else
            {
                Dog dog = new Dog()
                {
                    SerialNumber = NameTB.Text,
                    Height = int.Parse(HeightTB.Text),
                    Weight = int.Parse(WeightTB.Text),
                    Description = DescriptionTB.Text,
                    Age = int.Parse(AgeTB.Text),
                };

                if (PetImg.Source != null)
                {
                    var bitmap = PetImg.Source as BitmapImage;
                    if (bitmap != null)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            BitmapEncoder encoder = new PngBitmapEncoder();
                            encoder.Frames.Add(BitmapFrame.Create(bitmap));
                            encoder.Save(memoryStream);
                            dog.Photo = memoryStream.ToArray();
                        }
                    }
                }
                else
                {
                    string defaultImagePath = "pack://application:,,,/HomelessDogs;component/Images/logo.png";
                    BitmapImage defaultImage = new BitmapImage(new Uri(defaultImagePath, UriKind.RelativeOrAbsolute));
                    using (var memoryStream = new MemoryStream())
                    {
                        BitmapEncoder encoder = new PngBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(defaultImage));
                        encoder.Save(memoryStream);
                        dog.Photo = memoryStream.ToArray();
                    }
                }

                App.db.Dog.Add(dog);
                App.db.SaveChanges();

                MessageBox.Show("Питомец успешно добавлен.");
                NavigationService.Navigate(new MainGuestPage(App.employee));
            }
        }
    }
}
