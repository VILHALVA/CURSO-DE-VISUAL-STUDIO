using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE A BASE DO TRIÂNGULO: ");
            string baseTriangulo = Console.ReadLine();

            Console.WriteLine("DIGITE A ALTURA DO TRIÂNGULO: ");
            string alturaTriangulo = Console.ReadLine();

            double baseTrianguloNumero = Convert.ToDouble(baseTriangulo);
            double alturaTrianguloNumero = Convert.ToDouble(alturaTriangulo);

            double areaTriangulo = (baseTrianguloNumero * alturaTrianguloNumero / 2);

            Console.WriteLine("A ÁREA DO TRIÂNGULO É " + areaTriangulo);

            Console.Read();

        }
    }
}
