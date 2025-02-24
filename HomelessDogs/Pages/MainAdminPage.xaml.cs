﻿using System;
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
    /// Логика взаимодействия для MainAdminPage.xaml
    /// </summary>
    public partial class MainAdminPage : Page
    {
        public MainAdminPage()
        {
            InitializeComponent();
            AdminNameTB.Text = App.employee.AdminText;
            DateTime? mounthAgo = DateTime.Now.Subtract(TimeSpan.FromDays(7));
            int count = App.db.Survey.Where(s => s.Date > mounthAgo).ToList().Count();
            LastOperationTB.Text = $"Приемов за последнюю неделю: {count}";
        }
        private void EmployeesBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeePage());
        }

        private void PetsBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainGuestPage(App.employee));
        }

        private void HistoryOperationBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminListVisitsPage());
        }

        private void VolyeriBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AviaryPage());
        }
        

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
