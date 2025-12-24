using LawOfficeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfficeManagement.Data
{
    public class LawOfficeContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<CaseFile> CaseFiles { get; set; }
        public DbSet<WorkLog> WorkLogs { get; set; }
        public DbSet<Document> Documents { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=LawOfficeDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkLog>()
                .HasOne(w => w.CaseFile)
                .WithMany(c => c.WorkLogs)
                .HasForeignKey(w => w.CaseFileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.CaseFile)
                .WithMany(c => c.Documents)
                .HasForeignKey(d => d.CaseFileId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
