using Microsoft.AspNet.Identity.EntityFramework;

namespace Adoquin.Web
{
    public class AppUser : IdentityUser
    {
        public string Country { get; set; }

        public int Age { get; set; }
    }
}