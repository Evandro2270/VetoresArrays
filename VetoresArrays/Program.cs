using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                string[] nomes = { "Maria", "Jose", "Ana" };
                double[] valores = { 145.00 , 165.00, 175.00};

                for (int i = 0; i < nomes.Length; i++) {
                    Console.WriteLine(nomes[i]);
                }
                
                Console.WriteLine();
                for (int i = 0; i < valores.Length; i++)
                {
                    Console.WriteLine(valores[i]);
                }

            }
        }
    }
}