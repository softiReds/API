# API de gestión de usuarios

Esta API permite gestionar usuarios y sus roles en una base de datos. A continuación, se detallan las funcionalidades que ofrece la API y cómo utilizarlas.

## Funcionalidades

La API permite realizar las siguientes operaciones:

- Crear un usuario con su respectivo rol.
- Obtener la lista de usuarios y sus roles.
- Actualizar los datos de un usuario y su rol.
- Eliminar un usuario y su rol.

## Uso de la API

Para utilizar la API, se deben realizar las siguientes operaciones:

1. Clonar el repositorio de la API.
2. Configurar la cadena de conexión a la base de datos en el archivo "appsettings.json".
3. Ejecutar el comando "dotnet ef database update" para crear la base de datos.
4. Ejecutar la API utilizando el comando "dotnet run".

Una vez que la API esté en ejecución, se pueden realizar las siguientes operaciones:

- Crear un usuario: enviar una solicitud POST a la URL "/api/usuario" con los datos del usuario y su rol en el cuerpo de la solicitud.
- Obtener la lista de usuarios: enviar una solicitud GET a la URL "/api/usuario".
- Actualizar los datos de un usuario: enviar una solicitud PUT a la URL "/api/usuario/{id}" con los datos actualizados del usuario y su rol en el cuerpo de la solicitud.
- Eliminar un usuario: enviar una solicitud DELETE a la URL "/api/usuario/{id}".

## Tecnologías utilizadas

La API de gestión de usuarios se ha desarrollado utilizando las siguientes tecnologías:

- .NET 7
- Entity Framework Core
- ASP.NET Core
- C#

## Contribuciones

Si deseas contribuir al desarrollo de la API de gestión de usuarios, puedes hacerlo a través de pull requests en el repositorio de GitHub. Se agradecen todas las contribuciones y sugerencias para mejorar la API.
