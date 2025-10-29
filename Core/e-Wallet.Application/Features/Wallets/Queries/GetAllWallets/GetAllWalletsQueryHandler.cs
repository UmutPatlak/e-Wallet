using e_Wallet.Application.DTOs;
using e_Wallet.Application.Interfaces.AutoMapper;
using e_Wallet.Application.Interfaces.UnitOfWorks;
using e_Wallet.Domain.Entities;
using MediatR;
using System.Collections.Generic;   
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 
namespace e_Wallet.Application.Features.Wallets.Queries.GetAllWallets
{
    public class GetAllWalletsQueryHandler : IRequestHandler<GetAllWalletsQueryRequest, IList<GetAllWalletsQueryResponse>>
    {
        public Task<IList<GetAllWalletsQueryResponse>> Handle(GetAllWalletsQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}