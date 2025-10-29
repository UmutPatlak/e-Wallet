using e_Wallet.Domain.Entities; 
using MediatR; 

namespace e_Wallet.Application.Features.Wallets.Command.CreateWallet
{
    public class CreateWalletCommandRequest : IRequest<Unit>
    {
        public string Iban { get; set; }
        public bool IsActive { get; set; }
        public decimal Balance { get; set; }

        
    }
}