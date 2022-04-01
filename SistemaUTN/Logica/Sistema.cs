using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Sistema
    {

        static Usuario[] usuariosRegistrados;

        static Sistema() // constructor STATIC sistema
        {
            usuariosRegistrados = new Usuario[8];
            CargarUsuariosHardcodeados();
        }

        private static void CargarUsuariosHardcodeados()
        {
            usuariosRegistrados[0] = new Usuario("Pepe", "asd123");
            usuariosRegistrados[1] = new Usuario("Carola", "caro123");
            usuariosRegistrados[2] = new Usuario("Romeo", "miaumiau");
            usuariosRegistrados[3] = new Usuario("Jazmin", "rufosa123");
            usuariosRegistrados[4] = new Usuario("Juana", "rufruf01");

        }

        private static int VerificarPosicionLibre()
        {
            return -1;
        }

        public static bool CrearNuevoUsuario(string nombre, string password)
        {
           int pos =  VerificarPosicionLibre();

            if(pos != -1)
            {
                usuariosRegistrados[pos] = new Usuario(nombre, password);
                return true;
            }
            return false;

        }

        public static bool CambiarContra(string nombre, string password)
        {
            return true;
        }


        public static bool CheckearUsuario(string nombre, string pass)
        {

            if (string.IsNullOrEmpty(nombre.Trim()) || string.IsNullOrEmpty(pass.Trim()))
            {
                return false;
            }

            for (int i = 0; i < usuariosRegistrados.Length; i++)
            {
                if (usuariosRegistrados[i] != null)
                {
                    if (nombre.Trim() == usuariosRegistrados[i].GetNombre().Trim())
                    {
                        return usuariosRegistrados[i].ComprobarPass(pass); 
                    }
                }
            }

            return false;
        }

    }
}
