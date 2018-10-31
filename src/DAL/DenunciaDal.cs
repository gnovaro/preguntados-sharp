using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DenunciaDAL
    {
        public int alta(int usuarioID, int preguntaId, string descripcion, DateTime fecha) 
        {
            Conexion objconexion = new Conexion();
            string procedimiento = "denuncia_alta";
            int filasafectadas;

            SqlParameter[] parametros = new SqlParameter[4];

            parametros[0] = objconexion.crearParametro("@usuario_id", usuarioID);
            parametros[1] = objconexion.crearParametro("@pregunta_id", preguntaId);
            parametros[2] = objconexion.crearParametro("@descripcion", descripcion);
            parametros[3] = objconexion.crearParametro("@fecha", fecha);

            filasafectadas = objconexion.EscribirPorStoreProcedure(procedimiento,parametros);

            return filasafectadas;
        }
    }
}
