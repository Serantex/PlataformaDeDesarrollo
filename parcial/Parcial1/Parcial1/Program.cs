using System;
using System.Collections.Generic;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola");
            Insertar();
        }
        static void Insertar()
        {
            var bd = new TareasDB();


            bd.Usuarios.Add(new Usuario
            {
                id = 222,
                usuario = "lautaro",
                clave = 1234

            });

            bd.SaveChanges();
        }

    }
}
