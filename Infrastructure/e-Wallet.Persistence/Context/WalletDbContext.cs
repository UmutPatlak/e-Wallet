using e_Wallet.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace e_Wallet.Persistence.Context
{
    public class WalletDbContext : IdentityDbContext<User, Role, Guid>

    {
        public WalletDbContext()
        {
            
        }
        public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
    
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("AspNetUsers");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Roles");
            });

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            

        }


    }

}
