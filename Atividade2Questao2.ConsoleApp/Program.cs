//Atividade 2- 2° questao.

using System;

namespace Atividade2Questao2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Digite o Valor A: ");
            string strValorA = Console.ReadLine();
            int valorA = Convert.ToInt32(strValorA);

            Console.WriteLine("Digite o Valor de B: ");
            string strValorB = Console.ReadLine();
            int valorB = Convert.ToInt32(strValorB);

            Console.WriteLine("Digite o Valor de C");
            string strValorC = Console.ReadLine();
            int valorC = Convert.ToInt32(strValorC);

            if (valorA > valorB && valorB > valorC)
                Console.WriteLine($"A Ordem é: [{valorA}], [{valorB}], [{valorC}]");
            else if (valorA > valorB && valorA > valorC && valorC > valorB)
                Console.WriteLine($"A Ordem é: [{valorA}], [{valorC}], [{valorB}]");
            else if (valorB > valorA && valorA > valorC)
                Console.WriteLine($"A Ordem é: [{valorB}], [{valorA}], [{valorC}]");
            else if (valorB > valorA && valorB > valorC && valorC > valorA)
                Console.WriteLine($"A Ordem é: [{valorB}], [{valorC}], [{valorA}]");
            else if (valorC > valorB && valorB > valorA)
                Console.WriteLine($"A Ordem é: [{valorC}], [{valorB}], [{valorA}]");

            Console.ReadLine(); 
            
        }
    }
}
