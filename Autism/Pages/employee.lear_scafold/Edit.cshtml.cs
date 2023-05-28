using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.employee.lear_scafold
{
    public class EditModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public EditModel(ShareProject.Models.DatabaseAutismContext context)
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

            var employlearning =  await _context.EmployLearning.FirstOrDefaultAsync(m => m.Id == id);
            if (employlearning == null)
            {
                return NotFound();
            }
            EmployLearning = employlearning;
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

            _context.Attach(EmployLearning).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployLearningExists(EmployLearning.Id))
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

        private bool EmployLearningExists(long id)
        {
          return (_context.EmployLearning?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
