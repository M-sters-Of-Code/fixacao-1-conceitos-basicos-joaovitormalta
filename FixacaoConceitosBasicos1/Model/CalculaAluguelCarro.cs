using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int KmInicial, int KmFinal)
        {
            int aluguelDiario = dias * 95;
            double KmPercorrido = (KmFinal - KmInicial) * 0.35 ;
            double valorFinal = aluguelDiario + KmPercorrido;
            return valorFinal;
        }
    }
}
