using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
                multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
                operación que desea realizar (pulsando el caracter +, -, * o /).
                El usuario decidirá cuándo finalizar el programa.


                Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
                a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
                operación matemática. El método devolverá el resultado de la operación.
                b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
                utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
                TRUE si el número es distinto de CERO.
             */


            Console.WriteLine(Calculado.Calcular(5, 5, '+')); 
            Console.WriteLine(Calculado.Calcular(5, 5, '-')); 
            Console.WriteLine(Calculado.Calcular(5, 5, '*')); 
            Console.WriteLine(Calculado.Calcular(5, 5, '/')); 
            Console.WriteLine(Calculado.Calcular(5, 0, '/')); 
            


            Console.ReadKey();
        }
    }
}
