using MediatR;

namespace e_Wallet.Application.Features.Wallets.Command.DeleteWallet
{
    public class DeleteWalletCommandRequest : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
