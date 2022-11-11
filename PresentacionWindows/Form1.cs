using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaEmpleado.Models;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            List<Empleado> lista = new List<Empleado>();
            Empleado empleado1 = new Empleado(1, "juan", "perez", "2450");
            Empleado empleado2 = new Empleado(2, "Maria", "perez", "2451");
            Empleado empleado3 = new Empleado(3, "Julia", "Martinez", "2453");
            lista.Add(empleado1);
            lista.Add(empleado2);
            lista.Add(empleado3);

            Departamento departamento = new Departamento(1,"IT", lista);

            GridViewEmpleados.DataSource = departamento.empleados;

        }
    }
}
