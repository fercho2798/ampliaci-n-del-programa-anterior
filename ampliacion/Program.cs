using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace DeberDelViernes
{
    class Program : GeneradorAutomaticoIdentificacion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Mochila = new Mochila
            {
                Marca = "jansport",
                Modelo = "Negro",
                Precio = 50
            };
            
            
            
            var empresa = new Empresa();

            var estudiante = new Persona
            {
                Nombre = "Maria",
                Celular = empresa.ConstruirCeluler("samsung")
            };

            estudiante.Computadora = empresa.ConstruirMoto("");
            estudiante.Mochila = empresa.ConstruirMochila( "Jansport","Negro",50);
            
            Console.WriteLine(estudiante.Saludar());
            Console.WriteLine(estudiante.Productos());
            Console.WriteLine(estudiante.Mochila.Nueva());
            
            Console.ReadKey();
        }
    }
}
