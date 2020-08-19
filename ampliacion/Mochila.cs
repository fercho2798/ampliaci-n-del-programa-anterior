using System;
using System.Collections.Generic;
using System.Text;

namespace DeberDelViernes
{
    class mochila : Producto
    {
        public float Precio { get; set; }
        public mochila() : base()
        {

        }
        public string Nueva()
        {
            return $"numero de la mochila{Id} {this.Marca} {this.Modelo} {this.Precio}";
        }
    }
}
