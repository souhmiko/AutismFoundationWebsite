using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShareProject.Models;

namespace Autism.Pages.post_meta_scsfold
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
        ViewData["PostId"] = new SelectList(_context.BlogPost, "Id", "Title");
            return Page();
        }

        [BindProperty]
        public BlogPostMeta BlogPostMeta { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BlogPostMeta == null || BlogPostMeta == null)
            {
                return Page();
            }

            _context.BlogPostMeta.Add(BlogPostMeta);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
