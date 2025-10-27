using e_Wallet.Application.Interfaces.UnitOfWorks;
using e_Wallet.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Application.Features.Users.Command.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteUserCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
        {

            var userList = await unitOfWork.GetReadRepository<User>()
                    .GetAllAsync(x => x.Id == request.Id && !x.IsDeleted);

            var user = userList.FirstOrDefault();

            if (user is null)
            {
                throw new Exception("Silinecek kullanıcı bulunamadı.");
            }

            user.IsDeleted = true;

           await unitOfWork.GetWriteRepository<User>().UpdateAsync(user);
            await unitOfWork.SaveAsync();
        }
    }
}
