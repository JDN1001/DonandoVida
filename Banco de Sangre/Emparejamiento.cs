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
    public partial class Emparejamiento : Form
    {
        conexionSQLN cn = new conexionSQLN();
        static string conexionstring = "server = DESKTOP-LN2IJ7F; database = BancoDeSangre;" +
            "integrated security = true";
        SqlConnection con = new SqlConnection(conexionstring);
        public Emparejamiento()
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
            string comparacion = "O-";//O negativa es universal la puede recibir cualquiera
            string comparacion2 = "A+";//A positiva recibe A+,A-,O+,O-
            string comparacion3 = "AB-";//AB negativa recibe AB-,A-,B-,O-
            string comparacion4 = "O+";// O positiva recibe O+,O-
            string comparacion5 = "B+";//B positiva recibe B+,B-,O+,O-
            string comparacion6 = "AB+";//AB positiva es universal la puede recibir cualquiera
            string comparacion7 = "A-";//A negativa recibe A-,O-
            string comparacion8 = "B-";//B negativa recibe B-,O-

            if (comparacion == txtBusqueda.Text)
            {
                string Query = "Select * from UsuarioDonador where (gpo_sanguieno ='A' or gpo_sanguieno ='B' or gpo_sanguieno ='AB' or gpo_sanguieno ='O')  and dona_recibe = 'Recibe'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

                string Query1 = "Select * from UsuarioDonador where (gpo_sanguieno ='O') and not factor_rh = 'Positivo' and dona_recibe = 'Dona'";
                SqlCommand cmd2 = new SqlCommand(Query1, con);
                SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;
            }
            else if (comparacion2 == txtBusqueda.Text)
            {
                string Query = "Select * from UsuarioDonador where (gpo_sanguieno ='A' or gpo_sanguieno ='O')  and dona_recibe = 'Recibe'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

                string Query1 = "Select * from UsuarioDonador where (gpo_sanguieno ='A') and factor_rh = 'Positivo' and dona_recibe = 'Dona'";
                SqlCommand cmd2 = new SqlCommand(Query1, con);
                SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;
            }
            else if (comparacion3 == txtBusqueda.Text)
            {
                string Query = "Select * from UsuarioDonador where (gpo_sanguieno ='A' or gpo_sanguieno ='B' or gpo_sanguieno ='AB' or gpo_sanguieno ='O')  and not factor_rh = 'Positivo' and dona_recibe = 'Recibe'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

                string Query1 = "Select * from UsuarioDonador where (gpo_sanguieno ='AB') and not factor_rh = 'Positivo' and dona_recibe = 'Dona'";
                SqlCommand cmd2 = new SqlCommand(Query1, con);
                SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;
            }
            else if (comparacion4 == txtBusqueda.Text)
            {
                string Query = "Select * from UsuarioDonador where ( gpo_sanguieno ='O') and dona_recibe = 'Recibe'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

                string Query1 = "Select * from UsuarioDonador where (gpo_sanguieno ='O') and factor_rh = 'Positivo' and dona_recibe = 'Dona'";
                SqlCommand cmd2 = new SqlCommand(Query1, con);
                SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;
            }
            else if (comparacion5 == txtBusqueda.Text)
            {
                string Query = "Select * from UsuarioDonador where (gpo_sanguieno ='B' or gpo_sanguieno ='O') and dona_recibe = 'Recibe'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

                string Query1 = "Select * from UsuarioDonador where (gpo_sanguieno ='B') and factor_rh = 'Positivo' and dona_recibe = 'Dona'";
                SqlCommand cmd2 = new SqlCommand(Query1, con);
                SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;
            }
            else if (comparacion6 == txtBusqueda.Text)
            {
                string Query = "Select * from UsuarioDonador where (gpo_sanguieno ='A' or gpo_sanguieno ='B' or gpo_sanguieno ='AB' or gpo_sanguieno ='O')  and dona_recibe = 'Recibe'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

                string Query1 = "Select * from UsuarioDonador where (gpo_sanguieno ='AB') and factor_rh = 'Positivo' and dona_recibe = 'Dona'";
                SqlCommand cmd2 = new SqlCommand(Query1, con);
                SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;
            }
            else if (comparacion7 == txtBusqueda.Text)
            {
                string Query = "Select * from UsuarioDonador where (gpo_sanguieno ='A' or gpo_sanguieno ='O') and not factor_rh = 'Positivo' and dona_recibe = 'Recibe'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

                string Query1 = "Select * from UsuarioDonador where (gpo_sanguieno ='A') and not factor_rh = 'Positivo' and dona_recibe = 'Dona'";
                SqlCommand cmd2 = new SqlCommand(Query1, con);
                SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;
            }
            else if (comparacion8 == txtBusqueda.Text)
            {
                string Query = "Select * from UsuarioDonador where (gpo_sanguieno ='B' or gpo_sanguieno ='O') and not factor_rh = 'Positivo' and dona_recibe = 'Recibe'";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

                string Query1 = "Select * from UsuarioDonador where (gpo_sanguieno ='B') and not factor_rh = 'Positivo' and dona_recibe = 'Dona'";
                SqlCommand cmd2 = new SqlCommand(Query1, con);
                SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;
            }
        }
    }
}
