using Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O PRIMEIRO NÚMERO: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("DIGITE O SEGUNDO NÚMERO: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double soma = Operacoes.Somar(numero1, numero2);
            double resta = Operacoes.Restart(numero1, numero2);

            Console.WriteLine("RESULTADO DA SOMA "+ soma);
            Console.WriteLine("RESULTADO DO RESTO "+ resta);

            Console.WriteLine();
        }
    }
}
