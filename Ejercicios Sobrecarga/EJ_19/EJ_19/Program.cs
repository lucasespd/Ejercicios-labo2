using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sumador sumadorUno = new Sumador();
            Sumador sumadorDos = new Sumador(3);

            Console.WriteLine("El resultado de la suma es {0}", sumadorUno.Sumar(55,2));
            Console.WriteLine("El resultado de la suma es {0}", sumadorDos.Sumar("5", "8"));
            Console.WriteLine("La conversion es {0}", (int)sumadorDos);
            Console.WriteLine("La cantidad de sumas entre los 2 es {0}", sumadorUno + sumadorDos);
            Console.WriteLine("Ambos tienen la misma cantidad de sumas? {0}", (sumadorUno | sumadorDos));





            Console.ReadKey();

        }
    }
}
