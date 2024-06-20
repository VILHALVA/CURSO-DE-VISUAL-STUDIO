using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE A PRIMEIRA STRING:");
            string PrimeiraString = Console.ReadLine();

            Console.WriteLine("DIGITE A SEGUNDA STRING:");
            String SegundaStrig = Console.ReadLine();

            String resultado = PrimeiraString + " " + SegundaStrig;

            Console.WriteLine(resultado);

            Console.Read();
        }
    }
}
