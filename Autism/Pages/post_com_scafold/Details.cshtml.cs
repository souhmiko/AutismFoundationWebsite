using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.post_com_scafold
{
    public class DetailsModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DetailsModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

      public PostComment PostComment { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.PostComment == null)
            {
                return NotFound();
            }

            var postcomment = await _context.PostComment.FirstOrDefaultAsync(m => m.Id == id);
            if (postcomment == null)
            {
                return NotFound();
            }
            else 
            {
                PostComment = postcomment;
            }
            return Page();
        }
    }
}
