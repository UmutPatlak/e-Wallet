using e_Wallet.Application.Features.Wallets.Command.CreateWallet;
using FluentValidation;

namespace e_Wallet.Application.Features.Wallets.Command.CreateWallet
{
    public class CreateWalletCommandValidator : AbstractValidator<CreateWalletCommandRequest>
    {
        public CreateWalletCommandValidator()
        {
            
        }
    }
}
