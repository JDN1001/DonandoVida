using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{

    public class ConexionSQL
    {
        static string conexionstring = "server = DESKTOP-LN2IJ7F; database = BancoDeSangre;" +
            "integrated security = true";

        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string Usuario, string Contrasena)
        {
            int count;
            con.Open();
            string Query = "Select Count(*) From Administrador where usuario = '" + Usuario + "'" +
                "  and contrasena = '" + Contrasena + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;

        }

        public int InsertarUsuario(string nombre, string apellido_paterno, string apellido_materno, string telefono, string direccion, string gpo_sanguineo, string factor_rh, string dona_recibe)
        {
            int flag = 0;
            con.Open();
            string Query = "insert into UsuarioDonador values ('" + nombre + "','" + apellido_paterno + "','" + apellido_materno +
                "','" + telefono + "','" + direccion + "','" + gpo_sanguineo + "','" + factor_rh + "','" + dona_recibe + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultarUsuarioDG()
        {
            string Query = "select * from UsuarioDonador";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

  

       
    }
}
