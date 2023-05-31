using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.employee.lear_scafold
{
    public class DeleteModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public DeleteModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        [BindProperty]
      public EmployLearning EmployLearning { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.EmployLearning == null)
            {
                return NotFound();
            }

            var employlearning = await _context.EmployLearning.FirstOrDefaultAsync(m => m.Id == id);

            if (employlearning == null)
            {
                return NotFound();
            }
            else 
            {
                EmployLearning = employlearning;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.EmployLearning == null)
            {
                return NotFound();
            }
            var employlearning = await _context.EmployLearning.FindAsync(id);

            if (employlearning != null)
            {
                EmployLearning = employlearning;
                _context.EmployLearning.Remove(EmployLearning);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
