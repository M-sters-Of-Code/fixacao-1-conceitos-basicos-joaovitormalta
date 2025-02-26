using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAumento
    {
        public static double Calcular(double salario, double percentualAumento)
        {
            double valorAumento = percentualAumento / 100;
            double novoSalario = salario * valorAumento;
            return novoSalario;
        }
    }
}
