using Application.Categories.Commands.CreateCommand;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class CategoryController : ApiController
{
    public CategoryController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryCommand command)
    {
        var result = await _mediator.Send(command);

        if (!result.IsSuccess)
        {
            return BadRequest(result);
        }

        return CreatedAtAction(nameof(Index), result.Value.Id, result.Value);
    }


}
