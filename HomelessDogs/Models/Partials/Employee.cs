using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomelessDogs.Models
{
    public partial class Employee
    {
        public string FullNameAuth
        {
            get
            {
                return Id_post == 1 ? $"Вы входите как {Surname} {Name.Remove(1)}.{Patronymic.Remove(1)}. - администратор." : $"Вы входите как {Surname} {Name.Remove(1)}.{Patronymic.Remove(1)}. - ветеринар.";
            }
        }

        public string AdminText
        {
            get
            {
                return $"{App.employee.Surname} {App.employee.Name.Remove(1)}.{App.employee.Patronymic.Remove(1)}";
            }
        }

        public string VetText
        {
            get
            {
                return $"{App.employee.Surname} {App.employee.Name.Remove(1)}.{App.employee.Patronymic.Remove(1)}";
            }
        }
    }
}
