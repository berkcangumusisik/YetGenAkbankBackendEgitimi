using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp.Common
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<string> Details { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }

        public Event()
        {
            Id = Guid.NewGuid();
        }
    }
}
