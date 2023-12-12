using System;

class Program
{
    static void Main()
    {
        MinhaBiblioteca.Calculadora calculadora = new MinhaBiblioteca.Calculadora();

        int resultadoSoma = calculadora.Somar(5, 3);
        int resultadoSubtracao = calculadora.Subtrair(8, 2);

        Console.WriteLine($"Soma: {resultadoSoma}");
        Console.WriteLine($"Subtração: {resultadoSubtracao}");
    }
}
