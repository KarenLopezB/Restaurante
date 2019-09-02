using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Platillos
    {
        public string NombrePla { get; set; }
        public string IdentificadorPla { get; set; }
        public string Descripcion { get; set; }

        private int _precio;
        public int Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if (value >= 50)
                {
                    _precio = value;
                }
                else
                {
                    throw new Exception("El precio debe ser mayor");
                }
            }
        }

        public List<Ingredientes> Ingredientes { get; set; }

        public Platillos()
        {
            NombrePla = "Pendiente";
            IdentificadorPla = "Sin asignar";
            Descripcion = "Sin asignar";
            Precio = 000;
            Ingredientes = new List<Ingredientes>();
        }
    }
}
