using System;

namespace Atividade2Questao5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor A: ");
            string strValorA = Console.ReadLine();
            int valorA = Convert.ToInt32(strValorA);

            Console.WriteLine("Digite o Valor B: ");
            String strValorB = Console.ReadLine();
            int valorB = Convert.ToInt32(strValorB);

            int valorC;

            if (valorA == valorB)
                valorC = valorA + valorB;
            else 
                valorC= valorA * valorB;

            Console.WriteLine($"O Valor de C é {valorC} ");
            Console.ReadLine();
        }
    }
}
