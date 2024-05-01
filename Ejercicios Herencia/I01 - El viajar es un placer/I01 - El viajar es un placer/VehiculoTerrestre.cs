using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01___El_viajar_es_un_placer
{
    public class VehiculoTerrestre
    {

        /*
         cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short
         
         */

        protected short cantidadPuertas;
        protected short cantidadRuedas;
        protected string color;

        public VehiculoTerrestre(short cantidadPuertas, short cantidadRuedas, string color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
        }

        public short CantidadPuertas
        {
            get {  return cantidadPuertas;}
        }
        public short CantidadRuedas
        {
            get { return cantidadRuedas; }
        }
        public string Color
        {
            get { return this.color; }
        }
    }
}
