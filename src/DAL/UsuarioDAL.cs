using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        

        public int alta(string nombre, string email, int idiomaId, DateTime fecha, string contrasena ) 
        {
            Conexion objconexion = new Conexion();
            string procedimiento = "usuario_alta";
            int filavalor;
            string variable = "@p_id";
            SqlParameter[] parametros = new SqlParameter[6];

            parametros[0] = objconexion.crearParametroDeSalida("@p_id");
            parametros[1] = objconexion.crearParametro("@p_nombre", nombre);
            parametros[2] = objconexion.crearParametro("@p_email", email);
            parametros[3] = objconexion.crearParametro("@p_idioma_id", idiomaId);
            parametros[4] = objconexion.crearParametro("@p_fechanac", fecha);
            parametros[5] = objconexion.crearParametro("@p_contrasena", contrasena);

            filavalor = objconexion.EscribiryObtenerValorSP(procedimiento,parametros,variable);
            //Aca devuelvo el valor del id despues de hacer el insert y si fallo devuelve -1
            return filavalor;
        }
    }
}
