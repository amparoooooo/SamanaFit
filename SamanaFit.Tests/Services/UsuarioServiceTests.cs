using SamanaFit.Ui.Tests.Infrastructure;
using SamanaFit.Ui.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;
using UsuarioEntity = SamanaFit.Data.Models.Usuario;

namespace SamanaFit.Tests.Services;

public class UsuarioServiceTests
{
    [Fact]
    public async Task Buscar_CuandoExisteUsuario_RetornaEntidad()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Usuarios.Add(CreateUsuario(id: 1, nombre: "Juan Perez"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new UsuarioService(context);

        var result = await service.Buscar(1);

        Assert.NotNull(result);
        Assert.Equal(1, result!.IdUsuario);
        Assert.Equal("Juan Perez", result.Nombre);
        Assert.Empty(context.ChangeTracker.Entries());
    }

    [Fact]
    public async Task Buscar_CuandoNoExisteUsuario_RetornaNull()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new UsuarioService(context);

        var result = await service.Buscar(999);

        Assert.Null(result);
    }

    [Fact]
    public async Task GetList_CuandoSeFiltraPorNombre_RetornaCoincidencias()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Usuarios.AddRange(
                CreateUsuario(id: 1, nombre: "Ana Lopez"),
                CreateUsuario(id: 2, nombre: "Carlos Ruiz"),
                CreateUsuario(id: 3, nombre: "Ana Maria"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new UsuarioService(context);

        var result = await service.GetList(u => u.Nombre != null && u.Nombre.Contains("Ana"));

        Assert.Equal(2, result.Count);
        Assert.Contains(result, u => u.IdUsuario == 1);
        Assert.Contains(result, u => u.IdUsuario == 3);
        Assert.DoesNotContain(result, u => u.IdUsuario == 2);
    }

    [Fact]
    public async Task Insertar_CuandoUsuarioEsValido_AlmacenaEntidad()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new UsuarioService(context);
        var usuario = CreateUsuario(id: 10, nombre: "Maria Diaz");

        var wasInserted = await service.Insertar(usuario);

        Assert.True(wasInserted);
        var saved = await context.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == 10);
        Assert.NotNull(saved);
        Assert.Equal("Maria Diaz", saved!.Nombre);
    }

    [Fact]
    public async Task Existe_CuandoExisteUsuario_RetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Usuarios.Add(CreateUsuario(id: 5, nombre: "Lucia Perez"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new UsuarioService(context);

        var exists = await service.Existe(5);

        Assert.True(exists);
    }

    [Fact]
    public async Task Existe_CuandoNoExisteUsuario_RetornaFalse()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new UsuarioService(context);

        var exists = await service.Existe(77);

        Assert.False(exists);
    }

    [Fact]
    public async Task Modificar_CuandoUsuarioExiste_ActualizaDatos()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();

        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Usuarios.Add(CreateUsuario(id: 20, nombre: "Pedro Soto"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new UsuarioService(context);
        var updated = CreateUsuario(id: 20, nombre: "Pedro Soto Actualizado");

        var wasUpdated = await service.Modificar(updated);

        Assert.True(wasUpdated);
        var saved = await context.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == 20);
        Assert.NotNull(saved);
        Assert.Equal("Pedro Soto Actualizado", saved!.Nombre);
    }

    [Fact]
    public async Task Guardar_CuandoUsuarioNoExiste_InsertaYRetornaTrue()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new UsuarioService(context);
        var nuevo = CreateUsuario(id: 30, nombre: "Camila Ortiz");

        var result = await service.Guardar(nuevo);

        Assert.True(result);
        var saved = await context.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == 30);
        Assert.NotNull(saved);
        Assert.Equal("Camila Ortiz", saved!.Nombre);
    }

    [Fact]
    public async Task Guardar_CuandoUsuarioExiste_ModificaYRetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Usuarios.Add(CreateUsuario(id: 40, nombre: "Andrea Leon"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new UsuarioService(context);
        var updated = CreateUsuario(id: 40, nombre: "Andrea Leon Actualizada");

        var result = await service.Guardar(updated);

        Assert.True(result);
        var saved = await context.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == 40);
        Assert.NotNull(saved);
        Assert.Equal("Andrea Leon Actualizada", saved!.Nombre);
    }

    [Fact]
    public async Task Eliminar_CuandoUsuarioExiste_EliminaYRetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Usuarios.Add(CreateUsuario(id: 50, nombre: "Jose Marin"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new UsuarioService(context);

        var result = await service.Eliminar(50);

        Assert.True(result);
        var saved = await context.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == 50);
        Assert.Null(saved);
    }

    [Fact]
    public async Task Eliminar_CuandoUsuarioNoExiste_RetornaFalse()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new UsuarioService(context);

        var result = await service.Eliminar(999);

        Assert.False(result);
    }

    private static UsuarioEntity CreateUsuario(int id, string nombre)
    {
        return new UsuarioEntity
        {
            IdUsuario = id,
            Nombre = nombre
        };
    }
}
