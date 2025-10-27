using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using e_Wallet.Application.Features.Users.Queries.GetAllUsers;
using e_Wallet.Application.Features.Users.Command.CreateUser;
using e_Wallet.Application.Features.Users.Command.DeleteUser;
using e_Wallet.Application.Features.Users.Command.UpdateUser;
namespace e_Wallet.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet] 
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await mediator.Send(new GetAllUsersQueryRequest());
            throw new Exception("Bu bir test hatasıdır.");
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest request)
        {
            await mediator.Send(request); 
           
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(DeleteUserCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
    }
}
