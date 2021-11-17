using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_Identity_Tutorial.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Core_Identity_Tutorial.Data
{
    public class ASPNET_Core_Identity_TutorialContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ASPNET_Core_Identity_TutorialContext (DbContextOptions<ASPNET_Core_Identity_TutorialContext> options)
            : base(options)
        {
        }

        //dbset User
        //dbset Role
        //dbset etc...

        public DbSet<ASP.NET_Core_Identity_Tutorial.Models.Employee> Employee { get; set; }
    }
}
