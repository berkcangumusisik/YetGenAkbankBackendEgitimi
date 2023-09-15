using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1.ValueObjects
{
    public class Guest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdNumber { get; set; }
        public string PhoneNumber { get; set; }

        public Guest(string name, string surname, string ıdNumber, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            IdNumber = ıdNumber;
            PhoneNumber = phoneNumber;
        }
    }
}
