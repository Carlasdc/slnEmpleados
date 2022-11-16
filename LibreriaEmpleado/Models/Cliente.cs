using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    internal class Cliente:Individuo
    {
        public Cliente(int clienteId, string nombre, string apellido, string cuit, string telefono):base( nombre, apellido)
        {
            Cuit = cuit;
            Telefono = telefono;
            ClienteId = clienteId;
        }

        public int ClienteId { get; set; }
        public string Cuit { get; set; }
        public string Telefono { get; set; }
    }
}
