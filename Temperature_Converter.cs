using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Temperature_Converter
    {
        public double cel(double f)
        {
            return (5.0 / 9.0) * (f - 32.0);
        }
        public double feh(double c)
        {
            return (c * 9) / 5 + 32;
        }

    }
}
