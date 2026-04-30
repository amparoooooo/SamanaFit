using SamanaFit.Ui.Tests.Infrastructure;
using SamanaFit.Ui.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;
using DetalleRutinaEntity = SamanaFit.Data.Models.DetalleRutina;

namespace SamanaFit.Tests.Services
{
    public class DetalleRutinaServiceTests
    {
        [Fact]
        public async Task Buscar_CuandoExisteDetalle_RetornaEntidad()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.DetalleRutinas.Add(CreateDetalle(id: 1, idRutina: 10, idEjercicio: 20, series: 3, repeticiones: 12, descanso: 60));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new DetalleRutinaService(context);

            var result = await service.Buscar(1);

            Assert.NotNull(result);
            Assert.Equal(1, result!.IdDetalle);
            Assert.Equal(10, result.IdRutina);
            Assert.Equal(20, result.IdEjercicio);
            Assert.Equal(3, result.Series);
            Assert.Equal(12, result.Repeticiones);
            Assert.Equal(60, result.Descanso);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteDetalle_RetornaNull()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new DetalleRutinaService(context);

            var result = await service.Buscar(999);

            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorRutina_RetornaCoincidencias()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.DetalleRutinas.AddRange(
                    CreateDetalle(id: 1, idRutina: 100, idEjercicio: 1, series: 3, repeticiones: 10, descanso: 30),
                    CreateDetalle(id: 2, idRutina: 100, idEjercicio: 2, series: 4, repeticiones: 12, descanso: 45),
                    CreateDetalle(id: 3, idRutina: 200, idEjercicio: 3, series: 5, repeticiones: 8, descanso: 60));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new DetalleRutinaService(context);

            var result = await service.GetList(d => d.IdRutina == 100);

            Assert.Equal(2, result.Count);
            Assert.Contains(result, d => d.IdDetalle == 1);
            Assert.Contains(result, d => d.IdDetalle == 2);
        }

        [Fact]
        public async Task Insertar_CuandoDetalleEsValido_AlmacenaEntidad()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new DetalleRutinaService(context);
            var detalle = CreateDetalle(id: 10, idRutina: 1, idEjercicio: 2, series: 3, repeticiones: 15, descanso: 90);

            var wasInserted = await service.Insertar(detalle);

            Assert.True(wasInserted);
            var saved = await context.DetalleRutinas.FirstOrDefaultAsync(d => d.IdDetalle == 10);
            Assert.NotNull(saved);
            Assert.Equal(1, saved!.IdRutina);
            Assert.Equal(2, saved.IdEjercicio);
            Assert.Equal(3, saved.Series);
            Assert.Equal(15, saved.Repeticiones);
            Assert.Equal(90, saved.Descanso);
        }

        [Fact]
        public async Task Existe_CuandoExisteDetalle_RetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.DetalleRutinas.Add(CreateDetalle(id: 5, idRutina: 1, idEjercicio: 1, series: 2, repeticiones: 10, descanso: 30));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new DetalleRutinaService(context);

            var exists = await service.Existe(5);

            Assert.True(exists);
        }

        [Fact]
        public async Task Existe_CuandoNoExisteDetalle_RetornaFalse()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new DetalleRutinaService(context);

            var exists = await service.Existe(77);

            Assert.False(exists);
        }

        [Fact]
        public async Task Modificar_CuandoDetalleExiste_ActualizaDatos()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.DetalleRutinas.Add(CreateDetalle(id: 20, idRutina: 2, idEjercicio: 3, series: 3, repeticiones: 10, descanso: 30));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new DetalleRutinaService(context);
            var updated = CreateDetalle(id: 20, idRutina: 2, idEjercicio: 3, series: 4, repeticiones: 12, descanso: 45);

            var wasUpdated = await service.Modificar(updated);

            Assert.True(wasUpdated);
            var saved = await context.DetalleRutinas.FirstOrDefaultAsync(d => d.IdDetalle == 20);
            Assert.NotNull(saved);
            Assert.Equal(4, saved!.Series);
            Assert.Equal(12, saved.Repeticiones);
            Assert.Equal(45, saved.Descanso);
        }

        [Fact]
        public async Task Guardar_CuandoDetalleNoExiste_InsertaYRetornaTrue()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new DetalleRutinaService(context);
            var nuevo = CreateDetalle(id: 30, idRutina: 3, idEjercicio: 4, series: 3, repeticiones: 8, descanso: 60);

            var result = await service.Guardar(nuevo);

            Assert.True(result);
            var saved = await context.DetalleRutinas.FirstOrDefaultAsync(d => d.IdDetalle == 30);
            Assert.NotNull(saved);
            Assert.Equal(3, saved!.IdRutina);
            Assert.Equal(4, saved.IdEjercicio);
        }

        [Fact]
        public async Task Guardar_CuandoDetalleExiste_ModificaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.DetalleRutinas.Add(CreateDetalle(id: 40, idRutina: 4, idEjercicio: 5, series: 3, repeticiones: 10, descanso: 30));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new DetalleRutinaService(context);
            var updated = CreateDetalle(id: 40, idRutina: 4, idEjercicio: 5, series: 6, repeticiones: 12, descanso: 90);

            var result = await service.Guardar(updated);

            Assert.True(result);
            var saved = await context.DetalleRutinas.FirstOrDefaultAsync(d => d.IdDetalle == 40);
            Assert.NotNull(saved);
            Assert.Equal(6, saved!.Series);
            Assert.Equal(12, saved.Repeticiones);
            Assert.Equal(90, saved.Descanso);
        }

        [Fact]
        public async Task Eliminar_CuandoDetalleExiste_EliminaYRetornaTrue()
        {
            var dbName = TestDbContextFactory.NewDatabaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.DetalleRutinas.Add(CreateDetalle(id: 50, idRutina: 5, idEjercicio: 6, series: 3, repeticiones: 10, descanso: 30));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new DetalleRutinaService(context);

            var result = await service.Eliminar(50);

            Assert.True(result);
            var saved = await context.DetalleRutinas.FirstOrDefaultAsync(d => d.IdDetalle == 50);
            Assert.Null(saved);
        }

        [Fact]
        public async Task Eliminar_CuandoDetalleNoExiste_RetornaFalse()
        {
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDatabaseName());
            var service = new DetalleRutinaService(context);

            var result = await service.Eliminar(999);

            Assert.False(result);
        }

        private static DetalleRutinaEntity CreateDetalle(
            int id,
            int? idRutina,
            int? idEjercicio,
            int? series,
            int? repeticiones,
            int? descanso)
        {
            return new DetalleRutinaEntity
            {
                IdDetalle = id,
                IdRutina = idRutina,
                IdEjercicio = idEjercicio,
                Series = series,
                Repeticiones = repeticiones,
                Descanso = descanso
            };
        }
    }
}
