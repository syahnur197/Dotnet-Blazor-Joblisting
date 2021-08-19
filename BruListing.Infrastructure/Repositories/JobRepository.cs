using BruListing.Core.Entities;
using BruListing.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruListing.Infrastructure.Repositories
{
    public class JobRepository : IJobRepository
    {
        public Task<Job> AddAsync(Job entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Job entity)
        {
            throw new NotImplementedException();
        }

        public Task<Job> GeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Job>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Job> UpdateAsync(Job entity)
        {
            throw new NotImplementedException();
        }
    }
}
