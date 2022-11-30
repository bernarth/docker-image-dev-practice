namespace Api.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class PeopleController : ControllerBase
{
    private readonly ILogger<PeopleController> _logger;

    public PeopleController(ILogger<PeopleController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPeople")]
    public async Task<IActionResult> Get()
    {
        var response = new
        {
            Success = true,
            Data = "Alberth"
        };
        return Ok(response);
    }
}
