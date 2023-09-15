using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1.Entities
{
    public class Reservation
    {
        public int ID { get; set; }
        public ValueObjects.Guest Guest { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }


        public Reservation(ValueObjects.Guest guest, DateTime checkInDate, DateTime checkOutDate)
        {
            Random random = new Random();
            ID = random.Next(1000, int.MaxValue);
            Guest = guest;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

        
    }
}
