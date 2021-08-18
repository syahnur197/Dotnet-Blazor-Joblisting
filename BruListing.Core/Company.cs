using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruListing.Core
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<Job> Jobs { get; set; }
    }
}
