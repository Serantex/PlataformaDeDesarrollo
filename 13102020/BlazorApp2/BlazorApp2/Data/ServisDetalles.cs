using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class ServisDetalle
    {
        public Detalle[] GetDatalles()
        {
            var bd = new TareasDB();

            var list = bd.Detalle.ToArray();

            return list;

        }


        private TareasDB context;

        public ServisDetalle(TareasDB _context)
        {
            context = _context;
        }

        public async Task<Detalle> Get(int id)
        {
            return await context.Detalle.Where(i => i.id == id).SingleAsync();
        }

        public async Task<List<Detalle>> GetAll()
        {
            return await context.Detalle.ToListAsync();
        }

        public async Task<Detalle> Save(Detalle value)
        {
            if (value.id == 0)
            {
                await context.Detalle.AddAsync(value);
            }
            else
            {
                context.Detalle.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<List<Recurso>> GetRecurso()
        {
            return await context.Recursos.ToListAsync();
        }


        public async Task<List<Tarea>> GetTarea()
        {
            return await context.Tareas.ToListAsync();
        }


        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Detalle.Where(i => i.id == id).SingleAsync();
            context.Detalle.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }


    }
}