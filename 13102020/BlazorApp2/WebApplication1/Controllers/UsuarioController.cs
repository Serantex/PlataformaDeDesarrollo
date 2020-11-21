using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using apiNet.data;
 

namespace apiNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly TareasDB _context;

        public UsuarioController(TareasDB context)
        {
            _context = context;
        }

        [HttpGet]

        public  List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }
    }
}
