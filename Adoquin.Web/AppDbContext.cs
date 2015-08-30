using Microsoft.AspNet.Identity.EntityFramework;

namespace Adoquin.Web
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
            : base("DefaultConnection")
        {
        }
    }
}