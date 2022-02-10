using System;

namespace Atividade2Questao3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Peso: ");
            string strPeso = Console.ReadLine();
            double Peso = Convert.ToDouble(strPeso);

            Console.WriteLine("Digite sua Altura: ");
            string strAltura = Console.ReadLine();
            double Altura = Convert.ToDouble(strAltura);

            double imc = Peso / Math.Pow(Altura, 2);            //PERGUNTAR PRO TIAGO

            if (imc < 18.5)
                Console.WriteLine("Abaixo do Peso");

            else if (imc > 18.5 && imc <= 25)
                Console.WriteLine("Peso Normal");

            else if (imc > 25 && imc < 30)
                Console.WriteLine("Acima do Peso");

            else if (imc > 30)
                Console.WriteLine("Obeso");

            Console.ReadLine();


        }
    }
}
