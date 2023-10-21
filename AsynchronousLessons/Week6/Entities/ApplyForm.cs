using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Common;

namespace Week6.Entities
{
    public class ApplyForm: EntityBase<Guid>
    {
        public string ResumeUrl { get; set; }
        public string CoverLetter { get; set; }

    }
}
