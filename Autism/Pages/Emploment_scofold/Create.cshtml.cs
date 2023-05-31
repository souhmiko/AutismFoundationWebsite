using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShareProject.Models;

namespace Autism.Pages.Emploment_scofold
{
    public class CreateModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public CreateModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EmployLearningId"] = new SelectList(_context.EmployLearning, "Id", "Name");
        ViewData["EmployTrainId"] = new SelectList(_context.EmployTraining, "Id", "Name");
        ViewData["EmployerId"] = new SelectList(_context.Employer, "Id", "Address");
            return Page();
        }

        [BindProperty]
        public Employment Employment { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Employment == null || Employment == null)
            {
                return Page();
            }

            _context.Employment.Add(Employment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
