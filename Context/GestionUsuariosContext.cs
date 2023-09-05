using APIGestiónUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace APIGestiónUsuarios.Context;

public class GestionUsuariosContext : DbContext
{
    public GestionUsuariosContext(DbContextOptions<GestionUsuariosContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<UsuarioRol> UsuarioRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(usuario =>
        {
            usuario.ToTable("Usuario");

            usuario.HasKey(e => e.UsuarioId);

            usuario.Property(e => e.UsuarioNombre).HasMaxLength(60).IsRequired();
            usuario.Property(e => e.UsuarioApellido).HasMaxLength(60).IsRequired();
            usuario.Property(e => e.UsuarioCorreoElectronico).IsRequired();
            usuario.Property(e => e.UsuarioContraseña).IsRequired();
            usuario.Property(e => e.UsuarioFechaCreacion).IsRequired();
            usuario.Property(e => e.UsuarioFechaActualizacion).IsRequired();
        });

        modelBuilder.Entity<Rol>(rol =>
        {
            rol.ToTable("Rol");

            rol.HasKey(e => e.RolId);

            rol.Property(e => e.RolNombre).IsRequired();
        });

        modelBuilder.Entity<UsuarioRol>(usuarioRol =>
        {
            usuarioRol.ToTable("UsuarioRol");

            usuarioRol.HasKey(e => e.UsuarioRolId);

            usuarioRol.HasOne(e => e.Usuario).WithOne(e => e.UsuarioRol).HasForeignKey<Usuario>(e => e.UsuarioId);
            usuarioRol.HasOne(e => e.Rol).WithOne(e => e.UsuarioRol).HasForeignKey<Rol>(e => e.RolId);
        });
    }
}