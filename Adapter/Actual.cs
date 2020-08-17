using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Actual : IActual
    {
        public int sumar(int a, int b)
        {
            return a + b;
        }
    }
}
