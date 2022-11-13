using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.Data;

namespace WindowsEmpleado
{
    public static class AdminEmpleado
    {
        public static DbEmpleados context = new DbEmpleados();

        public static List<Empleado> Listar()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            listaEmpleados = context.Empleados.ToList();
            return listaEmpleados;
        }

        public static int Insertar(Empleado empleado)
        {
            int id = empleado.IndividuoId;
            Empleado empleadoIns = context.Empleados.Find(id);
            if (empleadoIns != null)
            {
                context.Empleados.Add(empleadoIns);
            }
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;

        }
    }
}
