using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESA UN NUMERO SI EL NUMERO ES EL MISMO QUE EL NUMERO SECRETO PODES ESCAPAR DE LATINOAMERICA (eliga un numero del 1 al 13)");

            Random random = new Random();
            int secreto = random.Next(13)+1;
            int intentos = 0;
            int numero = 0;

              
            while(numero != secreto && intentos<3)
            {
                numero = int.Parse(Console.ReadLine());

                intentos++;

                if (numero != secreto) 
                {
                    if (intentos == 3)
                    {
                        Console.Write("PERDISTE el numero correcto era "+secreto);
                        break;
                    }
                    Console.Write("ups intenta otra vez\n");
                }
                else
                {
                    Console.Write("correcto lograste escapar de latinoamerica");
                    break;
                }
            }


        }
    }
}
