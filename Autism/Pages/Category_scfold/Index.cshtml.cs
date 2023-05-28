using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.Category_scfold
{
    public class IndexModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public IndexModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category
                .Include(c => c.Parent).ToListAsync();
            }
        }
    }
}
