using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QtdeAvioes = 0;
            do
            {
                
                Console.WriteLine("Digite a quantidade de Aviôes: ");
                QtdeAvioes = int.Parse(Console.ReadLine());
                if (QtdeAvioes<=0)
                {
                    Console.Clear();
                    Console.WriteLine("Digite um numero VALIDO ");
                
                }
            }
            while (QtdeAvioes <= 0);

            Aplicativo3RN app3 = new Aplicativo3RN();

            Console.Write("A quantdade total de asentos é: ");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(app3.MultiplicarAssentos(QtdeAvioes));
            Console.ResetColor();
            Console.ReadLine();

        }
    }
}
