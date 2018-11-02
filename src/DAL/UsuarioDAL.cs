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
            string variable = "@id";
            SqlParameter[] parametros = new SqlParameter[6];

            parametros[0] = objconexion.crearParametro("@nombre", nombre);
            parametros[1] = objconexion.crearParametro("@email", email);
            parametros[2] = objconexion.crearParametro("@idioma_id", idiomaId);
            parametros[3] = objconexion.crearParametro("@fechanac", fecha);
            parametros[4] = objconexion.crearParametro("@contrasena", contrasena);
            parametros[5] = objconexion.crearParametroDeSalida("@id");

            filavalor = objconexion.EscribiryObtenerValorSP(procedimiento,parametros,variable);
            //Aca devuelvo el valor del id despues de hacer el insert y si fallo devuelve -1
            return filavalor;
        }

        public DataTable obtenerUsuario(string email) 
        {
            Conexion objConexion = new Conexion();
            string consultaSql = "SELECT * FROM usuario WHERE email = '" + email + "'";
            DataTable datausuario = objConexion.LeerPorComando(consultaSql);

            return datausuario;
        }
    }
}
