using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            LineaAerea lineaAerea= new LineaAerea();
            { lineaAerea.IdLinea = 1; lineaAerea.Nombre = "Aereolineas Argentinas";  lineaAerea.FechaInicioActividades = DateTime.Now; }
            Avion avion = new Avion()
            {
                Capacidad = Convert.ToInt32(txtCapacidad.Text),
                Denominacion = txtDenominacion.Text,
                LineaAerea = lineaAerea

            };

            int filasAfectadas = AdmAvion.Insertar(avion);
            if (filasAfectadas>0)
            {
                MessageBox.Show("Avión insertado.");
                MostrarAviones();
            }
        }

        private void MostrarAviones()
        {
            gridAvion.DataSource = AdmAvion.Listar();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            MostrarAviones();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LineaAerea lineaAerea = new LineaAerea();
            { lineaAerea.IdLinea = 1; lineaAerea.Nombre = "Aereolineas Argentinas"; lineaAerea.FechaInicioActividades = DateTime.Now; }
            Avion avion = new Avion()
            {
                IdAvion = Convert.ToInt32(txtId.Text),
                Capacidad = Convert.ToInt32(txtCapacidad.Text),
                Denominacion = txtDenominacion.Text,
                LineaAerea = lineaAerea

            };

            int filasAfectadas = AdmAvion.Editar(avion);
            if (filasAfectadas> 0)
            {
                MessageBox.Show("Avión editado.");
                MostrarAviones();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LineaAerea lineaAerea = new LineaAerea();
            { lineaAerea.IdLinea = 1; lineaAerea.Nombre = "Aereolineas Argentinas"; lineaAerea.FechaInicioActividades = DateTime.Now; }
            Avion avion = new Avion()
            {
                IdAvion = Convert.ToInt32(txtId.Text),
                Capacidad = Convert.ToInt32(txtCapacidad.Text),
                Denominacion = txtDenominacion.Text,
                LineaAerea = lineaAerea

            };

            int filasAfectadas = AdmAvion.Eliminar(avion.IdAvion);
            if (filasAfectadas > 0) 
            {
                MessageBox.Show("Avión eliminado.");
                MostrarAviones();
            }

        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            Avion avion = AdmAvion.TraerUno(id);
            MessageBox.Show("El avión es " + avion.Denominacion + ". Tiene " + avion.Capacidad + " pasajeros.");
        }
    }
}
