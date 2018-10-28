using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PreguntaDAL
    {
        public DataRow obtenerPreguntaRandom(int idiomaId,int categoriaId)
        {
            Conexion objConexion = new Conexion();
            string consultaSql = "SELECT TOP 1 * FROM pregunta WHERE categoria_id="+ categoriaId  + " AND idioma_id=" +idiomaId +" AND estado = 1 ORDER BY NEWID()";
            DataTable dataTablePregunta = objConexion.LeerPorComando(consultaSql);
            return dataTablePregunta.Rows[0];
        }

        public DataTable obtenerPreguntas(int idiomaId) 
        {
            Conexion objConexion = new Conexion();
            string consultaSql = "SELECT * FROM pregunta WHERE idioma_id=" + idiomaId + " AND estado = 1";
            DataTable dataTablePregunta = objConexion.LeerPorComando(consultaSql);

            return dataTablePregunta;
        }

        public int alta(int idiomaId,int categoriaId, string descripcion, int usuarioId) 
        {

            Conexion objconexion = new Conexion();
            string procedimiento = "pregunta_alta";
            int filavalor;
            string variable = "@p_id";
            SqlParameter[] parametros = new SqlParameter[5];

            parametros[0] = objconexion.crearParametroDeSalida("@p_id");
            parametros[1] = objconexion.crearParametro("@p_idioma_id", idiomaId);
            parametros[2] = objconexion.crearParametro("@p_categoria_id", categoriaId);
            parametros[3] = objconexion.crearParametro("@p_descripcion", descripcion);
            parametros[4] = objconexion.crearParametro("@p_usuario_id", usuarioId);

            filavalor = objconexion.EscribiryObtenerValorSP(procedimiento, parametros, variable);
            //Aca devuelvo el valor del id despues de hacer el insert y si fallo devuelve -1
            return filavalor;
        }

        public int altaOpcionCorrectaId(int id, int opcionId) 
        {
            Conexion objconexion = new Conexion();
            string procedimiento = "pregunta_setOpcionCorrecta";
            int filasafectadas;

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = objconexion.crearParametro("@p_id", id);
            parametros[1] = objconexion.crearParametro("@p_opcion_id_correcta", opcionId);
            filasafectadas = objconexion.EscribirPorStoreProcedure(procedimiento, parametros);

            return filasafectadas;
        }
    }
}
