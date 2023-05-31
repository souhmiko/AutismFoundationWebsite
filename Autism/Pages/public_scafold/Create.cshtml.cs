using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShareProject.Models;

namespace Autism.Pages.public_scafold
{
    public class CreateModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public CreateModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PublicationId"] = new SelectList(_context.Resource, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Publication Publication { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publication == null || Publication == null)
            {
                return Page();
            }

            _context.Publication.Add(Publication);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
