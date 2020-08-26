using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            string respuesta = "";
            
            while(respuesta!="calecita" && intentos<3)
            {
                Console.Write("Vas en un avion. Delante tienes un caballo y detras un Camion. ¿Donde estas?");

                respuesta = Console.ReadLine();

                intentos++;

                if (respuesta != "calecita")
                {
                    if (intentos == 3)
                    {
                        Console.Write("PERDISTE");
                        break;
                    }
                    Console.Write("ups intenta otra vez\n");
                }
                else
                {
                    Console.Write("correcto");
                    break;
                }

 


            }


        }
    }
}
