using APIGestiónUsuarios.Models;
using APIGestiónUsuarios.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIGestiónUsuarios.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _service;

    public UsuarioController(IUsuarioService service) => _service = service;

    [HttpGet]
    public IActionResult Post([FromBody] Usuario usuario)
    {
        _service.Post(usuario);

        return Ok();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.Get());
    }

    [HttpPut("{id}")]
    public IActionResult Put([FromBody] Usuario usuario, Guid id)
    {
        _service.Put(usuario, id);

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _service.Delete(id);

        return Ok();
    }
}