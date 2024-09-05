/* 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
   • SP – R$67.836,43
   • RJ – R$36.678,66
   • MG – R$29.229,88
   • ES – R$27.165,48
   • Outros – R$19.849,53
   Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.  
 */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double faturamentoSP = 67836.43;
            double faturamentoRJ = 36678.66;
            double faturamentoMG = 29229.88;
            double faturamentoES = 27165.48;
            double faturamentoOutros = 19849.53;

            double faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;
            Console.WriteLine("Faturamento total: " + faturamentoTotal.ToString("F2", CultureInfo.InvariantCulture));

            double percentualSP = (faturamentoSP / faturamentoTotal) * 100.00;
            Console.WriteLine("Percentual SP: " + percentualSP.ToString("F2", CultureInfo.InvariantCulture) + "%");

            double percentualRJ = (faturamentoRJ / faturamentoTotal) * 100.00;
            Console.WriteLine("Percentual RJ: " + percentualRJ.ToString("F2", CultureInfo.InvariantCulture) + "%");

            double percentualMG = (faturamentoMG / faturamentoTotal) * 100.00;
            Console.WriteLine("Percentual MG: " + percentualMG.ToString("F2", CultureInfo.InvariantCulture) + "%");

            double percentualES = (faturamentoES / faturamentoTotal) * 100.00;
            Console.WriteLine("Percentual ES: " + percentualES.ToString("F2", CultureInfo.InvariantCulture) + "%");

            double percentualOutros = (faturamentoOutros / faturamentoTotal) * 100.00;
            Console.WriteLine("Percentual Outros: " + percentualOutros.ToString("F2", CultureInfo.InvariantCulture) + "%");

        }
    }
}
