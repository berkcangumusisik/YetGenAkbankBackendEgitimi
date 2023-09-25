using MeetingApp.Abstract;
using MeetingApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp.Entities
{
    internal class Todo : Event, INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Yapılacak İş: {Title}");
        }
    }
}
