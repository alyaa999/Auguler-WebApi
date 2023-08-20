using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace WebApplication11.Models
{
    public class TutorialDbContext : IdentityDbContext<User>
    {
        public TutorialDbContext(DbContextOptions<TutorialDbContext> Options) : base(Options)
        {
        }
        public DbSet<Student> Students { get; set; }
        

    }
}
