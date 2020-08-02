using System;
using System.Collections.Generic;
using System.Text;
using BeeKeepr.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeeKeeprMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Hive> Hives { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Queen> Queens { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
