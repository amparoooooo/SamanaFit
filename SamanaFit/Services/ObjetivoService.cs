using Microsoft.EntityFrameworkCore;
using SamanaFit.Data.Context;
using SamanaFit.Data.Models;
using System.Linq.Expressions;
using Aplicada1.Core;

namespace SamanaFit.Ui.Services;

public class ObjetivoService(SamanaFitContext context) : IService<Objetivo, int>
{
    public Task<Objetivo?> Buscar(int id)
    {
        return context.Objetivos
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.IdObjetivo == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var objetivo = await context.Objetivos.FindAsync(id);
        if (objetivo is null)
        {
            return false;
        }

        context.Objetivos.Remove(objetivo);
        var cantidad = await context.SaveChangesAsync();

        return cantidad > 0;
    }

    public async Task<List<Objetivo>> GetList(Expression<Func<Objetivo, bool>> criterio)
    {
        return await context.Objetivos
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Insertar(Objetivo objetivo)
    {
        context.Objetivos.Add(objetivo);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Objetivo objetivo)
    {
        if (!await Existe(objetivo.IdObjetivo))
            return await Insertar(objetivo);
        else
            return await Modificar(objetivo);
    }

    public Task<bool> Existe(int id)
    {
        return context.Objetivos.AnyAsync(o => o.IdObjetivo == id);
    }

    public async Task<bool> Modificar(Objetivo objetivo)
    {
        context.Objetivos.Update(objetivo);
        return await context.SaveChangesAsync() > 0;
    }
}
