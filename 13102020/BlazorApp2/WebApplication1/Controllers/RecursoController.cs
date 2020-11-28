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
    public class RecursoController : ControllerBase
    {
        private readonly TareasDB _context;

        public RecursoController(TareasDB context)
        {
            _context = context;
        }
        [HttpGet]

        public List<Recurso> GetAll()
        {
            return _context.Recursos.ToList();
        }

        [HttpGet("{id}")]

        public Recurso GetRecurso(int id)
        {
            Recurso recurso = _context.Recursos.Where(i => i.id == id).SingleOrDefault();
            return recurso;
        }

        [HttpPut]
        public Recurso EditRecurso(Recurso value)
        {
            Recurso recursoeditar = _context.Recursos.Find(value.id);
            recursoeditar.nombre = value.nombre;
            recursoeditar.UsuarioId = value.UsuarioId;
            _context.SaveChanges();
            return value;
        }

        [HttpPost]
        public Recurso CreateTarea(Recurso value)
        {
            _context.Recursos.Add(value);
            _context.SaveChanges();
            return value;
        }


        [HttpDelete("{id}")]
        public Recurso DeleteRecurso(int id)
        {
            Recurso recursoborrar = _context.Recursos.Find(id);
            _context.Recursos.Remove(recursoborrar);
            _context.SaveChanges();
            return recursoborrar;
        }
    }
}
