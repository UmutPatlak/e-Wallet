using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Wallet.Domain.Entities;

namespace e_Wallet.Persistence.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            
            Transaction transaction1 = new()
            {
                Id = 1,
                SourceWalletId = 2,      
                DestinationWalletId = 1, 
                TransactionTypeId = 1,  
                Amount = 500,
                Description = "Test Transferi 1",
                IsDeleted = false
            };

            Transaction transaction2 = new()
            {
                Id = 2,
                SourceWalletId = 1,      
                DestinationWalletId = 2,
                TransactionTypeId = 2,   
                Amount = 200,
                Description = "Test Transferi 2",
                IsDeleted = false
            };
            builder.HasData(transaction1,transaction2);
        }
    }
}
