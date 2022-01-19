using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArteTest
{
    class Articulo
    {
        public string nombre { get; set; }
        public string id { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }
        public double stock { get; set; }
        public double precio { get; set; }

        public virtual void Mostrar()
        {
            Console.WriteLine("Artículo: " + nombre +" id: #"+id+"\nCategoría: "+categoria+"\nDescripción: " + descripcion+ "\nDisponibilidad: " +stock + "\nPrecio: $" +precio);
        }
    }
}
