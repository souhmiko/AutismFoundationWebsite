using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.NewFolder
{
    public class DeleteModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DeleteModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        [BindProperty]
      public BlogPost BlogPost { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.BlogPost == null)
            {
                return NotFound();
            }

            var blogpost = await _context.BlogPost.FirstOrDefaultAsync(m => m.Id == id);

            if (blogpost == null)
            {
                return NotFound();
            }
            else 
            {
                BlogPost = blogpost;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.BlogPost == null)
            {
                return NotFound();
            }
            var blogpost = await _context.BlogPost.FindAsync(id);

            if (blogpost != null)
            {
                BlogPost = blogpost;
                _context.BlogPost.Remove(BlogPost);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
