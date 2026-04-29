using SamanaFit.Ui.Tests.Infrastructure;
using SamanaFit.Ui.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;
using EjercicioEntity = SamanaFit.Data.Models.Ejercicio;

namespace SamanaFit.Tests.Services
{
    public class EjercicioServiceTests
    {
        [Fact]
        public async Task Buscar_CuandoExisteEjercicio_RetornaEntidad()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ejercicios.Add(CreateEjercicio(id: 1, nombre: "Ejercicio 1"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new EjercicioService(context);

            var result = await service.Buscar(1);

            Assert.NotNull(result);
            Assert.Equal(1, result!.IdEjercicio);
            Assert.Equal("Ejercicio 1", result.Nombre);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteEjercicio_RetornaNull()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new EjercicioService(context);

            var result = await service.Buscar(999);

            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorNombre_RetornaCoincidencias()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ejercicios.AddRange(
                    CreateEjercicio(id: 1, nombre: "Ejercicio 1"),
                    CreateEjercicio(id: 2, nombre: "Ejercicio 2"),
                    CreateEjercicio(id: 3, nombre: "Ejercicio 3"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new EjercicioService(context);

            var result = await service.GetList(s => s.Nombre != null && s.Nombre.Contains("Ejercicio"));

            Assert.Equal(3, result.Count);
            Assert.Contains(result, s => s.IdEjercicio == 1);
            Assert.Contains(result, s => s.IdEjercicio == 3);
            Assert.Contains(result, s => s.IdEjercicio == 2);
        }

        [Fact]
        public async Task Insertar_CuandoEjercicioEsValido_AlmacenaEntidad()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new EjercicioService(context);
            var ejercicio = CreateEjercicio(id: 10, nombre: "Ejercicio 10");
            var wasInserted = await service.Insertar(ejercicio);

            Assert.True(wasInserted);
            var saved = await context.Ejercicios.FirstOrDefaultAsync(s => s.IdEjercicio == 10);
            Assert.NotNull(saved);
            Assert.Equal("Ejercicio 10", saved!.Nombre);
        }

        [Fact]
        public async Task Existe_CuandoExisteEjercicio_RetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ejercicios.Add(CreateEjercicio(id: 5, nombre: "Ejercicio 5"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new EjercicioService(context);

            var exists = await service.Existe(5);

            Assert.True(exists);
        }

        [Fact]
        public async Task Existe_CuandoNoExisteEjercicio_RetornaFalse()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new EjercicioService(context);

            var exists = await service.Existe(77);

            Assert.False(exists);
        }

        [Fact]
        public async Task Modificar_CuandoEjercicioExiste_ActualizaDatos()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();

            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ejercicios.Add(CreateEjercicio(id: 20, nombre: "Ejercicio 20"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new EjercicioService(context);
            var updated = CreateEjercicio(id: 20, nombre: "Ejercicio 20 Actualizado");

            var wasUpdated = await service.Modificar(updated);

            Assert.True(wasUpdated);
            var saved = await context.Ejercicios.FirstOrDefaultAsync(s => s.IdEjercicio == 20);
            Assert.NotNull(saved);
            Assert.Equal("Ejercicio 20 Actualizado", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoEjercicioNoExiste_InsertaYRetornaTrue()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new EjercicioService(context);
            var nuevo = CreateEjercicio(id: 30, nombre: "Ejercicio 30");
            var result = await service.Guardar(nuevo);

            Assert.True(result);
            var saved = await context.Ejercicios.FirstOrDefaultAsync(s => s.IdEjercicio == 30);
            Assert.NotNull(saved);
            Assert.Equal("Ejercicio 30", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoEjercicioExiste_ModificaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ejercicios.Add(CreateEjercicio(id: 40, nombre: "Ejercicio 40"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new EjercicioService(context);
            var updated = CreateEjercicio(id: 40, nombre: "Ejercicio 40 Actualizado");

            var result = await service.Guardar(updated);

            Assert.True(result);
            var saved = await context.Ejercicios.FirstOrDefaultAsync(s => s.IdEjercicio == 40);
            Assert.NotNull(saved);
            Assert.Equal("Ejercicio 40 Actualizado", saved!.Nombre);
        }

        [Fact]
        public async Task Eliminar_CuandoEjercicioExiste_EliminaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ejercicios.Add(CreateEjercicio(id: 50, nombre: "Ejercicio 50"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new EjercicioService(context);

            var result = await service.Eliminar(50);

            Assert.True(result);
            var saved = await context.Ejercicios.FirstOrDefaultAsync(s => s.IdEjercicio == 50);
            Assert.Null(saved);
        }

        [Fact]
        public async Task Eliminar_CuandoEjercicioNoExiste_RetornaFalse()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new EjercicioService(context);

            var result = await service.Eliminar(999);

            Assert.False(result);
        }

        private static EjercicioEntity CreateEjercicio(int id, string nombre)
        {
            return new EjercicioEntity
            {
                IdEjercicio = id,
                Nombre = nombre
            };
        }
    }

}
