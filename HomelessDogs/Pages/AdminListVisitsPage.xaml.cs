﻿using HomelessDogs.Models;
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
    /// Логика взаимодействия для AdminListVisitsPage.xaml
    /// </summary>
    public partial class AdminListVisitsPage : Page
    {
        public AdminListVisitsPage()
        {
            InitializeComponent();
            VisitsLV.ItemsSource = App.db.Survey.ToList();
            NameVeterinarsTB.Text = App.employee.Name;
        }

        private void VisitsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.selectedSurvey = VisitsLV.SelectedItem as Survey;
            NavigationService.Navigate(new EditVisitPage());
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddVisitPage());

        }

        private void BackBTN_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainAdminPage());

        }
    }
}
