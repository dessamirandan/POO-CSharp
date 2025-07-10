using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    public class Conversor
    {
        public static double iof = 6.00;
        public static double DolarParaReal(double quantia, double cotacao) { double total = quantia * cotacao;
        return total + total * iof / 100.0;
        }

    }
}