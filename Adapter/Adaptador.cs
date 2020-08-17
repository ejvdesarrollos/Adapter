using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adaptador : IActual
    {
        Nueva oNuevo = new Nueva();

        //Implemento la interfaz Vigente
        //Creo internamente una instancia del nuevo objeto
        //Encapsulo el paso del actual al nuevo
        public int sumar(int a, int b)
        {
            int[] valores = { a, b };
            return (int)oNuevo.suma(valores);
        }
    }
}
