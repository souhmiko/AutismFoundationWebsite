using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.Emploment_scofold
{
    public class DetailsModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DetailsModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

      public Employment Employment { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Employment == null)
            {
                return NotFound();
            }

            var employment = await _context.Employment.FirstOrDefaultAsync(m => m.Id == id);
            if (employment == null)
            {
                return NotFound();
            }
            else 
            {
                Employment = employment;
            }
            return Page();
        }
    }
}
