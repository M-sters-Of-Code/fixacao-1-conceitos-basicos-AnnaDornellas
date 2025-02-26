using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            
            double valorDiario = 95;
            double valorPorKm = 0.35;
            int quilometragemUsada = quilometragemFinal - quilometragemInicial;

            
            return (dias * valorDiario) + (quilometragemUsada * valorPorKm);
        }
    }
}
