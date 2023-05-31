﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.public_scafold
{
    public class IndexModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public IndexModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        public IList<Publication> Publication { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publication != null)
            {
                Publication = await _context.Publication
                .Include(p => p.PublicationNavigation).ToListAsync();
            }
        }
    }
}
