using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.post_meta_scsfold
{
    public class DeleteModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DeleteModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        [BindProperty]
      public BlogPostMeta BlogPostMeta { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.BlogPostMeta == null)
            {
                return NotFound();
            }

            var blogpostmeta = await _context.BlogPostMeta.FirstOrDefaultAsync(m => m.Id == id);

            if (blogpostmeta == null)
            {
                return NotFound();
            }
            else 
            {
                BlogPostMeta = blogpostmeta;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.BlogPostMeta == null)
            {
                return NotFound();
            }
            var blogpostmeta = await _context.BlogPostMeta.FindAsync(id);

            if (blogpostmeta != null)
            {
                BlogPostMeta = blogpostmeta;
                _context.BlogPostMeta.Remove(BlogPostMeta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
