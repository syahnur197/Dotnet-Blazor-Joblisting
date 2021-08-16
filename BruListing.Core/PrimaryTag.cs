using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruListing.Core
{
    class PrimaryTag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Job> Jobs { get; set; }
    }
}
