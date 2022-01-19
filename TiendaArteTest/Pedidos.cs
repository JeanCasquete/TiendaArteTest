using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArteTest
{
    class Pedidos
    {
        public string numeropedido { get; set; }       
        public string descripcion { get; set; }
        public string confirmacion { get; set; }
        public virtual void Mostrar()
        {
            Console.WriteLine("Número de pedido: " + numeropedido +"\nDescripción: " + descripcion + "\nConfirmacion de pedido: " + confirmacion);
        }
    }
}
