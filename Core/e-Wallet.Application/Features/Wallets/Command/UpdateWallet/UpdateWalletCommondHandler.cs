using e_Wallet.Application.Features.Wallets.Command.UpdateWallet; 
using e_Wallet.Application.Interfaces.AutoMapper;
using e_Wallet.Application.Interfaces.UnitOfWorks;
using e_Wallet.Domain.Entities;
using MediatR;
using System; 
using System.Threading;
using System.Threading.Tasks;

namespace e_Wallet.Application.Features.Wallets.Command.UpdateWallet
{
    
    public class UpdateWalletCommandHandler : IRequestHandler<UpdateWalletCommandRequest, Unit>
    {
        public Task<Unit> Handle(UpdateWalletCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

