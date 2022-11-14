using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner2
{
    internal class Rechnen : IRechner
    {
        public double Divide(double zahl1, double zahl2)
        {
            return zahl1 / zahl2;
        }

        public double Minus(double zahl1, double zahl2)
        {
            return zahl1 - zahl2;
        }

        public double Multiple(double zahl1, double zahl2)
        {
            return zahl1 * zahl2;
        }

        public double Plus(double zahl1, double zahl2)
        {
            return zahl1 + zahl2;
        }
    }
}
