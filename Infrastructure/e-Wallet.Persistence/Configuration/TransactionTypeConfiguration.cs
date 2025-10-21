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
    public class TransactionTypeConfiguration : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder)
        {

            TransactionType transactionType1 = new()
            {
                Id = 1,
                Name = "Deposit",
                IsDeleted = false,
                Description = "Money Deposit"

            };
            TransactionType transactionType2 = new()
            {
                Id = 2,
                Name = "Withdrawal",
                IsDeleted = false,
                Description = "Money Withdrawal"
            };
            builder.HasData(transactionType1, transactionType2);

        }
    }
}
