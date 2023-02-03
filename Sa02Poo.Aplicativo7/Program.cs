using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string opcao;
            Console.WriteLine("Deseja iniciar o programa? ");
            opcao = Console.ReadLine();
            if (opcao == "n" || opcao == "N")
            {
                Console.WriteLine("Tenha um bom dia :D");
                Console.ReadKey();
            }
            do
            {
                decimal preco1, preco2, preco3, preco4, preco5;
                

                Console.WriteLine("Digite o valor da PRIMEIRA peça: ");
                preco1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da SEGUNDA peça: ");
                preco2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da TERCEIRA peça: ");
                preco3 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da QUARTA peça: ");
                preco4 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da QUINTA peça: ");
                preco5 = decimal.Parse(Console.ReadLine());

                Aplicativo7RN app7 = new Aplicativo7RN();
                Console.Clear();
                Console.Write("Valor total das peças: R$");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(app7.SomaPecas(preco1, preco2, preco3, preco4, preco5));
                Console.ResetColor();
                Console.WriteLine("---------------------------");
                Console.WriteLine("Deseja reiniciar o programa? ");
                opcao=Console.ReadLine();
            }
            while (opcao == "s" || opcao == "S");

        }
    }
}
