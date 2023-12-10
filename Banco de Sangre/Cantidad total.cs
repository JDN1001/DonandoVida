using Datos;
using ProcesoDonacionSangre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_Sangre
{
    public partial class Cantidad_total : Form
    {

        static string conexionstring = "server = DESKTOP-LN2IJ7F; database = BancoDeSangre;" +
            "integrated security = true";
        SqlConnection con = new SqlConnection(conexionstring);
        public Cantidad_total()
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

        private void btnBuscarGpo_Click(object sender, EventArgs e)
        {
            int contar;
            //SqlCommand cmd = new SqlCommand("Select count (distinct gpo_sanguieno) from UsuarioDonador",con);
            SqlCommand cmd = new SqlCommand("Select count (*) from UsuarioDonador where gpo_sanguieno ='" + txtBusqueda.Text + "' group by gpo_sanguieno", con);
            con.Open();
            contar = (int)cmd.ExecuteScalar();
            label3.Text = contar.ToString() + " Gpo sanguineos";
            con.Close();
        }
    }
}
