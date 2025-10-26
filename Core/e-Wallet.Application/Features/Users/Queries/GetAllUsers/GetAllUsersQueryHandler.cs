using e_Wallet.Application.DTOs;
using e_Wallet.Application.Interfaces.AutoMapper;
using e_Wallet.Application.Interfaces.UnitOfWorks;
using e_Wallet.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace e_Wallet.Application.Features.Users.Queries.GetAllUsers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllUsersQueryRequest, IList<GetAllUsersQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetAllUsersQueryResponse>> Handle(GetAllUsersQueryRequest request, CancellationToken cancellationToken)
        {
            var users = await unitOfWork.GetReadRepository<User>().GetAllAsync(include: x => x.Include(b => b.Wallets));

            var user = mapper.Map<UserDto , User>(new User());

            var map = mapper.Map<GetAllUsersQueryResponse, User>(users);


            return map;
        }
    }
}