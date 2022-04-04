using System;
using Logica;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, password;
            bool usuarioCorrecto;

            Console.Title = "Sistema UTN";
           
                do
                {
                    Console.WriteLine("\nIngrese usuario\n");
                    nombre = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine("\nIngrese password\n");
                    password = Console.ReadLine();

                    Console.Clear();

                    usuarioCorrecto = Sistema.CheckearUsuario(nombre, password);

                    if (usuarioCorrecto)
                    {
                        Console.WriteLine("Usuario Logueado");
                    }
                    else
                    {
                        Console.WriteLine("Usuario incorrecto");
                    }

                } while (!usuarioCorrecto);

            FuncionesConsola.SitioEnConstruccion();
        
        }
    }
}
