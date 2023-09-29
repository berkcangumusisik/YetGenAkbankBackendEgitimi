using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Entities
{
    public class CountryInformation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }

        public CountryInformation(string lineData)
        {
            string[] data = lineData.Split(',');
            Name = data[0];
            TaxRate = Convert.ToDecimal(data[1]);

        }
    }
}
