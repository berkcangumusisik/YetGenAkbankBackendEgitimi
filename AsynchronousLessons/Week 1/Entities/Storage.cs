using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_1.Enums;
using Week_1.ValueObjects;

namespace Week_1.Entities
{
    public class Storage
    {
        
        public string Brand { get; set; }
        public Capacity Capacity { get; set; }

        public Storage(string brand, Capacity capacity)
        {
            Brand = brand;
            Capacity = capacity;
        }

    }
}
