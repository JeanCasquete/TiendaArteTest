using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArteTest
{
    class Carrito
    {
        //public string nombre { get; set; }
        //public string id { get; set; }
        public string descripcion { get; set; }
        public double preciofinal { get; set; }

        public virtual void Mostrar()
        {
            Console.WriteLine("Descripción: " + descripcion + "\nPrecio Final: $" + preciofinal);
        }
    }
}
