namespace Api.Controllers;

using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;

[ApiController]
[Route("api/v1/[controller]")]
public class PeopleController : ControllerBase
{
    private readonly IPersonRepository personRepository;

    public PeopleController(IPersonRepository personRepository)
    {
        this.personRepository = personRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await personRepository.GetPeople());
    }

    [HttpPost]
    public async Task<IActionResult> InsertPerson([FromBody] Person person)
    {
        return person == null ? BadRequest() : 
            !ModelState.IsValid ? BadRequest(ModelState) : Ok(await personRepository.InsertPerson(person));
    }
}
