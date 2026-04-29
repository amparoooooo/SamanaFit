using Microsoft.EntityFrameworkCore;
using SamanaFit.Data.Context;
using SamanaFit.Data.Models;
using System.Linq.Expressions;
using Aplicada1.Core;

namespace SamanaFit.Ui.Services;

public class EjercicioService(SamanaFitContext context) : IService<Ejercicio, int>
{
    public Task<Ejercicio?> Buscar(int id)
    {
        return context.Ejercicios
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.IdEjercicio == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var ejercicio = await context.Ejercicios.FindAsync(id);
        if (ejercicio is null)
        {
            return false;
        }

        context.Ejercicios.Remove(ejercicio);
        var cantidad = await context.SaveChangesAsync();

        return cantidad > 0;
    }

    public async Task<List<Ejercicio>> GetList(Expression<Func<Ejercicio, bool>> criterio)
    {
        return await context.Ejercicios
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Insertar(Ejercicio ejercicio)
    {
        context.Ejercicios.Add(ejercicio);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Ejercicio ejercicio)
    {
        if (!await Existe(ejercicio.IdEjercicio))
            return await Insertar(ejercicio);
        else
            return await Modificar(ejercicio);
    }

    public Task<bool> Existe(int id)
    {
        return context.Ejercicios.AnyAsync(e => e.IdEjercicio == id);
    }

    public async Task<bool> Modificar(Ejercicio ejercicio)
    {
        context.Ejercicios.Update(ejercicio);
        return await context.SaveChangesAsync() > 0;
    }
}
