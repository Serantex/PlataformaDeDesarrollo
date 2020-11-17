using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(int Id, string User, int Clave)
        {
            this.id = Id;
            this.usuario = User;
            this.clave = Clave;
        }

        public int id { get; set; }

        public string usuario { get; set; }

        public int clave { get; set; }

    }
}