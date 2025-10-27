using e_Wallet.Application.Interfaces.AutoMapper;
using e_Wallet.Application.Interfaces.UnitOfWorks;
using e_Wallet.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Application.Features.Users.Command.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork UnitOfWork;

        public UpdateUserCommandHandler(IUnitOfWork unitOfWork , IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            this.mapper = mapper;
        
        }
        public async Task Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await UnitOfWork.GetReadRepository<User>().GetAllAsync(x => x.Id == request.Id && !x.IsDeleted);
            var map = mapper.Map<User, UpdateUserCommandRequest>(request); 
            await UnitOfWork.GetWriteRepository<User>().UpdateAsync(map);
            await UnitOfWork.SaveAsync();


        }
    }
}
