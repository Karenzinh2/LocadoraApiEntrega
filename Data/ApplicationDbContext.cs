using Microsoft.EntityFrameworkCore;

namespace LocadoraApi.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
       
    }
}
