using Microsoft.EntityFrameworkCore;
using SamanaFit.Data.Context;
using SamanaFit.Data.Models;
using System.Linq.Expressions;
using Aplicada1.Core;

namespace SamanaFit.Ui.Services;

public class SexoService(SamanaFitContext context) : IService<Sexo, int>
{
    public Task<Sexo?> Buscar(int id)
    {
        return context.Sexos
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.IdSexo == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var sexo = await context.Sexos.FindAsync(id);
        if (sexo is null)
        {
            return false;
        }

        context.Sexos.Remove(sexo);
        var cantidad = await context.SaveChangesAsync();

        return cantidad > 0;
    }

    public async Task<List<Sexo>> GetList(Expression<Func<Sexo, bool>> criterio)
    {
        return await context.Sexos
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Insertar(Sexo sexo)
    {
        context.Sexos.Add(sexo);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Sexo sexo)
    {
        if (!await Existe(sexo.IdSexo))
            return await Insertar(sexo);
        else
            return await Modificar(sexo);
    }

    public Task<bool> Existe(int id)
    {
        return context.Sexos.AnyAsync(s => s.IdSexo == id);
    }

    public async Task<bool> Modificar(Sexo sexo)
    {
        context.Sexos.Update(sexo);
        return await context.SaveChangesAsync() > 0;
    }
}
