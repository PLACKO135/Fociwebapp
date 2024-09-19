using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Fociwebapp.Models;
using Microsoft.EntityFrameworkCore;

namespace Fociwebapp.Pages
{
    public class TabellaModel : PageModel
    {
        readonly Fociwebapp.Models.FociDBcontext _content;
        public TabellaModel(Fociwebapp.Models.FociDBcontext context) {_content = context;}
        public List<Meccs> Meccs { get; set; } = default;
        public async Task OnGet(){Meccs=await _content.Meccsek.ToListAsync();}
    }
}
