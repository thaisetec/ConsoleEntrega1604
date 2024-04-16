using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntrega1604
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valor = 100;
            double total = 0;
            int meio = 0;
            int inteiro = 0;
            for (int ing = 1; ing <= 30; ing++)
            {
                Console.WriteLine("Possuí comprovante de estudante: 1(sim)/2(não)");
                int cert = int.Parse(Console.ReadLine());
                if (ing <= 10 && cert == 1)
                {
                    valor = valor / 2;
                    meio++;
                }
                else if (ing <= 20 && cert == 1)
                {
                    meio++;
                   valor = (valor * 1.5) / 2;
                }
                else if (ing <= 30 && cert == 1)
                {
                    meio++;
                    valor = (valor * 3) / 2;
                }
                if (ing <= 10 && cert == 2)
                {
                    inteiro++;
                    valor = valor;
                }
                total += valor;
            }
            Console.WriteLine("O total foi de " + total);
            Console.WriteLine(" quantidade de ingressos inteiros" + inteiro);
            Console.WriteLine("quantidade de ingressos meio" + meio);
        }
    }
}
