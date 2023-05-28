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
    public class DeleteModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DeleteModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.Employment == null)
            {
                return NotFound();
            }
            var employment = await _context.Employment.FindAsync(id);

            if (employment != null)
            {
                Employment = employment;
                _context.Employment.Remove(Employment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
