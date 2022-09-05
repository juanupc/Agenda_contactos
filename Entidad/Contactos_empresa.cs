using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Contactos_empresa
    {
        public string IdCliente { get; set; }
        public string NIT { get; set; }
        public string RazonSocial { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public Contactos_empresa(string idCliente, string nombre, string nit, string razonsocial, string correo, string telefono)
        {
            IdCliente = idCliente;
            NIT = nit;
            RazonSocial = razonsocial;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;

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
            return IdCliente + ";" + NIT + ";" + RazonSocial + ";" + Correo + ";" + Nombre + ";" + Telefono;
        }
        private void Mapear(string linea)
        {
            IdCliente = linea.Split(';')[0];
            NIT = linea.Split(';')[1];
            RazonSocial = linea.Split(';')[2];
            Correo = linea.Split(';')[3];
            Nombre = linea.Split(';')[4];
            Telefono = linea.Split(';')[5];
        }
    }
}
