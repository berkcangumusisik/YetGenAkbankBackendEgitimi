using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    public class Square : Shape
    {
        public decimal Base { get; set; }
        public decimal Height { get; set; }

        public Square()
        {
            Type = "Üçgen";
        }


        public override decimal GetArea()
        {
            return Base * Height / 2;
        }
    }
}
