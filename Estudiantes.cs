using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public void CalcularCostoMatricula()
        {
            double costo = 0;
            if (Creditos <= 20)
            {

                costo = Creditos * ValorCredito;

            }
            else
            {

                costo = (20 * ValorCredito) + ((Creditos - 20) * ValorCredito * 2);

            }

            double descuento = 0;
            if (Estrato == 1)
            {
                descuento = 0.80;
            }
            else if (Estrato == 2)
            {
                descuento = 0.50;
            }
            else if (Estrato == 3)
            {
                descuento = 0.30;
            }
            return costo * (1 - descuento);
        }
    }
}
