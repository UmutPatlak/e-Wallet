using e_Wallet.Application.Interfaces.UnitOfWorks;
using e_Wallet.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Application.Features.Users.Command.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateUserCommandHandler( IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            User user = new(request.Name,request.Surname);
            await unitOfWork.GetWriteRepository<User>().AddAsync(user);
            await unitOfWork.SaveAsync();
        }
    }
}
