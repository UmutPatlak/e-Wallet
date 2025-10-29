using e_Wallet.Application.Features.Wallets.Queries.GetAllWallets;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_Wallet.Api.Controllers
{
    [Route("api/[controller]" )]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator mediator;

        public ValuesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await mediator.Send(new GetAllWalletsQueryRequest());

            return Ok(response);
        }


    }
}
