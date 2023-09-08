using Application.Transactions.Commands.CreateTransaction;

namespace WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class TransactionController : ApiController
{
    public TransactionController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok();
    }


    [HttpPost]
    public async Task<IActionResult> Create(CreateTransactionCommand command)
    {
        var result = await _mediator.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return CreatedAtAction(nameof(Index), result.Value.Id, result.Value);
    }
}
