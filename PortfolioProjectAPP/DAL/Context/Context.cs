using Microsoft.EntityFrameworkCore;
using PortfolioProjectAPP.DAL.Entities;

namespace PortfolioProjectAPP.DAL.Context
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4027H88\\SQLEXPRESS;initial catalog =NewPortfolioDB;integrated security = true ; TrustServerCertificate=true");
        }

        public DbSet<Works> Works { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
