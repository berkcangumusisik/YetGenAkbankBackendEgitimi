using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerProject.Command
{
    public class EntityBase<T>
    {
        public T Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
