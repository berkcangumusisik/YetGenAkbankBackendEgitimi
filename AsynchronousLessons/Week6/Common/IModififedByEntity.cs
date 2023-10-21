using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Common
{
    public interface IModififedByEntity
    {
        public DateTime? ModifiedOn { get; set; }
    }
}
