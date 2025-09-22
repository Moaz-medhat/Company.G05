using Company.G05.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.G05.DAL.Data.Context
{
    internal class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()  
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = CompanyG05 ; TrustedConnection = true ; TrustServerCertificate = true");
        }

        public DbSet<Department> departments { get; set; }
    }
}
