using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.model;


namespace BlazorApp2.Data
{
    public class ServisUsuario
    {
        public Usuario[] GetUsuarios()
        {
            var bd = new TareasDB();

            var list = bd.Usuarios.ToArray();

            return list;

        }


        private TareasDB context;

        public ServisUsuario(TareasDB _context)
        {
            context = _context;
        }

        public async Task<Usuario> Get(int id)
        {
            return await context.Usuarios.Where(i => i.id == id).SingleAsync();
        }

        public async Task<List<Usuario>> GetAll()
        {
            var remoteService = RestService.For<IRemotService>("http://localhost:44362/apiNet");
            return await remoteService.GetAllUsuarios();
        }

        public async Task<Usuario> Save(Usuario value)
        {
            if (value.id == 0)
            {
                await context.Usuarios.AddAsync(value);
            }
            else
            {
                context.Usuarios.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Usuarios.Where(i => i.id == id).SingleAsync();
            context.Usuarios.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }


        public async Task<List<Usuario>> GetRoles()
        {
            return await context.Usuarios.ToListAsync();
        }
    }
}