using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using e_Wallet.Application.Features.Users.Queries.GetAllUsers;
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
            return Ok(response);
        }
    }
}
