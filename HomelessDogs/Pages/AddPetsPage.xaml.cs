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
    /// Логика взаимодействия для AddPetsPage.xaml
    /// </summary>
    public partial class AddPetsPage : Page
    {
        public AddPetsPage()
        {
            InitializeComponent();
            BylatEblanLV.ItemsSource = App.db.Aviary.ToList();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddAviaryBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
