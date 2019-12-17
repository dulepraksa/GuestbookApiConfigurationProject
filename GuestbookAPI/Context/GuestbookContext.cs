using GuestbookAPI.Models.Event;
using GuestbookAPI.Models.Type;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestbookAPI.Models
{
    public class GuestbookContext : IdentityDbContext
    {
        public GuestbookContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationEvent> Events { get; set; }
        public DbSet<ApplicationType> Types { get; set; }
    }
}
