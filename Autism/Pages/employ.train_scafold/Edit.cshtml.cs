using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.employ.train_scafold
{
    public class EditModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public EditModel(ShareProject.Models.DatabaseAutismContext context)
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

            var employtraining =  await _context.EmployTraining.FirstOrDefaultAsync(m => m.Id == id);
            if (employtraining == null)
            {
                return NotFound();
            }
            EmployTraining = employtraining;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EmployTraining).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployTrainingExists(EmployTraining.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployTrainingExists(long id)
        {
          return (_context.EmployTraining?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
