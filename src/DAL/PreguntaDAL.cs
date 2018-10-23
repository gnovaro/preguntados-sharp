using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class PreguntaDAL
    {
        public DataRow obtenerPreguntaRandom(int idiomaId)
        {
            Conexion objConexion = new Conexion();
            string consultaSql = "SELECT TOP 1 * FROM pregunta WHERE idioma_id="+ idiomaId;
            DataTable dataTablePregunta = objConexion.LeerPorComando(consultaSql);
            return dataTablePregunta.Rows[0];
        }
    }
}
