using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Application.Features.Wallets.Queries.GetAllWallets
{
    public class GetAllWalletsQueryResponse
    {
        public Guid Id { get; set; }
        public string Iban { get; set; }
        public bool IsActive { get; set; } 
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")] public decimal Balance { get; set; }


    }
}
