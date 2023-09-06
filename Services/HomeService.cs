using APIGestiónUsuarios.Context;

namespace APIGestiónUsuarios.Services;

public class HomeService : IHomeService
{
    public async Task CreateDatabase(GestionUsuariosContext dbContext)
    {
        dbContext.Database.EnsureCreated();
    }
}

public interface IHomeService
{
    Task CreateDatabase(GestionUsuariosContext dbContext);
}