using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.model
{
    public class Detalle
    {

        public Detalle() { }
        public Detalle(int Id, DateTime Fecha, DateTime Tiempo, Recurso Recurso, Tarea Tarea)
        {
            this.id = Id;
            this.fecha = Fecha;
            this.tiempo = Tiempo;
            this.Recurso = Recurso;
            this.Tarea = Tarea;
        }

        public int id { get; set; }
        public DateTime fecha { get; set; }

        public DateTime tiempo { get; set; }

        public int RecursoId { get; set; }

        public Recurso Recurso { get; set; }

        public Tarea Tarea { get; set; }

        public int TareaId { get; set; }

    }
}
