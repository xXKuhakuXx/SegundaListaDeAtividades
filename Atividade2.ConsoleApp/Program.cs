//Atividade 2- 1° questao.

using System;

namespace Atividade2.ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            Console.Write("Digite o valor de A: ");
            string strValordeA = Console.ReadLine();
            double doubValordeA = Convert.ToDouble(strValordeA);

            Console.Write("Digite o Valor de B: ");
            string strValordeB = Console.ReadLine();
            double doubValordeB = Convert.ToDouble(strValordeB);

            Console.Write("Digite o Valor de C: ");
            string strValordeC = Console.ReadLine();
            double doubValordeC = Convert.ToDouble(strValordeC);


            if (doubValordeA + doubValordeB < doubValordeC)
                Console.WriteLine("'A' mais 'B' é menor que C");

            else if (doubValordeA + doubValordeB > doubValordeC)
                Console.WriteLine("'A' mais 'B' é maior que C");
            else
                Console.WriteLine("O valor de 'A' + 'B' é igual a 'C'");

            Console.ReadLine();



        }

    }
}