using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShareProject.Models;

namespace Autism.Pages.NewFolder
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
        ViewData["AuthorId"] = new SelectList(_context.BlogUser, "Id", "Email");
        ViewData["ParentId"] = new SelectList(_context.BlogPost, "Id", "Title");
            return Page();
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BlogPost == null || BlogPost == null)
            {
                return Page();
            }

            _context.BlogPost.Add(BlogPost);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
