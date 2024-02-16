﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
                dos grupos de números, cuyas sumas son iguales.
                El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
                cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
                49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
                Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
                usuario ingrese por consola.
                Nota: Utilizar estructuras repetitivas y selectivas.*/

            Console.WriteLine("ingrese un número: ");
            int numero;
            int acumanterior = 0;
            int acumposterior = 0;
            int contadorcentro = 0;
            int.TryParse(Console.ReadLine(), out numero);



            for (int x = 1; x < numero; x++)
            {
                acumanterior = 0;
                acumposterior = 0;

                for (int i = 1; i < x; i++)
                {
                    acumanterior += i;
                }
                for (int y = x + 1; y <= numero; y++)
                {
                    acumposterior += y;
                }

                if (acumanterior == acumposterior)
                {
                    contadorcentro++;
                }

            }

            Console.WriteLine(contadorcentro);







            Console.ReadKey();

        }
        
    }
}
