namespace Api.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            response = "Welcome to this Docker project",
            test = "/api/v1/people"
        });
    }
}