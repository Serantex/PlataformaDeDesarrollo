using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiNet.data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConsoleApp1.model;

namespace apiNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly TareasDB _context;

        public TareaController(TareasDB context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Tarea> GetAllTareas()
        {
            return _context.Tareas.ToList();
        }


        [HttpGet("{id}")]

        public Tarea GetTarea(int id)
        {
            Tarea tarea = _context.Tareas.Where(i => i.id == id).SingleOrDefault();
            return tarea;
        }

        [HttpPut]
        public Tarea EditTarea(Tarea value)
        {
            Tarea editar = _context.Tareas.Find(value.id);
            editar.titulo = value.titulo;
            editar.vencimiento = value.vencimiento;
            editar.estimacion = value.estimacion;
            editar.responsableId = value.responsableId;
            editar.estado = value.estado;
            _context.SaveChanges();
            return value;
        }

        [HttpPost]
        public Tarea CreateTarea(Tarea value)
        {
            _context.Tareas.Add(value);
            _context.SaveChanges();
            return value;
        }


        [HttpDelete("{id}")]
        public Tarea DeleteTarea(int id)
        {
            Tarea tareaborrar = _context.Tareas.Find(id);
            _context.Tareas.Remove(tareaborrar);
            _context.SaveChanges();
            return tareaborrar;
        }
    }
}
