﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estilos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        //Sobreescribir el metodo tostring para mostrar la descripcion
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
