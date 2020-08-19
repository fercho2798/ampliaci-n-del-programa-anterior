using System;
using System.Collections.Generic;
using System.Text;

namespace DeberDelViernes
{
    class GeneradorAutomaticoIdentificacion
    {
        readonly Random random = new Random();
        public int Id { get; set;}
        public GeneradorAutomaticoIdentificacion()
        {
            Id = random.Next();
        }
        public GeneradorAutomaticoIdentificacion(int Identificador)
        {
            Id = Identificador;
        }
        public GeneradorAutomaticoIdentificacion(string IdenticicadorDos)
        {
            Id = Convert.ToInt32( IdenticicadorDos);
        }

    }
}
