using Microsoft.EntityFrameworkCore;
using System;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.model;

namespace BlazorApp2.Data
{
    public class ServisTarea
    {

        private TareasDB context;

        public ServisTarea(TareasDB _context)
        {
            context = _context;
        }

        public async Task<List<Tarea>> GetAll()
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");

            return await remoteService.GetAllTareas();
        }

        public async Task<Tarea> Get(int id)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");
            return await remoteService.GetTarea(id);
        }


        public async Task<Tarea> Save(Tarea value)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");

            if (value.id == 0)
            {
                await remoteService.CreateTarea(value);
            }
            else
            {
                await remoteService.EditTarea(value);
            }
            return value;
        }


        public async Task<Tarea> Remove(int id)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");

            return await remoteService.DeleteTarea(id);
        }

    }
}