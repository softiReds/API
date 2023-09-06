using APIGestiónUsuarios.Context;
using APIGestiónUsuarios.Models;

namespace APIGestiónUsuarios.Services;

public class UsuarioService : IUsuarioService
{
    private readonly GestionUsuariosContext _dbContext;

    public UsuarioService(GestionUsuariosContext dbContext) => _dbContext = dbContext;

    public async Task Post(Usuario usuario)
    {
        usuario.UsuarioId = Guid.NewGuid();
        usuario.UsuarioFechaCreacion = DateTime.Now;

        await _dbContext.Usuarios.AddAsync(usuario);
        await _dbContext.SaveChangesAsync();
    }

    public IEnumerable<Usuario> Get() => _dbContext.Usuarios;

    public async Task Put(Usuario usuario, Guid id)
    {
        Usuario usuarioActualizar = _dbContext.Usuarios.Find(id);

        if (usuarioActualizar != null)
        {
            usuarioActualizar.UsuarioNombre = usuario.UsuarioNombre;
            usuarioActualizar.UsuarioApellido = usuario.UsuarioApellido;
            usuarioActualizar.UsuarioCorreoElectronico = usuario.UsuarioCorreoElectronico;
            usuarioActualizar.UsuarioContraseña = usuario.UsuarioContraseña;
            usuarioActualizar.UsuarioFechaCreacion = usuario.UsuarioFechaCreacion;
            usuarioActualizar.UsuarioFechaActualizacion = DateTime.Now;

            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
    {
        Usuario usuarioEliminar = _dbContext.Usuarios.Find(id);

        if (usuarioEliminar != null)
        {
            _dbContext.Remove(usuarioEliminar);

            await _dbContext.SaveChangesAsync();
        }
    }
}

public interface IUsuarioService
{
    Task Post(Usuario usuario);
    IEnumerable<Usuario> Get();
    Task Put(Usuario usuario, Guid id);
    Task Delete(Guid id);
}