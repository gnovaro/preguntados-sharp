using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IdiomaDAL
    {
        public DataTable obtenerIdiomas()
        {            
            Conexion objConexion = new Conexion();
            string consultaSql = "SELECT * FROM idioma";
            DataTable dataTableIdioma = objConexion.LeerPorComando(consultaSql);
            return dataTableIdioma;
        }

    }
}
