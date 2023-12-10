using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcesoDonacionSangre;

namespace Banco_de_Sangre
{
    public partial class Inicio : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresa_Click(object sender, EventArgs e)
        {
            if(cn.conSQL(txtUsuario.Text, txtPasswd.Text) == 1)
            {
                //Una vez encontrado el usuario desaparece ventana del login
                this.Hide();
                //Se creara un objeto para invocar el menú principal
                VentanaPrincipal v1 = new VentanaPrincipal();
                v1.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no encontrado");
            }
        }
    }
}
