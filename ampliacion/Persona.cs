using System;

namespace DeberDelViernes
{
    class Persona : GeneradorAutomaticoIdentificacion
    {
        public string Nombre { get; set; }
        Celular celular;
        public Celular Celular 
        {
            get
            {
                return celular;
            }
            set 
            {
                celular = value;
                celular.Propietario = this;
            } 
        }
        public Mochila Mochila 
        { 
            get 
            {
                return Mochila;
            }
            set
            {
                Mochila = value;
                Mochila.Propietario = this;
            }
        }
        public mochila Mochila { get; set; }
        public Persona() : base()
        {

        }

        public string Saludar()
        {
            return $"Hola me llamo{this.Nombre}";
        }

        public string Productos()
        {
            if (celular != null)
                   return $"tengo celular{celular.Modelo}";
                 else
                   return "No tengo celular";
        }

        
    }
}
