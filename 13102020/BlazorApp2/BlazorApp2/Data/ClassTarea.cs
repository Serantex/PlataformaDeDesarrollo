using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{

    public class Tarea
    {
        public Tarea() { }
        public Tarea(int Id, string Titulo, DateTime Vencimiento, DateTime Estimacion, Recurso Responsable, bool Estado)
        {
            this.id = Id;
            this.titulo = Titulo;
            this.vencimiento = Vencimiento;
            this.estimacion = Estimacion;
            this.responsable = Responsable;
            this.estado = Estado;
        }

        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime vencimiento { get; set; }
        public DateTime estimacion { get; set; }
        public Recurso responsable { get; set; }
        public int responsableId { get; set; }
        public bool estado { get; set; }


    }
}