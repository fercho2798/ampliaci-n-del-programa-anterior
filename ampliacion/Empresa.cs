using System;
using System.Collections.Generic;
using System.Text;

namespace DeberDelViernes
{
    class Empresa : GeneradorAutomaticoIdentificacion
    {
        public string Nombre { get; set; }
        public Empresa() : base()
        {

        }
        public Empresa(int id) : base(id)
        {

        }

        public Empresa(string id) : base(id)
        {

        }
        public Celular ConstruirCeluler(string modelo)
        {
            return new Celular()
            {
                Marca = Nombre,
                Modelo = modelo
            };
        }

        public Moto ConstruirMoto(string modelo)
        {
            return new Computadora()
            {
                Marca = Nombre,
                Modelo = modelo
            };
        }

        public Pelota ConstruirPeota(string marca, string modelo, int precio)
        {

            return new Mochila()
            {
                Marca = marca,
                Modelo = modelo,
                Precio = precio
            };
        }
    }
}
