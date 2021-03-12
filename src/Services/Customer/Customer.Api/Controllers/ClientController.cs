
using Customer.Service.EventHandlers.Commands;
using Customer.Service.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Api.Controllers
{
    [ApiController]
    [Route("v1/clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientQueryService _clientQueryService;
        private readonly ILogger<ClientController> _logger;
        private readonly IMediator _mediator;

        public ClientController(
            ILogger<ClientController> logger,
            IMediator mediator,
            IClientQueryService clientQuerService)
        {
            _logger = logger;
            _mediator = mediator;
            _clientQueryService = clientQuerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int page = 1, int pageSize = 10) => Ok(await _clientQueryService.GetAllAsync(page, pageSize));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _clientQueryService.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Create(ClientCreateCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }
    }
}