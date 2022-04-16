using System;

namespace Entidades_Teatro
{
    public class Teatro
    {
        string nombreTeatro;
        Espectador[] arrayEspectadores;

        public Teatro()
        {
            arrayEspectadores = new Espectador[20];
            nombreTeatro = "Teatro de Juana";
        }

        public string NombreTeatro
        {
            get { return nombreTeatro; }
        }
        public Espectador[] ArrayEspectadores
        {
            get { return this.arrayEspectadores; }
        }

        public Espectador this[int indice]
        {
            get { return this.arrayEspectadores[5]; }

            set { this.arrayEspectadores[indice] = value; }
        }
        public Espectador this[string palabra]  // 9999
        {
            get
            {
                foreach (Espectador item in arrayEspectadores)
                {
                    if (item.NumeroTelefonico == palabra)
                    {
                        return item;
                    }
                }


                //for (int i = 0; i < arrayEspectadores.Length; i++)
                //{                                                     // 9999
                //    if (this.arrayEspectadores[i].NumeroTelefonico == palabra)
                //    {
                //        return this.arrayEspectadores[i];
                //    }
                //}
                return null;

            }

        }
    }
}
