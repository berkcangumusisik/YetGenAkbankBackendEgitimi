using FreelancerProject.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerProject.Entities
{
    public class Review : EntityBase<Guid>
    {
        public string Text { get; set; }
        public int Points { get; set; }
    }
}
