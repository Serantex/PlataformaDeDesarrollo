using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1
{
    public class Tarea
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime vencimiento { get; set; }
        public DateTime estimacion { get; set; }
        public Recurso responsable { get; set; }
        public bool estado { get; set; }


    }
}
