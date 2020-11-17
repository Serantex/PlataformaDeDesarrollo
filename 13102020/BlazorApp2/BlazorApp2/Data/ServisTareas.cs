using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class ServisTarea
    {
        public Tarea[] GetTareas()
        {
            var bd = new TareasDB();

            var list = bd.Tareas.ToArray();

            return list;
        }




        private TareasDB context;

        public ServisTarea(TareasDB _context)
        {
            context = _context;
        }

        public async Task<Tarea> Get(int id)
        {
            return await context.Tareas.Where(i => i.id == id).SingleAsync();
        }

        public async Task<List<Tarea>> GetAll()
        {
            return await context.Tareas.ToListAsync();
        }

        public async Task<Tarea> Save(Tarea value)
        {
            if (value.id == 0)
            {
                await context.Tareas.AddAsync(value);
            }
            else
            {
                context.Tareas.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Tareas.Where(i => i.id == id).SingleAsync();
            context.Tareas.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Recurso>> GetRecursos()
        {
            return await context.Recursos.ToListAsync();
        }


    }
}