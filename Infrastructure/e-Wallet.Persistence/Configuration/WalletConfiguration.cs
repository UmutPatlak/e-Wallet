using e_Wallet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Persistence.Configuration
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            
            Wallet wallet1 = new()
            {
                Id = 1,
                UserId = 1,
                IsDeleted = false,  
                Balance = 1000,

                 };
            Wallet wallet2 = new()
            {
                Id = 2,
                UserId = 2,
                IsDeleted = false,
                Balance = 2000,
                
            };
            Wallet wallet3 = new()
            {
                Id = 3,
                UserId = 2,
                IsDeleted = true,
                Balance = 2000,
                

            };
            builder.HasData(wallet1, wallet2,wallet3);
        }
    }
}
