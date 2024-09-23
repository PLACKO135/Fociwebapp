using Fociwebapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fociwebapp.Pages
{
    public class AdatokFeltolteseFájlbólModel : PageModel
    {
        private readonly IWebHostEnvironment _env;
        private readonly FociDBcontext _context;
        public AdatokFeltolteseFájlbólModel(IWebHostEnvironment webHostEnvironment, FociDBcontext context)
        {
            _env = webHostEnvironment;
            _context = context;
        }

        [BindProperty]
        public IFormFile? Feltoltes { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Feltoltes != null || Feltoltes.Length == 0)
            {
                ModelState.AddModelError("Feltoltes", "Adj meg egy file-t");
                return Page();
            }
          
                var UpLoadDirPath = Path.Combine(_env.ContentRootPath, "uploads");
                var UploadFilePath = Path.Combine(UpLoadDirPath, Feltoltes.FileName);

                using (var filestream = new FileStream(UploadFilePath, FileMode.Create))
                {
                    await Feltoltes.CopyToAsync(filestream);
                }

                StreamReader sr = new(UploadFilePath);
                sr.ReadLine();
                while (sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var elemek = line.Split(' ');
                    Meccs ujmeccs = new Meccs();
                    ujmeccs.Fordulo = int.Parse(elemek[0]);
                    ujmeccs.HazaiVeg = int.Parse(elemek[1]);
                    ujmeccs.VendegVeg = int.Parse(elemek[2]);
                    ujmeccs.HazaiFel = int.Parse(elemek[3]);
                    ujmeccs.VendegFel = int.Parse(elemek[4]);
                    ujmeccs.HazaiNev = elemek[5];
                    ujmeccs.VendegNev = elemek[5];

                    _context.Meccsek.Add(ujmeccs);
                }
                sr.Close();
                _context.SaveChanges();

                // System.IO.File.Delete(UploadFilePath);
                return Page();
            
        }
    }
}
