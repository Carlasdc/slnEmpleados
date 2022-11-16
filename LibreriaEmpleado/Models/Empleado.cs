using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
     public class Empleado:Individuo
    {
        public Empleado(int empleadoId, string nombre, string apellido, string legajo) : base( nombre, apellido)
        {
            EmpleadoId=empleadoId;
            Legajo = legajo;
        }
        public Empleado() { }
        public int EmpleadoId { get; set; }
        public string Legajo { get; set; }
        public Departamento Departamento { get; set; }
    }
}
