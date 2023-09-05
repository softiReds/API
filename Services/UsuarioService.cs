using APIGestiónUsuarios.Models;

namespace APIGestiónUsuarios.Services;

public class UsuarioService : IUsuarioService
{

}

public interface IUsuarioService
{
    IEnumerable<Usuario> Get();
    Task Put(Usuario usuario, Guid id);
    Task Post(Usuario usuario);
    Task Delete(Guid id);
}