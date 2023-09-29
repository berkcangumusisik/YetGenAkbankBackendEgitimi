using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Abstract;
using Week3.Common;
using Week3.Enums;

namespace Week3.Entities
{
    public class User : EntityBase<Guid>
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MemberShipType MemberShip { get; set; }
        public DateTime Birthday { get; set; }
        
    }
}
