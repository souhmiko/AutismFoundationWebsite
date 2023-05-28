using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.resourceAttachment_scafold
{
    public class DeleteModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DeleteModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ResourceAttachment ResourceAttachment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.ResourceAttachment == null)
            {
                return NotFound();
            }

            var resourceattachment = await _context.ResourceAttachment.FirstOrDefaultAsync(m => m.Id == id);

            if (resourceattachment == null)
            {
                return NotFound();
            }
            else 
            {
                ResourceAttachment = resourceattachment;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.ResourceAttachment == null)
            {
                return NotFound();
            }
            var resourceattachment = await _context.ResourceAttachment.FindAsync(id);

            if (resourceattachment != null)
            {
                ResourceAttachment = resourceattachment;
                _context.ResourceAttachment.Remove(ResourceAttachment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
