using APIGestiónUsuarios.Context;
using Microsoft.AspNetCore.Mvc;

namespace APIGestiónUsuarios.Controllers;

[ApiController]
[Route("home")]
public class HomeController : ControllerBase
{
    private readonly GestionUsuariosContext _dbContext;

    public HomeController(GestionUsuariosContext dbContext) => _dbContext = dbContext;

    [HttpGet]
    public IActionResult CreateDataBase()
    {
        _dbContext.Database.EnsureCreated();
        return Ok();
    }
}