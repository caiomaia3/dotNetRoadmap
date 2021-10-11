using System;
using System.Collections.Generic;
using System.Text;

namespace notasAluno
{
    class NotasAluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

    }
}
