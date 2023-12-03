using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMVC.Models;

namespace WebMVC.Data
{
    public class WebMVCContext : DbContext
    {
        public WebMVCContext (DbContextOptions<WebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebMVC.Models.Category> Category { get; set; } = default!;
        public DbSet<WebMVC.Models.Product> Product { get; set; } = default!;
        public DbSet<WebMVC.Models.User> User { get; set; } = default!;
    }
}
