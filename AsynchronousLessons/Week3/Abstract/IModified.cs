using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Entities;

namespace Week3.Abstract
{
    public interface IModified
    {
        public DateTime ModifiedOn { get; set; }
        public User ModifiedBy { get; set; }
    }
}
