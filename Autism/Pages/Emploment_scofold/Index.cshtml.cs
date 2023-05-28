using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.Emploment_scofold
{
    public class IndexModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public IndexModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        public IList<Employment> Employment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employment != null)
            {
                Employment = await _context.Employment
                .Include(e => e.EmployLearning)
                .Include(e => e.EmployTrain)
                .Include(e => e.Employer).ToListAsync();
            }
        }
    }
}
