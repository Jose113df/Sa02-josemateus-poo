using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 5000;
            Console.WriteLine("Temos R$5000 e vamos dividir para 10 clientes! ");
            Aplicativo4RN app4 = new Aplicativo4RN();

            Console.Write("Valor para cada cliente: R$");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(+app4.Dividir(valor));
            Console.ResetColor();
            Console.ReadKey();  
        }
    }
}
