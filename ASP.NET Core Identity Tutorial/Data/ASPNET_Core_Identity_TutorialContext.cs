using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_Identity_Tutorial.Models;

namespace ASP.NET_Core_Identity_Tutorial.Data
{
    public class ASPNET_Core_Identity_TutorialContext : DbContext
    {
        public ASPNET_Core_Identity_TutorialContext (DbContextOptions<ASPNET_Core_Identity_TutorialContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_Core_Identity_Tutorial.Models.Employee> Employee { get; set; }
    }
}
