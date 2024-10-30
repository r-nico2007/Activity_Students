using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_
{
    internal class Estudiantes
    {
        public int Creditos { get; set; }
        public int Estrato { get; set; }
        public double ValorCredito { get; set; }

        public Estudiantes(int creditos, int estrato, double valorCredito)
        {
            Creditos = creditos;
            Estrato = estrato;
            ValorCredito = valorCredito;
        }
    }
}
