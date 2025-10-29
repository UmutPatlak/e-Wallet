using e_Wallet.Application.Features.Wallets.Command.DeleteWallet; 
using e_Wallet.Application.Interfaces.UnitOfWorks;
using e_Wallet.Domain.Entities;
using MediatR;

namespace e_Wallet.Application.Features.Wallets.Command.DeleteWallet
{
    public class DeleteWalletCommandHandler : IRequestHandler<DeleteWalletCommandRequest, Unit>
    {
        public Task<Unit> Handle(DeleteWalletCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

