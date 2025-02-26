using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaDesconto
    {
        public static double Calcular(double valor, double percentualDesconto)
        {
            double valorDesconto = percentualDesconto / 100;
            double valorComDesconto = valor * valorDesconto;
            return valorComDesconto;
        }
    }
}
