using Microsoft.EntityFrameworkCore;
using SamanaFit.Data.Context;
using SamanaFit.Data.Models;
using System.Linq.Expressions;
using Aplicada1.Core;

namespace SamanaFit.Ui.Services;

public class RutinaService(SamanaFitContext context) : IService<Rutina, int>
{
    public Task<Rutina?> Buscar(int id)
    {
        return context.Rutinas
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.IdRutina == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var rutina = await context
        .Rutinas
        .FindAsync(id);

        if (rutina == null)
            return false;
      

        context.Rutinas.Remove(rutina);
        var cantidad = await context.SaveChangesAsync();

        return cantidad > 0;
    }

    public async Task<List<Rutina>> GetList(Expression<Func<Rutina, bool>> criterio)
    {
        return await context.Rutinas
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Insertar(Rutina rutina)
    {
        rutina.FechaCreacion ??= DateOnly.FromDateTime(DateTime.Today);
        context.Rutinas.Add(rutina);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Rutina rutina)
    {
        if (!await Existe(rutina.IdRutina))
            return await Insertar(rutina);
        else
            return await Modificar(rutina);
    }

    public Task<bool> Existe(int id)
    {
        return context.Rutinas.AnyAsync(a => a.IdRutina == id);
    }

    public async Task<bool> Modificar(Rutina rutina)
    {
        context.Rutinas.Update(rutina);
        return await context.SaveChangesAsync() > 0;
    }
}
