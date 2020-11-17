using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class ServisRecurso
    {

        public Recurso[] GetRecursos()
        {
            var bd = new TareasDB();

            var list = bd.Recursos.ToArray();

            return list;

        }



        private TareasDB context;

        public ServisRecurso(TareasDB _context)
        {
            context = _context;
        }

        public async Task<Recurso> Get(int id)
        {
            return await context.Recursos.Where(i => i.id == id).SingleAsync();
        }

        public async Task<List<Recurso>> GetAll()
        {
            return await context.Recursos.ToListAsync();
        }

        public async Task<Recurso> Save(Recurso value)
        {
            if (value.id == 0)
            {
                await context.Recursos.AddAsync(value);
            }
            else
            {
                context.Recursos.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Recursos.Where(i => i.id == id).SingleAsync();
            context.Recursos.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            return await context.Usuarios.ToListAsync();
        }

    }
}