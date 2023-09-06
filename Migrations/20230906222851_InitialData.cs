using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIGestiónUsuarios.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "RolId", "RolNombre" },
                values: new object[,]
                {
                    { new Guid("08b6b52e-d0a8-49d5-9d35-ef1e9cfb05b9"), "Desarrolador de Software" },
                    { new Guid("633b52e0-237c-473b-8f8f-247ccff0bac6"), "Consultor" },
                    { new Guid("6d35e5f3-3ecf-42ae-9eb4-327a66b7a777"), "Project Manager" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "UsuarioApellido", "UsuarioContraseña", "UsuarioCorreoElectronico", "UsuarioFechaActualizacion", "UsuarioFechaCreacion", "UsuarioNombre" },
                values: new object[,]
                {
                    { new Guid("5f103855-c839-4d4c-b5c4-90a466ea8b4f"), "Villamizar", "contrasenaMateo", "mateo@pm.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mateo" },
                    { new Guid("8f2e59c3-8d39-4494-9e2c-5c13c6585b26"), "Delgado", "contrasenaXimena", "ximena@consultor.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ximena" },
                    { new Guid("ae0b504f-a239-4b5c-b1a7-e334a9819435"), "Rojas", "contrasenaSantiago", "santiago@desarrollador.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santiago" }
                });

            migrationBuilder.InsertData(
                table: "UsuarioRol",
                columns: new[] { "UsuarioRolId", "RolId", "UsuarioId" },
                values: new object[,]
                {
                    { new Guid("0dc39b94-303a-41a0-9fee-2f5f89e9ac24"), new Guid("08b6b52e-d0a8-49d5-9d35-ef1e9cfb05b9"), new Guid("ae0b504f-a239-4b5c-b1a7-e334a9819435") },
                    { new Guid("5ce64c6b-b8f6-41a1-b5ee-09147804724c"), new Guid("6d35e5f3-3ecf-42ae-9eb4-327a66b7a777"), new Guid("5f103855-c839-4d4c-b5c4-90a466ea8b4f") },
                    { new Guid("9502d17c-8a89-44a8-a4b6-e67cc78d811f"), new Guid("633b52e0-237c-473b-8f8f-247ccff0bac6"), new Guid("8f2e59c3-8d39-4494-9e2c-5c13c6585b26") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "RolId",
                keyValue: new Guid("08b6b52e-d0a8-49d5-9d35-ef1e9cfb05b9"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "RolId",
                keyValue: new Guid("633b52e0-237c-473b-8f8f-247ccff0bac6"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "RolId",
                keyValue: new Guid("6d35e5f3-3ecf-42ae-9eb4-327a66b7a777"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: new Guid("5f103855-c839-4d4c-b5c4-90a466ea8b4f"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: new Guid("8f2e59c3-8d39-4494-9e2c-5c13c6585b26"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: new Guid("ae0b504f-a239-4b5c-b1a7-e334a9819435"));

            migrationBuilder.DeleteData(
                table: "UsuarioRol",
                keyColumn: "UsuarioRolId",
                keyValue: new Guid("0dc39b94-303a-41a0-9fee-2f5f89e9ac24"));

            migrationBuilder.DeleteData(
                table: "UsuarioRol",
                keyColumn: "UsuarioRolId",
                keyValue: new Guid("5ce64c6b-b8f6-41a1-b5ee-09147804724c"));

            migrationBuilder.DeleteData(
                table: "UsuarioRol",
                keyColumn: "UsuarioRolId",
                keyValue: new Guid("9502d17c-8a89-44a8-a4b6-e67cc78d811f"));
        }
    }
}
