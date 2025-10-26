using e_Wallet.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Wallet.Application.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersQueryResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}