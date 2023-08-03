using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnline.Entidades
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public int NombreLocalidad { get; set; }
        public Provincia Provincia { get; set; }
    }
}
