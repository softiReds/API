using APIGestiónUsuarios.Models;
using APIGestiónUsuarios.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIGestiónUsuarios.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RolController : ControllerBase
{
    private readonly IRolService _service;

    public RolController(IRolService service) => _service = service;

    [HttpPost]
    public IActionResult Post([FromBody] Rol rol)
    {
        _service.Post(rol);

        return Ok();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.Get());
    }

    [HttpPut("{id}")]
    public IActionResult Put([FromBody] Rol rol, [FromRoute] Guid id)
    {
        _service.Put(rol, id);

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        _service.Delete(id);

        return Ok();
    }
}