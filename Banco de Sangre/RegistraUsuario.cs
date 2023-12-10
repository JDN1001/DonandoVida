using ProcesoDonacionSangre;
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
    public partial class RegistraUsuario : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public RegistraUsuario()
        {
            InitializeComponent();
        }

        private void btnRegresoMenu_Click(object sender, EventArgs e)
        {
            //Oculta la venta del registro
            this.Hide();
            //Se creara un objeto para invocar el menú principal
            VentanaPrincipal v1 = new VentanaPrincipal();
            v1.Show();
        }

        private void btnGuardaU_Click(object sender, EventArgs e)
        {
            cn.InsertarUsuario(txtNombreR.Text,txtApeP.Text,txtApeM.Text,txtTelefono.Text,txtDireccion.Text,txtGpoSangre.Text,txtFactorRH.Text,txtDonacion.Text);
            MessageBox.Show("Registro Exitoso");
            //Limpia los campos de los text box una vez que termine la ejecución
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
            //cn.ConsultaDT();
        }
    }
}
