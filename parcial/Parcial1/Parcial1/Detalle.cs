using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1
{
   public class Detalle
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }

        public DateTime tiempo { get; set; }

        public Recurso Recurso { get; set; }

        public Tarea Tarea { get; set; }


    }
}
