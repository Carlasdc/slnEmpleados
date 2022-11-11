using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Individuo
    {
        public Individuo(int individuoId, string nombre, string apellido)
        {
            IndividuoId = individuoId;
            Nombre = nombre;
            Apellido = apellido;
        }
        public Individuo() {}
        public int IndividuoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
