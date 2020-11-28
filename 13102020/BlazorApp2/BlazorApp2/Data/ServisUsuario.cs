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
            var remoteService = RestService.For<IRemotService>("https://localhost:44366/api");
            return await remoteService.GetUsuario(id);
        }


        public async Task<List<Usuario>> GetAll()
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44366/api");

            return await remoteService.GetAllUsuarios();
        }

        public async Task<Usuario> Save(Usuario value)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44366/api");

            if (value.id == 0)
            {
                await remoteService.CreateUsuario(value);
            }
            else
            {
                await remoteService.EditUsuario(value);
            }
            return value;
        }


        public async Task<Usuario> Remove(int id)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44366/api");

            return await remoteService.DeleteUsuario(id);
        }
    }
}