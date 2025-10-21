using e_Wallet.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Domain.Entities;
    public class TransactionType : EntityBase
    {
        public string Name { get; set; } 
        public string Description { get; set; }
 
    }

