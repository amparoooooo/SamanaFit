using SamanaFit.Ui.Tests.Infrastructure;
using SamanaFit.Ui.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;
using NivelEntity = SamanaFit.Data.Models.Nivel;

namespace SamanaFit.Tests.Services
{
    public class NivelServiceTests
    {
        [Fact]
        public async Task Buscar_CuandoExisteNivel_RetornaEntidad()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Nivels.Add(CreateNivel(id: 1, nombre: "Nivel 1"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new NivelService(context);

            var result = await service.Buscar(1);

            Assert.NotNull(result);
            Assert.Equal(1, result!.IdNivel);
            Assert.Equal("Nivel 1", result.Nombre);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteNivel_RetornaNull()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new NivelService(context);

            var result = await service.Buscar(999);

            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorNombre_RetornaCoincidencias()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Nivels.AddRange(
                    CreateNivel(id: 1, nombre: "Nivel 1"),
                    CreateNivel(id: 2, nombre: "Nivel 2"),
                    CreateNivel(id: 3, nombre: "Nivel 3"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new NivelService(context);

            var result = await service.GetList(s => s.Nombre != null && s.Nombre.Contains("Nivel"));

            Assert.Equal(3, result.Count);
            Assert.Contains(result, s => s.IdNivel == 1);
            Assert.Contains(result, s => s.IdNivel == 3);
            Assert.Contains(result, s => s.IdNivel == 2);
        }

        [Fact]
        public async Task Insertar_CuandoNivelEsValido_AlmacenaEntidad()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new NivelService(context);
            var nivel = CreateNivel(id: 10, nombre: "Nivel 10");
            var wasInserted = await service.Insertar(nivel);

            Assert.True(wasInserted);
            var saved = await context.Nivels.FirstOrDefaultAsync(s => s.IdNivel == 10);
            Assert.NotNull(saved);
            Assert.Equal("Nivel 10", saved!.Nombre);
        }

        [Fact]
        public async Task Existe_CuandoExisteNivel_RetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Nivels.Add(CreateNivel(id: 5, nombre: "Nivel 5"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new NivelService(context);

            var exists = await service.Existe(5);

            Assert.True(exists);
        }

        [Fact]
        public async Task Existe_CuandoNoExisteNivel_RetornaFalse()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new NivelService(context);

            var exists = await service.Existe(77);

            Assert.False(exists);
        }

        [Fact]
        public async Task Modificar_CuandoNivelExiste_ActualizaDatos()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();

            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Nivels.Add(CreateNivel(id: 20, nombre: "Nivel 20"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new NivelService(context);
            var updated = CreateNivel(id: 20, nombre: "Nivel 20 Actualizado");

            var wasUpdated = await service.Modificar(updated);

            Assert.True(wasUpdated);
            var saved = await context.Nivels.FirstOrDefaultAsync(s => s.IdNivel == 20);
            Assert.NotNull(saved);
            Assert.Equal("Nivel 20 Actualizado", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoNivelNoExiste_InsertaYRetornaTrue()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new NivelService(context);
            var nuevo = CreateNivel(id: 30, nombre: "Nivel 30");
            var result = await service.Guardar(nuevo);

            Assert.True(result);
            var saved = await context.Nivels.FirstOrDefaultAsync(s => s.IdNivel == 30);
            Assert.NotNull(saved);
            Assert.Equal("Nivel 30", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoNivelExiste_ModificaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Nivels.Add(CreateNivel(id: 40, nombre: "Nivel 40"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new NivelService(context);
            var updated = CreateNivel(id: 40, nombre: "Nivel 40 Actualizado");

            var result = await service.Guardar(updated);

            Assert.True(result);
            var saved = await context.Nivels.FirstOrDefaultAsync(s => s.IdNivel == 40);
            Assert.NotNull(saved);
            Assert.Equal("Nivel 40 Actualizado", saved!.Nombre);
        }

        [Fact]
        public async Task Eliminar_CuandoNivelExiste_EliminaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Nivels.Add(CreateNivel(id: 50, nombre: "Nivel 50"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new NivelService(context);

            var result = await service.Eliminar(50);

            Assert.True(result);
            var saved = await context.Nivels.FirstOrDefaultAsync(s => s.IdNivel == 50);
            Assert.Null(saved);
        }

        [Fact]
        public async Task Eliminar_CuandoNivelNoExiste_RetornaFalse()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new NivelService(context);

            var result = await service.Eliminar(999);

            Assert.False(result);
        }

        private static NivelEntity CreateNivel(int id, string nombre)
        {
            return new NivelEntity
            {
                IdNivel = id,
                Nombre = nombre
            };
        }
    }

}
