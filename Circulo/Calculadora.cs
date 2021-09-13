using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class Calculadora
    {

        // valor fixo do Pi
        public static double Pi = 3.14;

        // calculo da Circunferencia
        public static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        // calculo do Volume
        public static double Volume(double r)
        {

            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
