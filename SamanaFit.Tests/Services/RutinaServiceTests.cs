using SamanaFit.Ui.Tests.Infrastructure;
using SamanaFit.Ui.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;
using RutinaEntity = SamanaFit.Data.Models.Rutina;


namespace SamanaFit.Tests.Services
{
    public class RutinaServiceTests
    {

        [Fact]
        public async Task Buscar_CuandoExisteRutina_RetornaEntidad()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Rutinas.Add(CreateRutina(id: 1, nombre: "Rutina 1"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RutinaService(context);

            var result = await service.Buscar(1);

            Assert.NotNull(result);
            Assert.Equal(1, result!.IdRutina);
            Assert.Equal("Rutina 1", result.Nombre);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteRutina_RetornaNull()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new RutinaService(context);

            var result = await service.Buscar(999);

            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorNombre_RetornaCoincidencias()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Rutinas.AddRange(
                    CreateRutina(id: 1, nombre: "Rutina 1"),
                    CreateRutina(id: 2, nombre: "Rutina 2"),
                    CreateRutina(id: 3, nombre: "Rutina 3"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RutinaService(context);

            var result = await service.GetList(s => s.Nombre != null && s.Nombre.Contains("Rutina"));

            Assert.Equal(3, result.Count);
            Assert.Contains(result, s => s.IdRutina == 1);
            Assert.Contains(result, s => s.IdRutina == 3);
            Assert.Contains(result, s => s.IdRutina == 2);
        }

        [Fact]
        public async Task Insertar_CuandoRutinaEsValida_AlmacenaEntidad()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new RutinaService(context);
            var rutina = CreateRutina(id: 10, nombre: "Rutina 10");
            var wasInserted = await service.Insertar(rutina);

            Assert.True(wasInserted);
            var saved = await context.Rutinas.FirstOrDefaultAsync(s => s.IdRutina == 10);
            Assert.NotNull(saved);
            Assert.Equal("Rutina 10", saved!.Nombre);
        }

        [Fact]
        public async Task Existe_CuandoExisteRutina_RetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Rutinas.Add(CreateRutina(id: 5, nombre: "Rutina 5"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RutinaService(context);

            var exists = await service.Existe(5);

            Assert.True(exists);
        }

        [Fact]
        public async Task Existe_CuandoNoExisteRutina_RetornaFalse()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new RutinaService(context);

            var exists = await service.Existe(77);

            Assert.False(exists);
        }

        [Fact]
        public async Task Modificar_CuandoRutinaExiste_ActualizaDatos()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();

            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Rutinas.Add(CreateRutina(id: 20, nombre: "Rutina 20"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RutinaService(context);
            var updated = CreateRutina(id: 20, nombre: "Rutina 20 Actualizada");

            var wasUpdated = await service.Modificar(updated);

            Assert.True(wasUpdated);
            var saved = await context.Rutinas.FirstOrDefaultAsync(s => s.IdRutina == 20);
            Assert.NotNull(saved);
            Assert.Equal("Rutina 20 Actualizada", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoRutinaNoExiste_InsertaYRetornaTrue()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new RutinaService(context);
            var nuevo = CreateRutina(id: 30, nombre: "Rutina 30");
            var result = await service.Guardar(nuevo);

            Assert.True(result);
            var saved = await context.Rutinas.FirstOrDefaultAsync(s => s.IdRutina == 30);
            Assert.NotNull(saved);
            Assert.Equal("Rutina 30", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoRutinaExiste_ModificaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Rutinas.Add(CreateRutina(id: 40, nombre: "Rutina 40"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RutinaService(context);
            var updated = CreateRutina(id: 40, nombre: "Rutina 40 Actualizada");

            var result = await service.Guardar(updated);

            Assert.True(result);
            var saved = await context.Rutinas.FirstOrDefaultAsync(s => s.IdRutina == 40);
            Assert.NotNull(saved);
            Assert.Equal("Rutina 40 Actualizada", saved!.Nombre);
        }

        [Fact]
        public async Task Eliminar_CuandoRutinaExiste_EliminaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Rutinas.Add(CreateRutina(id: 50, nombre: "Rutina 50"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RutinaService(context);

            var result = await service.Eliminar(50);

            Assert.True(result);
            var saved = await context.Rutinas.FirstOrDefaultAsync(s => s.IdRutina == 50);
            Assert.Null(saved);
        }

        [Fact]
        public async Task Eliminar_CuandoRutinaNoExiste_RetornaFalse()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new RutinaService(context);

            var result = await service.Eliminar(999);

            Assert.False(result);
        }

        private static RutinaEntity CreateRutina(int id, string nombre)
        {
            return new RutinaEntity
            {
                IdRutina = id,
                Nombre = nombre
            };
        }
    }


}
