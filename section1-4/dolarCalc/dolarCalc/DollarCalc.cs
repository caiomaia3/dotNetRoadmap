using System;
using System.Collections.Generic;
using System.Text;

namespace dolarCalc
{
    static class DollarCalc
    {
        static double IOF = 6;

        public static double Converter2Reais(double cotacaoDolar, double baseDeCalculo)
        {
            double valorDoIOF = baseDeCalculo * IOF / 100;
            double valorReais = (baseDeCalculo + valorDoIOF)*cotacaoDolar;

            return valorReais;
        }

    }
}
