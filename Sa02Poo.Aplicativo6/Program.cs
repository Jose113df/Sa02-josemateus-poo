using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal precoUnitario, qtdeFrota;

            Console.WriteLine("digite a quantidade da sua frota: ");
            qtdeFrota= decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço unitario dos Aviões");
            precoUnitario=decimal.Parse(Console.ReadLine());

            Aplicativo6RN app6= new Aplicativo6RN();

            Console.Write("O preço total é ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(app6.calculo(precoUnitario, qtdeFrota));
            Console.ResetColor();
            Console.ReadLine();
               



        }
    }
}
