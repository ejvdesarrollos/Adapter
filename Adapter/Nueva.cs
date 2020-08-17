using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Nueva
    {
        public double suma (int[] valores)
        {
            double resultado = 0;
            foreach(int valor in valores)
            {
                resultado += valor;
            }

            return resultado;
        }
    }
}
