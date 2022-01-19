using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArteTest
{
    class Login : Usuario, IMetodos
    {      
        public override void Mostrar()
        {
            Console.WriteLine("---Tu información---");
            base.Mostrar();
        }
    }
}
