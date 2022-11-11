using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    internal class Cliente:Individuo
    {
        public Cliente(int individuoId, string nombre, string apellido, string cuit, string telefono):base(individuoId, nombre, apellido)
        {
            Cuit = cuit;
            Telefono = telefono;
        }

        public string Cuit { get; set; }
        public string Telefono { get; set; }
    }
}
