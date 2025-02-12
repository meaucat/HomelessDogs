using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomelessDogs.Models
{
    public partial class Dog
    {
        public string IsGiveText
        {
            get
            {
                return IsGive == false ? "Ищет хозяина" : "Хозяин нашелся";
            }
        }

        public string AgeText
        {
            get
            {
                if (Age % 100 >= 11 && Age % 100 <= 14)
                {
                    return $"{Age} лет";
                }
                else if (Age % 10 == 1)
                {
                    return $"{Age} год";
                }
                else if (Age % 10 >= 2 && Age % 10 <= 4)
                {
                    return $"{Age} года";
                }
                else
                {
                    return $"{Age} лет";
                }
            }
        }
    }
}
