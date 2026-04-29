
using Microsoft.EntityFrameworkCore;
using SamanaFit.Data.Context;
using SamanaFit.Data.Models;
using System.Linq.Expressions;
using Aplicada1.Core;

namespace SamanaFit.Ui.Services;

public class NivelService(SamanaFitContext context) : IService<Nivel, int>
{
    public Task<Nivel?> Buscar(int id)
    {
        return context.Nivels
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.IdNivel == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var nivel = await context.Nivels.FindAsync(id);
        if (nivel is null)
        {
            return false;
        }

        context.Nivels.Remove(nivel);
        var cantidad = await context.SaveChangesAsync();

        return cantidad > 0;
    }

    public async Task<List<Nivel>> GetList(Expression<Func<Nivel, bool>> criterio)
    {
        return await context.Nivels
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Insertar(Nivel nivel)
    {
        context.Nivels.Add(nivel);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Nivel nivel)
    {
        if (!await Existe(nivel.IdNivel))
            return await Insertar(nivel);
        else
            return await Modificar(nivel);
    }

    public Task<bool> Existe(int id)
    {
        return context.Nivels.AnyAsync(n => n.IdNivel == id);
    }

    public async Task<bool> Modificar(Nivel nivel)
    {
        context.Nivels.Update(nivel);
        return await context.SaveChangesAsync() > 0;
    }
}
