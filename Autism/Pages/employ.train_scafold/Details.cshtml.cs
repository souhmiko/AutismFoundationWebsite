using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.employ.train_scafold
{
    public class DetailsModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DetailsModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

      public EmployTraining EmployTraining { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.EmployTraining == null)
            {
                return NotFound();
            }

            var employtraining = await _context.EmployTraining.FirstOrDefaultAsync(m => m.Id == id);
            if (employtraining == null)
            {
                return NotFound();
            }
            else 
            {
                EmployTraining = employtraining;
            }
            return Page();
        }
    }
}
