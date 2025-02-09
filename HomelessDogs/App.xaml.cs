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
        public static HomelessDogsEntities db = new HomelessDogsEntities();
        public static Employee employee;
        public static Aviary selectedAviary {  get; set; }
    }
}
