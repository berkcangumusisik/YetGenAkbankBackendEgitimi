using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Common;
using Week6.Enums;

namespace Week6.Entities
{
    public class JobPost : EntityBase<Guid>
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public WorkMode WorkMode { get; set; }

        public JobPost()
        {
            Id = Guid.NewGuid();
        }
    }
}
