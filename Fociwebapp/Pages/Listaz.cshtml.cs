using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fociwebapp.Models;

namespace Fociwebapp.Pages
{
    public class ListazModel : PageModel
    {
        private readonly Fociwebapp.Models.FociDBcontext _context;

        public ListazModel(Fociwebapp.Models.FociDBcontext context)
        {
            _context = context;
        }

        public IList<Meccs> Meccs { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Meccs = await _context.Meccsek.ToListAsync();
        }
    }
}
