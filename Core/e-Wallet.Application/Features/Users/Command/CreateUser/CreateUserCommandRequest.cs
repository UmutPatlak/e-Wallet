using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Application.Features.Users.Command.CreateUser
{
    public class CreateUserCommandRequest : IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }



    }
}
