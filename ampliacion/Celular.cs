using System;
using System.Collections.Generic;
using System.Text;

namespace DeberDelViernes
{
    class Celular: Producto
    {
       
        public float Precio { get; set; }
        public float ConsumoElectrico { get; set; }
        public Celular()  : base() 
        { 
        }

    }
}
