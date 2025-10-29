using e_Wallet.Application.Features.Wallets.Command.DeleteWallet;
using FluentValidation;

namespace e_Wallet.Application.Features.Wallets.Command.DeleteWallet
{
    public class DeleteWalletCommandValidator : AbstractValidator<DeleteWalletCommandRequest>
    {
        public DeleteWalletCommandValidator()
        {

        }
    }
}
