using Microsoft.AspNetCore.Mvc;
using PassIn.Application.UseCases.Events.Register;
using PassIn.Communication.Requests;

namespace PassIn.Api.Controllers;
[Route("api/[controller]")]
[ApiController]

public class EventsController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestEventJson request)
    {
        try
        {
            var useCase = new RegisterEventUseCase();

            useCase.Execute(request);

            return Created();

        }catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
