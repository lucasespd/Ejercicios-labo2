﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AppJuegos: Aplicacion
    {

        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo,int tamanio) 
            :base(nombre,sistemaOperativo,tamanio)
        {

        }

        //Propiedades
        protected override int Tamanio
        {
            get { return this.tamanioMb; }
        }

    }
}
