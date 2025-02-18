using HomelessDogs.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HomelessDogs
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

        public static HomelessDogsEntities db = new HomelessDogsEntities();
        //public static HomelessDogsEntities1 db = new HomelessDogsEntities1();
        public static Employee employee;
        public static Aviary selectedAviary {  get; set; }
        public static Dog selectedDog { get; set; }
        public static Employee selectedEmployee { get; set; }
        public static Survey selectedSurvey { get; set; }
    }
}
