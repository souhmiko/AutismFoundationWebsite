using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.NewFolder
{
    public class EditModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public EditModel(ShareProject.Models.DatabaseAutismContext context)
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

            var blogpost =  await _context.BlogPost.FirstOrDefaultAsync(m => m.Id == id);
            if (blogpost == null)
            {
                return NotFound();
            }
            BlogPost = blogpost;
           ViewData["AuthorId"] = new SelectList(_context.BlogUser, "Id", "Email");
           ViewData["ParentId"] = new SelectList(_context.BlogPost, "Id", "Title");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BlogPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlogPostExists(BlogPost.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BlogPostExists(long id)
        {
          return (_context.BlogPost?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
