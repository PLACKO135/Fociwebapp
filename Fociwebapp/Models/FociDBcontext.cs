using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;

namespace Fociwebapp.Models
{
    public class FociDBcontext : DbContext
    {
        public FociDBcontext(DbContextOptions<FociDBcontext> options):base()
            {

            }
        public DbSet<Meccs> Meccsek { get; set; }
    }
}

