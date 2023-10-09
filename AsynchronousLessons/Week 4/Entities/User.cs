using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string AccountName { get; set; }
        public int FollowerCount { get; set; }

        public User(string accountName, int followerCount)
        {
            Id = Guid.NewGuid();
            AccountName = accountName;
            FollowerCount = followerCount;
        }
    }
}
