using Microsoft.EntityFrameworkCore;
using SamanaFit.Data.Context;
using SamanaFit.Data.Models;
using System.Linq.Expressions;
using Aplicada1.Core;

namespace SamanaFit.Ui.Services;

public class DetalleRutinaService(SamanaFitContext context) : IService<DetalleRutina, int>
{
    public Task<DetalleRutina?> Buscar(int id)
    {
        return context.DetalleRutinas
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.IdDetalle == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var detalle = await context.DetalleRutinas.FindAsync(id);
        if (detalle is null)
        {
            return false;
        }

        context.DetalleRutinas.Remove(detalle);
        var cantidad = await context.SaveChangesAsync();

        return cantidad > 0;
    }

    public async Task<List<DetalleRutina>> GetList(Expression<Func<DetalleRutina, bool>> criterio)
    {
        return await context.DetalleRutinas
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Insertar(DetalleRutina detalle)
    {
        context.DetalleRutinas.Add(detalle);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(DetalleRutina detalle)
    {
        if (!await Existe(detalle.IdDetalle))
            return await Insertar(detalle);
        else
            return await Modificar(detalle);
    }

    public Task<bool> Existe(int id)
    {
        return context.DetalleRutinas.AnyAsync(d => d.IdDetalle == id);
    }

    public async Task<bool> Modificar(DetalleRutina detalle)
    {
        context.DetalleRutinas.Update(detalle);
        return await context.SaveChangesAsync() > 0;
    }
}
