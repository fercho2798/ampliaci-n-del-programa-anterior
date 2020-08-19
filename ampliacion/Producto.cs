using System;
using System.Collections.Generic;
using System.Text;

namespace DeberDelViernes
{
    class Producto : GeneradorAutomaticoIdentificacion
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Persona Propietario { get; set; }

        public Producto() : base()
        {
            
        }
    }
}
