using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProcesoDonacionSangre
{
    public class conexionSQLN
    {
        // ConexionSQL cn = new Datos.ConexionSQL();
        ConexionSQL cn = new ConexionSQL();
        public int conSQL(string user, string pass)
        {
            return cn.consultalogin(user, pass);
        }

        public DataTable ConsultaDT()
        {
            return cn.ConsultarUsuarioDG();
        }

        public int InsertarUsuario(string nombre, string apellido_paterno, string apellido_materno, string telefono, string direccion, string gpo_sanguineo, string factor_rh, string dona_recibe)
        {

            return cn.InsertarUsuario(nombre, apellido_paterno,apellido_materno,telefono,direccion,gpo_sanguineo, factor_rh, dona_recibe);
        }

    }
    
   
}
