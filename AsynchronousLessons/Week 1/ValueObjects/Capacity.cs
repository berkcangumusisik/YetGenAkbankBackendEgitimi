using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_1.Enums;

namespace Week_1.ValueObjects
{
    public class Capacity
    {
        public int Size { get; set; }
        public CapacitySizeType SizeType { get; set; }

        public Capacity(int size, CapacitySizeType sizeType)
        {
            Size = size;
            SizeType = sizeType;
        }
    }
}
