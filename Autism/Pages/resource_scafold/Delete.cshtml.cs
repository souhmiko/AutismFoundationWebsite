using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.NewFolder1
{
    public class DeleteModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DeleteModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Resource Resource { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Resource == null)
            {
                return NotFound();
            }

            var resource = await _context.Resource.FirstOrDefaultAsync(m => m.Id == id);

            if (resource == null)
            {
                return NotFound();
            }
            else 
            {
                Resource = resource;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.Resource == null)
            {
                return NotFound();
            }
            var resource = await _context.Resource.FindAsync(id);

            if (resource != null)
            {
                Resource = resource;
                _context.Resource.Remove(Resource);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
