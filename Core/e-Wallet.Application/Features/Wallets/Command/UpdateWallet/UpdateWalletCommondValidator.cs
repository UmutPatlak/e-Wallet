using e_Wallet.Application.Features.Wallets.Command.UpdateWallet;
using FluentValidation;

namespace e_Wallet.Application.Features.Wallets.Command.UpdateWallet
{
    public class UpdateWalletCommandValidator : AbstractValidator<UpdateWalletCommandRequest>
    {
        public UpdateWalletCommandValidator() { }
        
    }
}
