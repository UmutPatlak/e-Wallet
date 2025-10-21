using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Domain.Common
{
    public  class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate  { get; set; } =new DateTime(2025, 10, 21);
        public bool IsDeleted { get; set; }= false;
    }
}
