using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsEmpleados.Data
{
    public class DbEmpleadoContext:DbContext
    {
        public DbEmpleadoContext() : base("keyDBEmpleados") { }

        // por cada modelo una propiedad DBSET
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

    }
}