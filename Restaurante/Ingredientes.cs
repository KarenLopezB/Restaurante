using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Ingredientes
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }

        public Ingredientes() 
        {
            Nombre = "Pendiente";
            Identificador = "Sin asignar";
        }
    }
}
