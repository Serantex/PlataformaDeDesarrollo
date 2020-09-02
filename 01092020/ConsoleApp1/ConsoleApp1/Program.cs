using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje="INGRESA UN NUMERO SI EL NUMERO ES EL MISMO QUE EL NUMERO SECRETO PODES ESCAPAR DE LATINOAMERICA (eliga un numero del 1 al 13)";

            Random random = new Random();
            int secreto = random.Next(12)+1;
            int intentos = 0;
            int numero = 0;

              
            while(numero != secreto && intentos<3)
            {

                intentos++;
                numero=Ingreso(mensaje);
                if (numero != secreto) 
                {
                    if (intentos == 3)
                    {
                         Perdiste(secreto);
                        break;
                    }
                   mensaje="ups intenta otra vez\n";
                }
                else
                {
                    Ganaste();
                    break;
                }
            }

        }
        static int Ingreso(string text)
        {
            Console.WriteLine(text);
            return int.Parse(Console.ReadLine());
        }


        static void Ganaste()
        {
            Console.WriteLine("correcto lograste escapar de latinoamerica");

        }

        static void Perdiste(int secret)
        {
            Console.WriteLine("PERDISTE el numero correcto era " + secret);


        }
    }
}
