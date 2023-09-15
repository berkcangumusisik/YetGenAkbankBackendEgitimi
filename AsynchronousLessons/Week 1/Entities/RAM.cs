using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_1.Enums;
using Week_1.ValueObjects;

namespace Week_1.Entities
{
    public class RAM
    {
        public string Brand { get; set; }
        public Capacity Capacity { get; set; }

        public RAM(string brand, Capacity capacity)
        {
            Brand = brand;
            Capacity = capacity;
        }
    }
}
