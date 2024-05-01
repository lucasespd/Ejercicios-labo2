using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01___El_viajar_es_un_placer
{
    public class Moto: VehiculoTerrestre
    {
        /*
         cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
         */

        private short cilindrada;

        public Moto(short cantidadPuertas,short cantidadRuedas,string color,short cilindrada)
            :base(cantidadPuertas,cantidadRuedas,color)
        {
            this.cilindrada = cilindrada;
        }

        //public Moto(short cantidadRuedas, short cantidadPuertas, string color, short cilindrada)
        //{
        //    this.cantidadRuedas = cantidadRuedas;
        //    this.cantidadPuertas = cantidadPuertas;
        //    this.color = color;
        //    this.cilindrada = cilindrada;
        //}
    }
}
