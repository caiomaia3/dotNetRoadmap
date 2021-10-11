using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercise4_worker
{
    class Worker
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double percentual)
        {
            Console.Write("Dados atualizados:");
            Console.WriteLine(Nome + Nome + ", $ " +
                    (percentual * SalarioBruto/100 + SalarioLiquido()).ToString("F2", CultureInfo.InvariantCulture) + ".");
        }
        public override string ToString()
        {
            return Nome + ", $ " +
                    (SalarioBruto - Imposto).ToString("F2",CultureInfo.InvariantCulture)+ ".";
        }
    }
}
