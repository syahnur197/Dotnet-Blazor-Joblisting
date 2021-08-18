using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruListing.Core
{
    public class Job
    {
        public int Id { get; set; }

        public Company Company { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal MinimumCompensation { get; set; }

        public decimal MaximumCompensation { get; set; }

        public string Location { get; set; }

        public PrimaryTag PrimaryTag { get; set; }

        [NotMapped]
        public ICollection<Tag> Tags { get; set; }
    }
}
