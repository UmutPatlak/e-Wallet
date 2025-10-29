using e_Wallet.Application.Interfaces.AutoMapper;
using e_Wallet.Application.Interfaces.UnitOfWorks;
using e_Wallet.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace e_Wallet.Application.Features.Wallets.Command.CreateWallet
{
    public class CreateWalletCommandHandler : IRequestHandler<CreateWalletCommandRequest, Unit>
    {
        public Task<Unit> Handle(CreateWalletCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
