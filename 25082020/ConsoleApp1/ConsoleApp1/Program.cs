using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CalculadoraCientifica calcu = new CalculadoraCientifica();
            calcu.numero1 = 10;

            calcu.suma(2, 3);
            Console.WriteLine("suma "+ calcu.suma(3, 3));
            Console.WriteLine("resta " + calcu.resta(3, 3));
            Console.WriteLine("multiplicar " + calcu.multiplicar(3, 3));
            Console.WriteLine("dividir " + calcu.dividir(3, 3));
            Console.WriteLine("potencia " + calcu.potencia(2, 3));
        }
    }
}
