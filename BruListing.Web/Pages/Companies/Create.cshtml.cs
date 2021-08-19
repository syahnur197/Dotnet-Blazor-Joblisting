using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BruListing.Core.Entities;
using BruListing.Infrastructure.Data;
using BruListing.Core.Interfaces.Repositories;
using BruListing.Infrastructure.Repositories;

namespace BruListing.Web.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly ICompanyRepository _repository;

        public CreateModel(ICompanyRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var createdCompany = await _repository.AddAsync(Company);

            return RedirectToPage("./Index");
        }
    }
}
