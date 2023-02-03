using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal aviao1 = 0, aviao2 = 0;
            do
            {

                Console.WriteLine("Digite ovalor do PRIMEIRO avião ");
                aviao1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite ovalor do SEGUNDO avião ");
                aviao2 = decimal.Parse(Console.ReadLine());

                if (aviao1 <= 0||aviao2<=0)
                {
                    Console.Clear();
                    Console.WriteLine("Digite um numero VALIDO ");

                }
            }
            while (aviao1 <= 0 || aviao2 <= 0);

            Aplicativo1RN app1= new Aplicativo1RN();
            Console.Write("O valor total da soma dos Aviões são: ");
            Console.ForegroundColor= ConsoleColor.Green;   
            Console.WriteLine(app1.SomarValor(aviao1,aviao2));
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
