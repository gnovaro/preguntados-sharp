using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class OpcionDAL
    {
        /*public DataTable obtenerOpcionesPorPregunta(int PreguntaId)
        {

        }*/

        public int alta(int preguntaId,string descripcion,int correcta) 
        {
            Conexion objconexion = new Conexion();
            string procedimiento = "opcion_alta";
            int filasafectadas;

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = objconexion.crearParametro("@p_pregunta_id", preguntaId);
            parametros[1] = objconexion.crearParametro("@p_descripcion_opcion", descripcion);
            parametros[2] = objconexion.crearParametro("@p_correcta", correcta);

            filasafectadas = objconexion.EscribirPorStoreProcedure(procedimiento, parametros);

            return filasafectadas;

        }

        public int altaCorrecta(int preguntaId, string descripcion, int correcta) 
        {
            Conexion objconexion = new Conexion();
            string procedimiento = "opcion_alta";
            int filavalor;
            string variable = "@p_id";

            SqlParameter[] parametros = new SqlParameter[4];

            parametros[0] = objconexion.crearParametroDeSalida("@p_id");
            parametros[1] = objconexion.crearParametro("@p_pregunta_id", preguntaId);
            parametros[2] = objconexion.crearParametro("@p_descripcion_opcion", descripcion);
            parametros[3] = objconexion.crearParametro("@p_correcta", correcta);

            filavalor = objconexion.EscribiryObtenerValorSP(procedimiento, parametros, variable);
            //Aca devuelvo el valor del id despues de hacer el insert y si fallo devuelve -1
            return filavalor;
        }


        public DataTable obtenerOpciones(int preguntaId) 
        {
            Conexion objConexion = new Conexion();
            string consultaSql = "SELECT * FROM pregunta_opcion WHERE pregunta_id =" + preguntaId;
            DataTable dataTablePregunta = objConexion.LeerPorComando(consultaSql);

            return dataTablePregunta;
        }
    }
}
