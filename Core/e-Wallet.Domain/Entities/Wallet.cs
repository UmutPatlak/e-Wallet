using e_Wallet.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Domain.Entities;
    public class Wallet : EntityBase
    {

        [Column(TypeName = "decimal(18, 2)")]public decimal Balance { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        [InverseProperty("SourceWallet")] public ICollection<Transaction> TransactionsAsSource { get; set; }
        [InverseProperty("DestinationWallet")]public ICollection<Transaction> TransactionsAsDestination { get; set; }
    }

