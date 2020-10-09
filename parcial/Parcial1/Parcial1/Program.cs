using System;
using System.Collections.Generic;
using System.Linq;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola");
            //InsertarUsuario();
            //InsertarRecurso(2);
            //InsertarTarea(1);
            //InsertarDetalle(1, 1);
            //ActualizarDetalle(1, 1, 1);
            BorrarUsuario(224);
        }

        static void InsertarUsuario()
        {
            var bd = new TareasDB();


            bd.Usuarios.Add(new Usuario
            {
                usuario = "lautaro",
                clave = 1234
            });

            bd.SaveChanges();
        }

        static void InsertarRecurso(int n)
        {
            var bd = new TareasDB();
            var lista = bd.Usuarios.Where(i => i.id == n).ToList();

            bd.Recursos.Add(new Recurso
            {
                nombre = "lapiz",
                usuario = lista[0]
            });

            bd.SaveChanges();
        }



        static void BorrarUsuario(int n)
        {
            var bd = new TareasDB();
            var user = bd.Usuarios.Where(i => i.id == n).Single();
            bd.Usuarios.Remove(user);
            bd.SaveChanges();
        }

        static void ActualizarDetalle(int d,int r,int t)
        {
            var bd = new TareasDB();
            var detalles = bd.Detalles.Where(i => i.id == d).ToList();
            var recur = bd.Recursos.Where(i => i.id == r).ToList();
            var tare = bd.Tareas.Where(i => i.id == t).ToList();

            detalles[0].fecha = new DateTime(2020, 7, 5);
            detalles[0].tiempo = new DateTime(2020, 10, 6);
            detalles[0].Recurso = recur[0];
            detalles[0].Tarea = tare[0];

            bd.SaveChanges();
        }

        static void InsertarDetalle(int r, int t)
        {
            var bd = new TareasDB();
            var recur = bd.Recursos.Where(i => i.id == r).ToList();
            var tare = bd.Tareas.Where(i => i.id == t).ToList();

            bd.Detalles.Add(new Detalle 
            { 
            fecha = new DateTime(2020, 5, 25),
            tiempo = new DateTime(2020, 6, 25),
            Recurso = recur[0],
            Tarea = tare[0]
        });

            bd.SaveChanges();
        }

        static void InsertarTarea(int r)
        {
            var bd = new TareasDB();
            var recur = bd.Recursos.Where(i => i.id == r).ToList();

            bd.Tareas.Add(new Tarea
            {
                titulo="escribir",
                vencimiento = new DateTime(2020, 5, 25),
                estimacion = new DateTime(2020, 6, 25),
                responsable = recur[0],
                estado = true
            });

            bd.SaveChanges();
        }


    }
}
