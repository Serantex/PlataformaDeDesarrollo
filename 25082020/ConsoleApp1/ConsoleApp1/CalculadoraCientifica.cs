using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    public class CalculadoraCientifica : Calculadora{


        public double potencia(int num1, int num2)
        {
            return Math.Pow(num1, num2);
        }



    }
}
