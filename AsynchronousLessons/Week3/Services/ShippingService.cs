using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Entities;

namespace Week3.Services
{
    public class ShippingService
    {
        public decimal CalculateTax(Product product, CountryInformation countryInformation)
        {
           return product.Price * countryInformation.TaxRate;
        }
    }
}
