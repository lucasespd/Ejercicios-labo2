using Biblioteca;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.EFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Bernal", 30, "Mendoza", 2.65f);
            Provincial l4 = new Provincial("Morón", Provincial.EFranja.Franja_1, 21, "Bera");

            
            Console.WriteLine(l1 == l2);
            Console.WriteLine(l1 == l3);
            Console.WriteLine(l2 == l4);
            Console.WriteLine(l3 == l4);

        }
    }
}
