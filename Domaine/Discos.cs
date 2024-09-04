using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Domaine
{
    public class Discos
    {
            public string Titulo { get; set; }
            public int CantidadCanciones { get; set; }
            public string UrlImagen { get; set; }
            public Estilos Tipo { get; set; }
            public Seccion Edicion { get; set; }
    }
}
