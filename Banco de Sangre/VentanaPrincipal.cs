using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_Sangre
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            //Oculta la ventana del menú
            this.Hide();
            //Se creara un objeto para invocar la ventana Registra Usuario
            RegistraUsuario v1 = new RegistraUsuario();
            v1.Show();
        }

        private void bntConsulta_Click(object sender, EventArgs e)
        {
            //Oculta la ventana del menú
            this.Hide();
            //Se creara un objeto para invocar la ventana Consulta datos
            Consulta_Datos v1 = new Consulta_Datos();
            v1.Show();
        }

        private void btnEmparejamiento_Click(object sender, EventArgs e)
        {
            //Oculta la ventana del menú
            this.Hide();
            //Se creara un objeto para invocar la ventana Emparejamiento
            Emparejamiento v1 = new Emparejamiento();
            v1.Show();
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            //Oculta la venta del registro
            this.Hide();
            //Se creara un objeto para invocar la ventana Cantidad total
            Cantidad_total v1 = new Cantidad_total();
            v1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
