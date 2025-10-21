using e_Wallet.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Domain.Entities;
    public class Transaction : EntityBase
    {
        public Wallet SourceWallet { get; set; }
        public Wallet DestinationWallet { get; set; }
        public int? SourceWalletId { get; set; }
        public int? DestinationWalletId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]public decimal Amount { get; set; }
        public string Description { get; set; }
        public int TransactionTypeId { get; set; }
        public TransactionType TransactionType { get; set; }
    }

