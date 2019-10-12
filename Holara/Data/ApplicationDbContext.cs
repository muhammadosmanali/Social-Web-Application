using System;
using System.Collections.Generic;
using System.Text;
using Holara.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Holara.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Friends> Friends { get; set; }

        public DbSet<HidePost> HidePosts { get; set; }
    }
}
