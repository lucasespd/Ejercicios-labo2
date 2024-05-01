using Biblioteca;

namespace C02___Enciendan_sus_motores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AutoF1 a1 = new AutoF1(14, "Ferrari");
            ////AutoF1 a2 = new AutoF1(16, "Ferrari");
            //AutoF1 a3 = new AutoF1(14, "RedBull");
            //AutoF1 a4 = new AutoF1(11, "RedBull");

            //Competencia gp = new Competencia(20, 3);


            //Console.WriteLine(gp+a1);
            ////Console.WriteLine(gp+a2);
            //Console.WriteLine(gp+a3);
            //Console.WriteLine(gp+a4);
            //Console.WriteLine("---------");
            //Console.WriteLine(gp.MostrarDatos());


            ////Console.WriteLine(a1.CantidadCombustible);
            ////Console.WriteLine(a1.EnCompetencia);
            ////Console.WriteLine(a1.VueltasRestantes);
            ////Console.WriteLine("-------");
            ////Console.WriteLine(a1.MostrarDatos());
            ////Console.WriteLine("-------");
            ////Console.WriteLine(a1 == a2);
            ////Console.WriteLine(a1 == a3);
            ///
            AutoF1 a1 = new AutoF1(1, "escu1");
            AutoF1 a2 = new AutoF1(4, "escu2");
            AutoF1 a3 = new AutoF1(5, "escu3");
            AutoF1 a4 = new AutoF1(1, "escu1");
            AutoF1 a5 = new AutoF1(2, "escu4");
            Competencia competencia = new Competencia(5, 10);



            
        }
    }
}
