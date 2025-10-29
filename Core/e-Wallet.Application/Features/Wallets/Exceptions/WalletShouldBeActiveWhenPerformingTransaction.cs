using System;

namespace e_Wallet.Application.Features.Wallets.Exceptions
{
    // 1. "Exception" son ekini ekleyin ve System.Exception'dan miras alın
    public class WalletShouldBeActiveWhenPerformingTransactionException : Exception
    {
        // 2. Standart yapıcı metotları (constructors) ekleyin
        public WalletShouldBeActiveWhenPerformingTransactionException()
            : base("İşlem yapmak için cüzdan aktif olmalıdır.")
        {
        }

        public WalletShouldBeActiveWhenPerformingTransactionException(string message)
            : base(message)
        {
        }

        public WalletShouldBeActiveWhenPerformingTransactionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}