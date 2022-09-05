using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Contactos_personales
    {
        public class Contactos_empresa
        {
            public string IdContactos { get; set; }
            public string Telefono { get; set; }
            public string Nombre { get; set; }
            public string Cumple { get; set; }

            public Contactos_empresa(string idContactos, string nombre, string telefono, string cumple)
            {
                IdContactos = idContactos;
                Telefono = telefono;
                Nombre = nombre;
                Cumple = cumple;
            }
            public Contactos_empresa()
            {

            }
            public Contactos_empresa(string linea)
            {
                if (linea != null)
                {
                    Mapear(linea);
                }

            }
            public string Linea()
            {
                return IdContactos + ";" + Telefono + ";" + Nombre + ";" + Cumple;
            }
            private void Mapear(string linea)
            {
                IdContactos = linea.Split(';')[0];
                Telefono = linea.Split(';')[1];
                Nombre = linea.Split(';')[2];
                Cumple = linea.Split(';')[3];

            }
        }
    }
}
