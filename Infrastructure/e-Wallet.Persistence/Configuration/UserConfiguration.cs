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
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            User user1 = new()
            { Id = 1 , Name = "John", Surname = "Doe"  , IsDeleted = false
            };
            User user2 = new()
            {
                Id = 2,
                Name = "Jane",
                Surname = "Smith",
                IsDeleted = false
            };
            builder.HasData(user1,user2);
        }
    }
}
