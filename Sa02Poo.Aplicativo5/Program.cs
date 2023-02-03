using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal jan=0, fev=0, mar=0;


            do
            {

                Console.WriteLine("Digite o valor do mes de JANEIRO ");
                jan = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor do mes de FEVEREIRO ");
                fev = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor do mes de MARÇO ");
                mar = decimal.Parse(Console.ReadLine());
                if (jan <= 0 || fev <= 0 || mar <= 0)
                {
                    
                    Console.Clear();
                    Console.WriteLine("Digite um numero VALIDO ");

                }
            }
            while (jan <= 0 || fev <= 0 || mar<=0);

            Aplicativo5RN app5 = new Aplicativo5RN();

            Console.Write("Faturamento total do primeiro trimestre é: R$");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(app5.FaturamentoTrimestral(jan, fev, mar));
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
