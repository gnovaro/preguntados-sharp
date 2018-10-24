using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RespuestaDal
    {
        public int alta(int usuarioId, int preguntaId, int opcionId, int correcta)
        {
            Conexion objconexion = new Conexion();
            string procedimiento = "respuesta_alta";
            int filasafectadas;

            SqlParameter[] parametros = new SqlParameter[4];

            parametros[0] = objconexion.crearParametro("@p_usuario_id", usuarioId);
            parametros[1] = objconexion.crearParametro("@p_pregunta_id", preguntaId);
            parametros[2] = objconexion.crearParametro("@p_pregunta_opcion_id", opcionId);
            parametros[3] = objconexion.crearParametro("@p_correctamente", correcta);

            filasafectadas = objconexion.EscribirPorStoreProcedure(procedimiento, parametros);

            return filasafectadas;
        
        }
    }
}
