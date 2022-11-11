using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
     public class Empleado:Individuo
    {
        public Empleado(int individuoId, string nombre, string apellido, string legajo) : base(individuoId, nombre, apellido)
        {
            Legajo = legajo;
        }
        public Empleado() { }
        public string Legajo { get; set; }
        
    }
}
