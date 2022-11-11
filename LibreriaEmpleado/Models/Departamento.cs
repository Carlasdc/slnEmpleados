using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Departamento
    {
        public Departamento(int departamentoId, string nombre, List<Empleado> empleados)
        {
            DepartamentoId = departamentoId;
            Nombre = nombre;
            this.empleados = empleados;
        }
        public Departamento() { }
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> empleados { get; set; }

    }
}
