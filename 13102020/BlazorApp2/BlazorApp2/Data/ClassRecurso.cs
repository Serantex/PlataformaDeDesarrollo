using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class Recurso
    {
        public Recurso() { }
        public Recurso(int Id, string Nombre, Usuario Usuario)
        {
            this.id = Id;
            this.nombre = Nombre;
            this.usuario = Usuario;
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public Usuario usuario { get; set; }
        public int UsuarioId { get; set; }
    }

}
