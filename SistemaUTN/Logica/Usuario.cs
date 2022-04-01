using System;

namespace Logica
{
    public class Usuario
    {
        private string nombre;
        private string contrasenia;


        public Usuario(string nombre, string contrasenia)
        {
            this.nombre = nombre;
            this.contrasenia = contrasenia;
        }

        public string GetNombre()  // get
        {
            return nombre;
        }

        public void SetNombre(string dato)  // set 
        {
            this.nombre = dato;
        }


        public bool ComprobarPass(string pass)
        {
            return contrasenia == pass;
        }

        public void ModificarContra(string pass)
        {
            this.contrasenia = pass;
        }
    }
}

