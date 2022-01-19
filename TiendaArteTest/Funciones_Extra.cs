using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArteTest
{
    class Funciones_Extra
    {
        public int masopciones;
        public string direcci { get; set; }
        public virtual void notificaciones()
        {

            Console.Clear();
            Console.WriteLine(" Aquí encontraras tus notifaciones ");
            Console.WriteLine("  Estas son tus notificaciones: ");
            Console.WriteLine("    **no tiene notificaciones, nadie lo quiere");
        }
        public virtual void direcciones()
        {
                Console.Clear();
                Console.WriteLine("DIRECCIONES");
                Console.WriteLine(" Agrega tu direccion");           
                direcci= Console.ReadLine();
                Console.WriteLine(" La direccion " +direcci +"fue agregada correctamente");
                  
        }
           
         
    }
}
