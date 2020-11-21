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

    }
}
