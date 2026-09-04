# FeriadosChileNet5

Conversión del proyecto Django a ASP.NET Core MVC con .NET 5.

## Importante
No existe una versión oficial llamada .NET 5.1. Por eso el proyecto está configurado con `net5.0`, que es la versión disponible de .NET 5.

## Ejecutar

```bash
dotnet restore
dotnet run
```

Abrir la URL indicada por la consola.

## Arquitectura

- Controllers/FeriadosController.cs: equivalente a `views.py` de Django.
- Services/FeriadosService.cs: consume la API externa.
- Models/: modelos para deserializar el JSON.
- Views/Feriados/Index.cshtml: equivalente al template `feriados.html`.

Flujo:

Navegador -> Controller -> Service -> API externa -> JSON -> Razor View
