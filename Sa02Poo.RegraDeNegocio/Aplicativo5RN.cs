using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.RegraDeNegocio
{
    public class Aplicativo5RN
    {
        public decimal FaturamentoTrimestral(decimal v1,decimal v2, decimal v3)
        {
            decimal media = (v1 + v2 + v3) / 3;

            return media;
        }


    }
}
