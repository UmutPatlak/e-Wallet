using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Application.Features.Wallets.Queries.GetAllWallets
{
    public class GetAllWalletsQueryRequest : IRequest<IList<GetAllWalletsQueryResponse>>     {
    }
}
