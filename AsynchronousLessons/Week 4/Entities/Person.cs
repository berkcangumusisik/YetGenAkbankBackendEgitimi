using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_4.Enums;

namespace Week_4.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }
        public Gender GenderType { get; set; }
    }
}
