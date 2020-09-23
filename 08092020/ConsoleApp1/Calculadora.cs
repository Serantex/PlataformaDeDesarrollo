using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;
namespace ConsoleApp1
{
    public class Calculadora
    {
        private int numero;
        private int numero2;

      //  public Calculadora(int a, int b)
      //  {
      //  numero = a;
      //  numero2 = b;
     // }
        public int numero1
        {
            get
            { 
                return numero;
            }
            set
            {
                numero = value;
            }
        }


        /// <summary>
        /// metodo que suma 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public int suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        /// <summary>
        /// metodo que resta
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public int resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        /// <summary>
        /// metodo que multiplica
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public int multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        /// <summary>
        /// metodo que divide
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public float dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }
}
