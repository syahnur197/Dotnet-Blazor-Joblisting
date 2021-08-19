using BruListing.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruListing.Core.Interfaces.Repositories
{
    public interface IJobRepository
    {
        Task<Job> GeByIdAsync(int jobId);

        Task<List<Job>> ListAsync();

        Task<Job> AddAsync(Job job);

        Task<Job> UpdateAsync(Job job);

        Task<Boolean> DeleteAsync(Job job);
    }
}
