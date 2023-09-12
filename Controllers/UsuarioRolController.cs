using APIGestiónUsuarios.Models;
using APIGestiónUsuarios.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIGestiónUsuarios.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioRolController : ControllerBase
{
    private readonly IUsuarioRolService _service;

    public UsuarioRolController(IUsuarioRolService service) => _service = service;

    [HttpPost]
    public IActionResult Post([FromBody] UsuarioRol usuarioRol)
    {
        _service.Post(usuarioRol);

        return Ok();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.Get());
    }

    [HttpPut("{id}")]
    public IActionResult Put([FromBody] UsuarioRol usuarioRol, [FromRoute] Guid id)
    {
        _service.Put(usuarioRol, id);

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        _service.Delete(id);

        return Ok();
    }
}