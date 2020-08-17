using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio para ejemplo
            //Ambos objetos implementan la misma intefaz
            //pero el nuevo encapsula el paso de modalidad actual a modalidad nueva.
            IActual calculadoraActual = new Actual();
            Console.WriteLine(calculadoraActual.sumar(1, 2));

            IActual calculadoraNueva = new Adaptador();
            Console.WriteLine(calculadoraNueva.sumar(5, 6));
        }
    }
}
