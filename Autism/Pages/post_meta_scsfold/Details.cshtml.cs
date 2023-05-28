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
    public class DetailsModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DetailsModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

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
    }
}
