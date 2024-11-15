using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ASP.NET_Core_Identity_Tutorial.Data
{
    public class ASPNET_Core_Identity_TutorialContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ASPNET_Core_Identity_TutorialContext (DbContextOptions<ASPNET_Core_Identity_TutorialContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_Core_Identity_Tutorial.Models.Employee> Employee { get; set; }
    }
}
