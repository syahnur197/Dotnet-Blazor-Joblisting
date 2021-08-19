using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BruListing.Core.Entities;
using BruListing.Infrastructure.Data;
using BruListing.Core.Interfaces.Repositories;

namespace BruListing.Web.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly ICompanyRepository _repository;

        public IndexModel(ICompanyRepository repository)
        {
            _repository = repository;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _repository.ListAsync();
        }
    }
}
