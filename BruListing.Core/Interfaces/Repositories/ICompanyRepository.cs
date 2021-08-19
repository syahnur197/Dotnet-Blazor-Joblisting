using BruListing.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruListing.Core.Interfaces.Repositories
{
    public interface ICompanyRepository
    {
        Task<Company> GeByIdAsync(int companyId);

        Task<List<Company>> ListAsync();

        Task<Company> AddAsync(Company company);

        Task<Company> UpdateAsync(Company company);

        Task<Boolean> DeleteAsync(Company company);
    }
}
