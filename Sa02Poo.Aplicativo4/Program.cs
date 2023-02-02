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
            int valor = 5000;
            Aplicativo4RN app4= new Aplicativo4RN();

            Console.WriteLine("Valor para cada cliente: "+app4.dividir(valor));
        }
    }
}
