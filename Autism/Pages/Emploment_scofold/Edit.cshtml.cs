using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.Emploment_scofold
{
    public class EditModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public EditModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employment Employment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Employment == null)
            {
                return NotFound();
            }

            var employment =  await _context.Employment.FirstOrDefaultAsync(m => m.Id == id);
            if (employment == null)
            {
                return NotFound();
            }
            Employment = employment;
           ViewData["EmployLearningId"] = new SelectList(_context.EmployLearning, "Id", "Name");
           ViewData["EmployTrainId"] = new SelectList(_context.EmployTraining, "Id", "Name");
           ViewData["EmployerId"] = new SelectList(_context.Employer, "Id", "Address");
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

            _context.Attach(Employment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmploymentExists(Employment.Id))
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

        private bool EmploymentExists(long id)
        {
          return (_context.Employment?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
