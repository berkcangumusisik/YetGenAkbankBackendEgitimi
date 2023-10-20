using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Domain.Entities
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

    }
}


/**
 * WEB API
 * Web Api yazmanın avantajı herhangi bir platformdan istek atılabilmesidir.
 * Kullanıcılarımızın isteklerini karşılayabilmek için bir web api yazmamız gerekiyor.
 * Web Api ile sadece backend tarafı yazılmış oluyor. Frontend tarafı yazılmamış oluyor. Web veya mobilden istek atılarak merkezi bir noktadan veri alışverişi yapılabilir.
 * 
 */