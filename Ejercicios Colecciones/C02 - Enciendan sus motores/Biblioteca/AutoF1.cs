using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1
    {
        private static short cantidadCombustible;
        private static bool enCompetencia;
        private string escuderia;
        private short numero;
        private static short vueltasRestantes;

        static AutoF1()
        {
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
        }

        public AutoF1(short numero,string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        //prop
        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }
        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set {  enCompetencia = value; }
        }
        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set {  vueltasRestantes = value;}
        }

        //sobrecargas

        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        public static bool operator !=(AutoF1 a1,AutoF1 a2)
        {
            return !(a1 == a2);
        }

        //metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"En competencia?: {this.EnCompetencia}");
            sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");
            sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");

            return sb.ToString();
        }
    }
}
