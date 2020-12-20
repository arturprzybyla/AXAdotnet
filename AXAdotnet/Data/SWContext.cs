using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AXAdotnet.Data
{
    public class SWContext : DbContext
    {
        public SWContext(DbContextOptions<SWContext> options)
           : base(options)
        {
        }

        public DbSet<Rate> Rates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rate>().ToTable("Rate")
                .Property(f => f.ID)
            .ValueGeneratedOnAdd();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=SWdb",
                    providerOptions =>
                    {
                        providerOptions.EnableRetryOnFailure();
                    });
        }
    }
}
