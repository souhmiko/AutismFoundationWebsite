using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShareProject.Models;

namespace Autism.Pages.employee.lear_scafold
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
            return Page();
        }

        [BindProperty]
        public EmployLearning EmployLearning { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.EmployLearning == null || EmployLearning == null)
            {
                return Page();
            }

            _context.EmployLearning.Add(EmployLearning);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
