using SamanaFit.Ui.Tests.Infrastructure;
using SamanaFit.Ui.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;
using SexoEntity = SamanaFit.Data.Models.Sexo;

namespace SamanaFit.Tests.Services;

public class SexoServiceTests
{
    [Fact]
    public async Task Buscar_CuandoExisteSexo_RetornaEntidad()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Sexos.Add(CreateSexo(id: 1, nombre: "Masculino"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new SexoService(context);

        var result = await service.Buscar(1);

        Assert.NotNull(result);
        Assert.Equal(1, result!.IdSexo);
        Assert.Equal("Masculino", result.Nombre);
        Assert.Empty(context.ChangeTracker.Entries());
    }

    [Fact]
    public async Task Buscar_CuandoNoExisteSexo_RetornaNull()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new SexoService(context);

        var result = await service.Buscar(999);

        Assert.Null(result);
    }

    [Fact]
    public async Task GetList_CuandoSeFiltraPorNombre_RetornaCoincidencias()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Sexos.AddRange(
                CreateSexo(id: 1, nombre: "Masculino"),
                CreateSexo(id: 2, nombre: "Femenino"),
                CreateSexo(id: 3, nombre: "Masculino Avanzado"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new SexoService(context);

        var result = await service.GetList(s => s.Nombre != null && s.Nombre.Contains("Masculino"));

        Assert.Equal(2, result.Count);
        Assert.Contains(result, s => s.IdSexo == 1);
        Assert.Contains(result, s => s.IdSexo == 3);
        Assert.DoesNotContain(result, s => s.IdSexo == 2);
    }

    [Fact]
    public async Task Insertar_CuandoSexoEsValido_AlmacenaEntidad()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new SexoService(context);
        var sexo = CreateSexo(id: 10, nombre: "No Binario");

        var wasInserted = await service.Insertar(sexo);

        Assert.True(wasInserted);
        var saved = await context.Sexos.FirstOrDefaultAsync(s => s.IdSexo == 10);
        Assert.NotNull(saved);
        Assert.Equal("No Binario", saved!.Nombre);
    }

    [Fact]
    public async Task Existe_CuandoExisteSexo_RetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Sexos.Add(CreateSexo(id: 5, nombre: "Femenino"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new SexoService(context);

        var exists = await service.Existe(5);

        Assert.True(exists);
    }

    [Fact]
    public async Task Existe_CuandoNoExisteSexo_RetornaFalse()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new SexoService(context);

        var exists = await service.Existe(77);

        Assert.False(exists);
    }

    [Fact]
    public async Task Modificar_CuandoSexoExiste_ActualizaDatos()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();

        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Sexos.Add(CreateSexo(id: 20, nombre: "Masculino"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new SexoService(context);
        var updated = CreateSexo(id: 20, nombre: "Masculino Actualizado");

        var wasUpdated = await service.Modificar(updated);

        Assert.True(wasUpdated);
        var saved = await context.Sexos.FirstOrDefaultAsync(s => s.IdSexo == 20);
        Assert.NotNull(saved);
        Assert.Equal("Masculino Actualizado", saved!.Nombre);
    }

    [Fact]
    public async Task Guardar_CuandoSexoNoExiste_InsertaYRetornaTrue()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new SexoService(context);
        var nuevo = CreateSexo(id: 30, nombre: "Otro");

        var result = await service.Guardar(nuevo);

        Assert.True(result);
        var saved = await context.Sexos.FirstOrDefaultAsync(s => s.IdSexo == 30);
        Assert.NotNull(saved);
        Assert.Equal("Otro", saved!.Nombre);
    }

    [Fact]
    public async Task Guardar_CuandoSexoExiste_ModificaYRetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Sexos.Add(CreateSexo(id: 40, nombre: "Femenino"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new SexoService(context);
        var updated = CreateSexo(id: 40, nombre: "Femenino Actualizado");

        var result = await service.Guardar(updated);

        Assert.True(result);
        var saved = await context.Sexos.FirstOrDefaultAsync(s => s.IdSexo == 40);
        Assert.NotNull(saved);
        Assert.Equal("Femenino Actualizado", saved!.Nombre);
    }

    [Fact]
    public async Task Eliminar_CuandoSexoExiste_EliminaYRetornaTrue()
    {
        var dbName = TestDbContextFactory.NewDatabaseName();
        await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
        {
            seedContext.Sexos.Add(CreateSexo(id: 50, nombre: "Masculino"));
            await seedContext.SaveChangesAsync();
        }

        await using var context = TestDbContextFactory.CreateContext(dbName);
        var service = new SexoService(context);

        var result = await service.Eliminar(50);

        Assert.True(result);
        var saved = await context.Sexos.FirstOrDefaultAsync(s => s.IdSexo == 50);
        Assert.Null(saved);
    }

    [Fact]
    public async Task Eliminar_CuandoSexoNoExiste_RetornaFalse()
    {
        await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
        var service = new SexoService(context);

        var result = await service.Eliminar(999);

        Assert.False(result);
    }

    private static SexoEntity CreateSexo(int id, string nombre)
    {
        return new SexoEntity
        {
            IdSexo = id,
            Nombre = nombre
        };
    }
}
