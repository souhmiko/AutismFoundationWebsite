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
    public class IndexModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public IndexModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        public IList<PostComment> PostComment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PostComment != null)
            {
                PostComment = await _context.PostComment
                .Include(p => p.Parent)
                .Include(p => p.Post).ToListAsync();
            }
        }
    }
}
