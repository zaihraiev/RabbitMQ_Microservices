using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().Property(p => p.AccountBalance).HasColumnType("decimal(18,4)");
        }
    }
}
