using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BruListing.Core.Entities;
using BruListing.Infrastructure.Data;

namespace BruListing.Web.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly BruListing.Infrastructure.Data.AppDbContext _context;

        public DetailsModel(BruListing.Infrastructure.Data.AppDbContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Companies.FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
