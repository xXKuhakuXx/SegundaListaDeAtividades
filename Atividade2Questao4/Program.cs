using System;

namespace Atividade2Questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um Número: ");
            string strNumero = Console.ReadLine();
            double numero = Convert.ToDouble(strNumero);

            if (numero % 2 == 0)                        //PERGUNTAR PRO TIAGO
                Console.WriteLine("O Número é Par");
            else
                Console.WriteLine("O Número é Impar");

            Console.ReadLine();
        }
    }
}
