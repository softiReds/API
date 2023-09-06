using APIGestiónUsuarios.Context;
using APIGestiónUsuarios.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIGestiónUsuarios.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly GestionUsuariosContext _dbContext;
    private readonly IHomeService _service;
    public HomeController(IHomeService service) => _service = service;

    [HttpGet]
    public IActionResult CreateDataBase()
    {
        _service.CreateDatabase(_dbContext);
        return Ok();
    }
}