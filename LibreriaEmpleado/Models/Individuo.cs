using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Individuo
    {
        public Individuo( string nombre, string apellido)
        { 
            Nombre = nombre;
            Apellido = apellido;
        }
        public Individuo() {}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
