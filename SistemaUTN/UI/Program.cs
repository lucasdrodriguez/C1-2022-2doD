using System;
using Logica;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Sistema.CheckearUsuario("Pepe", "asd123"))
            {
                Console.WriteLine("Logeado");
            }
            else
            {
                Console.WriteLine("SIN ACCESO");
            }
        }
    }
}
