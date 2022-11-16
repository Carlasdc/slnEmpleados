using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEmpleados.Data;

namespace WindowsEmpleado
{
    public partial class Form1 : Form
    {
        DbEmpleadoContext context = new DbEmpleadoContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado() { EmpleadoId= 12, Nombre="Martin", Apellido="Rodriguez",Legajo="2244" };
            context.Empleados.Add(empleado);

            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Empleado ingresado");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Empleado> lista = context.Empleados.ToList();

            dataGridListar.DataSource = lista;
            
        }
    }
}
