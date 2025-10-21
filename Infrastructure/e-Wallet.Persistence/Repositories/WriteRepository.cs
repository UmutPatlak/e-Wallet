using e_Wallet.Application.Interfaces.Repositories;
using e_Wallet.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntityBase, new()

    {
        private readonly DbContext dbcontext;

        public WriteRepository(DbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        private DbSet<T> Table => dbcontext.Set<T>();

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity); 


        }

        public async Task AddRangeAsync(IList<T> entities)
        {
            await Table.AddRangeAsync(entities);


        }

        public async Task HardDeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));


        }

        

        public async Task<T> UpdateAsync(T entity)
        {
                await Task.Run(() => Table.Update(entity));
            return entity;


        }
    }
}
