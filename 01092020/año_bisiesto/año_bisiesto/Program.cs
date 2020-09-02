using System;

namespace año_bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "ingrese el año de su nacimiento para saber si es un año bisiesto";
            bool result = false;
            Console.WriteLine(Calcular(mensaje, out result));
            
        }

        static Boolean Calcular(string mensaje, out bool resultado)
        {
            Console.WriteLine(mensaje);
            int anio = int.Parse(Console.ReadLine());
            if(anio%4==0 && anio%100!=0 && anio % 400 != 0)
            {
                resultado= true;
            }
            else
            {
                resultado= false;
            }
            return resultado;
        }


    }
}
