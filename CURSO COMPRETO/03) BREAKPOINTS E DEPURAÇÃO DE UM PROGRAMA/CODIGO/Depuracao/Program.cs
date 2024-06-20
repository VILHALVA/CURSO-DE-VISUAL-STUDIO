using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depuracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            double num1 = randomGenerator.NextDouble();
            double num2 = randomGenerator.NextDouble();
            Console.WriteLine("Numero 1 = " + num1);
            Console.WriteLine("Numero 2 = " + num2);

            CalcularOperaciones(num1, num2);
            Console.ReadLine();
        }

        static void CalcularOperaciones(double num1, double num2)
        {
            double resultadoSuma = SumarNumeros(num1, num2);
            double resultadoDivision = DividirNumeros(num1, num2);

            MultiplicarNumeros();
        }

        static double SumarNumeros(double num1, double num2)
        {
            double resultado = num1 + num2;
            Console.WriteLine("Resultado da Soma = " + resultado);
            return resultado;
        }

        static double DividirNumeros(double num1, double num2)
        {
            double resultado = num1 / num2;
            Console.WriteLine("Resultado da divisão = " + resultado);
            return resultado;
        }

        static void MultiplicarNumeros()
        {
            try
            {
                Random randomGenerator = new Random();
                // Random randomGenerator = null;
                double numMult1 = randomGenerator.NextDouble();
                double numMult2 = randomGenerator.NextDouble();
                double resultado = numMult1 * numMult2;
                Console.WriteLine("Resultado da Multiplicação = " + resultado);
            }
            catch
            {
                Console.WriteLine("OCORREU UM ERRO NA MULTIPLICAÇÃO!");
            }
           
        }
    }
}

