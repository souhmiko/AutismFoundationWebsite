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
    public class IndexModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public IndexModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        public IList<BlogPostMeta> BlogPostMeta { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BlogPostMeta != null)
            {
                BlogPostMeta = await _context.BlogPostMeta
                .Include(b => b.Post).ToListAsync();
            }
        }
    }
}
