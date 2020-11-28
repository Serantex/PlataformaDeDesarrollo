using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.model;

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

        public async Task<List<Detalle>> GetAll(int Id)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");

            return await remoteService.GetAllDetalles(Id);
        }

        public async Task<Detalle> Get(int id)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");
            return await remoteService.GetDetalle(id);
        }


        public async Task<Detalle> Save(Detalle value)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");

            if (value.id == 0)
            {
                await remoteService.CreateDetalle(value);
            }
            else
            {
                await remoteService.EditDetalle(value);
            }
            return value;
        }

        public async Task<Detalle> Remove(int id)
        {
            var remoteService = RestService.For<IRemotService>("https://localhost:44362/api");

            return await remoteService.DeleteDetalle(id);
        }




    }
}