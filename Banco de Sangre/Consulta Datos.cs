using ProcesoDonacionSangre;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banco_de_Sangre
{
    public partial class Consulta_Datos : Form
    {
        conexionSQLN cn = new conexionSQLN();
        static string conexionstring = "server = DESKTOP-LN2IJ7F; database = BancoDeSangre;" +
            "integrated security = true";
        SqlConnection con = new SqlConnection(conexionstring);
        public Consulta_Datos()
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dataGridView1.DataSource = cn.ConsultaDT();
            }
            else
            {
                string Query = "Select * from UsuarioDonador where gpo_sanguieno ='" + txtBusqueda.Text + "' or factor_rh = '" + txtBusqueda.Text + "' ";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource =  tabla;
            }
            
        }
    }
}
