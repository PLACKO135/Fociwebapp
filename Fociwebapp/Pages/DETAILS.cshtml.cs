﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fociwebapp.Models;

namespace Fociwebapp.Pages
{
    public class DETAILSModel : PageModel
    {
        private readonly Fociwebapp.Models.FociDBcontext _context;

        public DETAILSModel(Fociwebapp.Models.FociDBcontext context)
        {
            _context = context;
        }

        public Meccs Meccs { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meccs = await _context.Meccsek.FirstOrDefaultAsync(m => m.Id == id);
            if (meccs == null)
            {
                return NotFound();
            }
            else
            {
                Meccs = meccs;
            }
            return Page();
        }
    }
}
