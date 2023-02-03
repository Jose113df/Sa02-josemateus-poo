using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoAtual;
            Console.WriteLine("Qual o ano atual? ");
            anoAtual = int.Parse(Console.ReadLine());
            Aplicativo2RN app2 = new Aplicativo2RN();

            Console.WriteLine("O resultado da subtração é "+app2.Subtracao(anoAtual));
            Console.ReadKey();
        }
    }
}
