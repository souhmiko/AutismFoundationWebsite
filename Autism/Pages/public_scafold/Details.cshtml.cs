using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.public_scafold
{
    public class DetailsModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DetailsModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

      public Publication Publication { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Publication == null)
            {
                return NotFound();
            }

            var publication = await _context.Publication.FirstOrDefaultAsync(m => m.Id == id);
            if (publication == null)
            {
                return NotFound();
            }
            else 
            {
                Publication = publication;
            }
            return Page();
        }
    }
}
