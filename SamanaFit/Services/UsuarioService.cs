using Microsoft.EntityFrameworkCore;
using SamanaFit.Data.Context;
using SamanaFit.Data.Models;
using System.Linq.Expressions;
using Aplicada1.Core;

namespace SamanaFit.Ui.Services;

public class UsuarioService(SamanaFitContext context) : IService<Usuario, int>
{
    public Task<Usuario?> Buscar(int id)
    {
        return context.Usuarios
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.IdUsuario == id);
    }

    public async Task<bool> Eliminar(int id)
    {
        var usuario = await context.Usuarios.FindAsync(id);
        if (usuario is null)
        {
            return false;
        }

        context.Usuarios.Remove(usuario);
        var cantidad = await context.SaveChangesAsync();

        return cantidad > 0;
    }

    public async Task<List<Usuario>> GetList(Expression<Func<Usuario, bool>> criterio)
    {
        return await context.Usuarios
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Insertar(Usuario usuario)
    {
        context.Usuarios.Add(usuario);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Usuario usuario)
    {
        if (!await Existe(usuario.IdUsuario))
            return await Insertar(usuario);
        else
            return await Modificar(usuario);
    }

    public Task<bool> Existe(int id)
    {
        return context.Usuarios.AnyAsync(u => u.IdUsuario == id);
    }

    public async Task<bool> Modificar(Usuario usuario)
    {
        context.Usuarios.Update(usuario);
        return await context.SaveChangesAsync() > 0;
    }
}
