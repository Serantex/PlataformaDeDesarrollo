using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial1
{
    public class Usuario
    {

        public Usuario() {}

        [Key]
        public int id { get; set; }

        public string usuario { get; set; }

        public int clave { get; set; }


    }
}
