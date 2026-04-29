using SamanaFit.Ui.Tests.Infrastructure;
using SamanaFit.Ui.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;
using ObjetivoEntity = SamanaFit.Data.Models.Objetivo;

namespace SamanaFit.Tests.Services
{
    public class ObjetivoServiceTests
    {

        [Fact]
        public async Task Buscar_CuandoExisteObjetivo_RetornaEntidad()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Objetivos.Add(CreateObjetivo(id: 1, nombre: "Objetivo 1"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ObjetivoService(context);

            var result = await service.Buscar(1);

            Assert.NotNull(result);
            Assert.Equal(1, result!.IdObjetivo);
            Assert.Equal("Objetivo 1", result.Nombre);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteObjetivo_RetornaNull()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new ObjetivoService(context);

            var result = await service.Buscar(999);

            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorNombre_RetornaCoincidencias()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Objetivos.AddRange(
                    CreateObjetivo(id: 1, nombre: "Objetivo 1"),
                    CreateObjetivo(id: 2, nombre: "Objetivo 2"),
                    CreateObjetivo(id: 3, nombre: "Objetivo 3"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ObjetivoService(context);

            var result = await service.GetList(s => s.Nombre != null && s.Nombre.Contains("Objetivo"));

            Assert.Equal(3, result.Count);
            Assert.Contains(result, s => s.IdObjetivo == 1);
            Assert.Contains(result, s => s.IdObjetivo == 3);
            Assert.Contains(result, s => s.IdObjetivo == 2);
        }

        [Fact]
        public async Task Insertar_CuandoObjetivoEsValido_AlmacenaEntidad()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new ObjetivoService(context);
            var objetivo = CreateObjetivo(id: 10, nombre: "Objetivo 10");
            var wasInserted = await service.Insertar(objetivo);

            Assert.True(wasInserted);
            var saved = await context.Objetivos.FirstOrDefaultAsync(s => s.IdObjetivo == 10);
            Assert.NotNull(saved);
            Assert.Equal("Objetivo 10", saved!.Nombre);
        }

        [Fact]
        public async Task Existe_CuandoExisteObjetivo_RetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Objetivos.Add(CreateObjetivo(id: 5, nombre: "Objetivo 5"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ObjetivoService(context);

            var exists = await service.Existe(5);

            Assert.True(exists);
        }

        [Fact]
        public async Task Existe_CuandoNoExisteObjetivo_RetornaFalse()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new ObjetivoService(context);

            var exists = await service.Existe(77);

            Assert.False(exists);
        }

        [Fact]
        public async Task Modificar_CuandoObjetivoExiste_ActualizaDatos()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();

            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Objetivos.Add(CreateObjetivo(id: 20, nombre: "Objetivo 20"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ObjetivoService(context);
            var updated = CreateObjetivo(id: 20, nombre: "Objetivo 20 Actualizado");

            var wasUpdated = await service.Modificar(updated);

            Assert.True(wasUpdated);
            var saved = await context.Objetivos.FirstOrDefaultAsync(s => s.IdObjetivo == 20);
            Assert.NotNull(saved);
            Assert.Equal("Objetivo 20 Actualizado", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoObjetivoNoExiste_InsertaYRetornaTrue()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new ObjetivoService(context);
            var nuevo = CreateObjetivo(id: 30, nombre: "Otro");
            var result = await service.Guardar(nuevo);

            Assert.True(result);
            var saved = await context.Objetivos.FirstOrDefaultAsync(s => s.IdObjetivo == 30);
            Assert.NotNull(saved);
            Assert.Equal("Otro", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoObjetivoExiste_ModificaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Objetivos.Add(CreateObjetivo(id: 40, nombre: "Objetivo 40"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ObjetivoService(context);
            var updated = CreateObjetivo(id: 40, nombre: "Objetivo 40 Actualizado");

            var result = await service.Guardar(updated);

            Assert.True(result);
            var saved = await context.Objetivos.FirstOrDefaultAsync(s => s.IdObjetivo == 40);
            Assert.NotNull(saved);
            Assert.Equal("Objetivo 40 Actualizado", saved!.Nombre);
        }

        [Fact]
        public async Task Eliminar_CuandoObjetivoExiste_EliminaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Objetivos.Add(CreateObjetivo(id: 50, nombre: "Objetivo 50"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ObjetivoService(context);

            var result = await service.Eliminar(50);

            Assert.True(result);
            var saved = await context.Objetivos.FirstOrDefaultAsync(s => s.IdObjetivo == 50);
            Assert.Null(saved);
        }

        [Fact]
        public async Task Eliminar_CuandoObjetivoNoExiste_RetornaFalse()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new ObjetivoService(context);

            var result = await service.Eliminar(999);

            Assert.False(result);
        }

        private static ObjetivoEntity CreateObjetivo(int id, string nombre)
        {
            return new ObjetivoEntity
            {
                IdObjetivo = id,
                Nombre = nombre
            };
        }
    }

}
