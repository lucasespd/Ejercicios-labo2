namespace I01___El_viajar_es_un_placer
{
    public class Camion: VehiculoTerrestre
    {
        /*
         cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.
         */

        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadPuertas,short cantidadRuedas,string color,short cantidadMarchas,int pesoCarga) :base(cantidadPuertas,cantidadRuedas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        //public Camion(short cantidadRuedas, short cantidadPuertas, string color, short cantidadMarchas, int pesoCarga)
        //{
        //    this.cantidadRuedas = cantidadRuedas;
        //    this.cantidadPuertas = cantidadPuertas;
        //    this.color = color;
        //    this.cantidadMarchas = cantidadMarchas;
        //    this.pesoCarga = pesoCarga;
        //}



    }
}
