using e_Wallet.Application.Interfaces.Repositories;
using e_Wallet.Application.Interfaces.UnitOfWorks;
using e_Wallet.Persistence.Context;
using e_Wallet.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
        
    {
        private readonly WalletDbContext dbContext;

        public UnitOfWork(WalletDbContext dbContext)
        {
            this.dbContext= dbContext;
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        public int Save() => dbContext.SaveChanges();

        public async Task<int> SaveAsync() => await dbContext.SaveChangesAsync();

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);
        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);
    }
}
