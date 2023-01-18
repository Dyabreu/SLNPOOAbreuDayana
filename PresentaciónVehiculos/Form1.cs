using LibTransportes;

namespace PresentaciónVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Camion_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque();
            { remolque.Id = 1; remolque.Tipo = "Plataforma"; }
            Camion camion = new Camion();

            {
                camion.Nombre = "Camion Rígido";
                camion.Modelo = "OF-1621";
                camion.Placa = "12313DDK";
                camion.Empresa = "Dandys";
                camion.Mercancia = "Cajas de Dulces";
                camion.Remolque = remolque;
             }

            MessageBox.Show("Creado: " + camion.Imprimir() + "\nRemolque tipo: " + remolque.Tipo + ".\n " + camion.QuitarRemolque());

        }

        private void btnAutoElec_Click(object sender, EventArgs e)
        {
            AutoElectrico autoElec = new AutoElectrico();

            {
                autoElec.Nombre = "Auto Eléctrico 2000";
                autoElec.Modelo = "Volts Motors";
                autoElec.Placa = "122BUE";
                autoElec.Dueño = "Richard Ramirez";
                autoElec.CantPasajeros = 2;
            }
            MessageBox.Show("Creado: " + autoElec.Imprimir());
        }

        private void btnRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque();
            {
                remolque.Id = 2;
                remolque.Tipo = "Plataforma";

                MessageBox.Show(remolque.Imprimir());
            }
        }
    }
}