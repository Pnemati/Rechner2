using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner2
{
    internal interface IRechner
    {
        double Plus(double zahl1, double zahl2);
        double Minus(double zahl1, double zahl2);
        double Multiple(double zahl1, double zahl2);
        double Divide(double zahl1, double zahl2);

    }
}
