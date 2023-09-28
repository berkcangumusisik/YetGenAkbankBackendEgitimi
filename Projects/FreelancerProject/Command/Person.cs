using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerProject.Command
{
    public class Person<T> : EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
