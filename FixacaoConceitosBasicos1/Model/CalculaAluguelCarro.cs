using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {
        public static int Calcular(int dias, int KmInicial, int KmFinal)
        {
            int aluguelDiario = dias * 95;
            int KmPercorrido = ((KmFinal - KmInicial) * 35) / 100;
            int valorFinal = aluguelDiario + KmPercorrido;
            return valorFinal;
        }
    }
}
