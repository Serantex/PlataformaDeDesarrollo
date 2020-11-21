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
    public class DetalleController : ControllerBase
    {
        private readonly TareasDB _context;

        public DetalleController(TareasDB context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Detalle> GetAll()
        {
            return _context.Detalle.ToList();
        }
    }
}
