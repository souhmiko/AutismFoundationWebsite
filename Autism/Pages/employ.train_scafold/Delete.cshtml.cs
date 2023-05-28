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
    public class DeleteModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DeleteModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.EmployTraining == null)
            {
                return NotFound();
            }
            var employtraining = await _context.EmployTraining.FindAsync(id);

            if (employtraining != null)
            {
                EmployTraining = employtraining;
                _context.EmployTraining.Remove(EmployTraining);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
