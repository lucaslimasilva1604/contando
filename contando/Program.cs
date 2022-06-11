using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace contando
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CONTAGEM INTELIGENTE");
            Console.WriteLine("--------------------");

            Console.Write("Inicio: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Fim: ");
            int fim = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine(" C O N T A N D O");
            Console.WriteLine("--------------------");

            if (inicio > fim)
            {
                for (int i = inicio; i >= fim; i--)
                {
                    Console.Write($"{i}.. ");
                }
            }
            else
            {
                for (int i = inicio; i <= fim; i++)
                {
                    Console.Write($"{i}.. ");
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
