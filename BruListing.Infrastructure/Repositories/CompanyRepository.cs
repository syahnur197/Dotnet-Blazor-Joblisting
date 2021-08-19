using BruListing.Core.Entities;
using BruListing.Core.Interfaces.Repositories;
using BruListing.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruListing.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {

        private readonly AppDbContext _context;

        public CompanyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Company> AddAsync(Company company)
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();

            return company;
        }

        public Task<bool> DeleteAsync(Company company)
        {
            throw new NotImplementedException();
        }

        public async Task<Company> GeByIdAsync(int companyId)
        {
            var company = await _context.Companies.FindAsync(companyId);

            return company;
        }

        public async Task<List<Company>> ListAsync()
        {
            return await _context.Companies
                .ToListAsync();
        }

        public Task<Company> UpdateAsync(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
