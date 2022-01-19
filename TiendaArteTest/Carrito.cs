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

        public string numtarjeta { get; set; }
        public double cvv { get; set;  }
        public string fechatarjeta { get; set; }
       

        public virtual void Mostrar()
        {
            Console.WriteLine("Descripción: " + descripcion 
                + "\nPrecio Final: $" + preciofinal);
        }

        public virtual void agregartarjeta()
        {
            Console.WriteLine("**** AGREGA UNA TARJETA DE CREDITO/DEBITO ****");
            //Registro user1 = new Registro();
            Console.WriteLine("\nIngresa tu Numero de tarjeta:");
            numtarjeta =Console.ReadLine();
            Console.WriteLine("\nIngresa el codigo cvv de la tarjeta:");
            cvv = double.Parse(Console.ReadLine());
            while (cvv <= 99 && cvv >=300)
            {
                Console.WriteLine("\n El codigo cvv debe contener 3 digitos" 
                    + "\nIngresa el codigo cvv de la tarjeta:");
                cvv = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nIngresa la fecha de vencimiento de la tarjeta:");
            fechatarjeta = Console.ReadLine();


        }
    }
}
