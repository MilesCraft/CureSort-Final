using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CureSort.Models;

namespace CureSort.Data
{
    public class CureContext : DbContext
    {
        public CureContext(DbContextOptions<CureContext> options) : base(options)
        {
        }
        public DbSet<MedicalDevice> MedicalDevices { get; set; }
        public DbSet<Bin> Bins { get; set; }
        public DbSet<MedicalDeviceToAdd> MedicalDeviceToAdds { get; set; }
        public DbSet<SearchLog> SearchLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalDevice>().ToTable("MedicalDevice");
            modelBuilder.Entity<MedicalDeviceToAdd>().ToTable("MedicalDeviceToAdd");
            modelBuilder.Entity<Bin>().ToTable("Bin");
            modelBuilder.Entity<SearchLog>().ToTable("SearchLog");
        }
    }
}
