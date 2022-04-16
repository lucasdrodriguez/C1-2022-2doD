using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Teatro
{

    public class Espectador
    {
        int dni;
        string nombre;
        string numeroTelefonico;
        int cantidadEntradas;
        int codigoVenta;

        private Espectador()
        {
            cantidadEntradas = 1;
            codigoVenta = -1;
        }
        public Espectador(int dni, string nombre, string numTel) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.numeroTelefonico = numTel;
        }
        public Espectador(int dni, string nombre, string numTel, int cantEntradas) : this(dni, nombre, numTel)
        {
            this.CantidadEntradas = cantEntradas;
        }

        public int Dni
        {
            get
            {
                if (dni == 0)
                    return dni;
                else
                    return -1;

            }
            set
            {
                if (value > 0 && value < 99999999)
                {
                    dni = value;
                }

            }
        }

        public int CodigoVenta
        {
            set
            {
                if (value > 0)
                {
                    this.codigoVenta = value;
                }
            }
        }

        // public string numeroTelefonico;

        public string NumeroTelefonico
        {
            get { return this.numeroTelefonico; }
            set
            {
                this.numeroTelefonico = value;
            }
        }

    }
}
