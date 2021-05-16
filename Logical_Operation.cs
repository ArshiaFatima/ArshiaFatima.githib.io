using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Logical_Operation
    {
        public class logic
        {
            public bool AND(bool x, bool y)
            {
                return x & y;
            }
            public bool OR(bool x, bool y)
            {
                return x || y;
            }
            public bool NOR(bool x, bool y)
            {
                return !(x || y);
            }
            public bool XOR(bool x, bool y)
            {
                return x ^ y;
            }
            public bool NOT(bool x, bool y)
            {
                return x != y;
            }
            public bool NAND(bool x, bool y)
            {
                return !(x & y);
            }
            public bool XNOR(bool x, bool y)
            {
                return x == y ;
            }
        }
    }
}
