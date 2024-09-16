using Fociwebapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fociwebapp.Pages
{
    public class UjMeccsFelveteleModel : PageModel
    {
        [BindProperty]
        public Meccs UjMeccs { get; set; }

        public List<Meccs> MeccsekListaja { get; set; }=new List<Meccs>();  

        private readonly FociDBcontext _db;

        public UjMeccsFelveteleModel(FociDBcontext db)
        {
            _db=db;
        }

        public void OnGet()
        {
            MeccsekListaja=_db.Meccsek.ToList();
        }
        public IActionResult OnPost() 
        { 
            _db.Meccsek.Add(UjMeccs);
            _db.SaveChanges();
            return Page();
        }
    }
}
