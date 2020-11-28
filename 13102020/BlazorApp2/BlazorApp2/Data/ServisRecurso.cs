using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.model;

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
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");
            return await remoteService.GetRecurso(id);
        }


        public async Task<List<Recurso>> GetAll()
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");

            return await remoteService.GetAllRecursos();
        }

        public async Task<Recurso> Save(Recurso value)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");

            if (value.id == 0)
            {
                await remoteService.CreateRecurso(value);
            }
            else
            {
                await remoteService.EditRecurso(value);
            }
            return value;
        }


        public async Task<Recurso> Remove(int id)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");

            return await remoteService.DeleteRecurso(id);
        }


        public async Task<List<Usuario>> GetUsuarios()
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");

            return await remoteService.GetAllUsuarios();
        }

    }
}