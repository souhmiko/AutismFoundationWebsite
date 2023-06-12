using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [BindProperty(SupportsGet =true)]
        public string ?SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet =true)]
        public string? CategoryGenre { get; set; }

        public async Task OnGetAsync()
        {
            var Categories = from m in _context.Category
                           select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Categories = Categories.Where(s => s.Title.Contains(SearchString));
            }

            Category = await Categories.ToListAsync();
        }
    }
}
