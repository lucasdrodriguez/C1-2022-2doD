using System;
using Entidades_Teatro;


namespace Consola_Teatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Espectador espectador = new Espectador(1234, "pepe", "");

            //espectador.numeroTelefonico = "44556677";
            //espectador.dni = 11;

            //Console.WriteLine(espectador.numeroTelefonico);
            //Console.WriteLine(espectador.dni);


            Console.WriteLine(espectador.Dni);

            espectador.CodigoVenta = 20;


            Teatro teatrito = new Teatro();

            Espectador esp;

            esp = teatrito[2];
            esp = teatrito[1];
            esp = teatrito[5];
            esp = teatrito[6];

            teatrito[1] = new Espectador(903, "Carmela", "99933");

            esp = teatrito["9999"];

        }
    }
}
