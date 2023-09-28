using FreelancerProject.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerProject.Entities
{
    public class Freelancer : Person<Guid>
    {
        public string WorkExperience { get; set; }
        public List<Review> Review { get; set; }

        public void SetValuesCSV(string csvLine)
        {
            string[] data = csvLine.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]);
            FirstName = data[2];
            LastName = data[3];
            WorkExperience = data[4];
        }
    }

    
}
