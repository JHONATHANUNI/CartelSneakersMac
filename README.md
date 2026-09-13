# Urban Kicks para macOS

Migracion de la tienda original ASP.NET Web Forms a ASP.NET Core 8 MVC. Esta version funciona en macOS, Linux y Windows y usa SQLite local, por lo que no necesita SQL Server LocalDB.

## Requisitos

- .NET 8 SDK: https://dotnet.microsoft.com/download/dotnet/8.0

## Ejecutar en Mac

```bash
export DOTNET_ROOT=/opt/homebrew/opt/dotnet@8/libexec
export PATH=/opt/homebrew/opt/dotnet@8/bin:$PATH
dotnet restore
dotnet run --urls http://localhost:5187
```

Abre `http://localhost:5187`.

La base `urbankicks.db` se crea automaticamente con productos de ejemplo y un administrador:

- Usuario: `admin`
- Password: `admin123`

Cambia la password antes de publicar. Las imagenes de la version original deben copiarse a `wwwroot/images/`.

La carpeta `UrbanKicks/` original se conserva sin cambios como referencia.

## Funciones migradas

- Catalogo por marca y orden por precio
- Detalle de producto y seleccion de talla
- Carrito persistido en sesion, incluyendo tallas distintas
- Registro, login y contrasenas con hash
- Checkout y pedidos en SQLite
- Panel admin en `/admin` para agregar y eliminar productos

## Assets oficiales pendientes

Coloca estos archivos en `wwwroot/images/`:

- `cartel-sneakers-logo.png`: insignia circular del header y favicon.
- `cartel-hero.png`: fondo del héroe de About.

El héroe ya aplica el overlay negro y el recorte responsive sobre `cartel-hero.png`.
