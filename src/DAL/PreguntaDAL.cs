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
            string variable = "@id";
            SqlParameter[] parametros = new SqlParameter[5];

            parametros[0] = objconexion.crearParametro("@idioma_id", idiomaId);
            parametros[1] = objconexion.crearParametro("@categoria_id", categoriaId);
            parametros[2] = objconexion.crearParametro("@descripcion", descripcion);
            parametros[3] = objconexion.crearParametro("@usuario_id", usuarioId);
            parametros[4] = objconexion.crearParametroDeSalida("@id");

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

            parametros[0] = objconexion.crearParametro("@id", id);
            parametros[1] = objconexion.crearParametro("@opcion_id_correcta", opcionId);
            filasafectadas = objconexion.EscribirPorStoreProcedure(procedimiento, parametros);

            return filasafectadas;
        }

        public int guardarVotoPositivo(int id, int voto) 
        {
            Conexion objconexion = new Conexion();
            string procedimiento = "pregunta_guardarVotoPositivo";
            int filasafectadas;

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = objconexion.crearParametro("@id", id);
            parametros[1] = objconexion.crearParametro("@positivo", voto);
            filasafectadas = objconexion.EscribirPorStoreProcedure(procedimiento, parametros);

            return filasafectadas;
        }

        public int guardarVotoNegativo(int id, int voto) 
        {
            Conexion objconexion = new Conexion();
            string procedimiento = "pregunta_guardarVotoNegativo";
            int filasafectadas;

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = objconexion.crearParametro("@id", id);
            parametros[1] = objconexion.crearParametro("@negativo", voto);
            filasafectadas = objconexion.EscribirPorStoreProcedure(procedimiento, parametros);

            return filasafectadas;
        }

    }
}
